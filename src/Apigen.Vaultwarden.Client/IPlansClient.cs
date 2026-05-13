using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for Plans operations
/// </summary>
public partial interface IPlansClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/plans
  /// </summary>
  Task<PlanResponseModelListResponseModel> PlansGetAsync(CancellationToken cancellationToken = default);

}
