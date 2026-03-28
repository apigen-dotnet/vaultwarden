using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Request parameters for 
/// Operation: GET /api/organizations/{orgId}/users/{id}/events
/// </summary>
public class EventsGetOrganizationUserRequest : BaseRequest
{
  /// <summary>
  /// start
  /// </summary>
  [JsonPropertyName("start")]
  public string? Start { get; set; }

  /// <summary>
  /// end
  /// </summary>
  [JsonPropertyName("end")]
  public string? End { get; set; }

  /// <summary>
  /// continuationToken
  /// </summary>
  [JsonPropertyName("continuationToken")]
  public string? ContinuationToken { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (Start != null)
      queryParams["start"] = Start;
    if (End != null)
      queryParams["end"] = End;
    if (ContinuationToken != null)
      queryParams["continuationToken"] = ContinuationToken;

    return queryParams.ToQueryString();
  }
}
