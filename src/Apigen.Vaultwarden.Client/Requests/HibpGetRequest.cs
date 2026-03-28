using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Request parameters for 
/// Operation: GET /api/hibp/breach
/// </summary>
public class HibpGetRequest : BaseRequest
{
  /// <summary>
  /// username
  /// </summary>
  [JsonPropertyName("username")]
  public string? Username { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (Username != null)
      queryParams["username"] = Username;

    return queryParams.ToQueryString();
  }
}
