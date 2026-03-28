using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for Connect operations
/// </summary>
public interface IConnectClient
{
  /// <summary>
  /// Exchange credentials for an access token (OAuth2 password or client_credentials grant)
  /// Operation: POST /identity/connect/token
  /// </summary>
  Task<TokenResponse> ConnectTokenAsync(Apigen.Vaultwarden.Models.ConnectTokenRequest connectTokenRequest);

}
