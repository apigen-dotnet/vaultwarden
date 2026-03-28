using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

#nullable enable

namespace Apigen.Vaultwarden.Client;

/// <summary>
/// Request parameters for 
/// Operation: GET /api/organizations/{organizationId}/billing/vnext/warnings
/// </summary>
public class OrganizationBillingVNextGetWarningsRequest : BaseRequest
{
  /// <summary>
  /// id
  /// </summary>
  [JsonPropertyName("id")]
  public string? Id { get; set; }

  /// <summary>
  /// identifier
  /// </summary>
  [JsonPropertyName("identifier")]
  public string? Identifier { get; set; }

  /// <summary>
  /// This value is HTML encoded. For display purposes use the method DisplayName() instead.
  /// </summary>
  [JsonPropertyName("name")]
  public string? Name { get; set; }

  /// <summary>
  /// This value is HTML encoded. For display purposes use the method DisplayBusinessName() instead.
  /// </summary>
  [JsonPropertyName("businessName")]
  public string? BusinessName { get; set; }

  /// <summary>
  /// businessAddress1
  /// </summary>
  [JsonPropertyName("businessAddress1")]
  public string? BusinessAddress1 { get; set; }

  /// <summary>
  /// businessAddress2
  /// </summary>
  [JsonPropertyName("businessAddress2")]
  public string? BusinessAddress2 { get; set; }

  /// <summary>
  /// businessAddress3
  /// </summary>
  [JsonPropertyName("businessAddress3")]
  public string? BusinessAddress3 { get; set; }

  /// <summary>
  /// businessCountry
  /// </summary>
  [JsonPropertyName("businessCountry")]
  public string? BusinessCountry { get; set; }

  /// <summary>
  /// businessTaxNumber
  /// </summary>
  [JsonPropertyName("businessTaxNumber")]
  public string? BusinessTaxNumber { get; set; }

  /// <summary>
  /// billingEmail
  /// </summary>
  [JsonPropertyName("billingEmail")]
  public string? BillingEmail { get; set; }

  /// <summary>
  /// plan
  /// </summary>
  [JsonPropertyName("plan")]
  public string? Plan { get; set; }

  /// <summary>
  /// planType
  /// </summary>
  [JsonPropertyName("planType")]
  public int? PlanType { get; set; }

  /// <summary>
  /// seats
  /// </summary>
  [JsonPropertyName("seats")]
  public int? Seats { get; set; }

  /// <summary>
  /// maxCollections
  /// </summary>
  [JsonPropertyName("maxCollections")]
  public int? MaxCollections { get; set; }

  /// <summary>
  /// usePolicies
  /// </summary>
  [JsonPropertyName("usePolicies")]
  public bool? UsePolicies { get; set; }

  /// <summary>
  /// useSso
  /// </summary>
  [JsonPropertyName("useSso")]
  public bool? UseSso { get; set; }

  /// <summary>
  /// useKeyConnector
  /// </summary>
  [JsonPropertyName("useKeyConnector")]
  public bool? UseKeyConnector { get; set; }

  /// <summary>
  /// useScim
  /// </summary>
  [JsonPropertyName("useScim")]
  public bool? UseScim { get; set; }

  /// <summary>
  /// useGroups
  /// </summary>
  [JsonPropertyName("useGroups")]
  public bool? UseGroups { get; set; }

  /// <summary>
  /// useDirectory
  /// </summary>
  [JsonPropertyName("useDirectory")]
  public bool? UseDirectory { get; set; }

  /// <summary>
  /// useEvents
  /// </summary>
  [JsonPropertyName("useEvents")]
  public bool? UseEvents { get; set; }

  /// <summary>
  /// useTotp
  /// </summary>
  [JsonPropertyName("useTotp")]
  public bool? UseTotp { get; set; }

  /// <summary>
  /// use2fa
  /// </summary>
  [JsonPropertyName("use2fa")]
  public bool? Use2Fa { get; set; }

  /// <summary>
  /// useApi
  /// </summary>
  [JsonPropertyName("useApi")]
  public bool? UseApi { get; set; }

  /// <summary>
  /// useResetPassword
  /// </summary>
  [JsonPropertyName("useResetPassword")]
  public bool? UseResetPassword { get; set; }

