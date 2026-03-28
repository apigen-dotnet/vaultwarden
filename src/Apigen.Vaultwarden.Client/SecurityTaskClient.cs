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
/// Client for SecurityTask operations
/// </summary>
public class SecurityTaskClient
{
  private readonly HttpClient _httpClient;
  private readonly ILogger? _logger;

  internal SecurityTaskClient(HttpClient httpClient, ILogger? logger = null)
  {
    _httpClient = httpClient;
    _logger = logger;
  }

  /// <summary>
  /// Retrieves security tasks for the current user.
  /// Operation: GET /api/tasks
  /// </summary>
  public async Task<SecurityTasksResponseModelListResponseModel> SecurityTaskGetAsync(SecurityTaskGetRequest? request = null)
  {
    string url = "api/tasks".BuildUrl(request: request);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "GET", url);
    HttpResponseMessage response = await _httpClient.GetAsync(url);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.LogDebugRequestCompleted(_logger, (int)response.StatusCode, "GET", url, durationMs);

    string responseContent;
    try
    {
      response.EnsureSuccessStatusCode();
      responseContent = await response.Content.ReadAsStringAsync();
    }
    catch (HttpRequestException ex)
    {
      responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.LogErrorRequestFailed(_logger, (int)response.StatusCode, "GET", url, responseContent, ex);
      throw;
    }

    HttpClientLog.LogTraceResponseBody(_logger, url, responseContent);
    SecurityTasksResponseModelListResponseModel? result = JsonSerializer.Deserialize<SecurityTasksResponseModelListResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new SecurityTasksResponseModelListResponseModel();
  }


}
