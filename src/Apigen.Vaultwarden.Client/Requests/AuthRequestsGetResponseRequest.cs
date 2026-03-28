using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Request parameters for 
/// Operation: GET /api/auth-requests/{id}/response
/// </summary>
public class AuthRequestsGetResponseRequest : BaseRequest
{
  /// <summary>
  /// code
  /// </summary>
  [JsonPropertyName("code")]
  public string? Code { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (Code != null)
      queryParams["code"] = Code;

    return queryParams.ToQueryString();
  }
}
