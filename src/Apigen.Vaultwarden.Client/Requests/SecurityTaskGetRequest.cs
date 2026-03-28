using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Request parameters for Retrieves security tasks for the current user.
/// Operation: GET /api/tasks
/// </summary>
public class SecurityTaskGetRequest : BaseRequest
{
  /// <summary>
  /// Optional filter for task status. If not provided returns tasks of all statuses.
  /// </summary>
  [JsonPropertyName("status")]
  public int? Status { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (Status != null)
      queryParams["status"] = Status;

    return queryParams.ToQueryString();
  }
}
