using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for Sends operations
/// </summary>
public partial interface ISendsClient
{
  /// <summary>
  /// 
  /// Operation: POST /api/sends/access/{id}
  /// </summary>
  Task SendsAccessAsync(string id, Apigen.Vaultwarden.Models.SendAccessRequestModel sendAccessRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/sends/{encodedSendId}/access/file/{fileId}
  /// </summary>
  Task SendsGetSendFileDownloadDataAsync(string encodedSendId, string fileId, Apigen.Vaultwarden.Models.SendAccessRequestModel sendAccessRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: GET /api/sends/{id}
  /// </summary>
  Task<SendResponseModel> GetAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: PUT /api/sends/{id}
  /// </summary>
  Task<SendResponseModel> UpdateAsync(string id, Apigen.Vaultwarden.Models.SendRequestModel sendRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: DELETE /api/sends/{id}
  /// </summary>
  Task DeleteAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: GET /api/sends
  /// </summary>
  Task<SendResponseModelListResponseModel> SendsGetAllAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/sends
  /// </summary>
  Task<SendResponseModel> SendsPostAsync(Apigen.Vaultwarden.Models.SendRequestModel sendRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/sends/file/v2
  /// </summary>
  Task<SendFileUploadDataResponseModel> SendsPostFileAsync(Apigen.Vaultwarden.Models.SendRequestModel sendRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/sends/{id}/file/{fileId}
  /// </summary>
  Task SendsPostFileForExistingSendAsync(string id, string fileId, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: PUT /api/sends/{id}/remove-password
  /// </summary>
  Task<SendResponseModel> SendsPutRemovePasswordAsync(string id, CancellationToken cancellationToken = default);

}