  /// <summary>
  /// useSecretsManager
  /// </summary>
  [JsonPropertyName("useSecretsManager")]
  public bool? UseSecretsManager { get; set; }

  /// <summary>
  /// selfHost
  /// </summary>
  [JsonPropertyName("selfHost")]
  public bool? SelfHost { get; set; }

  /// <summary>
  /// usersGetPremium
  /// </summary>
  [JsonPropertyName("usersGetPremium")]
  public bool? UsersGetPremium { get; set; }

  /// <summary>
  /// useCustomPermissions
  /// </summary>
  [JsonPropertyName("useCustomPermissions")]
  public bool? UseCustomPermissions { get; set; }

  /// <summary>
  /// storage
  /// </summary>
  [JsonPropertyName("storage")]
  public int? Storage { get; set; }

  /// <summary>
  /// maxStorageGb
  /// </summary>
  [JsonPropertyName("maxStorageGb")]
  public int? MaxStorageGb { get; set; }

  /// <summary>
  /// gateway
  /// </summary>
  [JsonPropertyName("gateway")]
  public int? Gateway { get; set; }

  /// <summary>
  /// gatewayCustomerId
  /// </summary>
  [JsonPropertyName("gatewayCustomerId")]
  public string? GatewayCustomerId { get; set; }

  /// <summary>
  /// gatewaySubscriptionId
  /// </summary>
  [JsonPropertyName("gatewaySubscriptionId")]
  public string? GatewaySubscriptionId { get; set; }

  /// <summary>
  /// referenceData
  /// </summary>
  [JsonPropertyName("referenceData")]
  public string? ReferenceData { get; set; }

  /// <summary>
  /// enabled
  /// </summary>
  [JsonPropertyName("enabled")]
  public bool? Enabled { get; set; }

  /// <summary>
  /// licenseKey
  /// </summary>
  [JsonPropertyName("licenseKey")]
  public string? LicenseKey { get; set; }

  /// <summary>
  /// publicKey
  /// </summary>
  [JsonPropertyName("publicKey")]
  public string? PublicKey { get; set; }

  /// <summary>
  /// privateKey
  /// </summary>
  [JsonPropertyName("privateKey")]
  public string? PrivateKey { get; set; }

  /// <summary>
  /// twoFactorProviders
  /// </summary>
  [JsonPropertyName("twoFactorProviders")]
  public string? TwoFactorProviders { get; set; }

  /// <summary>
  /// expirationDate
  /// </summary>
  [JsonPropertyName("expirationDate")]
  public string? ExpirationDate { get; set; }

  /// <summary>
  /// creationDate
  /// </summary>
  [JsonPropertyName("creationDate")]
  public string? CreationDate { get; set; }

  /// <summary>
  /// revisionDate
  /// </summary>
  [JsonPropertyName("revisionDate")]
  public string? RevisionDate { get; set; }

  /// <summary>
  /// maxAutoscaleSeats
  /// </summary>
  [JsonPropertyName("maxAutoscaleSeats")]
  public int? MaxAutoscaleSeats { get; set; }

  /// <summary>
  /// ownersNotifiedOfAutoscaling
  /// </summary>
  [JsonPropertyName("ownersNotifiedOfAutoscaling")]
  public string? OwnersNotifiedOfAutoscaling { get; set; }

  /// <summary>
  /// status
  /// </summary>
  [JsonPropertyName("status")]
  public int? Status { get; set; }

  /// <summary>
  /// usePasswordManager
  /// </summary>
  [JsonPropertyName("usePasswordManager")]
  public bool? UsePasswordManager { get; set; }

  /// <summary>
  /// smSeats
  /// </summary>
  [JsonPropertyName("smSeats")]
  public int? SmSeats { get; set; }

  /// <summary>
  /// smServiceAccounts
  /// </summary>
  [JsonPropertyName("smServiceAccounts")]
  public int? SmServiceAccounts { get; set; }

  /// <summary>
  /// maxAutoscaleSmSeats
  /// </summary>
  [JsonPropertyName("maxAutoscaleSmSeats")]
  public int? MaxAutoscaleSmSeats { get; set; }

  /// <summary>
  /// maxAutoscaleSmServiceAccounts
  /// </summary>
  [JsonPropertyName("maxAutoscaleSmServiceAccounts")]
  public int? MaxAutoscaleSmServiceAccounts { get; set; }

