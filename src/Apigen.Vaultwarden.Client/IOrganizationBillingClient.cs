using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for OrganizationBilling operations
/// </summary>
public interface IOrganizationBillingClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{organizationId}/billing/metadata
  /// </summary>
  Task OrganizationBillingGetMetadataAsync(string organizationId);

}
