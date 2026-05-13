using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for Devices operations
/// </summary>
public partial interface IDevicesClient
{
  /// <summary>
  /// 
  /// Operation: GET /api/devices/identifier/{identifier}
  /// </summary>
  Task<DeviceResponseModel> GetAsync(string identifier, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: GET /api/devices
  /// </summary>
  Task<DeviceAuthRequestResponseModelListResponseModel> DevicesGetAllAsync(CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: PUT /api/devices/identifier/{identifier}/token
  /// </summary>
  Task DevicesPutTokenAsync(string identifier, Apigen.Vaultwarden.Models.DeviceTokenRequestModel deviceTokenRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/devices/identifier/{identifier}/token
  /// </summary>
  Task DevicesPostTokenAsync(string identifier, Apigen.Vaultwarden.Models.DeviceTokenRequestModel deviceTokenRequestModel, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: PUT /api/devices/identifier/{identifier}/clear-token
  /// </summary>
  Task DevicesPutClearTokenAsync(string identifier, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: POST /api/devices/identifier/{identifier}/clear-token
  /// </summary>
  Task DevicesPostClearTokenAsync(string identifier, CancellationToken cancellationToken = default);

  /// <summary>
  /// 
  /// Operation: GET /api/devices/knowndevice
  /// </summary>
  Task<JsonElement> DevicesGetByIdentifierQueryAsync(CancellationToken cancellationToken = default);

}
