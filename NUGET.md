# Apigen.Vaultwarden

Generated C# client for the [Vaultwarden](https://github.com/dani-garcia/vaultwarden) API (Bitwarden-compatible).

## Installation

```bash
dotnet add package Apigen.Vaultwarden
```

## Usage

```csharp
using Apigen.Vaultwarden.Client;
using Apigen.Vaultwarden.Models;

// All Vaultwarden endpoints share a single base URL
using var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://your-vaultwarden-instance/")
};
var client = new VaultwardenApiClient(httpClient);

// Prelogin (get KDF parameters)
var prelogin = await client.Accounts.AccountsPostPreloginAsync(
    new PasswordPreloginRequestModel { Email = "user@example.com" });

// Authenticate
var token = await client.Connect.ConnectTokenAsync(new ConnectTokenRequest
{
    GrantType = "password",
    Username = "user@example.com",
    Password = hashedPassword,
    Scope = "api offline_access",
    ClientId = "cli",
    DeviceType = 9,
    DeviceIdentifier = Guid.NewGuid().ToString(),
    DeviceName = "my-app",
});

// Add Bearer token for subsequent calls
httpClient.DefaultRequestHeaders.Authorization =
    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.AccessToken);

// Sync vault
var sync = await client.Sync.SyncGetAsync(new SyncGetRequest());
```

## Example

For a complete working example (login, vault sync, item decryption), see the [TestClient on GitHub](https://github.com/apigen-dotnet/vaultwarden/tree/main/examples/Apigen.Vaultwarden.TestClient).

## License

MIT
