using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for Policies operations
/// </summary>
public partial interface IPoliciesClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/policies/{type}
  /// </summary>
  Task<PolicyDetailResponseModel> GetAsync(string orgId, int type, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: PUT /api/organizations/{orgId}/policies/{type}
  /// </summary>
  Task<PolicyResponseModel> UpdateAsync(string orgId, int type, Apigen.Vaultwarden.Models.PolicyRequestModel policyRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/policies
  /// </summary>
  Task<PolicyResponseModelListResponseModel> PoliciesGetAllAsync(string orgId, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/policies/token
  /// </summary>
  Task<PolicyResponseModelListResponseModel> PoliciesGetByTokenAsync(string orgId, PoliciesGetByTokenRequest? request = null, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/policies/master-password
  /// </summary>
  Task<PolicyResponseModel> PoliciesGetMasterPasswordPolicyAsync(string orgId, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: PUT /api/organizations/{orgId}/policies/{type}/vnext
  /// </summary>
  Task<PolicyResponseModel> PoliciesPutVNextAsync(string orgId, int type, Apigen.Vaultwarden.Models.SavePolicyRequest savePolicyRequest, CancellationToken cancellationToken = default);

}
