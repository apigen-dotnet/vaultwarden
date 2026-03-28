using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Request parameters for 
/// Operation: GET /api/settings/domains
/// </summary>
public class SettingsGetDomainsRequest : BaseRequest
{
  /// <summary>
  /// excluded
  /// </summary>
  [JsonPropertyName("excluded")]
  public bool? Excluded { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (Excluded != null)
      queryParams["excluded"] = Excluded;

    return queryParams.ToQueryString();
  }
}
