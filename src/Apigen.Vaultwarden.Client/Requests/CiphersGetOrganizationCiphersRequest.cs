using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Request parameters for 
/// Operation: GET /api/ciphers/organization-details
/// </summary>
public class CiphersGetOrganizationCiphersRequest : BaseRequest
{
  /// <summary>
  /// organizationId
  /// </summary>
  [JsonPropertyName("organizationId")]
  public string? OrganizationId { get; set; }

  /// <summary>
  /// includeMemberItems
  /// </summary>
  [JsonPropertyName("includeMemberItems")]
  public bool? IncludeMemberItems { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (OrganizationId != null)
      queryParams["organizationId"] = OrganizationId;
    if (IncludeMemberItems != null)
      queryParams["includeMemberItems"] = IncludeMemberItems;

    return queryParams.ToQueryString();
  }
}
