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
/// Client for Policies operations
/// </summary>
public class PoliciesClient
{
  private readonly HttpClient _httpClient;
  private readonly ILogger? _logger;

  internal PoliciesClient(HttpClient httpClient, ILogger? logger = null)
  {
    _httpClient = httpClient;
    _logger = logger;
  }

  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/policies/{type}
  /// </summary>
  public async Task<PolicyDetailResponseModel> GetAsync(string orgId, int type)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId,
      ["type"] = type
    };
    string url = "api/organizations/{orgId}/policies/{type}".BuildUrl(pathParams);

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
    PolicyDetailResponseModel? result = JsonSerializer.Deserialize<PolicyDetailResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new PolicyDetailResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: PUT /api/organizations/{orgId}/policies/{type}
  /// </summary>
  public async Task<PolicyResponseModel> UpdateAsync(string orgId, int type, Apigen.Vaultwarden.Models.PolicyRequestModel policyRequestModel)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId,
      ["type"] = type
    };
    string url = "api/organizations/{orgId}/policies/{type}".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "PUT", url);
    string json = JsonSerializer.Serialize(policyRequestModel, JsonConfig.Default);
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
    PolicyResponseModel? result = JsonSerializer.Deserialize<PolicyResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new PolicyResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/policies
  /// </summary>
  public async Task<PolicyResponseModelListResponseModel> PoliciesGetAllAsync(string orgId)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId
    };
    string url = "api/organizations/{orgId}/policies".BuildUrl(pathParams);

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
    PolicyResponseModelListResponseModel? result = JsonSerializer.Deserialize<PolicyResponseModelListResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new PolicyResponseModelListResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/policies/token
  /// </summary>
  public async Task<PolicyResponseModelListResponseModel> PoliciesGetByTokenAsync(string orgId, PoliciesGetByTokenRequest? request = null)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId
    };
    string url = "api/organizations/{orgId}/policies/token".BuildUrl(pathParams, request);

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
    PolicyResponseModelListResponseModel? result = JsonSerializer.Deserialize<PolicyResponseModelListResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new PolicyResponseModelListResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/policies/master-password
  /// </summary>
  public async Task<PolicyResponseModel> PoliciesGetMasterPasswordPolicyAsync(string orgId)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId
    };
    string url = "api/organizations/{orgId}/policies/master-password".BuildUrl(pathParams);

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
    PolicyResponseModel? result = JsonSerializer.Deserialize<PolicyResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new PolicyResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: PUT /api/organizations/{orgId}/policies/{type}/vnext
  /// </summary>
  public async Task<PolicyResponseModel> PoliciesPutVNextAsync(string orgId, int type, Apigen.Vaultwarden.Models.SavePolicyRequest savePolicyRequest)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId,
      ["type"] = type
    };
    string url = "api/organizations/{orgId}/policies/{type}/vnext".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "PUT", url);
    string json = JsonSerializer.Serialize(savePolicyRequest, JsonConfig.Default);
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
    PolicyResponseModel? result = JsonSerializer.Deserialize<PolicyResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new PolicyResponseModel();
  }


}
