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
/// Client for OrganizationUsers operations
/// </summary>
public class OrganizationUsersClient
{
  private readonly HttpClient _httpClient;
  private readonly ILogger? _logger;

  internal OrganizationUsersClient(HttpClient httpClient, ILogger? logger = null)
  {
    _httpClient = httpClient;
    _logger = logger;
  }

  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/users/{id}
  /// </summary>
  public async Task<OrganizationUserDetailsResponseModel> GetAsync(string orgId, string id, OrganizationUsersGetRequest? request = null)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId,
      ["id"] = id
    };
    string url = "api/organizations/{orgId}/users/{id}".BuildUrl(pathParams, request);

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
    OrganizationUserDetailsResponseModel? result = JsonSerializer.Deserialize<OrganizationUserDetailsResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new OrganizationUserDetailsResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: PUT /api/organizations/{orgId}/users/{id}
  /// </summary>
  public async Task UpdateAsync(string orgId, string id, Apigen.Vaultwarden.Models.OrganizationUserUpdateRequestModel organizationUserUpdateRequestModel)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId,
      ["id"] = id
    };
    string url = "api/organizations/{orgId}/users/{id}".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "PUT", url);
    string json = JsonSerializer.Serialize(organizationUserUpdateRequestModel, JsonConfig.Default);
    HttpClientLog.LogTraceRequestBody(_logger, "PUT", "application/json", json);
    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
    HttpResponseMessage response = await _httpClient.PutAsync(url, content);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.LogDebugRequestCompleted(_logger, (int)response.StatusCode, "PUT", url, durationMs);

    try
    {
      response.EnsureSuccessStatusCode();
    }
    catch (HttpRequestException ex)
    {
      string responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.LogErrorRequestFailed(_logger, (int)response.StatusCode, "PUT", url, responseContent, ex);
      throw;
    }
  }


  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{orgId}/users/{id}
  /// </summary>
  public async Task OrganizationUsersPostPutAsync(string orgId, string id, Apigen.Vaultwarden.Models.OrganizationUserUpdateRequestModel organizationUserUpdateRequestModel)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId,
      ["id"] = id
    };
    string url = "api/organizations/{orgId}/users/{id}".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(organizationUserUpdateRequestModel, JsonConfig.Default);
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
  /// Operation: DELETE /api/organizations/{orgId}/users/{id}
  /// </summary>
  public async Task DeleteAsync(string orgId, string id)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId,
      ["id"] = id
    };
    string url = "api/organizations/{orgId}/users/{id}".BuildUrl(pathParams);

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
  /// Returns a set of basic information about all members of the organization. This is available to all members of the organization to manage collections. For this reason, it contains as little information as possible and no cryptographic keys or other sensitive data.
  /// Operation: GET /api/organizations/{orgId}/users/mini-details
  /// </summary>
  public async Task<OrganizationUserUserMiniDetailsResponseModelListResponseModel> OrganizationUsersGetMiniDetailsAsync(string orgId)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId
    };
    string url = "api/organizations/{orgId}/users/mini-details".BuildUrl(pathParams);

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
    OrganizationUserUserMiniDetailsResponseModelListResponseModel? result = JsonSerializer.Deserialize<OrganizationUserUserMiniDetailsResponseModelListResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new OrganizationUserUserMiniDetailsResponseModelListResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/users
  /// </summary>
  public async Task<OrganizationUserUserDetailsResponseModelListResponseModel> OrganizationUsersGetAllAsync(string orgId, OrganizationUsersGetAllRequest? request = null)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId
    };
    string url = "api/organizations/{orgId}/users".BuildUrl(pathParams, request);

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
    OrganizationUserUserDetailsResponseModelListResponseModel? result = JsonSerializer.Deserialize<OrganizationUserUserDetailsResponseModelListResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new OrganizationUserUserDetailsResponseModelListResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: DELETE /api/organizations/{orgId}/users
  /// </summary>
  public async Task<OrganizationUserBulkResponseModelListResponseModel> OrganizationUsersBulkRemoveAsync(string orgId, Apigen.Vaultwarden.Models.OrganizationUserBulkRequestModel organizationUserBulkRequestModel)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId
    };
    string url = "api/organizations/{orgId}/users".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "DELETE", url);
    HttpResponseMessage response = await _httpClient.DeleteAsync(url);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.LogDebugRequestCompleted(_logger, (int)response.StatusCode, "DELETE", url, durationMs);

    string responseContent;
    try
    {
      response.EnsureSuccessStatusCode();
      responseContent = await response.Content.ReadAsStringAsync();
    }
    catch (HttpRequestException ex)
    {
      responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.LogErrorRequestFailed(_logger, (int)response.StatusCode, "DELETE", url, responseContent, ex);
      throw;
    }

    HttpClientLog.LogTraceResponseBody(_logger, url, responseContent);
    OrganizationUserBulkResponseModelListResponseModel? result = JsonSerializer.Deserialize<OrganizationUserBulkResponseModelListResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new OrganizationUserBulkResponseModelListResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/users/{id}/reset-password-details
  /// </summary>
  public async Task<OrganizationUserResetPasswordDetailsResponseModel> OrganizationUsersGetResetPasswordDetailsAsync(string orgId, string id)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId,
      ["id"] = id
    };
    string url = "api/organizations/{orgId}/users/{id}/reset-password-details".BuildUrl(pathParams);

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
    OrganizationUserResetPasswordDetailsResponseModel? result = JsonSerializer.Deserialize<OrganizationUserResetPasswordDetailsResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new OrganizationUserResetPasswordDetailsResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{orgId}/users/invite
  /// </summary>
  public async Task OrganizationUsersInviteAsync(string orgId, Apigen.Vaultwarden.Models.OrganizationUserInviteRequestModel organizationUserInviteRequestModel)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId
    };
    string url = "api/organizations/{orgId}/users/invite".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(organizationUserInviteRequestModel, JsonConfig.Default);
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
  /// Operation: POST /api/organizations/{orgId}/users/reinvite
  /// </summary>
  public async Task<OrganizationUserBulkResponseModelListResponseModel> OrganizationUsersBulkReinviteAsync(string orgId, Apigen.Vaultwarden.Models.OrganizationUserBulkRequestModel organizationUserBulkRequestModel)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId
    };
    string url = "api/organizations/{orgId}/users/reinvite".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(organizationUserBulkRequestModel, JsonConfig.Default);
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
    OrganizationUserBulkResponseModelListResponseModel? result = JsonSerializer.Deserialize<OrganizationUserBulkResponseModelListResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new OrganizationUserBulkResponseModelListResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{orgId}/users/{id}/reinvite
  /// </summary>
  public async Task OrganizationUsersReinviteAsync(string orgId, string id)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId,
      ["id"] = id
    };
    string url = "api/organizations/{orgId}/users/{id}/reinvite".BuildUrl(pathParams);

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


  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{orgId}/users/{organizationUserId}/accept
  /// </summary>
  public async Task OrganizationUsersAcceptAsync(string orgId, string organizationUserId, Apigen.Vaultwarden.Models.OrganizationUserAcceptRequestModel organizationUserAcceptRequestModel)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId,
      ["organizationUserId"] = organizationUserId
    };
    string url = "api/organizations/{orgId}/users/{organizationUserId}/accept".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(organizationUserAcceptRequestModel, JsonConfig.Default);
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
  /// Operation: POST /api/organizations/{orgId}/users/{id}/confirm
  /// </summary>
  public async Task OrganizationUsersConfirmAsync(string orgId, string id, Apigen.Vaultwarden.Models.OrganizationUserConfirmRequestModel organizationUserConfirmRequestModel)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId,
      ["id"] = id
    };
    string url = "api/organizations/{orgId}/users/{id}/confirm".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(organizationUserConfirmRequestModel, JsonConfig.Default);
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
  /// Operation: POST /api/organizations/{orgId}/users/confirm
  /// </summary>
  public async Task<OrganizationUserBulkResponseModelListResponseModel> OrganizationUsersBulkConfirmAsync(string orgId, Apigen.Vaultwarden.Models.OrganizationUserBulkConfirmRequestModel organizationUserBulkConfirmRequestModel)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId
    };
    string url = "api/organizations/{orgId}/users/confirm".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(organizationUserBulkConfirmRequestModel, JsonConfig.Default);
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
    OrganizationUserBulkResponseModelListResponseModel? result = JsonSerializer.Deserialize<OrganizationUserBulkResponseModelListResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new OrganizationUserBulkResponseModelListResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{orgId}/users/public-keys
  /// </summary>
  public async Task<OrganizationUserPublicKeyResponseModelListResponseModel> OrganizationUsersUserPublicKeysAsync(string orgId, Apigen.Vaultwarden.Models.OrganizationUserBulkRequestModel organizationUserBulkRequestModel)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId
    };
    string url = "api/organizations/{orgId}/users/public-keys".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(organizationUserBulkRequestModel, JsonConfig.Default);
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
    OrganizationUserPublicKeyResponseModelListResponseModel? result = JsonSerializer.Deserialize<OrganizationUserPublicKeyResponseModelListResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new OrganizationUserPublicKeyResponseModelListResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: PUT /api/organizations/{orgId}/users/{userId}/reset-password-enrollment
  /// </summary>
  public async Task OrganizationUsersPutResetPasswordEnrollmentAsync(string orgId, string userId, Apigen.Vaultwarden.Models.OrganizationUserResetPasswordEnrollmentRequestModel organizationUserResetPasswordEnrollmentRequestModel)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId,
      ["userId"] = userId
    };
    string url = "api/organizations/{orgId}/users/{userId}/reset-password-enrollment".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "PUT", url);
    string json = JsonSerializer.Serialize(organizationUserResetPasswordEnrollmentRequestModel, JsonConfig.Default);
    HttpClientLog.LogTraceRequestBody(_logger, "PUT", "application/json", json);
    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
    HttpResponseMessage response = await _httpClient.PutAsync(url, content);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.LogDebugRequestCompleted(_logger, (int)response.StatusCode, "PUT", url, durationMs);

    try
    {
      response.EnsureSuccessStatusCode();
    }
    catch (HttpRequestException ex)
    {
      string responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.LogErrorRequestFailed(_logger, (int)response.StatusCode, "PUT", url, responseContent, ex);
      throw;
    }
  }


  /// <summary>
  /// 
  /// Operation: PUT /api/organizations/{orgId}/users/{id}/reset-password
  /// </summary>
  public async Task OrganizationUsersPutResetPasswordAsync(string orgId, string id, Apigen.Vaultwarden.Models.OrganizationUserResetPasswordRequestModel organizationUserResetPasswordRequestModel)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId,
      ["id"] = id
    };
    string url = "api/organizations/{orgId}/users/{id}/reset-password".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "PUT", url);
    string json = JsonSerializer.Serialize(organizationUserResetPasswordRequestModel, JsonConfig.Default);
    HttpClientLog.LogTraceRequestBody(_logger, "PUT", "application/json", json);
    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
    HttpResponseMessage response = await _httpClient.PutAsync(url, content);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.LogDebugRequestCompleted(_logger, (int)response.StatusCode, "PUT", url, durationMs);

    try
    {
      response.EnsureSuccessStatusCode();
    }
    catch (HttpRequestException ex)
    {
      string responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.LogErrorRequestFailed(_logger, (int)response.StatusCode, "PUT", url, responseContent, ex);
      throw;
    }
  }


  /// <summary>
  /// 
  /// Operation: PUT /api/organizations/{orgId}/users/{id}/revoke
  /// </summary>
  public async Task OrganizationUsersRevokeAsync(string orgId, string id)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId,
      ["id"] = id
    };
    string url = "api/organizations/{orgId}/users/{id}/revoke".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "PUT", url);
    HttpResponseMessage response = await _httpClient.PutAsync(url, null);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.LogDebugRequestCompleted(_logger, (int)response.StatusCode, "PUT", url, durationMs);

    try
    {
      response.EnsureSuccessStatusCode();
    }
    catch (HttpRequestException ex)
    {
      string responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.LogErrorRequestFailed(_logger, (int)response.StatusCode, "PUT", url, responseContent, ex);
      throw;
    }
  }


  /// <summary>
  /// 
  /// Operation: PUT /api/organizations/{orgId}/users/revoke
  /// </summary>
  public async Task<OrganizationUserBulkResponseModelListResponseModel> OrganizationUsersBulkRevokeAsync(string orgId, Apigen.Vaultwarden.Models.OrganizationUserBulkRequestModel organizationUserBulkRequestModel)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId
    };
    string url = "api/organizations/{orgId}/users/revoke".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "PUT", url);
    string json = JsonSerializer.Serialize(organizationUserBulkRequestModel, JsonConfig.Default);
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
    OrganizationUserBulkResponseModelListResponseModel? result = JsonSerializer.Deserialize<OrganizationUserBulkResponseModelListResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new OrganizationUserBulkResponseModelListResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: PUT /api/organizations/{orgId}/users/{id}/restore
  /// </summary>
  public async Task OrganizationUsersRestoreAsync(string orgId, string id)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId,
      ["id"] = id
    };
    string url = "api/organizations/{orgId}/users/{id}/restore".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "PUT", url);
    HttpResponseMessage response = await _httpClient.PutAsync(url, null);
    long durationMs = (long)System.Diagnostics.Stopwatch.GetElapsedTime(startTimestamp).TotalMilliseconds;
    HttpClientLog.LogDebugRequestCompleted(_logger, (int)response.StatusCode, "PUT", url, durationMs);

    try
    {
      response.EnsureSuccessStatusCode();
    }
    catch (HttpRequestException ex)
    {
      string responseContent = await response.Content.ReadAsStringAsync();
      HttpClientLog.LogErrorRequestFailed(_logger, (int)response.StatusCode, "PUT", url, responseContent, ex);
      throw;
    }
  }


  /// <summary>
  /// 
  /// Operation: PUT /api/organizations/{orgId}/users/restore
  /// </summary>
  public async Task<OrganizationUserBulkResponseModelListResponseModel> OrganizationUsersBulkRestoreAsync(string orgId, Apigen.Vaultwarden.Models.OrganizationUserBulkRequestModel organizationUserBulkRequestModel)
  {
    Dictionary<string, object> pathParams = new()
    {
      ["orgId"] = orgId
    };
    string url = "api/organizations/{orgId}/users/restore".BuildUrl(pathParams);

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "PUT", url);
    string json = JsonSerializer.Serialize(organizationUserBulkRequestModel, JsonConfig.Default);
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
    OrganizationUserBulkResponseModelListResponseModel? result = JsonSerializer.Deserialize<OrganizationUserBulkResponseModelListResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new OrganizationUserBulkResponseModelListResponseModel();
  }


}
