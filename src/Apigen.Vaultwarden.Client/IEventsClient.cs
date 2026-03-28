using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for Events operations
/// </summary>
public interface IEventsClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/ciphers/{id}/events
  /// </summary>
  Task<EventResponseModelListResponseModel> EventsGetCipherAsync(string id, EventsGetCipherRequest? request = null);

  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{id}/events
  /// </summary>
  Task<EventResponseModelListResponseModel> EventsGetOrganizationAsync(string id, EventsGetOrganizationRequest? request = null);

  /// <summary>
  /// 
  /// Operation: GET /api/organizations/{orgId}/users/{id}/events
  /// </summary>
  Task<EventResponseModelListResponseModel> EventsGetOrganizationUserAsync(string orgId, string id, EventsGetOrganizationUserRequest? request = null);

}
