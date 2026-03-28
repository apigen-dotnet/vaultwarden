using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for Collections operations
/// </summary>
public interface ICollectionsClient
{
  /// <summary>
  /// 
  /// Operation: PUT /api/organizations/{orgId}/collections/{id}
  /// </summary>
  Task<CollectionResponseModel> UpdateAsync(string orgId, string id, Apigen.Vaultwarden.Models.UpdateCollectionRequestModel updateCollectionRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{orgId}/collections/{id}
  /// </summary>
  Task<CollectionResponseModel> CollectionsPostPutAsync(string orgId, string id, Apigen.Vaultwarden.Models.UpdateCollectionRequestModel updateCollectionRequestModel);

  /// <summary>
  /// 
  /// Operation: DELETE /api/organizations/{orgId}/collections/{id}
  /// </summary>
  Task DeleteAsync(string orgId, string id);

  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/collections/{id}/details
  /// </summary>
  Task<CollectionAccessDetailsResponseModel> CollectionsGetDetailsAsync(string orgId, string id);

  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/collections/details
  /// </summary>
  Task<CollectionAccessDetailsResponseModelListResponseModel> CollectionsGetManyWithDetailsAsync(string orgId);

  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/collections
  /// </summary>
  Task<CollectionResponseModelListResponseModel> CollectionsGetAllAsync(string orgId);

  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{orgId}/collections
  /// </summary>
  Task<CollectionResponseModel> CollectionsPostAsync(string orgId, Apigen.Vaultwarden.Models.CreateCollectionRequestModel createCollectionRequestModel);

  /// <summary>
  /// 
  /// Operation: DELETE /api/organizations/{orgId}/collections
  /// </summary>
  Task CollectionsDeleteManyAsync(string orgId, Apigen.Vaultwarden.Models.CollectionBulkDeleteRequestModel collectionBulkDeleteRequestModel);

  /// <summary>
  /// 
  /// Operation: GET /api/collections
  /// </summary>
  Task<CollectionDetailsResponseModelListResponseModel> CollectionsGetUserAsync();

  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/collections/{id}/users
  /// </summary>
  Task<List<SelectionReadOnlyResponseModel>> CollectionsGetUsersAsync(string orgId, string id);

  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{orgId}/collections/bulk-access
  /// </summary>
  Task BulkAsync(string orgId, Apigen.Vaultwarden.Models.BulkCollectionAccessRequestModel bulkCollectionAccessRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/organizations/{orgId}/collections/{id}/delete
  /// </summary>
  Task CollectionsPostDeleteAsync(string orgId, string id);

}
