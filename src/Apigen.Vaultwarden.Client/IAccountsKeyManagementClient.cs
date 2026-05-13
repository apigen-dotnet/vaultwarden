using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Apigen.Vaultwarden.Models;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Interface for AccountsKeyManagement operations
/// </summary>
public partial interface IAccountsKeyManagementClient
{
  /// <summary>
  /// 
  /// Operation: POST /api/accounts/key-management/rotate-user-account-keys
  /// </summary>
  Task AccountsKeyManagementRotateUserAccountKeysAsync(Apigen.Vaultwarden.Models.RotateUserAccountKeysAndDataRequestModel rotateUserAccountKeysAndDataRequestModel, CancellationToken cancellationToken = default);

}
