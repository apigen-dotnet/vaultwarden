using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for Hibp operations
/// </summary>
public interface IHibpClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/hibp/breach
  /// </summary>
  Task HibpGetAsync(HibpGetRequest? request = null);

}
