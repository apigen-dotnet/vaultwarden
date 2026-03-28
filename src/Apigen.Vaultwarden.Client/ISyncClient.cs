using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for Sync operations
/// </summary>
public interface ISyncClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/sync
  /// </summary>
  Task<SyncResponseModel> SyncGetAsync(SyncGetRequest? request = null);

}
