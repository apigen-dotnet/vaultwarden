using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for OrganizationExport operations
/// </summary>
public partial interface IOrganizationExportClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{organizationId}/export
  /// </summary>
  Task OrganizationExportExportAsync(string organizationId, CancellationToken cancellationToken = default);

}
