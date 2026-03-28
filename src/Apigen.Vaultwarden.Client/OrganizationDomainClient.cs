using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;
using Microsoft.Extensions.Logging;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Client for OrganizationDomain operations
/// </summary>
public class OrganizationDomainClient
{
  private readonly HttpClient _httpClient;
  private readonly ILogger? _logger;

  internal OrganizationDomainClient(HttpClient httpClient, ILogger? logger = null)
  {
    _httpClient = httpClient;
    _logger = logger;
  }

  /// <summary>
  /// 
  /// Operation: POST /api/organizations/domain/sso/verified
  /// </summary>
  public async Task<VerifiedOrganizationDomainSsoDetailsResponseModel> OrganizationDomainGetVerifiedOrgDomainSsoDetailsAsync(Apigen.Vaultwarden.Models.OrganizationDomainSsoDetailsRequestModel organizationDomainSsoDetailsRequestModel)
  {
    string url = "api/organizations/domain/sso/verified";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(organizationDomainSsoDetailsRequestModel, JsonConfig.Default);
    HttpClientLog.LogTraceRequestBody(_logger, "POST", "application/json", json);
    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
    HttpResponseMessage response = await _httpClient.PostAsync(url, content);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.LogDebugRequestCompleted(_logger, (int)response.StatusCode, "POST", url, durationMs);

    string responseContent;
    try
    {
      response.EnsureSuccessStatusCode();
      responseContent = await response.Content.ReadAsStringAsync();
    }
    catch (HttpRequestException ex)
    {
      responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.LogErrorRequestFailed(_logger, (int)response.StatusCode, "POST", url, responseContent, ex);
      throw;
    }

    HttpClientLog.LogTraceResponseBody(_logger, url, responseContent);
    VerifiedOrganizationDomainSsoDetailsResponseModel? result = JsonSerializer.Deserialize<VerifiedOrganizationDomainSsoDetailsResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new VerifiedOrganizationDomainSsoDetailsResponseModel();
  }


}
