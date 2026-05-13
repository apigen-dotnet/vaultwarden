using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for Accounts operations
/// </summary>
public partial interface IAccountsClient
{
  /// <summary>
  /// 
  /// Operation: POST /identity/accounts/register/send-verification-email
  /// </summary>
  Task AccountsPostRegisterSendVerificationEmailAsync(Apigen.Vaultwarden.Models.RegisterSendVerificationEmailRequestModel registerSendVerificationEmailRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /identity/accounts/register/finish
  /// </summary>
  Task<RegisterFinishResponseModel> AccountsPostRegisterFinishAsync(Apigen.Vaultwarden.Models.RegisterFinishRequestModel registerFinishRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /identity/accounts/prelogin
  /// </summary>
  Task<PasswordPreloginResponseModel> AccountsPostPreloginAsync(Apigen.Vaultwarden.Models.PasswordPreloginRequestModel passwordPreloginRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/password-hint
  /// </summary>
  Task AccountsPostPasswordHintAsync(Apigen.Vaultwarden.Models.PasswordHintRequestModel passwordHintRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/email-token
  /// </summary>
  Task AccountsPostEmailTokenAsync(Apigen.Vaultwarden.Models.EmailTokenRequestModel emailTokenRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/email
  /// </summary>
  Task AccountsPostEmailAsync(Apigen.Vaultwarden.Models.EmailRequestModel emailRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/verify-email
  /// </summary>
  Task AccountsPostVerifyEmailAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/verify-email-token
  /// </summary>
  Task AccountsPostVerifyEmailTokenAsync(Apigen.Vaultwarden.Models.VerifyEmailRequestModel verifyEmailRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/password
  /// </summary>
  Task AccountsPostPasswordAsync(Apigen.Vaultwarden.Models.PasswordRequestModel passwordRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/set-password
  /// </summary>
  Task AccountsPostSetPasswordAsync(Apigen.Vaultwarden.Models.SetPasswordRequestModel setPasswordRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/verify-password
  /// </summary>
  Task<MasterPasswordPolicyResponseModel> AccountsPostVerifyPasswordAsync(Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/kdf
  /// </summary>
  Task AccountsPostKdfAsync(Apigen.Vaultwarden.Models.PasswordRequestModel passwordRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/security-stamp
  /// </summary>
  Task AccountsPostSecurityStampAsync(Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: GET /api/accounts/profile
  /// </summary>
  Task<ProfileResponseModel> AccountsGetProfileAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: PUT /api/accounts/profile
  /// </summary>
  Task<ProfileResponseModel> AccountsPutProfileAsync(Apigen.Vaultwarden.Models.UpdateProfileRequestModel updateProfileRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/profile
  /// </summary>
  Task<ProfileResponseModel> AccountsPostProfileAsync(Apigen.Vaultwarden.Models.UpdateProfileRequestModel updateProfileRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: PUT /api/accounts/avatar
  /// </summary>
  Task<ProfileResponseModel> AccountsPutAvatarAsync(Apigen.Vaultwarden.Models.UpdateAvatarRequestModel updateAvatarRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: GET /api/accounts/revision-date
  /// </summary>
  Task<JsonElement> AccountsGetAccountRevisionDateAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/keys
  /// </summary>
  Task<KeysResponseModel> AccountsPostKeysAsync(Apigen.Vaultwarden.Models.KeysRequestModel keysRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: DELETE /api/accounts
  /// </summary>
  Task AccountsDeleteAsync(Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/delete
  /// </summary>
  Task AccountsPostDeleteAsync(Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/delete-recover
  /// </summary>
  Task AccountsPostDeleteRecoverAsync(Apigen.Vaultwarden.Models.DeleteRecoverRequestModel deleteRecoverRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/delete-recover-token
  /// </summary>
  Task AccountsPostDeleteRecoverTokenAsync(Apigen.Vaultwarden.Models.VerifyDeleteRecoverRequestModel verifyDeleteRecoverRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/api-key
  /// </summary>
  Task<ApiKeyResponseModel> AccountsApiKeyAsync(Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/rotate-api-key
  /// </summary>
  Task<ApiKeyResponseModel> AccountsRotateApiKeyAsync(Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/request-otp
  /// </summary>
  Task AccountsPostRequestOtpAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/accounts/verify-otp
  /// </summary>
  Task AccountsVerifyOtpAsync(Apigen.Vaultwarden.Models.VerifyOtpRequestModel verifyOtpRequestModel, CancellationToken cancellationToken = default);

}
