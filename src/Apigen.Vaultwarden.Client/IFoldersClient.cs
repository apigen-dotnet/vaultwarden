using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for Folders operations
/// </summary>
public partial interface IFoldersClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/folders/{id}
  /// </summary>
  Task<FolderResponseModel> GetAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: PUT /api/folders/{id}
  /// </summary>
  Task<FolderResponseModel> UpdateAsync(string id, Apigen.Vaultwarden.Models.FolderRequestModel folderRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/folders/{id}
  /// </summary>
  Task<FolderResponseModel> FoldersPostPutAsync(string id, Apigen.Vaultwarden.Models.FolderRequestModel folderRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: DELETE /api/folders/{id}
  /// </summary>
  Task DeleteAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: GET /api/folders
  /// </summary>
  Task<FolderResponseModelListResponseModel> FoldersGetAllAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/folders
  /// </summary>
  Task<FolderResponseModel> FoldersPostAsync(Apigen.Vaultwarden.Models.FolderRequestModel folderRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/folders/{id}/delete
  /// </summary>
  Task FoldersPostDeleteAsync(string id, CancellationToken cancellationToken = default);

}
