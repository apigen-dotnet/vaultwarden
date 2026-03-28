using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for AuthRequests operations
/// </summary>
public interface IAuthRequestsClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/auth-requests
  /// </summary>
  Task<AuthRequestResponseModelListResponseModel> AuthRequestsGetAllAsync();

  /// <summary>
  /// 
  /// Operation: POST /api/auth-requests
  /// </summary>
  Task<AuthRequestResponseModel> AuthRequestsPostAsync(Apigen.Vaultwarden.Models.AuthRequestCreateRequestModel authRequestCreateRequestModel);

  /// <summary>
  /// 
  /// Operation: GET /api/auth-requests/{id}
  /// </summary>
  Task<AuthRequestResponseModel> GetAsync(string id);

  /// <summary>
  /// 
  /// Operation: PUT /api/auth-requests/{id}
  /// </summary>
  Task<AuthRequestResponseModel> UpdateAsync(string id, Apigen.Vaultwarden.Models.AuthRequestUpdateRequestModel authRequestUpdateRequestModel);

  /// <summary>
  /// 
  /// Operation: GET /api/auth-requests/pending
  /// </summary>
  Task<PendingAuthRequestResponseModelListResponseModel> AuthRequestsGetPendingAuthRequestsAsync();

  /// <summary>
  /// 
  /// Operation: GET /api/auth-requests/{id}/response
  /// </summary>
  Task<AuthRequestResponseModel> AuthRequestsGetResponseAsync(string id, AuthRequestsGetResponseRequest? request = null);

}
