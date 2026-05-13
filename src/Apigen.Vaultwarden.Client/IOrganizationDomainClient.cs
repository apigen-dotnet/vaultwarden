using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for OrganizationDomain operations
/// </summary>
public partial interface IOrganizationDomainClient
{
  /// <summary>
  /// 
  /// Operation: POST /api/organizations/domain/sso/verified
  /// </summary>
  Task<VerifiedOrganizationDomainSsoDetailsResponseModel> OrganizationDomainGetVerifiedOrgDomainSsoDetailsAsync(Apigen.Vaultwarden.Models.OrganizationDomainSsoDetailsRequestModel organizationDomainSsoDetailsRequestModel, CancellationToken cancellationToken = default);

}
