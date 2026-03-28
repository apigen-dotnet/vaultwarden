using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using Apigen.Vaultwarden.Client;
using Apigen.Vaultwarden.Models;

// ---------------------------------------------------------------------------
// Vaultwarden Test Client — equivalent of `bw login` + `bw list items`
//
// Usage: dotnet run -- <server-base-url>
//   e.g.: dotnet run -- https://vaultwarden.example.com
// ---------------------------------------------------------------------------

string baseUrl = args.Length > 0 ? args[0].TrimEnd('/') : "https://vault.bitwarden.com";

Console.WriteLine($"Server: {baseUrl}");
Console.WriteLine();

// -- Collect credentials --------------------------------------------------
Console.Write("Email: ");
string email = Console.ReadLine()!.Trim();
Console.Write("Master password: ");
string masterPassword = ReadPassword();
Console.WriteLine();

// -- Create unified client ------------------------------------------------
// For Vaultwarden all API endpoints live on the same host.
// The generated client uses path prefixes: /identity/*, /api/*, /public/*
using var httpClient = new HttpClient { BaseAddress = new Uri(baseUrl + "/") };
var client = new VaultwardenApiClient(httpClient);

// -- Step 1: Prelogin (get KDF params) ------------------------------------
Console.WriteLine("[1/6] Prelogin...");

var prelogin = await client.Accounts.AccountsPostPreloginAsync(
  new PasswordPreloginRequestModel { Email = email });

int kdfType = (int?)prelogin.Kdf ?? 0;
int kdfIterations = prelogin.KdfIterations ?? 600000;
Console.WriteLine($"  KDF: {(kdfType == 0 ? "PBKDF2-SHA256" : "Argon2id")}, iterations: {kdfIterations}");

// -- Step 2: Derive keys --------------------------------------------------
Console.WriteLine("[2/6] Deriving keys...");

byte[] passwordBytes = Encoding.UTF8.GetBytes(masterPassword);
byte[] saltBytes = Encoding.UTF8.GetBytes(email.ToLowerInvariant());

byte[] masterKey = Rfc2898DeriveBytes.Pbkdf2(
  passwordBytes, saltBytes, kdfIterations, HashAlgorithmName.SHA256, 32);

byte[] encKey = HKDF.Expand(HashAlgorithmName.SHA256, masterKey, 32, Encoding.UTF8.GetBytes("enc"));
byte[] macKey = HKDF.Expand(HashAlgorithmName.SHA256, masterKey, 32, Encoding.UTF8.GetBytes("mac"));
byte[] stretchedKey = [.. encKey, .. macKey];

byte[] masterPasswordHash = Rfc2898DeriveBytes.Pbkdf2(
  masterKey, passwordBytes, 1, HashAlgorithmName.SHA256, 32);
string hashedPassword = Convert.ToBase64String(masterPasswordHash);

Console.WriteLine("  Keys derived.");

// -- Step 3: Get access token ---------------------------------------------
Console.WriteLine("[3/6] Authenticating...");

string deviceId = Guid.NewGuid().ToString();

var tokenRequest = new ConnectTokenRequest
{
  GrantType = "password",
  Username = email,
  Password = hashedPassword,
  Scope = "api offline_access",
  ClientId = "cli",
  DeviceType = 9,
  DeviceIdentifier = deviceId,
  DeviceName = "apigen-test",
};

TokenResponse tokenResponse;
try
{
  tokenResponse = await client.Connect.ConnectTokenAsync(tokenRequest);
}
catch (HttpRequestException ex) when (ex.StatusCode == System.Net.HttpStatusCode.BadRequest)
{
  // 2FA required — retry with TOTP code
  Console.WriteLine("  2FA required.");
  Console.Write("  2FA code (TOTP): ");
  string twoFactorCode = Console.ReadLine()!.Trim();

  tokenRequest.TwoFactorToken = twoFactorCode;
  tokenRequest.TwoFactorProvider = 0;
  tokenRequest.TwoFactorRemember = 0;
  tokenRequest.DeviceIdentifier = Guid.NewGuid().ToString();

  tokenResponse = await client.Connect.ConnectTokenAsync(tokenRequest);
}

Console.WriteLine($"  Authenticated! Token expires in {tokenResponse.ExpiresIn}s");

// -- Step 4: Decrypt the user symmetric key --------------------------------
Console.WriteLine("[4/6] Decrypting vault key...");

byte[] userSymmetricKey = DecryptEncString(tokenResponse.Key!, stretchedKey);
Console.WriteLine($"  User symmetric key: {userSymmetricKey.Length} bytes");

// -- Step 5: Sync vault ----------------------------------------------------
Console.WriteLine("[5/6] Syncing vault...");

// Add the Bearer token to the shared HttpClient for subsequent API calls
httpClient.DefaultRequestHeaders.Authorization =
  new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", tokenResponse.AccessToken);

var syncResponse = await client.Sync.SyncGetAsync(
  new SyncGetRequest { ExcludeDomains = true });

var ciphers = syncResponse?.Ciphers ?? [];
Console.WriteLine($"  {ciphers.Count} items in vault");

// -- Step 6: Decrypt org keys ----------------------------------------------
Console.WriteLine("[6/6] Decrypting organization keys...");

