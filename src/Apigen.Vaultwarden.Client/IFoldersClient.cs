using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for Folders operations
/// </summary>
public interface IFoldersClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/folders/{id}
  /// </summary>
  Task<FolderResponseModel> GetAsync(string id);

  /// <summary>
  /// 
  /// Operation: PUT /api/folders/{id}
  /// </summary>
  Task<FolderResponseModel> UpdateAsync(string id, Apigen.Vaultwarden.Models.FolderRequestModel folderRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/folders/{id}
  /// </summary>
  Task<FolderResponseModel> FoldersPostPutAsync(string id, Apigen.Vaultwarden.Models.FolderRequestModel folderRequestModel);

  /// <summary>
  /// 
  /// Operation: DELETE /api/folders/{id}
  /// </summary>
  Task DeleteAsync(string id);

  /// <summary>
  /// 
  /// Operation: GET /api/folders
  /// </summary>
  Task<FolderResponseModelListResponseModel> FoldersGetAllAsync();

  /// <summary>
  /// 
  /// Operation: POST /api/folders
  /// </summary>
  Task<FolderResponseModel> FoldersPostAsync(Apigen.Vaultwarden.Models.FolderRequestModel folderRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/folders/{id}/delete
  /// </summary>
  Task FoldersPostDeleteAsync(string id);

}