  /// <summary>
  /// If set to true, only owners, admins, and some custom users can create and delete collections.
  /// If set to false, any organization member can create a collection, and any member can delete a collection that
  /// they have Can Manage permissions for.
  /// </summary>
  [JsonPropertyName("limitCollectionCreation")]
  public bool? LimitCollectionCreation { get; set; }

  /// <summary>
  /// limitCollectionDeletion
  /// </summary>
  [JsonPropertyName("limitCollectionDeletion")]
  public bool? LimitCollectionDeletion { get; set; }

  /// <summary>
  /// If set to true, admins, owners, and some custom users can read/write all collections and items in the Admin Console.
  /// If set to false, users generally need collection-level permissions to read/write a collection or its items.
  /// </summary>
  [JsonPropertyName("allowAdminAccessToAllCollectionItems")]
  public bool? AllowAdminAccessToAllCollectionItems { get; set; }

  /// <summary>
  /// If set to true, members can only delete items when they have a Can Manage permission over the collection.
  /// If set to false, members can delete items when they have a Can Manage OR Can Edit permission over the collection.
  /// </summary>
  [JsonPropertyName("limitItemDeletion")]
  public bool? LimitItemDeletion { get; set; }

  /// <summary>
  /// Risk Insights is a reporting feature that provides insights into the security of an organization&apos;s vault.
  /// </summary>
  [JsonPropertyName("useRiskInsights")]
  public bool? UseRiskInsights { get; set; }

  /// <summary>
  /// If true, the organization can claim domains, which unlocks additional enterprise features
  /// </summary>
  [JsonPropertyName("useOrganizationDomains")]
  public bool? UseOrganizationDomains { get; set; }

  /// <summary>
  /// If set to true, admins can initiate organization-issued sponsorships.
  /// </summary>
  [JsonPropertyName("useAdminSponsoredFamilies")]
  public bool? UseAdminSponsoredFamilies { get; set; }

  /// <summary>
  /// If set to true, organization needs their seat count synced with their subscription
  /// </summary>
  [JsonPropertyName("syncSeats")]
  public bool? SyncSeats { get; set; }

  /// <summary>
  /// If set to true,  user accounts created within the organization are automatically confirmed without requiring additional verification steps.
  /// </summary>
  [JsonPropertyName("useAutomaticUserConfirmation")]
  public bool? UseAutomaticUserConfirmation { get; set; }

