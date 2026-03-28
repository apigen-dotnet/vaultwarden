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
/// Client for Events operations
/// </summary>
public class EventsClient
{
  private readonly HttpClient _httpClient;
  private readonly ILogger? _logger;

  internal EventsClient(HttpClient httpClient, ILogger? logger = null)
  {
    _httpClient = httpClient;
    _logger = logger;
  }

  /// <summary>
  /// 
  /// Operation: GET /api/ciphers/{id}/events
  /// </summary>
  public async Task<EventResponseModelListResponseModel> EventsGetCipherAsync(string id, EventsGetCipherRequest? request = null)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["id"] = id
    };
    string url = "api/ciphers/{id}/events".BuildUrl(pathParams, request);

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
    EventResponseModelListResponseModel? result = JsonSerializer.Deserialize<EventResponseModelListResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new EventResponseModelListResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{id}/events
  /// </summary>
  public async Task<EventResponseModelListResponseModel> EventsGetOrganizationAsync(string id, EventsGetOrganizationRequest? request = null)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["id"] = id
    };
    string url = "api/organizations/{id}/events".BuildUrl(pathParams, request);

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
    EventResponseModelListResponseModel? result = JsonSerializer.Deserialize<EventResponseModelListResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new EventResponseModelListResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/users/{id}/events
  /// </summary>
  public async Task<EventResponseModelListResponseModel> EventsGetOrganizationUserAsync(string orgId, string id, EventsGetOrganizationUserRequest? request = null)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId,
      ["id"] = id
    };
    string url = "api/organizations/{orgId}/users/{id}/events".BuildUrl(pathParams, request);

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
    EventResponseModelListResponseModel? result = JsonSerializer.Deserialize<EventResponseModelListResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new EventResponseModelListResponseModel();
  }


}
