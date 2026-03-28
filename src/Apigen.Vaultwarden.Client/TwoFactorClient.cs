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
/// Client for TwoFactor operations
/// </summary>
public class TwoFactorClient
{
  private readonly HttpClient _httpClient;
  private readonly ILogger? _logger;

  internal TwoFactorClient(HttpClient httpClient, ILogger? logger = null)
  {
    _httpClient = httpClient;
    _logger = logger;
  }

  /// <summary>
  /// 
  /// Operation: GET /api/two-factor
  /// </summary>
  public async Task<TwoFactorProviderResponseModelListResponseModel> TwoFactorGetAsync()
  {
    string url = "api/two-factor";

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
    TwoFactorProviderResponseModelListResponseModel? result = JsonSerializer.Deserialize<TwoFactorProviderResponseModelListResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new TwoFactorProviderResponseModelListResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: POST /api/two-factor/get-authenticator
  /// </summary>
  public async Task<TwoFactorAuthenticatorResponseModel> TwoFactorGetAuthenticatorAsync(Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel)
  {
    string url = "api/two-factor/get-authenticator";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(secretVerificationRequestModel, JsonConfig.Default);
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
    TwoFactorAuthenticatorResponseModel? result = JsonSerializer.Deserialize<TwoFactorAuthenticatorResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new TwoFactorAuthenticatorResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: PUT /api/two-factor/authenticator
  /// </summary>
  public async Task<TwoFactorAuthenticatorResponseModel> TwoFactorPutAuthenticatorAsync(Apigen.Vaultwarden.Models.UpdateTwoFactorAuthenticatorRequestModel updateTwoFactorAuthenticatorRequestModel)
  {
    string url = "api/two-factor/authenticator";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "PUT", url);
    string json = JsonSerializer.Serialize(updateTwoFactorAuthenticatorRequestModel, JsonConfig.Default);
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
    TwoFactorAuthenticatorResponseModel? result = JsonSerializer.Deserialize<TwoFactorAuthenticatorResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new TwoFactorAuthenticatorResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: POST /api/two-factor/authenticator
  /// </summary>
  public async Task<TwoFactorAuthenticatorResponseModel> TwoFactorPostAuthenticatorAsync(Apigen.Vaultwarden.Models.UpdateTwoFactorAuthenticatorRequestModel updateTwoFactorAuthenticatorRequestModel)
  {
    string url = "api/two-factor/authenticator";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(updateTwoFactorAuthenticatorRequestModel, JsonConfig.Default);
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
    TwoFactorAuthenticatorResponseModel? result = JsonSerializer.Deserialize<TwoFactorAuthenticatorResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new TwoFactorAuthenticatorResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: DELETE /api/two-factor/authenticator
  /// </summary>
  public async Task<TwoFactorProviderResponseModel> TwoFactorDisableAuthenticatorAsync(Apigen.Vaultwarden.Models.TwoFactorAuthenticatorDisableRequestModel twoFactorAuthenticatorDisableRequestModel)
  {
    string url = "api/two-factor/authenticator";

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
    TwoFactorProviderResponseModel? result = JsonSerializer.Deserialize<TwoFactorProviderResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new TwoFactorProviderResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: POST /api/two-factor/get-yubikey
  /// </summary>
  public async Task<TwoFactorYubiKeyResponseModel> TwoFactorGetYubiKeyAsync(Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel)
  {
    string url = "api/two-factor/get-yubikey";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(secretVerificationRequestModel, JsonConfig.Default);
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
    TwoFactorYubiKeyResponseModel? result = JsonSerializer.Deserialize<TwoFactorYubiKeyResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new TwoFactorYubiKeyResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: PUT /api/two-factor/yubikey
  /// </summary>
  public async Task<TwoFactorYubiKeyResponseModel> TwoFactorPutYubiKeyAsync(Apigen.Vaultwarden.Models.UpdateTwoFactorYubicoOtpRequestModel updateTwoFactorYubicoOtpRequestModel)
  {
    string url = "api/two-factor/yubikey";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "PUT", url);
    string json = JsonSerializer.Serialize(updateTwoFactorYubicoOtpRequestModel, JsonConfig.Default);
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
    TwoFactorYubiKeyResponseModel? result = JsonSerializer.Deserialize<TwoFactorYubiKeyResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new TwoFactorYubiKeyResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: POST /api/two-factor/yubikey
  /// </summary>
  public async Task<TwoFactorYubiKeyResponseModel> TwoFactorPostYubiKeyAsync(Apigen.Vaultwarden.Models.UpdateTwoFactorYubicoOtpRequestModel updateTwoFactorYubicoOtpRequestModel)
  {
    string url = "api/two-factor/yubikey";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(updateTwoFactorYubicoOtpRequestModel, JsonConfig.Default);
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
    TwoFactorYubiKeyResponseModel? result = JsonSerializer.Deserialize<TwoFactorYubiKeyResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new TwoFactorYubiKeyResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: POST /api/two-factor/get-duo
  /// </summary>
  public async Task<TwoFactorDuoResponseModel> TwoFactorGetDuoAsync(Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel)
  {
    string url = "api/two-factor/get-duo";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(secretVerificationRequestModel, JsonConfig.Default);
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
    TwoFactorDuoResponseModel? result = JsonSerializer.Deserialize<TwoFactorDuoResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new TwoFactorDuoResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: PUT /api/two-factor/duo
  /// </summary>
  public async Task<TwoFactorDuoResponseModel> TwoFactorPutDuoAsync(Apigen.Vaultwarden.Models.UpdateTwoFactorDuoRequestModel updateTwoFactorDuoRequestModel)
  {
    string url = "api/two-factor/duo";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "PUT", url);
    string json = JsonSerializer.Serialize(updateTwoFactorDuoRequestModel, JsonConfig.Default);
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
    TwoFactorDuoResponseModel? result = JsonSerializer.Deserialize<TwoFactorDuoResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new TwoFactorDuoResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: POST /api/two-factor/duo
  /// </summary>
  public async Task<TwoFactorDuoResponseModel> TwoFactorPostDuoAsync(Apigen.Vaultwarden.Models.UpdateTwoFactorDuoRequestModel updateTwoFactorDuoRequestModel)
  {
    string url = "api/two-factor/duo";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(updateTwoFactorDuoRequestModel, JsonConfig.Default);
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
    TwoFactorDuoResponseModel? result = JsonSerializer.Deserialize<TwoFactorDuoResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new TwoFactorDuoResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: POST /api/two-factor/get-webauthn
  /// </summary>
  public async Task<TwoFactorWebAuthnResponseModel> TwoFactorGetWebAuthnAsync(Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel)
  {
    string url = "api/two-factor/get-webauthn";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(secretVerificationRequestModel, JsonConfig.Default);
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
    TwoFactorWebAuthnResponseModel? result = JsonSerializer.Deserialize<TwoFactorWebAuthnResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new TwoFactorWebAuthnResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: PUT /api/two-factor/webauthn
  /// </summary>
  public async Task<TwoFactorWebAuthnResponseModel> TwoFactorPutWebAuthnAsync(Apigen.Vaultwarden.Models.TwoFactorWebAuthnRequestModel twoFactorWebAuthnRequestModel)
  {
    string url = "api/two-factor/webauthn";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "PUT", url);
    string json = JsonSerializer.Serialize(twoFactorWebAuthnRequestModel, JsonConfig.Default);
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
    TwoFactorWebAuthnResponseModel? result = JsonSerializer.Deserialize<TwoFactorWebAuthnResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new TwoFactorWebAuthnResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: POST /api/two-factor/webauthn
  /// </summary>
  public async Task<TwoFactorWebAuthnResponseModel> TwoFactorPostWebAuthnAsync(Apigen.Vaultwarden.Models.TwoFactorWebAuthnRequestModel twoFactorWebAuthnRequestModel)
  {
    string url = "api/two-factor/webauthn";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(twoFactorWebAuthnRequestModel, JsonConfig.Default);
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
    TwoFactorWebAuthnResponseModel? result = JsonSerializer.Deserialize<TwoFactorWebAuthnResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new TwoFactorWebAuthnResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: DELETE /api/two-factor/webauthn
  /// </summary>
  public async Task<TwoFactorWebAuthnResponseModel> TwoFactorDeleteWebAuthnAsync(Apigen.Vaultwarden.Models.TwoFactorWebAuthnDeleteRequestModel twoFactorWebAuthnDeleteRequestModel)
  {
    string url = "api/two-factor/webauthn";

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
    TwoFactorWebAuthnResponseModel? result = JsonSerializer.Deserialize<TwoFactorWebAuthnResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new TwoFactorWebAuthnResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: POST /api/two-factor/get-email
  /// </summary>
  public async Task<TwoFactorEmailResponseModel> TwoFactorGetEmailAsync(Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel)
  {
    string url = "api/two-factor/get-email";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(secretVerificationRequestModel, JsonConfig.Default);
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
    TwoFactorEmailResponseModel? result = JsonSerializer.Deserialize<TwoFactorEmailResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new TwoFactorEmailResponseModel();
  }


  /// <summary>
  /// This endpoint is only used to set-up email two factor authentication.
  /// Operation: POST /api/two-factor/send-email
  /// </summary>
  public async Task TwoFactorSendEmailAsync(Apigen.Vaultwarden.Models.TwoFactorEmailRequestModel twoFactorEmailRequestModel)
  {
    string url = "api/two-factor/send-email";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(twoFactorEmailRequestModel, JsonConfig.Default);
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
  /// Operation: POST /api/two-factor/send-email-login
  /// </summary>
  public async Task TwoFactorSendEmailLoginAsync(Apigen.Vaultwarden.Models.TwoFactorEmailRequestModel twoFactorEmailRequestModel)
  {
    string url = "api/two-factor/send-email-login";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(twoFactorEmailRequestModel, JsonConfig.Default);
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
  /// Operation: PUT /api/two-factor/email
  /// </summary>
  public async Task<TwoFactorEmailResponseModel> TwoFactorPutEmailAsync(Apigen.Vaultwarden.Models.UpdateTwoFactorEmailRequestModel updateTwoFactorEmailRequestModel)
  {
    string url = "api/two-factor/email";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "PUT", url);
    string json = JsonSerializer.Serialize(updateTwoFactorEmailRequestModel, JsonConfig.Default);
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
    TwoFactorEmailResponseModel? result = JsonSerializer.Deserialize<TwoFactorEmailResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new TwoFactorEmailResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: PUT /api/two-factor/disable
  /// </summary>
  public async Task<TwoFactorProviderResponseModel> TwoFactorPutDisableAsync(Apigen.Vaultwarden.Models.TwoFactorProviderRequestModel twoFactorProviderRequestModel)
  {
    string url = "api/two-factor/disable";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "PUT", url);
    string json = JsonSerializer.Serialize(twoFactorProviderRequestModel, JsonConfig.Default);
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
    TwoFactorProviderResponseModel? result = JsonSerializer.Deserialize<TwoFactorProviderResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new TwoFactorProviderResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: POST /api/two-factor/disable
  /// </summary>
  public async Task<TwoFactorProviderResponseModel> TwoFactorPostDisableAsync(Apigen.Vaultwarden.Models.TwoFactorProviderRequestModel twoFactorProviderRequestModel)
  {
    string url = "api/two-factor/disable";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(twoFactorProviderRequestModel, JsonConfig.Default);
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
    TwoFactorProviderResponseModel? result = JsonSerializer.Deserialize<TwoFactorProviderResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new TwoFactorProviderResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: POST /api/two-factor/get-recover
  /// </summary>
  public async Task<TwoFactorRecoverResponseModel> TwoFactorGetRecoverAsync(Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel)
  {
    string url = "api/two-factor/get-recover";

    long startTimestamp = System.Diagnostics.Stopwatch.GetTimestamp();
    HttpClientLog.LogDebugRequestStarted(_logger, "POST", url);
    string json = JsonSerializer.Serialize(secretVerificationRequestModel, JsonConfig.Default);
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
    TwoFactorRecoverResponseModel? result = JsonSerializer.Deserialize<TwoFactorRecoverResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new TwoFactorRecoverResponseModel();
  }


  /// <summary>
  /// 
  /// Operation: GET /api/two-factor/get-device-verification-settings
  /// </summary>
  public async Task<DeviceVerificationResponseModel> TwoFactorGetDeviceVerificationSettingsAsync()
  {
    string url = "api/two-factor/get-device-verification-settings";

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
    DeviceVerificationResponseModel? result = JsonSerializer.Deserialize<DeviceVerificationResponseModel>(responseContent, JsonConfig.Default);
    return result ?? new DeviceVerificationResponseModel();
  }


}
