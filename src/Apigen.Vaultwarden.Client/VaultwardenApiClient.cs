using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using Apigen.Vaultwarden.Models;
using Microsoft.Extensions.Logging;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Main API client for accessing all resources
/// </summary>
public class VaultwardenApiClient
{
  private readonly HttpClient _httpClient;
  private readonly bool _disposeHttpClient;
  private readonly ILogger? _logger;

  /// <summary>
  /// Client for Accounts operations
  /// </summary>
  public AccountsClient Accounts { get; }

  /// <summary>
  /// Client for Connect operations
  /// </summary>
  public ConnectClient Connect { get; }

  /// <summary>
  /// Client for AccountsKeyManagement operations
  /// </summary>
  public AccountsKeyManagementClient AccountsKeyManagement { get; }

  /// <summary>
  /// Client for AuthRequests operations
  /// </summary>
  public AuthRequestsClient AuthRequests { get; }

  /// <summary>
  /// Client for Ciphers operations
  /// </summary>
  public CiphersClient Ciphers { get; }

  /// <summary>
  /// Client for Collections operations
  /// </summary>
  public CollectionsClient Collections { get; }

  /// <summary>
  /// Client for Config operations
  /// </summary>
  public ConfigClient Config { get; }

  /// <summary>
  /// Client for Devices operations
  /// </summary>
  public DevicesClient Devices { get; }

  /// <summary>
  /// Client for EmergencyAccess operations
  /// </summary>
  public EmergencyAccessClient EmergencyAccess { get; }

  /// <summary>
  /// Client for Events operations
  /// </summary>
  public EventsClient Events { get; }

  /// <summary>
  /// Client for Folders operations
  /// </summary>
  public FoldersClient Folders { get; }

  /// <summary>
  /// Client for Groups operations
  /// </summary>
  public GroupsClient Groups { get; }

  /// <summary>
  /// Client for Hibp operations
  /// </summary>
  public HibpClient Hibp { get; }

  /// <summary>
  /// Client for ImportCiphers operations
  /// </summary>
  public ImportCiphersClient ImportCiphers { get; }

  /// <summary>
  /// Client for Info operations
  /// </summary>
  public InfoClient Info { get; }

  /// <summary>
  /// Client for OrganizationBilling operations
  /// </summary>
  public OrganizationBillingClient OrganizationBilling { get; }

  /// <summary>
  /// Client for OrganizationBillingVNext operations
  /// </summary>
  public OrganizationBillingVNextClient OrganizationBillingVNext { get; }

  /// <summary>
  /// Client for OrganizationDomain operations
  /// </summary>
  public OrganizationDomainClient OrganizationDomain { get; }

  /// <summary>
  /// Client for OrganizationExport operations
  /// </summary>
  public OrganizationExportClient OrganizationExport { get; }

  /// <summary>
  /// Client for Organizations operations
  /// </summary>
  public OrganizationsClient Organizations { get; }

  /// <summary>
  /// Client for OrganizationUsers operations
  /// </summary>
  public OrganizationUsersClient OrganizationUsers { get; }

  /// <summary>
  /// Client for Plans operations
  /// </summary>
  public PlansClient Plans { get; }

  /// <summary>
  /// Client for Policies operations
  /// </summary>
  public PoliciesClient Policies { get; }

  /// <summary>
  /// Client for SecurityTask operations
  /// </summary>
  public SecurityTaskClient SecurityTask { get; }

  /// <summary>
  /// Client for Sends operations
  /// </summary>
  public SendsClient Sends { get; }

  /// <summary>
  /// Client for Settings operations
  /// </summary>
  public SettingsClient Settings { get; }

  /// <summary>
  /// Client for Sync operations
  /// </summary>
  public SyncClient Sync { get; }

  /// <summary>
  /// Client for TwoFactor operations
  /// </summary>
  public TwoFactorClient TwoFactor { get; }

  /// <summary>
  /// Client for Users operations
  /// </summary>
  public UsersClient Users { get; }

  /// <summary>
  /// Client for WebAuthn operations
  /// </summary>
  public WebAuthnClient WebAuthn { get; }

  /// <summary>
  /// Client for Organization operations
  /// </summary>
  public OrganizationClient Organization { get; }

  /// <summary>
  /// Initialize client with a pre-configured HttpClient
  /// </summary>
  /// <param name="httpClient">Pre-configured HttpClient with base address, auth headers, etc.</param>
  /// <param name="logger">Optional logger for request/response logging</param>
  public VaultwardenApiClient(HttpClient httpClient, ILogger? logger = null)
  {
    _httpClient = httpClient;
    _disposeHttpClient = false;
    _logger = logger;

    Accounts = new AccountsClient(_httpClient, _logger);
    Connect = new ConnectClient(_httpClient, _logger);
    AccountsKeyManagement = new AccountsKeyManagementClient(_httpClient, _logger);
    AuthRequests = new AuthRequestsClient(_httpClient, _logger);
    Ciphers = new CiphersClient(_httpClient, _logger);
    Collections = new CollectionsClient(_httpClient, _logger);
    Config = new ConfigClient(_httpClient, _logger);
    Devices = new DevicesClient(_httpClient, _logger);
    EmergencyAccess = new EmergencyAccessClient(_httpClient, _logger);
    Events = new EventsClient(_httpClient, _logger);
    Folders = new FoldersClient(_httpClient, _logger);
    Groups = new GroupsClient(_httpClient, _logger);
    Hibp = new HibpClient(_httpClient, _logger);
    ImportCiphers = new ImportCiphersClient(_httpClient, _logger);
    Info = new InfoClient(_httpClient, _logger);
    OrganizationBilling = new OrganizationBillingClient(_httpClient, _logger);
    OrganizationBillingVNext = new OrganizationBillingVNextClient(_httpClient, _logger);
    OrganizationDomain = new OrganizationDomainClient(_httpClient, _logger);
    OrganizationExport = new OrganizationExportClient(_httpClient, _logger);
    Organizations = new OrganizationsClient(_httpClient, _logger);
    OrganizationUsers = new OrganizationUsersClient(_httpClient, _logger);
    Plans = new PlansClient(_httpClient, _logger);
    Policies = new PoliciesClient(_httpClient, _logger);
    SecurityTask = new SecurityTaskClient(_httpClient, _logger);
    Sends = new SendsClient(_httpClient, _logger);
    Settings = new SettingsClient(_httpClient, _logger);
    Sync = new SyncClient(_httpClient, _logger);
    TwoFactor = new TwoFactorClient(_httpClient, _logger);
    Users = new UsersClient(_httpClient, _logger);
    WebAuthn = new WebAuthnClient(_httpClient, _logger);
    Organization = new OrganizationClient(_httpClient, _logger);
  }

