using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for Groups operations
/// </summary>
public interface IGroupsClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/groups/{id}
  /// </summary>
  Task<GroupResponseModel> GetAsync(string orgId, string id);

  /// <summary>
  /// 
  /// Operation: PUT /api/organizations/{orgId}/groups/{id}
  /// </summary>
  Task<GroupResponseModel> UpdateAsync(string orgId, string id, Apigen.Vaultwarden.Models.GroupRequestModel groupRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{orgId}/groups/{id}
  /// </summary>
  Task<GroupResponseModel> GroupsPostPutAsync(string orgId, string id, Apigen.Vaultwarden.Models.GroupRequestModel groupRequestModel);

  /// <summary>
  /// 
  /// Operation: DELETE /api/organizations/{orgId}/groups/{id}
  /// </summary>
  Task DeleteAsync(string orgId, string id);

  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/groups/{id}/details
  /// </summary>
  Task<GroupDetailsResponseModel> GroupsGetDetailsAsync(string orgId, string id);

  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/groups
  /// </summary>
  Task<GroupResponseModelListResponseModel> GroupsGetOrganizationGroupsAsync(string orgId);

  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{orgId}/groups
  /// </summary>
  Task<GroupResponseModel> GroupsPostAsync(string orgId, Apigen.Vaultwarden.Models.GroupRequestModel groupRequestModel);

  /// <summary>
  /// 
  /// Operation: DELETE /api/organizations/{orgId}/groups
  /// </summary>
  Task GroupsBulkDeleteAsync(string orgId, Apigen.Vaultwarden.Models.GroupBulkRequestModel groupBulkRequestModel);

  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/groups/details
  /// </summary>
  Task<GroupDetailsResponseModelListResponseModel> GroupsGetOrganizationGroupDetailsAsync(string orgId);

  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/groups/{id}/users
  /// </summary>
  Task<JsonElement> GroupsGetUsersAsync(string orgId, string id);

  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{orgId}/groups/{id}/delete
  /// </summary>
  Task GroupsPostDeleteAsync(string orgId, string id);

  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{orgId}/groups/{id}/delete-user/{orgUserId}
  /// </summary>
  Task GroupsPostDeleteUserAsync(string orgId, string id, string orgUserId);

}
