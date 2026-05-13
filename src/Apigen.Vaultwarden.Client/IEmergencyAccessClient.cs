using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for EmergencyAccess operations
/// </summary>
public partial interface IEmergencyAccessClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/emergency-access/trusted
  /// </summary>
  Task<EmergencyAccessGranteeDetailsResponseModelListResponseModel> EmergencyAccessGetContactsAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: GET /api/emergency-access/granted
  /// </summary>
  Task<EmergencyAccessGrantorDetailsResponseModelListResponseModel> EmergencyAccessGetGranteesAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: GET /api/emergency-access/{id}
  /// </summary>
  Task<EmergencyAccessGranteeDetailsResponseModel> GetAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: PUT /api/emergency-access/{id}
  /// </summary>
  Task UpdateAsync(string id, Apigen.Vaultwarden.Models.EmergencyAccessUpdateRequestModel emergencyAccessUpdateRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/emergency-access/{id}
  /// </summary>
  Task EmergencyAccessPostAsync(string id, Apigen.Vaultwarden.Models.EmergencyAccessUpdateRequestModel emergencyAccessUpdateRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: DELETE /api/emergency-access/{id}
  /// </summary>
  Task DeleteAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: GET /api/emergency-access/{id}/policies
  /// </summary>
  Task<PolicyResponseModelListResponseModel> EmergencyAccessPoliciesAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/emergency-access/{id}/delete
  /// </summary>
  Task EmergencyAccessPostDeleteAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/emergency-access/invite
  /// </summary>
  Task EmergencyAccessInviteAsync(Apigen.Vaultwarden.Models.EmergencyAccessInviteRequestModel emergencyAccessInviteRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/emergency-access/{id}/reinvite
  /// </summary>
  Task EmergencyAccessReinviteAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/emergency-access/{id}/accept
  /// </summary>
  Task EmergencyAccessAcceptAsync(string id, Apigen.Vaultwarden.Models.OrganizationUserAcceptRequestModel organizationUserAcceptRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/emergency-access/{id}/confirm
  /// </summary>
  Task EmergencyAccessConfirmAsync(string id, Apigen.Vaultwarden.Models.OrganizationUserConfirmRequestModel organizationUserConfirmRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/emergency-access/{id}/initiate
  /// </summary>
  Task EmergencyAccessInitiateAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/emergency-access/{id}/approve
  /// </summary>
  Task EmergencyAccessApproveAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/emergency-access/{id}/reject
  /// </summary>
  Task EmergencyAccessRejectAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/emergency-access/{id}/takeover
  /// </summary>
  Task<EmergencyAccessTakeoverResponseModel> EmergencyAccessTakeoverAsync(string id, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/emergency-access/{id}/password
  /// </summary>
  Task EmergencyAccessPasswordAsync(string id, Apigen.Vaultwarden.Models.EmergencyAccessPasswordRequestModel emergencyAccessPasswordRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/emergency-access/{id}/view
  /// </summary>
  Task<EmergencyAccessViewResponseModel> EmergencyAccessViewCiphersAsync(string id, CancellationToken cancellationToken = default);

}
