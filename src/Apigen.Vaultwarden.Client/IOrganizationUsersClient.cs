using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for OrganizationUsers operations
/// </summary>
public partial interface IOrganizationUsersClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/users/{id}
  /// </summary>
  Task<OrganizationUserDetailsResponseModel> GetAsync(string orgId, string id, OrganizationUsersGetRequest? request = null, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: PUT /api/organizations/{orgId}/users/{id}
  /// </summary>
  Task UpdateAsync(string orgId, string id, Apigen.Vaultwarden.Models.OrganizationUserUpdateRequestModel organizationUserUpdateRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{orgId}/users/{id}
  /// </summary>
  Task OrganizationUsersPostPutAsync(string orgId, string id, Apigen.Vaultwarden.Models.OrganizationUserUpdateRequestModel organizationUserUpdateRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: DELETE /api/organizations/{orgId}/users/{id}
  /// </summary>
  Task DeleteAsync(string orgId, string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// Returns a set of basic information about all members of the organization. This is available to all members of the organization to manage collections. For this reason, it contains as little information as possible and no cryptographic keys or other sensitive data.
  /// Operation: GET /api/organizations/{orgId}/users/mini-details
  /// </summary>
  Task<OrganizationUserUserMiniDetailsResponseModelListResponseModel> OrganizationUsersGetMiniDetailsAsync(string orgId, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/users
  /// </summary>
  Task<OrganizationUserUserDetailsResponseModelListResponseModel> OrganizationUsersGetAllAsync(string orgId, OrganizationUsersGetAllRequest? request = null, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: DELETE /api/organizations/{orgId}/users
  /// </summary>
  Task<OrganizationUserBulkResponseModelListResponseModel> OrganizationUsersBulkRemoveAsync(string orgId, Apigen.Vaultwarden.Models.OrganizationUserBulkRequestModel organizationUserBulkRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/users/{id}/reset-password-details
  /// </summary>
  Task<OrganizationUserResetPasswordDetailsResponseModel> OrganizationUsersGetResetPasswordDetailsAsync(string orgId, string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{orgId}/users/invite
  /// </summary>
  Task OrganizationUsersInviteAsync(string orgId, Apigen.Vaultwarden.Models.OrganizationUserInviteRequestModel organizationUserInviteRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{orgId}/users/reinvite
  /// </summary>
  Task<OrganizationUserBulkResponseModelListResponseModel> OrganizationUsersBulkReinviteAsync(string orgId, Apigen.Vaultwarden.Models.OrganizationUserBulkRequestModel organizationUserBulkRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{orgId}/users/{id}/reinvite
  /// </summary>
  Task OrganizationUsersReinviteAsync(string orgId, string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{orgId}/users/{organizationUserId}/accept
  /// </summary>
  Task OrganizationUsersAcceptAsync(string orgId, string organizationUserId, Apigen.Vaultwarden.Models.OrganizationUserAcceptRequestModel organizationUserAcceptRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{orgId}/users/{id}/confirm
  /// </summary>
  Task OrganizationUsersConfirmAsync(string orgId, string id, Apigen.Vaultwarden.Models.OrganizationUserConfirmRequestModel organizationUserConfirmRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{orgId}/users/confirm
  /// </summary>
  Task<OrganizationUserBulkResponseModelListResponseModel> OrganizationUsersBulkConfirmAsync(string orgId, Apigen.Vaultwarden.Models.OrganizationUserBulkConfirmRequestModel organizationUserBulkConfirmRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{orgId}/users/public-keys
  /// </summary>
  Task<OrganizationUserPublicKeyResponseModelListResponseModel> OrganizationUsersUserPublicKeysAsync(string orgId, Apigen.Vaultwarden.Models.OrganizationUserBulkRequestModel organizationUserBulkRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: PUT /api/organizations/{orgId}/users/{userId}/reset-password-enrollment
  /// </summary>
  Task OrganizationUsersPutResetPasswordEnrollmentAsync(string orgId, string userId, Apigen.Vaultwarden.Models.OrganizationUserResetPasswordEnrollmentRequestModel organizationUserResetPasswordEnrollmentRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: PUT /api/organizations/{orgId}/users/{id}/reset-password
  /// </summary>
  Task OrganizationUsersPutResetPasswordAsync(string orgId, string id, Apigen.Vaultwarden.Models.OrganizationUserResetPasswordRequestModel organizationUserResetPasswordRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: PUT /api/organizations/{orgId}/users/{id}/revoke
  /// </summary>
  Task OrganizationUsersRevokeAsync(string orgId, string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: PUT /api/organizations/{orgId}/users/revoke
  /// </summary>
  Task<OrganizationUserBulkResponseModelListResponseModel> OrganizationUsersBulkRevokeAsync(string orgId, Apigen.Vaultwarden.Models.OrganizationUserBulkRequestModel organizationUserBulkRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: PUT /api/organizations/{orgId}/users/{id}/restore
  /// </summary>
  Task OrganizationUsersRestoreAsync(string orgId, string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: PUT /api/organizations/{orgId}/users/restore
  /// </summary>
  Task<OrganizationUserBulkResponseModelListResponseModel> OrganizationUsersBulkRestoreAsync(string orgId, Apigen.Vaultwarden.Models.OrganizationUserBulkRequestModel organizationUserBulkRequestModel, CancellationToken cancellationToken = default);

}
