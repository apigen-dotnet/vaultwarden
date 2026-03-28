using System.Text.Json;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for Devices operations
/// </summary>
public interface IDevicesClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/devices/identifier/{identifier}
  /// </summary>
  Task<DeviceResponseModel> GetAsync(string identifier);

  /// <summary>
  /// 
  /// Operation: GET /api/devices
  /// </summary>
  Task<DeviceAuthRequestResponseModelListResponseModel> DevicesGetAllAsync();

  /// <summary>
  /// 
  /// Operation: PUT /api/devices/identifier/{identifier}/token
  /// </summary>
  Task DevicesPutTokenAsync(string identifier, Apigen.Vaultwarden.Models.DeviceTokenRequestModel deviceTokenRequestModel);

  /// <summary>
  /// 
  /// Operation: POST /api/devices/identifier/{identifier}/token
  /// </summary>
  Task DevicesPostTokenAsync(string identifier, Apigen.Vaultwarden.Models.DeviceTokenRequestModel deviceTokenRequestModel);

  /// <summary>
  /// 
  /// Operation: PUT /api/devices/identifier/{identifier}/clear-token
  /// </summary>
  Task DevicesPutClearTokenAsync(string identifier);

  /// <summary>
  /// 
  /// Operation: POST /api/devices/identifier/{identifier}/clear-token
  /// </summary>
  Task DevicesPostClearTokenAsync(string identifier);

  /// <summary>
  /// 
  /// Operation: GET /api/devices/knowndevice
  /// </summary>
  Task<JsonElement> DevicesGetByIdentifierQueryAsync();

}
