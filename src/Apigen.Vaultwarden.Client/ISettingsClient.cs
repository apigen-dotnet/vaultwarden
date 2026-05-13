using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for Settings operations
/// </summary>
public partial interface ISettingsClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/settings/domains
  /// </summary>
  Task<DomainsResponseModel> SettingsGetDomainsAsync(SettingsGetDomainsRequest? request = null, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: PUT /api/settings/domains
  /// </summary>
  Task<DomainsResponseModel> SettingsPutDomainsAsync(Apigen.Vaultwarden.Models.UpdateDomainsRequestModel updateDomainsRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/settings/domains
  /// </summary>
  Task<DomainsResponseModel> SettingsPostDomainsAsync(Apigen.Vaultwarden.Models.UpdateDomainsRequestModel updateDomainsRequestModel, CancellationToken cancellationToken = default);

}
