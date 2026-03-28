using System.Collections.Generic;
using System.Linq;
using System.Web;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Base class for request objects
/// </summary>
public abstract class BaseRequest
{
  public virtual string ToQueryString() => string.Empty;
}
