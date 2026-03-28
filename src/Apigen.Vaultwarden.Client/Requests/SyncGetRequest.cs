using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Request parameters for 
/// Operation: GET /api/sync
/// </summary>
public class SyncGetRequest : BaseRequest
{
  /// <summary>
  /// excludeDomains
  /// </summary>
  [JsonPropertyName("excludeDomains")]
  public bool? ExcludeDomains { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (ExcludeDomains != null)
      queryParams["excludeDomains"] = ExcludeDomains;

    return queryParams.ToQueryString();
  }
}
