using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Request parameters for 
/// Operation: GET /api/organizations/{orgId}/policies/token
/// </summary>
public class PoliciesGetByTokenRequest : BaseRequest
{
  /// <summary>
  /// email
  /// </summary>
  [JsonPropertyName("email")]
  public string? Email { get; set; }

  /// <summary>
  /// token
  /// </summary>
  [JsonPropertyName("token")]
  public string? Token { get; set; }

  /// <summary>
  /// organizationUserId
  /// </summary>
  [JsonPropertyName("organizationUserId")]
  public string? OrganizationUserId { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (Email != null)
      queryParams["email"] = Email;
    if (Token != null)
      queryParams["token"] = Token;
    if (OrganizationUserId != null)
      queryParams["organizationUserId"] = OrganizationUserId;

    return queryParams.ToQueryString();
  }
}
