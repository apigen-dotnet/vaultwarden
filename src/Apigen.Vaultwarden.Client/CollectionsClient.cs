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
/// Client for Collections operations
/// </summary>
public class CollectionsClient
{
  private readonly HttpClient _httpClient;
  private readonly ILogger? _logger;

  internal CollectionsClient(HttpClient httpClient, ILogger? logger = null)
  {
    _httpClient = httpClient;
    _logger = logger;
  }

  /// <summary>
  /// 
  /// Operation: PUT /api/organizations/{orgId}/collections/{id}
  /// </summary>
  public async Task<CollectionResponseModel> UpdateAsync(string orgId, string id, Apigen.Vaultwarden.Models.UpdateCollectionRequestModel updateCollectionRequestModel)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId,
      ["id"] = id
    };
    string url = "api/organizations/{orgId}/collections/{id}".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "PUT", url);
    string json = JsonSerializer.Serialize(updateCollectionRequestModel, JsonConfig.Default);
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
    CollectionResponseModel? result = JsonSerializer.Deserialize<CollectionResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new CollectionResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{orgId}/collections/{id}
  /// </summary>
  public async Task<CollectionResponseModel> CollectionsPostPutAsync(string orgId, string id, Apigen.Vaultwarden.Models.UpdateCollectionRequestModel updateCollectionRequestModel)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId,
      ["id"] = id
    };
    string url = "api/organizations/{orgId}/collections/{id}".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(updateCollectionRequestModel, JsonConfig.Default);
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
    CollectionResponseModel? result = JsonSerializer.Deserialize<CollectionResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new CollectionResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: DELETE /api/organizations/{orgId}/collections/{id}
  /// </summary>
  public async Task DeleteAsync(string orgId, string id)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId,
      ["id"] = id
    };
    string url = "api/organizations/{orgId}/collections/{id}".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "DELETE", url);
    HttpResponseMessage response = await _httpClient.DeleteAsync(url);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.LogDebugRequestCompleted(_logger, (int)response.StatusCode, "DELETE", url, durationMs);

    try
    {
      response.EnsureSuccessStatusCode();
    }
    catch (HttpRequestException ex)
    {
      string responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.LogErrorRequestFailed(_logger, (int)response.StatusCode, "DELETE", url, responseContent, ex);
      throw;
    }
  }


  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/collections/{id}/details
  /// </summary>
  public async Task<CollectionAccessDetailsResponseModel> CollectionsGetDetailsAsync(string orgId, string id)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId,
      ["id"] = id
    };
    string url = "api/organizations/{orgId}/collections/{id}/details".BuildUrl(pathParams);

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
    CollectionAccessDetailsResponseModel? result = JsonSerializer.Deserialize<CollectionAccessDetailsResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new CollectionAccessDetailsResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/collections/details
  /// </summary>
  public async Task<CollectionAccessDetailsResponseModelListResponseModel> CollectionsGetManyWithDetailsAsync(string orgId)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId
    };
    string url = "api/organizations/{orgId}/collections/details".BuildUrl(pathParams);

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
    CollectionAccessDetailsResponseModelListResponseModel? result = JsonSerializer.Deserialize<CollectionAccessDetailsResponseModelListResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new CollectionAccessDetailsResponseModelListResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/collections
  /// </summary>
  public async Task<CollectionResponseModelListResponseModel> CollectionsGetAllAsync(string orgId)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId
    };
    string url = "api/organizations/{orgId}/collections".BuildUrl(pathParams);

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
    CollectionResponseModelListResponseModel? result = JsonSerializer.Deserialize<CollectionResponseModelListResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new CollectionResponseModelListResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{orgId}/collections
  /// </summary>
  public async Task<CollectionResponseModel> CollectionsPostAsync(string orgId, Apigen.Vaultwarden.Models.CreateCollectionRequestModel createCollectionRequestModel)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId
    };
    string url = "api/organizations/{orgId}/collections".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(createCollectionRequestModel, JsonConfig.Default);
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
    CollectionResponseModel? result = JsonSerializer.Deserialize<CollectionResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new CollectionResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: DELETE /api/organizations/{orgId}/collections
  /// </summary>
  public async Task CollectionsDeleteManyAsync(string orgId, Apigen.Vaultwarden.Models.CollectionBulkDeleteRequestModel collectionBulkDeleteRequestModel)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId
    };
    string url = "api/organizations/{orgId}/collections".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "DELETE", url);
    HttpResponseMessage response = await _httpClient.DeleteAsync(url);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.LogDebugRequestCompleted(_logger, (int)response.StatusCode, "DELETE", url, durationMs);

    try
    {
      response.EnsureSuccessStatusCode();
    }
    catch (HttpRequestException ex)
    {
      string responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.LogErrorRequestFailed(_logger, (int)response.StatusCode, "DELETE", url, responseContent, ex);
      throw;
    }
  }


  /// <summary>
  /// 
  /// Operation: GET /api/collections
  /// </summary>
  public async Task<CollectionDetailsResponseModelListResponseModel> CollectionsGetUserAsync()
  {
    string url = "api/collections";

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
    CollectionDetailsResponseModelListResponseModel? result = JsonSerializer.Deserialize<CollectionDetailsResponseModelListResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new CollectionDetailsResponseModelListResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/collections/{id}/users
  /// </summary>
  public async Task<List<SelectionReadOnlyResponseModel>> CollectionsGetUsersAsync(string orgId, string id)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId,
      ["id"] = id
    };
    string url = "api/organizations/{orgId}/collections/{id}/users".BuildUrl(pathParams);

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
    List<SelectionReadOnlyResponseModel>? result = JsonSerializer.Deserialize<List<SelectionReadOnlyResponseModel>>(responseContent, JsonConfig.Default);
    return result ?? new List<SelectionReadOnlyResponseModel>();
  }


  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{orgId}/collections/bulk-access
  /// </summary>
  public async Task BulkAsync(string orgId, Apigen.Vaultwarden.Models.BulkCollectionAccessRequestModel bulkCollectionAccessRequestModel)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId
    };
    string url = "api/organizations/{orgId}/collections/bulk-access".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(bulkCollectionAccessRequestModel, JsonConfig.Default);
    HttpClientLog.LogTraceRequestBody(_logger, "POST", "application/json", json);
    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
    HttpResponseMessage response = await _httpClient.PostAsync(url, content);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.LogDebugRequestCompleted(_logger, (int)response.StatusCode, "POST", url, durationMs);

    try
    {
      response.EnsureSuccessStatusCode();
    }
    catch (HttpRequestException ex)
    {
      string responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.LogErrorRequestFailed(_logger, (int)response.StatusCode, "POST", url, responseContent, ex);
      throw;
    }
  }


  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{orgId}/collections/{id}/delete
  /// </summary>
  public async Task CollectionsPostDeleteAsync(string orgId, string id)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId,
      ["id"] = id
    };
    string url = "api/organizations/{orgId}/collections/{id}/delete".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    HttpResponseMessage response = await _httpClient.PostAsync(url, null);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.LogDebugRequestCompleted(_logger, (int)response.StatusCode, "POST", url, durationMs);

    try
    {
      response.EnsureSuccessStatusCode();
    }
    catch (HttpRequestException ex)
    {
      string responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.LogErrorRequestFailed(_logger, (int)response.StatusCode, "POST", url, responseContent, ex);
      throw;
    }
  }


}
