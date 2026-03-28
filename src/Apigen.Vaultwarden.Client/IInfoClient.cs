using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for Info operations
/// </summary>
public interface IInfoClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/alive
  /// </summary>
  Task<JsonElement> InfoGetAliveAsync();

  /// <summary>
  /// 
  /// Operation: GET /api/now
  /// </summary>
  Task<JsonElement> InfoGetNowAsync();

  /// <summary>
  /// 
  /// Operation: GET /api/version
  /// </summary>
  Task InfoGetVersionAsync();

}
