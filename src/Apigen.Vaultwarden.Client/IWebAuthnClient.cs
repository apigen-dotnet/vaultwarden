using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for WebAuthn operations
/// </summary>
public interface IWebAuthnClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/webauthn
  /// </summary>
  Task<WebAuthnCredentialResponseModelListResponseModel> WebAuthnGetAsync();

}
