using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for Config operations
/// </summary>
public interface IConfigClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/config
  /// </summary>
  Task<ConfigResponseModel> ConfigGetConfigsAsync();

}
