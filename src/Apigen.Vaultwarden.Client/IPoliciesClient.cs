using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for Policies operations
/// </summary>
public interface IPoliciesClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/policies/{type}
  /// </summary>
  Task<PolicyDetailResponseModel> GetAsync(string orgId, int type);

  /// <summary>
  /// 
  /// Operation: PUT /api/organizations/{orgId}/policies/{type}
  /// </summary>
  Task<PolicyResponseModel> UpdateAsync(string orgId, int type, Apigen.Vaultwarden.Models.PolicyRequestModel policyRequestModel);

  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/policies
  /// </summary>
  Task<PolicyResponseModelListResponseModel> PoliciesGetAllAsync(string orgId);

  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/policies/token
  /// </summary>
  Task<PolicyResponseModelListResponseModel> PoliciesGetByTokenAsync(string orgId, PoliciesGetByTokenRequest? request = null);

  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/policies/master-password
  /// </summary>
  Task<PolicyResponseModel> PoliciesGetMasterPasswordPolicyAsync(string orgId);

  /// <summary>
  /// 
  /// Operation: PUT /api/organizations/{orgId}/policies/{type}/vnext
  /// </summary>
  Task<PolicyResponseModel> PoliciesPutVNextAsync(string orgId, int type, Apigen.Vaultwarden.Models.SavePolicyRequest savePolicyRequest);

}
