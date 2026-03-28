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
/// Client for AuthRequests operations
/// </summary>
public class AuthRequestsClient
{
  private readonly HttpClient _httpClient;
  private readonly ILogger? _logger;

  internal AuthRequestsClient(HttpClient httpClient, ILogger? logger = null)
  {
    _httpClient = httpClient;
    _logger = logger;
  }

  /// <summary>
  /// 
  /// Operation: GET /api/auth-requests
  /// </summary>
  public async Task<AuthRequestResponseModelListResponseModel> AuthRequestsGetAllAsync()
  {
    string url = "api/auth-requests";

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
    AuthRequestResponseModelListResponseModel? result = JsonSerializer.Deserialize<AuthRequestResponseModelListResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new AuthRequestResponseModelListResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: POST /api/auth-requests
  /// </summary>
  public async Task<AuthRequestResponseModel> AuthRequestsPostAsync(Apigen.Vaultwarden.Models.AuthRequestCreateRequestModel authRequestCreateRequestModel)
  {
    string url = "api/auth-requests";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(authRequestCreateRequestModel, JsonConfig.Default);
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
    AuthRequestResponseModel? result = JsonSerializer.Deserialize<AuthRequestResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new AuthRequestResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: GET /api/auth-requests/{id}
  /// </summary>
  public async Task<AuthRequestResponseModel> GetAsync(string id)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["id"] = id
    };
    string url = "api/auth-requests/{id}".BuildUrl(pathParams);

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
    AuthRequestResponseModel? result = JsonSerializer.Deserialize<AuthRequestResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new AuthRequestResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: PUT /api/auth-requests/{id}
  /// </summary>
  public async Task<AuthRequestResponseModel> UpdateAsync(string id, Apigen.Vaultwarden.Models.AuthRequestUpdateRequestModel authRequestUpdateRequestModel)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["id"] = id
    };
    string url = "api/auth-requests/{id}".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "PUT", url);
    string json = JsonSerializer.Serialize(authRequestUpdateRequestModel, JsonConfig.Default);
    HttpClientLog.LogTraceRequestBody(_logger, "PUT", "application/json", json);
    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
    HttpResponseMessage response = await _httpClient.PutAsync(url, content);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.LogDebugRequestCompleted(_logger, (int)response.StatusCode, "PUT", url, durationMs);

    string responseContent;
    try
    {
      response.EnsureSuccessStatusCode();
      responseContent = await response.Content.ReadAsStringAsync();
    }
    catch (HttpRequestException ex)
    {
      responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.LogErrorRequestFailed(_logger, (int)response.StatusCode, "PUT", url, responseContent, ex);
      throw;
    }

    HttpClientLog.LogTraceResponseBody(_logger, url, responseContent);
    AuthRequestResponseModel? result = JsonSerializer.Deserialize<AuthRequestResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new AuthRequestResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: GET /api/auth-requests/pending
  /// </summary>
  public async Task<PendingAuthRequestResponseModelListResponseModel> AuthRequestsGetPendingAuthRequestsAsync()
  {
    string url = "api/auth-requests/pending";

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
    PendingAuthRequestResponseModelListResponseModel? result = JsonSerializer.Deserialize<PendingAuthRequestResponseModelListResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new PendingAuthRequestResponseModelListResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: GET /api/auth-requests/{id}/response
  /// </summary>
  public async Task<AuthRequestResponseModel> AuthRequestsGetResponseAsync(string id, AuthRequestsGetResponseRequest? request = null)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["id"] = id
    };
    string url = "api/auth-requests/{id}/response".BuildUrl(pathParams, request);

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
    AuthRequestResponseModel? result = JsonSerializer.Deserialize<AuthRequestResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new AuthRequestResponseModel();
  }


}
