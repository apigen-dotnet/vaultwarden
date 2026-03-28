using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for SecurityTask operations
/// </summary>
public interface ISecurityTaskClient
{
  /// <summary>
  /// Retrieves security tasks for the current user.
  /// Operation: GET /api/tasks
  /// </summary>
  Task<SecurityTasksResponseModelListResponseModel> SecurityTaskGetAsync(SecurityTaskGetRequest? request = null);

}