  public override string ToQueryString()
  {
    Dictionary<string, object> queryParams = new Dictionary<string, object>();

    if (Id != null)
      queryParams["id"] = Id;
    if (Identifier != null)
      queryParams["identifier"] = Identifier;
    if (Name != null)
      queryParams["name"] = Name;
    if (BusinessName != null)
      queryParams["businessName"] = BusinessName;
    if (BusinessAddress1 != null)
      queryParams["businessAddress1"] = BusinessAddress1;
    if (BusinessAddress2 != null)
      queryParams["businessAddress2"] = BusinessAddress2;
    if (BusinessAddress3 != null)
      queryParams["businessAddress3"] = BusinessAddress3;
    if (BusinessCountry != null)
      queryParams["businessCountry"] = BusinessCountry;
    if (BusinessTaxNumber != null)
      queryParams["businessTaxNumber"] = BusinessTaxNumber;
    if (BillingEmail != null)
      queryParams["billingEmail"] = BillingEmail;
    if (Plan != null)
      queryParams["plan"] = Plan;
    if (PlanType != null)
      queryParams["planType"] = PlanType;
    if (Seats != null)
      queryParams["seats"] = Seats;
    if (MaxCollections != null)
      queryParams["maxCollections"] = MaxCollections;
    if (UsePolicies != null)
      queryParams["usePolicies"] = UsePolicies;
    if (UseSso != null)
      queryParams["useSso"] = UseSso;
    if (UseKeyConnector != null)
      queryParams["useKeyConnector"] = UseKeyConnector;
    if (UseScim != null)
      queryParams["useScim"] = UseScim;
    if (UseGroups != null)
      queryParams["useGroups"] = UseGroups;
    if (UseDirectory != null)
      queryParams["useDirectory"] = UseDirectory;
    if (UseEvents != null)
      queryParams["useEvents"] = UseEvents;
    if (UseTotp != null)
      queryParams["useTotp"] = UseTotp;
    if (Use2Fa != null)
      queryParams["use2fa"] = Use2Fa;
    if (UseApi != null)
      queryParams["useApi"] = UseApi;
    if (UseResetPassword != null)
      queryParams["useResetPassword"] = UseResetPassword;
    if (UseSecretsManager != null)
      queryParams["useSecretsManager"] = UseSecretsManager;
    if (SelfHost != null)
      queryParams["selfHost"] = SelfHost;
    if (UsersGetPremium != null)
      queryParams["usersGetPremium"] = UsersGetPremium;
    if (UseCustomPermissions != null)
      queryParams["useCustomPermissions"] = UseCustomPermissions;
    if (Storage != null)
      queryParams["storage"] = Storage;
    if (MaxStorageGb != null)
      queryParams["maxStorageGb"] = MaxStorageGb;
    if (Gateway != null)
      queryParams["gateway"] = Gateway;
    if (GatewayCustomerId != null)
      queryParams["gatewayCustomerId"] = GatewayCustomerId;
    if (GatewaySubscriptionId != null)
      queryParams["gatewaySubscriptionId"] = GatewaySubscriptionId;
    if (ReferenceData != null)
      queryParams["referenceData"] = ReferenceData;
    if (Enabled != null)
      queryParams["enabled"] = Enabled;
    if (LicenseKey != null)
      queryParams["licenseKey"] = LicenseKey;
    if (PublicKey != null)
      queryParams["publicKey"] = PublicKey;
    if (PrivateKey != null)
      queryParams["privateKey"] = PrivateKey;
    if (TwoFactorProviders != null)
      queryParams["twoFactorProviders"] = TwoFactorProviders;
    if (ExpirationDate != null)
      queryParams["expirationDate"] = ExpirationDate;
    if (CreationDate != null)
      queryParams["creationDate"] = CreationDate;
    if (RevisionDate != null)
      queryParams["revisionDate"] = RevisionDate;
    if (MaxAutoscaleSeats != null)
      queryParams["maxAutoscaleSeats"] = MaxAutoscaleSeats;
    if (OwnersNotifiedOfAutoscaling != null)
      queryParams["ownersNotifiedOfAutoscaling"] = OwnersNotifiedOfAutoscaling;
    if (Status != null)
      queryParams["status"] = Status;
    if (UsePasswordManager != null)
      queryParams["usePasswordManager"] = UsePasswordManager;
    if (SmSeats != null)
      queryParams["smSeats"] = SmSeats;
    if (SmServiceAccounts != null)
      queryParams["smServiceAccounts"] = SmServiceAccounts;
    if (MaxAutoscaleSmSeats != null)
      queryParams["maxAutoscaleSmSeats"] = MaxAutoscaleSmSeats;
    if (MaxAutoscaleSmServiceAccounts != null)
      queryParams["maxAutoscaleSmServiceAccounts"] = MaxAutoscaleSmServiceAccounts;
    if (LimitCollectionCreation != null)
      queryParams["limitCollectionCreation"] = LimitCollectionCreation;
    if (LimitCollectionDeletion != null)
      queryParams["limitCollectionDeletion"] = LimitCollectionDeletion;
    if (AllowAdminAccessToAllCollectionItems != null)
      queryParams["allowAdminAccessToAllCollectionItems"] = AllowAdminAccessToAllCollectionItems;
    if (LimitItemDeletion != null)
      queryParams["limitItemDeletion"] = LimitItemDeletion;
    if (UseRiskInsights != null)
      queryParams["useRiskInsights"] = UseRiskInsights;
    if (UseOrganizationDomains != null)
      queryParams["useOrganizationDomains"] = UseOrganizationDomains;
    if (UseAdminSponsoredFamilies != null)
      queryParams["useAdminSponsoredFamilies"] = UseAdminSponsoredFamilies;
    if (SyncSeats != null)
      queryParams["syncSeats"] = SyncSeats;
    if (UseAutomaticUserConfirmation != null)
      queryParams["useAutomaticUserConfirmation"] = UseAutomaticUserConfirmation;

    return queryParams.ToQueryString();
  }
}