  private VaultwardenApiClient(HttpClient httpClient, bool disposeHttpClient, ILogger? logger)
  {
    _httpClient = httpClient;
    _disposeHttpClient = disposeHttpClient;
    _logger = logger;

    Accounts = new AccountsClient(_httpClient, _logger);
    Connect = new ConnectClient(_httpClient, _logger);
    AccountsKeyManagement = new AccountsKeyManagementClient(_httpClient, _logger);
    AuthRequests = new AuthRequestsClient(_httpClient, _logger);
    Ciphers = new CiphersClient(_httpClient, _logger);
    Collections = new CollectionsClient(_httpClient, _logger);
    Config = new ConfigClient(_httpClient, _logger);
    Devices = new DevicesClient(_httpClient, _logger);
    EmergencyAccess = new EmergencyAccessClient(_httpClient, _logger);
    Events = new EventsClient(_httpClient, _logger);
    Folders = new FoldersClient(_httpClient, _logger);
    Groups = new GroupsClient(_httpClient, _logger);
    Hibp = new HibpClient(_httpClient, _logger);
    ImportCiphers = new ImportCiphersClient(_httpClient, _logger);
    Info = new InfoClient(_httpClient, _logger);
    OrganizationBilling = new OrganizationBillingClient(_httpClient, _logger);
    OrganizationBillingVNext = new OrganizationBillingVNextClient(_httpClient, _logger);
    OrganizationDomain = new OrganizationDomainClient(_httpClient, _logger);
    OrganizationExport = new OrganizationExportClient(_httpClient, _logger);
    Organizations = new OrganizationsClient(_httpClient, _logger);
    OrganizationUsers = new OrganizationUsersClient(_httpClient, _logger);
    Plans = new PlansClient(_httpClient, _logger);
    Policies = new PoliciesClient(_httpClient, _logger);
    SecurityTask = new SecurityTaskClient(_httpClient, _logger);
    Sends = new SendsClient(_httpClient, _logger);
    Settings = new SettingsClient(_httpClient, _logger);
    Sync = new SyncClient(_httpClient, _logger);
    TwoFactor = new TwoFactorClient(_httpClient, _logger);
    Users = new UsersClient(_httpClient, _logger);
    WebAuthn = new WebAuthnClient(_httpClient, _logger);
    Organization = new OrganizationClient(_httpClient, _logger);
  }

  /// <summary>
  /// Create client with Bearer token authentication
  /// </summary>
  public static VaultwardenApiClient WithBearer(string bearerToken, string baseUrl = "https://localhost", ILogger? logger = null)
  {
    HttpClient httpClient = CreateTokenAuthHttpClient(bearerToken, baseUrl, "Authorization", true);
    return new VaultwardenApiClient(httpClient, true, logger);
  }

  private static HttpClient CreateTokenAuthHttpClient(string apiToken, string baseUrl, string headerName, bool useBearer)
  {
    // Ensure baseUrl ends with / for proper Uri combining with relative paths
    string normalizedBaseUrl = baseUrl.EndsWith("/") ? baseUrl : baseUrl + "/";
    HttpClient client = new() { BaseAddress = new Uri(normalizedBaseUrl) };

    if (useBearer)
    {
      client.DefaultRequestHeaders.Add(headerName, $"Bearer {apiToken}");
    }
    else
    {
      client.DefaultRequestHeaders.Add(headerName, apiToken);
    }

    return client;
  }

  private static HttpClient CreateBasicAuthHttpClient(string username, string password, string baseUrl)
  {
    // Ensure baseUrl ends with / for proper Uri combining with relative paths
    string normalizedBaseUrl = baseUrl.EndsWith("/") ? baseUrl : baseUrl + "/";
    HttpClient client = new() { BaseAddress = new Uri(normalizedBaseUrl) };

    string credentials = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"{username}:{password}"));
    client.DefaultRequestHeaders.Add("Authorization", $"Basic {credentials}");

    return client;
  }

  private static HttpClient CreateCookieAuthHttpClient(string token, string cookieName, string baseUrl)
  {
    string normalizedBaseUrl = baseUrl.EndsWith("/") ? baseUrl : baseUrl + "/";
    System.Net.CookieContainer cookies = new();
    cookies.Add(new Uri(normalizedBaseUrl), new System.Net.Cookie(cookieName, token));
    HttpClientHandler handler = new() { CookieContainer = cookies };
    HttpClient client = new(handler) { BaseAddress = new Uri(normalizedBaseUrl) };

    return client;
  }

  /// <summary>
  /// Dispose resources
  /// </summary>
  public void Dispose()
  {
    if (_disposeHttpClient)
    {
      _httpClient?.Dispose();
    }
  }
}
