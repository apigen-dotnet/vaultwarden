using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for Users operations
/// </summary>
public interface IUsersClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/users/{id}/public-key
  /// </summary>
  Task<UserKeyResponseModel> UsersGetPublicKeyAsync(string id);

}
