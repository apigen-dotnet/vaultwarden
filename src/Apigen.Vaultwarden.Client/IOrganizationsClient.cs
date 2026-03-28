using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for Organizations operations
/// </summary>
public interface IOrganizationsClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{id}
  /// </summary>
  Task<OrganizationResponseModel> GetAsync(string id);

  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{id}
  /// </summary>
  Task OrganizationsPostPutAsync(string id, Apigen.Vaultwarden.Models.OrganizationUpdateRequestModel organizationUpdateRequestModel);

  /// <summary>
  /// 
  /// Operation: DELETE /api/organizations/{id}
  /// </summary>
  Task DeleteAsync(string id, Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel);

  /// <summary>
  /// 
  /// Operation: PUT /api/organizations/{id}
  /// </summary>
  Task UpdateAsync(string id, Apigen.Vaultwarden.Models.OrganizationUpdateRequestModel organizationUpdateRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/organizations
  /// </summary>
  Task<OrganizationResponseModel> OrganizationsPostAsync(Apigen.Vaultwarden.Models.OrganizationCreateRequestModel organizationCreateRequestModel);

  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{identifier}/auto-enroll-status
  /// </summary>
  Task<OrganizationAutoEnrollStatusResponseModel> OrganizationsGetAutoEnrollStatusAsync(string identifier);

  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{id}/leave
  /// </summary>
  Task OrganizationsLeaveAsync(string id);

  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{id}/delete
  /// </summary>
  Task OrganizationsPostDeleteAsync(string id, Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{id}/api-key
  /// </summary>
  Task<ApiKeyResponseModel> OrganizationsApiKeyAsync(string id, Apigen.Vaultwarden.Models.OrganizationApiKeyRequestModel organizationApiKeyRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{id}/rotate-api-key
  /// </summary>
  Task<ApiKeyResponseModel> OrganizationsRotateApiKeyAsync(string id, Apigen.Vaultwarden.Models.OrganizationApiKeyRequestModel organizationApiKeyRequestModel);

  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{id}/public-key
  /// </summary>
  Task<OrganizationPublicKeyResponseModel> OrganizationsGetPublicKeyAsync(string id);

  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{id}/keys
  /// </summary>
  Task<OrganizationPublicKeyResponseModel> OrganizationsGetKeysAsync(string id);

  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{id}/keys
  /// </summary>
  Task<OrganizationKeysResponseModel> OrganizationsPostKeysAsync(string id, Apigen.Vaultwarden.Models.OrganizationKeysRequestModel organizationKeysRequestModel);

}
