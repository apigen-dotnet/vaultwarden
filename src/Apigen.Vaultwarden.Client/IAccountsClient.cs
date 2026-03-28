using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for Accounts operations
/// </summary>
public interface IAccountsClient
{
  /// <summary>
  /// 
  /// Operation: POST /identity/accounts/register/send-verification-email
  /// </summary>
  Task AccountsPostRegisterSendVerificationEmailAsync(Apigen.Vaultwarden.Models.RegisterSendVerificationEmailRequestModel registerSendVerificationEmailRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /identity/accounts/register/finish
  /// </summary>
  Task<RegisterFinishResponseModel> AccountsPostRegisterFinishAsync(Apigen.Vaultwarden.Models.RegisterFinishRequestModel registerFinishRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /identity/accounts/prelogin
  /// </summary>
  Task<PasswordPreloginResponseModel> AccountsPostPreloginAsync(Apigen.Vaultwarden.Models.PasswordPreloginRequestModel passwordPreloginRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/password-hint
  /// </summary>
  Task AccountsPostPasswordHintAsync(Apigen.Vaultwarden.Models.PasswordHintRequestModel passwordHintRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/email-token
  /// </summary>
  Task AccountsPostEmailTokenAsync(Apigen.Vaultwarden.Models.EmailTokenRequestModel emailTokenRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/email
  /// </summary>
  Task AccountsPostEmailAsync(Apigen.Vaultwarden.Models.EmailRequestModel emailRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/verify-email
  /// </summary>
  Task AccountsPostVerifyEmailAsync();

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/verify-email-token
  /// </summary>
  Task AccountsPostVerifyEmailTokenAsync(Apigen.Vaultwarden.Models.VerifyEmailRequestModel verifyEmailRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/password
  /// </summary>
  Task AccountsPostPasswordAsync(Apigen.Vaultwarden.Models.PasswordRequestModel passwordRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/set-password
  /// </summary>
  Task AccountsPostSetPasswordAsync(Apigen.Vaultwarden.Models.SetPasswordRequestModel setPasswordRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/verify-password
  /// </summary>
  Task<MasterPasswordPolicyResponseModel> AccountsPostVerifyPasswordAsync(Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/kdf
  /// </summary>
  Task AccountsPostKdfAsync(Apigen.Vaultwarden.Models.PasswordRequestModel passwordRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/security-stamp
  /// </summary>
  Task AccountsPostSecurityStampAsync(Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel);

  /// <summary>
  /// 
  /// Operation: GET /api/accounts/profile
  /// </summary>
  Task<ProfileResponseModel> AccountsGetProfileAsync();

  /// <summary>
  /// 
  /// Operation: PUT /api/accounts/profile
  /// </summary>
  Task<ProfileResponseModel> AccountsPutProfileAsync(Apigen.Vaultwarden.Models.UpdateProfileRequestModel updateProfileRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/profile
  /// </summary>
  Task<ProfileResponseModel> AccountsPostProfileAsync(Apigen.Vaultwarden.Models.UpdateProfileRequestModel updateProfileRequestModel);

  /// <summary>
  /// 
  /// Operation: PUT /api/accounts/avatar
  /// </summary>
  Task<ProfileResponseModel> AccountsPutAvatarAsync(Apigen.Vaultwarden.Models.UpdateAvatarRequestModel updateAvatarRequestModel);

  /// <summary>
  /// 
  /// Operation: GET /api/accounts/revision-date
  /// </summary>
  Task<JsonElement> AccountsGetAccountRevisionDateAsync();

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/keys
  /// </summary>
  Task<KeysResponseModel> AccountsPostKeysAsync(Apigen.Vaultwarden.Models.KeysRequestModel keysRequestModel);

  /// <summary>
  /// 
  /// Operation: DELETE /api/accounts
  /// </summary>
  Task AccountsDeleteAsync(Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/delete
  /// </summary>
  Task AccountsPostDeleteAsync(Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/delete-recover
  /// </summary>
  Task AccountsPostDeleteRecoverAsync(Apigen.Vaultwarden.Models.DeleteRecoverRequestModel deleteRecoverRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/delete-recover-token
  /// </summary>
  Task AccountsPostDeleteRecoverTokenAsync(Apigen.Vaultwarden.Models.VerifyDeleteRecoverRequestModel verifyDeleteRecoverRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/api-key
  /// </summary>
  Task<ApiKeyResponseModel> AccountsApiKeyAsync(Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/rotate-api-key
  /// </summary>
  Task<ApiKeyResponseModel> AccountsRotateApiKeyAsync(Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/request-otp
  /// </summary>
  Task AccountsPostRequestOtpAsync();

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/verify-otp
  /// </summary>
  Task AccountsVerifyOtpAsync(Apigen.Vaultwarden.Models.VerifyOtpRequestModel verifyOtpRequestModel);

}