// Decrypt the user's RSA private key
Dictionary<Guid, byte[]> orgKeys = new();
if (!string.IsNullOrEmpty(tokenResponse.PrivateKey))
{
  byte[] rsaPrivateKeyDer = DecryptEncString(tokenResponse.PrivateKey, userSymmetricKey);
  using var rsa = RSA.Create();
  rsa.ImportPkcs8PrivateKey(rsaPrivateKeyDer, out _);

  // Decrypt each org's key using RSA
  foreach (var org in syncResponse?.Profile?.Organizations ?? [])
  {
    if (org.Id == null || string.IsNullOrEmpty(org.Key)) continue;
    try
    {
      byte[] orgKeyBytes = DecryptRsa(org.Key, rsa);
      orgKeys[org.Id.Value] = orgKeyBytes;
    }
    catch (Exception ex)
    {
      Console.WriteLine($"  Warning: could not decrypt key for org {org.Id}: {ex.Message}");
    }
  }
  Console.WriteLine($"  Decrypted {orgKeys.Count} organization key(s)");
}
else
{
  Console.WriteLine("  No private key (no org support)");
}

Console.WriteLine();

// -- Display items like `bw list items` ------------------------------------
Console.WriteLine($"{"Type",-12} {"Name",-40} {"Username",-30} URI");
Console.WriteLine(new string('-', 110));

foreach (var cipher in ciphers.Where(c => c.DeletedDate == null))
{
  string typeName = cipher.Type switch
  {
    CipherType.Login => "Login",
    CipherType.SecureNote => "SecureNote",
    CipherType.Card => "Card",
    CipherType.Identity => "Identity",
    CipherType.SshKey => "SSHKey",
    _ => cipher.Type?.ToString() ?? "?"
  };

  // Determine the base key: org key or user key
  byte[] baseKey = userSymmetricKey;
  if (cipher.OrganizationId != null && orgKeys.TryGetValue(cipher.OrganizationId.Value, out var ok))
    baseKey = ok;

  // Per-item key (encrypted with the base key)
  byte[] itemKey = baseKey;
  if (!string.IsNullOrEmpty(cipher.Key))
  {
    try { itemKey = DecryptEncString(cipher.Key, baseKey); }
    catch { /* fall back to base key */ }
  }

  string name = TryDecrypt(cipher.Name, itemKey);
  string username = "";
  string uri = "";

  if (cipher.Login != null)
  {
    username = TryDecrypt(cipher.Login.Username, itemKey);
    var firstUri = cipher.Login.Uris?.FirstOrDefault();
    if (firstUri != null)
      uri = TryDecrypt(firstUri.Uri, itemKey);
  }

  Console.WriteLine($"{typeName,-12} {Truncate(name, 38),-40} {Truncate(username, 28),-30} {Truncate(uri, 50)}");
}

Console.WriteLine();
Console.WriteLine($"Total: {ciphers.Count} items ({ciphers.Count(c => c.DeletedDate != null)} in trash)");

// ── Helpers ──────────────────────────────────────────────────────────────

static string Truncate(string s, int max) =>
  s.Length <= max ? s : s[..(max - 1)] + "…";

static string TryDecrypt(string? encString, byte[] key)
{
  if (string.IsNullOrEmpty(encString)) return "";
  try
  {
    byte[] plain = DecryptEncString(encString, key);
    return Encoding.UTF8.GetString(plain);
  }
  catch
  {
    return "[decrypt error]";
  }
}

static byte[] DecryptRsa(string encString, RSA rsa)
{
  // Format: "{type}.{ct}" — type 3 = RSA-2048-OAEP-SHA256, type 4 = RSA-2048-OAEP-SHA1
  int dotIdx = encString.IndexOf('.');
  int encType = int.Parse(encString[..dotIdx]);
  byte[] ct = Convert.FromBase64String(encString[(dotIdx + 1)..].Split('|')[0]);

  var padding = encType == 3 ? RSAEncryptionPadding.OaepSHA256
    : encType == 4 ? RSAEncryptionPadding.OaepSHA1
    : RSAEncryptionPadding.OaepSHA1; // default fallback

  return rsa.Decrypt(ct, padding);
}

static byte[] DecryptEncString(string encString, byte[] key)
{
  // Format: "{type}.{iv}|{ct}|{mac}"
  int dotIdx = encString.IndexOf('.');
  int encType = int.Parse(encString[..dotIdx]);
  string[] parts = encString[(dotIdx + 1)..].Split('|');

  byte[] iv = Convert.FromBase64String(parts[0]);
  byte[] ct = Convert.FromBase64String(parts[1]);

  byte[] ek = key[..32];
  byte[] mk = key[32..64];

  if (encType == 2 && parts.Length == 3)
  {
    byte[] mac = Convert.FromBase64String(parts[2]);
    byte[] macData = [.. iv, .. ct];
    byte[] computedMac = HMACSHA256.HashData(mk, macData);
    if (!CryptographicOperations.FixedTimeEquals(computedMac, mac))
      throw new CryptographicException("MAC verification failed");
  }

  using var aes = Aes.Create();
  aes.Key = ek;
  aes.IV = iv;
  aes.Mode = CipherMode.CBC;
  aes.Padding = PaddingMode.PKCS7;
  return aes.CreateDecryptor().TransformFinalBlock(ct, 0, ct.Length);
}

static string ReadPassword()
{
  var sb = new StringBuilder();
  while (true)
  {
    var keyInfo = Console.ReadKey(intercept: true);
    if (keyInfo.Key == ConsoleKey.Enter) break;
    if (keyInfo.Key == ConsoleKey.Backspace && sb.Length > 0)
    {
      sb.Remove(sb.Length - 1, 1);
      Console.Write("\b \b");
    }
    else if (keyInfo.Key != ConsoleKey.Backspace)
    {
      sb.Append(keyInfo.KeyChar);
      Console.Write('*');
    }
  }
  return sb.ToString();
}
