using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for TwoFactor operations
/// </summary>
public partial interface ITwoFactorClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/two-factor
  /// </summary>
  Task<TwoFactorProviderResponseModelListResponseModel> TwoFactorGetAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/two-factor/get-authenticator
  /// </summary>
  Task<TwoFactorAuthenticatorResponseModel> TwoFactorGetAuthenticatorAsync(Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: PUT /api/two-factor/authenticator
  /// </summary>
  Task<TwoFactorAuthenticatorResponseModel> TwoFactorPutAuthenticatorAsync(Apigen.Vaultwarden.Models.UpdateTwoFactorAuthenticatorRequestModel updateTwoFactorAuthenticatorRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/two-factor/authenticator
  /// </summary>
  Task<TwoFactorAuthenticatorResponseModel> TwoFactorPostAuthenticatorAsync(Apigen.Vaultwarden.Models.UpdateTwoFactorAuthenticatorRequestModel updateTwoFactorAuthenticatorRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: DELETE /api/two-factor/authenticator
  /// </summary>
  Task<TwoFactorProviderResponseModel> TwoFactorDisableAuthenticatorAsync(Apigen.Vaultwarden.Models.TwoFactorAuthenticatorDisableRequestModel twoFactorAuthenticatorDisableRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/two-factor/get-yubikey
  /// </summary>
  Task<TwoFactorYubiKeyResponseModel> TwoFactorGetYubiKeyAsync(Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: PUT /api/two-factor/yubikey
  /// </summary>
  Task<TwoFactorYubiKeyResponseModel> TwoFactorPutYubiKeyAsync(Apigen.Vaultwarden.Models.UpdateTwoFactorYubicoOtpRequestModel updateTwoFactorYubicoOtpRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/two-factor/yubikey
  /// </summary>
  Task<TwoFactorYubiKeyResponseModel> TwoFactorPostYubiKeyAsync(Apigen.Vaultwarden.Models.UpdateTwoFactorYubicoOtpRequestModel updateTwoFactorYubicoOtpRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/two-factor/get-duo
  /// </summary>
  Task<TwoFactorDuoResponseModel> TwoFactorGetDuoAsync(Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: PUT /api/two-factor/duo
  /// </summary>
  Task<TwoFactorDuoResponseModel> TwoFactorPutDuoAsync(Apigen.Vaultwarden.Models.UpdateTwoFactorDuoRequestModel updateTwoFactorDuoRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/two-factor/duo
  /// </summary>
  Task<TwoFactorDuoResponseModel> TwoFactorPostDuoAsync(Apigen.Vaultwarden.Models.UpdateTwoFactorDuoRequestModel updateTwoFactorDuoRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/two-factor/get-webauthn
  /// </summary>
  Task<TwoFactorWebAuthnResponseModel> TwoFactorGetWebAuthnAsync(Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: PUT /api/two-factor/webauthn
  /// </summary>
  Task<TwoFactorWebAuthnResponseModel> TwoFactorPutWebAuthnAsync(Apigen.Vaultwarden.Models.TwoFactorWebAuthnRequestModel twoFactorWebAuthnRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/two-factor/webauthn
  /// </summary>
  Task<TwoFactorWebAuthnResponseModel> TwoFactorPostWebAuthnAsync(Apigen.Vaultwarden.Models.TwoFactorWebAuthnRequestModel twoFactorWebAuthnRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: DELETE /api/two-factor/webauthn
  /// </summary>
  Task<TwoFactorWebAuthnResponseModel> TwoFactorDeleteWebAuthnAsync(Apigen.Vaultwarden.Models.TwoFactorWebAuthnDeleteRequestModel twoFactorWebAuthnDeleteRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/two-factor/get-email
  /// </summary>
  Task<TwoFactorEmailResponseModel> TwoFactorGetEmailAsync(Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// This endpoint is only used to set-up email two factor authentication.
  /// Operation: POST /api/two-factor/send-email
  /// </summary>
  Task TwoFactorSendEmailAsync(Apigen.Vaultwarden.Models.TwoFactorEmailRequestModel twoFactorEmailRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/two-factor/send-email-login
  /// </summary>
  Task TwoFactorSendEmailLoginAsync(Apigen.Vaultwarden.Models.TwoFactorEmailRequestModel twoFactorEmailRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: PUT /api/two-factor/email
  /// </summary>
  Task<TwoFactorEmailResponseModel> TwoFactorPutEmailAsync(Apigen.Vaultwarden.Models.UpdateTwoFactorEmailRequestModel updateTwoFactorEmailRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: PUT /api/two-factor/disable
  /// </summary>
  Task<TwoFactorProviderResponseModel> TwoFactorPutDisableAsync(Apigen.Vaultwarden.Models.TwoFactorProviderRequestModel twoFactorProviderRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/two-factor/disable
  /// </summary>
  Task<TwoFactorProviderResponseModel> TwoFactorPostDisableAsync(Apigen.Vaultwarden.Models.TwoFactorProviderRequestModel twoFactorProviderRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/two-factor/get-recover
  /// </summary>
  Task<TwoFactorRecoverResponseModel> TwoFactorGetRecoverAsync(Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: GET /api/two-factor/get-device-verification-settings
  /// </summary>
  Task<DeviceVerificationResponseModel> TwoFactorGetDeviceVerificationSettingsAsync(CancellationToken cancellationToken = default);

}
