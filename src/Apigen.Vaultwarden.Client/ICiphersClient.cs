using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for Ciphers operations
/// </summary>
public interface ICiphersClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/ciphers/{id}
  /// </summary>
  Task<CipherResponseModel> GetAsync(string id);

  /// <summary>
  /// 
  /// Operation: PUT /api/ciphers/{id}
  /// </summary>
  Task<CipherResponseModel> UpdateAsync(string id, Apigen.Vaultwarden.Models.CipherRequestModel cipherRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/{id}
  /// </summary>
  Task<CipherResponseModel> CiphersPostPutAsync(string id, Apigen.Vaultwarden.Models.CipherRequestModel cipherRequestModel);

  /// <summary>
  /// 
  /// Operation: DELETE /api/ciphers/{id}
  /// </summary>
  Task DeleteAsync(string id);

  /// <summary>
  /// 
  /// Operation: GET /api/ciphers/{id}/admin
  /// </summary>
  Task<CipherMiniResponseModel> CiphersGetAdminAsync(string id);

  /// <summary>
  /// 
  /// Operation: PUT /api/ciphers/{id}/admin
  /// </summary>
  Task<CipherMiniResponseModel> CiphersPutAdminAsync(string id, Apigen.Vaultwarden.Models.CipherRequestModel cipherRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/{id}/admin
  /// </summary>
  Task<CipherMiniResponseModel> CiphersPostPutAdminAsync(string id, Apigen.Vaultwarden.Models.CipherRequestModel cipherRequestModel);

  /// <summary>
  /// 
  /// Operation: DELETE /api/ciphers/{id}/admin
  /// </summary>
  Task CiphersDeleteAdminAsync(string id);

  /// <summary>
  /// 
  /// Operation: GET /api/ciphers/{id}/details
  /// </summary>
  Task<CipherDetailsResponseModel> CiphersGetDetailsAsync(string id);

  /// <summary>
  /// 
  /// Operation: GET /api/ciphers
  /// </summary>
  Task<CipherDetailsResponseModelListResponseModel> CiphersGetAllAsync();

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers
  /// </summary>
  Task<CipherResponseModel> CiphersPostAsync(Apigen.Vaultwarden.Models.CipherRequestModel cipherRequestModel);

  /// <summary>
  /// 
  /// Operation: DELETE /api/ciphers
  /// </summary>
  Task CiphersDeleteManyAsync(Apigen.Vaultwarden.Models.CipherBulkDeleteRequestModel cipherBulkDeleteRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/create
  /// </summary>
  Task<CipherResponseModel> CiphersPostCreateAsync(Apigen.Vaultwarden.Models.CipherCreateRequestModel cipherCreateRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/admin
  /// </summary>
  Task<CipherMiniResponseModel> CiphersPostAdminAsync(Apigen.Vaultwarden.Models.CipherCreateRequestModel cipherCreateRequestModel);

  /// <summary>
  /// 
  /// Operation: DELETE /api/ciphers/admin
  /// </summary>
  Task CiphersDeleteManyAdminAsync(Apigen.Vaultwarden.Models.CipherBulkDeleteRequestModel cipherBulkDeleteRequestModel);

  /// <summary>
  /// 
  /// Operation: GET /api/ciphers/organization-details
  /// </summary>
  Task<CipherMiniDetailsResponseModelListResponseModel> CiphersGetOrganizationCiphersAsync(CiphersGetOrganizationCiphersRequest? request = null);

  /// <summary>
  /// 
  /// Operation: PUT /api/ciphers/{id}/partial
  /// </summary>
  Task<CipherResponseModel> CiphersPutPartialAsync(string id, Apigen.Vaultwarden.Models.CipherPartialRequestModel cipherPartialRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/{id}/partial
  /// </summary>
  Task<CipherResponseModel> CiphersPostPartialAsync(string id, Apigen.Vaultwarden.Models.CipherPartialRequestModel cipherPartialRequestModel);

  /// <summary>
  /// 
  /// Operation: PUT /api/ciphers/{id}/share
  /// </summary>
  Task<CipherResponseModel> CiphersPutShareAsync(string id, Apigen.Vaultwarden.Models.CipherShareRequestModel cipherShareRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/{id}/share
  /// </summary>
  Task<CipherResponseModel> CiphersPostShareAsync(string id, Apigen.Vaultwarden.Models.CipherShareRequestModel cipherShareRequestModel);

  /// <summary>
  /// 
  /// Operation: PUT /api/ciphers/{id}/collections
  /// </summary>
  Task<CipherDetailsResponseModel> CiphersPutCollectionsAsync(string id, Apigen.Vaultwarden.Models.CipherCollectionsRequestModel cipherCollectionsRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/{id}/collections
  /// </summary>
  Task<CipherDetailsResponseModel> CiphersPostCollectionsAsync(string id, Apigen.Vaultwarden.Models.CipherCollectionsRequestModel cipherCollectionsRequestModel);

  /// <summary>
  /// 
  /// Operation: PUT /api/ciphers/{id}/collections_v2
  /// </summary>
  Task<OptionalCipherDetailsResponseModel> CiphersPutCollectionsVNextAsync(string id, Apigen.Vaultwarden.Models.CipherCollectionsRequestModel cipherCollectionsRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/{id}/collections_v2
  /// </summary>
  Task<OptionalCipherDetailsResponseModel> CiphersPostCollectionsVNextAsync(string id, Apigen.Vaultwarden.Models.CipherCollectionsRequestModel cipherCollectionsRequestModel);

  /// <summary>
  /// 
  /// Operation: PUT /api/ciphers/{id}/collections-admin
  /// </summary>
  Task<CipherMiniDetailsResponseModel> CiphersPutCollectionsAdminAsync(string id, Apigen.Vaultwarden.Models.CipherCollectionsRequestModel cipherCollectionsRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/{id}/collections-admin
  /// </summary>
  Task<CipherMiniDetailsResponseModel> CiphersPostCollectionsAdminAsync(string id, Apigen.Vaultwarden.Models.CipherCollectionsRequestModel cipherCollectionsRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/bulk-collections
  /// </summary>
  Task BulkAsync(Apigen.Vaultwarden.Models.CipherBulkUpdateCollectionsRequestModel cipherBulkUpdateCollectionsRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/{id}/delete
  /// </summary>
  Task CiphersPostDeleteAsync(string id);

  /// <summary>
  /// 
  /// Operation: PUT /api/ciphers/{id}/delete
  /// </summary>
  Task CiphersPutDeleteAsync(string id);

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/{id}/delete-admin
  /// </summary>
  Task CiphersPostDeleteAdminAsync(string id);

  /// <summary>
  /// 
  /// Operation: PUT /api/ciphers/{id}/delete-admin
  /// </summary>
  Task CiphersPutDeleteAdminAsync(string id);

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/delete
  /// </summary>
  Task CiphersPostDeleteManyAsync(Apigen.Vaultwarden.Models.CipherBulkDeleteRequestModel cipherBulkDeleteRequestModel);

  /// <summary>
  /// 
  /// Operation: PUT /api/ciphers/delete
  /// </summary>
  Task CiphersPutDeleteManyAsync(Apigen.Vaultwarden.Models.CipherBulkDeleteRequestModel cipherBulkDeleteRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/delete-admin
  /// </summary>
  Task CiphersPostDeleteManyAdminAsync(Apigen.Vaultwarden.Models.CipherBulkDeleteRequestModel cipherBulkDeleteRequestModel);

  /// <summary>
  /// 
  /// Operation: PUT /api/ciphers/delete-admin
  /// </summary>
  Task CiphersPutDeleteManyAdminAsync(Apigen.Vaultwarden.Models.CipherBulkDeleteRequestModel cipherBulkDeleteRequestModel);

  /// <summary>
  /// 
  /// Operation: PUT /api/ciphers/{id}/restore
  /// </summary>
  Task<CipherResponseModel> CiphersPutRestoreAsync(string id);

  /// <summary>
  /// 
  /// Operation: PUT /api/ciphers/{id}/restore-admin
  /// </summary>
  Task<CipherMiniResponseModel> CiphersPutRestoreAdminAsync(string id);

  /// <summary>
  /// 
  /// Operation: PUT /api/ciphers/restore
  /// </summary>
  Task<CipherMiniResponseModelListResponseModel> CiphersPutRestoreManyAsync(Apigen.Vaultwarden.Models.CipherBulkRestoreRequestModel cipherBulkRestoreRequestModel);

  /// <summary>
  /// 
  /// Operation: PUT /api/ciphers/restore-admin
  /// </summary>
  Task<CipherMiniResponseModelListResponseModel> CiphersPutRestoreManyAdminAsync(Apigen.Vaultwarden.Models.CipherBulkRestoreRequestModel cipherBulkRestoreRequestModel);

  /// <summary>
  /// 
  /// Operation: PUT /api/ciphers/move
  /// </summary>
  Task CiphersMoveManyAsync(Apigen.Vaultwarden.Models.CipherBulkMoveRequestModel cipherBulkMoveRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/move
  /// </summary>
  Task CiphersPostMoveManyAsync(Apigen.Vaultwarden.Models.CipherBulkMoveRequestModel cipherBulkMoveRequestModel);

  /// <summary>
  /// 
  /// Operation: PUT /api/ciphers/share
  /// </summary>
  Task<CipherMiniResponseModelListResponseModel> CiphersPutShareManyAsync(Apigen.Vaultwarden.Models.CipherBulkShareRequestModel cipherBulkShareRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/purge
  /// </summary>
  Task CiphersPostPurgeAsync(Apigen.Vaultwarden.Models.SecretVerificationRequestModel secretVerificationRequestModel, CiphersPostPurgeRequest? request = null);

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/{id}/attachment/v2
  /// </summary>
  Task<AttachmentUploadDataResponseModel> CiphersPostAttachmentAsync(string id, Apigen.Vaultwarden.Models.AttachmentRequestModel attachmentRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/{id}/attachment/{attachmentId}
  /// </summary>
  Task CiphersPostFileForExistingAttachmentAsync(string id, string attachmentId);

  /// <summary>
  /// 
  /// Operation: GET /api/ciphers/{id}/attachment/{attachmentId}
  /// </summary>
  Task<AttachmentResponseModel> GetAsync(string id, string attachmentId);

  /// <summary>
  /// 
  /// Operation: DELETE /api/ciphers/{id}/attachment/{attachmentId}
  /// </summary>
  Task<DeleteAttachmentResponseData> DeleteAsync(string id, string attachmentId);

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/{id}/attachment
  /// </summary>
  Task<CipherResponseModel> CiphersPostAttachmentV1Async(string id);

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/{id}/attachment-admin
  /// </summary>
  Task<CipherMiniResponseModel> CiphersPostAttachmentAdminAsync(string id);

  /// <summary>
  /// 
  /// Operation: DELETE /api/ciphers/{id}/attachment/{attachmentId}/admin
  /// </summary>
  Task<DeleteAttachmentResponseData> CiphersDeleteAttachmentAdminAsync(string id, string attachmentId);

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/{id}/attachment/{attachmentId}/share
  /// </summary>
  Task CiphersPostAttachmentShareAsync(string id, string attachmentId, CiphersPostAttachmentShareRequest? request = null);

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/{id}/attachment/{attachmentId}/delete
  /// </summary>
  Task<DeleteAttachmentResponseData> CiphersPostDeleteAttachmentAsync(string id, string attachmentId);

  /// <summary>
  /// 
  /// Operation: POST /api/ciphers/{id}/attachment/{attachmentId}/delete-admin
  /// </summary>
  Task<DeleteAttachmentResponseData> CiphersPostDeleteAttachmentAdminAsync(string id, string attachmentId);

}
