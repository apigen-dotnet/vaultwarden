using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for Info operations
/// </summary>
public partial interface IInfoClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/alive
  /// </summary>
  Task<JsonElement> InfoGetAliveAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: GET /api/now
  /// </summary>
  Task<JsonElement> InfoGetNowAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: GET /api/version
  /// </summary>
  Task InfoGetVersionAsync(CancellationToken cancellationToken = default);

}
