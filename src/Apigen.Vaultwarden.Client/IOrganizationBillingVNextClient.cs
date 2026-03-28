using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for OrganizationBillingVNext operations
/// </summary>
public interface IOrganizationBillingVNextClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{organizationId}/billing/vnext/warnings
  /// </summary>
  Task OrganizationBillingVNextGetWarningsAsync(string organizationId, OrganizationBillingVNextGetWarningsRequest? request = null);

}
