using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for EmergencyAccess operations
/// </summary>
public interface IEmergencyAccessClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/emergency-access/trusted
  /// </summary>
  Task<EmergencyAccessGranteeDetailsResponseModelListResponseModel> EmergencyAccessGetContactsAsync();

  /// <summary>
  /// 
  /// Operation: GET /api/emergency-access/granted
  /// </summary>
  Task<EmergencyAccessGrantorDetailsResponseModelListResponseModel> EmergencyAccessGetGranteesAsync();

  /// <summary>
  /// 
  /// Operation: GET /api/emergency-access/{id}
  /// </summary>
  Task<EmergencyAccessGranteeDetailsResponseModel> GetAsync(string id);

  /// <summary>
  /// 
  /// Operation: PUT /api/emergency-access/{id}
  /// </summary>
  Task UpdateAsync(string id, Apigen.Vaultwarden.Models.EmergencyAccessUpdateRequestModel emergencyAccessUpdateRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/emergency-access/{id}
  /// </summary>
  Task EmergencyAccessPostAsync(string id, Apigen.Vaultwarden.Models.EmergencyAccessUpdateRequestModel emergencyAccessUpdateRequestModel);

  /// <summary>
  /// 
  /// Operation: DELETE /api/emergency-access/{id}
  /// </summary>
  Task DeleteAsync(string id);

  /// <summary>
  /// 
  /// Operation: GET /api/emergency-access/{id}/policies
  /// </summary>
  Task<PolicyResponseModelListResponseModel> EmergencyAccessPoliciesAsync(string id);

  /// <summary>
  /// 
  /// Operation: POST /api/emergency-access/{id}/delete
  /// </summary>
  Task EmergencyAccessPostDeleteAsync(string id);

  /// <summary>
  /// 
  /// Operation: POST /api/emergency-access/invite
  /// </summary>
  Task EmergencyAccessInviteAsync(Apigen.Vaultwarden.Models.EmergencyAccessInviteRequestModel emergencyAccessInviteRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/emergency-access/{id}/reinvite
  /// </summary>
  Task EmergencyAccessReinviteAsync(string id);

  /// <summary>
  /// 
  /// Operation: POST /api/emergency-access/{id}/accept
  /// </summary>
  Task EmergencyAccessAcceptAsync(string id, Apigen.Vaultwarden.Models.OrganizationUserAcceptRequestModel organizationUserAcceptRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/emergency-access/{id}/confirm
  /// </summary>
  Task EmergencyAccessConfirmAsync(string id, Apigen.Vaultwarden.Models.OrganizationUserConfirmRequestModel organizationUserConfirmRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/emergency-access/{id}/initiate
  /// </summary>
  Task EmergencyAccessInitiateAsync(string id);

  /// <summary>
  /// 
  /// Operation: POST /api/emergency-access/{id}/approve
  /// </summary>
  Task EmergencyAccessApproveAsync(string id);

  /// <summary>
  /// 
  /// Operation: POST /api/emergency-access/{id}/reject
  /// </summary>
  Task EmergencyAccessRejectAsync(string id);

  /// <summary>
  /// 
  /// Operation: POST /api/emergency-access/{id}/takeover
  /// </summary>
  Task<EmergencyAccessTakeoverResponseModel> EmergencyAccessTakeoverAsync(string id);

  /// <summary>
  /// 
  /// Operation: POST /api/emergency-access/{id}/password
  /// </summary>
  Task EmergencyAccessPasswordAsync(string id, Apigen.Vaultwarden.Models.EmergencyAccessPasswordRequestModel emergencyAccessPasswordRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/emergency-access/{id}/view
  /// </summary>
  Task<EmergencyAccessViewResponseModel> EmergencyAccessViewCiphersAsync(string id);

}
