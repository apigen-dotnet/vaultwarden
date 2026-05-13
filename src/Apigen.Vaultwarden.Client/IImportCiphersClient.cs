using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for ImportCiphers operations
/// </summary>
public partial interface IImportCiphersClient
{
  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/import
  /// </summary>
  Task ImportCiphersPostImportAsync(Apigen.Vaultwarden.Models.ImportCiphersRequestModel importCiphersRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/import-organization
  /// </summary>
  Task ImportCiphersPostImportOrganizationAsync(Apigen.Vaultwarden.Models.ImportOrganizationCiphersRequestModel importOrganizationCiphersRequestModel, ImportCiphersPostImportOrganizationRequest? request = null, CancellationToken cancellationToken = default);

}
