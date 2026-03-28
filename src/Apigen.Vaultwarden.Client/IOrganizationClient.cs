using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for Organization operations
/// </summary>
public interface IOrganizationClient
{
  /// <summary>
  /// Import members and groups.
  /// Operation: POST /public/organization/import
  /// </summary>
  Task<OkResult> OrganizationImportAsync(Apigen.Vaultwarden.Models.OrganizationImportRequestModel organizationImportRequestModel);

}
