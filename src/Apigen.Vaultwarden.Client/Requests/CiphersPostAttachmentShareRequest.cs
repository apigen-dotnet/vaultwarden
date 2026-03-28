using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Request parameters for 
/// Operation: POST /api/ciphers/{id}/attachment/{attachmentId}/share
/// </summary>
public class CiphersPostAttachmentShareRequest : BaseRequest
{
  /// <summary>
  /// organizationId
  /// </summary>
  [JsonPropertyName("organizationId")]
  public string? OrganizationId { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (OrganizationId != null)
      queryParams["organizationId"] = OrganizationId;

    return queryParams.ToQueryString();
  }
}
