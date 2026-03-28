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
/// Client for Organization operations
/// </summary>
public class OrganizationClient
{
  private readonly HttpClient _httpClient;
  private readonly ILogger? _logger;

  internal OrganizationClient(HttpClient httpClient, ILogger? logger = null)
  {
    _httpClient = httpClient;
    _logger = logger;
  }

  /// <summary>
  /// Import members and groups.
  /// Operation: POST /public/organization/import
  /// </summary>
  public async Task<OkResult> OrganizationImportAsync(Apigen.Vaultwarden.Models.OrganizationImportRequestModel organizationImportRequestModel)
  {
    string url = "public/organization/import";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(organizationImportRequestModel, JsonConfig.Default);
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
    OkResult? result = JsonSerializer.Deserialize<OkResult>(responseContent, JsonConfig.Default);
    return result ?? new OkResult();
  }


}
