using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for ImportCiphers operations
/// </summary>
public interface IImportCiphersClient
{
  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/import
  /// </summary>
  Task ImportCiphersPostImportAsync(Apigen.Vaultwarden.Models.ImportCiphersRequestModel importCiphersRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/import-organization
  /// </summary>
  Task ImportCiphersPostImportOrganizationAsync(Apigen.Vaultwarden.Models.ImportOrganizationCiphersRequestModel importOrganizationCiphersRequestModel, ImportCiphersPostImportOrganizationRequest? request = null);

}
