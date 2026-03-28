using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Request parameters for 
/// Operation: GET /api/organizations/{orgId}/users
/// </summary>
public class OrganizationUsersGetAllRequest : BaseRequest
{
  /// <summary>
  /// includeGroups
  /// </summary>
  [JsonPropertyName("includeGroups")]
  public bool? IncludeGroups { get; set; }

  /// <summary>
  /// includeCollections
  /// </summary>
  [JsonPropertyName("includeCollections")]
  public bool? IncludeCollections { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (IncludeGroups != null)
      queryParams["includeGroups"] = IncludeGroups;
    if (IncludeCollections != null)
      queryParams["includeCollections"] = IncludeCollections;

    return queryParams.ToQueryString();
  }
}
