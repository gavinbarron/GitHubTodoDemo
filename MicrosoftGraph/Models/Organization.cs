using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class Organization : DirectoryObject, IParsable {
        /// <summary>The collection of service plans associated with the tenant. Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AssignedPlan>? AssignedPlans { get; set; }
#nullable restore
#else
        public List<AssignedPlan> AssignedPlans { get; set; }
#endif
        /// <summary>Branding for the organization. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public OrganizationalBranding? Branding { get; set; }
#nullable restore
#else
        public OrganizationalBranding Branding { get; set; }
#endif
        /// <summary>Telephone number for the organization. Although this is a string collection, only one number can be set for this property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? BusinessPhones { get; set; }
#nullable restore
#else
        public List<string> BusinessPhones { get; set; }
#endif
        /// <summary>Navigation property to manage certificate-based authentication configuration. Only a single instance of certificateBasedAuthConfiguration can be created in the collection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GitHubTodoDemo.MicrosoftGraph.Models.CertificateBasedAuthConfiguration>? CertificateBasedAuthConfiguration { get; set; }
#nullable restore
#else
        public List<GitHubTodoDemo.MicrosoftGraph.Models.CertificateBasedAuthConfiguration> CertificateBasedAuthConfiguration { get; set; }
#endif
        /// <summary>City name of the address for the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? City { get; set; }
#nullable restore
#else
        public string City { get; set; }
#endif
        /// <summary>Country/region name of the address for the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Country { get; set; }
#nullable restore
#else
        public string Country { get; set; }
#endif
        /// <summary>Country or region abbreviation for the organization in ISO 3166-2 format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryLetterCode { get; set; }
#nullable restore
#else
        public string CountryLetterCode { get; set; }
#endif
        /// <summary>Timestamp of when the organization was created. The value cannot be modified and is automatically populated when the organization is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Two-letter ISO 3166 country code indicating the default service usage location of an organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultUsageLocation { get; set; }
#nullable restore
#else
        public string DefaultUsageLocation { get; set; }
#endif
        /// <summary>The display name for the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The collection of open extensions defined for the organization. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Extension>? Extensions { get; set; }
#nullable restore
#else
        public List<Extension> Extensions { get; set; }
#endif
        /// <summary>Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MarketingNotificationEmails { get; set; }
#nullable restore
#else
        public List<string> MarketingNotificationEmails { get; set; }
#endif
        /// <summary>Mobile device management authority.</summary>
        public MdmAuthority? MobileDeviceManagementAuthority { get; set; }
        /// <summary>The time and date at which the tenant was last synced with the on-premises directory. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }
        /// <summary>true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced. Nullable. null if this object has never been synced from an on-premises directory (default).</summary>
        public bool? OnPremisesSyncEnabled { get; set; }
        /// <summary>The partnerTenantType property</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.PartnerTenantType? PartnerTenantType { get; set; }
        /// <summary>Postal code of the address for the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PostalCode { get; set; }
#nullable restore
#else
        public string PostalCode { get; set; }
#endif
        /// <summary>The preferred language for the organization. Should follow ISO 639-1 Code; for example, en.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreferredLanguage { get; set; }
#nullable restore
#else
        public string PreferredLanguage { get; set; }
#endif
        /// <summary>The privacy profile of an organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.PrivacyProfile? PrivacyProfile { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.PrivacyProfile PrivacyProfile { get; set; }
#endif
        /// <summary>Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ProvisionedPlan>? ProvisionedPlans { get; set; }
#nullable restore
#else
        public List<ProvisionedPlan> ProvisionedPlans { get; set; }
#endif
        /// <summary>The securityComplianceNotificationMails property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SecurityComplianceNotificationMails { get; set; }
#nullable restore
#else
        public List<string> SecurityComplianceNotificationMails { get; set; }
#endif
        /// <summary>The securityComplianceNotificationPhones property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SecurityComplianceNotificationPhones { get; set; }
#nullable restore
#else
        public List<string> SecurityComplianceNotificationPhones { get; set; }
#endif
        /// <summary>State name of the address for the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
#endif
        /// <summary>Street name of the address for organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Street { get; set; }
#nullable restore
#else
        public string Street { get; set; }
#endif
        /// <summary>Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? TechnicalNotificationMails { get; set; }
#nullable restore
#else
        public List<string> TechnicalNotificationMails { get; set; }
#endif
        /// <summary>The tenantType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantType { get; set; }
#nullable restore
#else
        public string TenantType { get; set; }
#endif
        /// <summary>The collection of domains associated with this tenant. Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<VerifiedDomain>? VerifiedDomains { get; set; }
#nullable restore
#else
        public List<VerifiedDomain> VerifiedDomains { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Organization and sets the default values.
        /// </summary>
        public Organization() : base() {
            OdataType = "#microsoft.graph.organization";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Organization CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Organization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignedPlans", n => { AssignedPlans = n.GetCollectionOfObjectValues<AssignedPlan>(AssignedPlan.CreateFromDiscriminatorValue)?.ToList(); } },
                {"branding", n => { Branding = n.GetObjectValue<OrganizationalBranding>(OrganizationalBranding.CreateFromDiscriminatorValue); } },
                {"businessPhones", n => { BusinessPhones = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"certificateBasedAuthConfiguration", n => { CertificateBasedAuthConfiguration = n.GetCollectionOfObjectValues<GitHubTodoDemo.MicrosoftGraph.Models.CertificateBasedAuthConfiguration>(GitHubTodoDemo.MicrosoftGraph.Models.CertificateBasedAuthConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"city", n => { City = n.GetStringValue(); } },
                {"country", n => { Country = n.GetStringValue(); } },
                {"countryLetterCode", n => { CountryLetterCode = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"defaultUsageLocation", n => { DefaultUsageLocation = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue)?.ToList(); } },
                {"marketingNotificationEmails", n => { MarketingNotificationEmails = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"mobileDeviceManagementAuthority", n => { MobileDeviceManagementAuthority = n.GetEnumValue<MdmAuthority>(); } },
                {"onPremisesLastSyncDateTime", n => { OnPremisesLastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"onPremisesSyncEnabled", n => { OnPremisesSyncEnabled = n.GetBoolValue(); } },
                {"partnerTenantType", n => { PartnerTenantType = n.GetEnumValue<PartnerTenantType>(); } },
                {"postalCode", n => { PostalCode = n.GetStringValue(); } },
                {"preferredLanguage", n => { PreferredLanguage = n.GetStringValue(); } },
                {"privacyProfile", n => { PrivacyProfile = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.PrivacyProfile>(GitHubTodoDemo.MicrosoftGraph.Models.PrivacyProfile.CreateFromDiscriminatorValue); } },
                {"provisionedPlans", n => { ProvisionedPlans = n.GetCollectionOfObjectValues<ProvisionedPlan>(ProvisionedPlan.CreateFromDiscriminatorValue)?.ToList(); } },
                {"securityComplianceNotificationMails", n => { SecurityComplianceNotificationMails = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"securityComplianceNotificationPhones", n => { SecurityComplianceNotificationPhones = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"state", n => { State = n.GetStringValue(); } },
                {"street", n => { Street = n.GetStringValue(); } },
                {"technicalNotificationMails", n => { TechnicalNotificationMails = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"tenantType", n => { TenantType = n.GetStringValue(); } },
                {"verifiedDomains", n => { VerifiedDomains = n.GetCollectionOfObjectValues<VerifiedDomain>(VerifiedDomain.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AssignedPlan>("assignedPlans", AssignedPlans);
            writer.WriteObjectValue<OrganizationalBranding>("branding", Branding);
            writer.WriteCollectionOfPrimitiveValues<string>("businessPhones", BusinessPhones);
            writer.WriteCollectionOfObjectValues<GitHubTodoDemo.MicrosoftGraph.Models.CertificateBasedAuthConfiguration>("certificateBasedAuthConfiguration", CertificateBasedAuthConfiguration);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("country", Country);
            writer.WriteStringValue("countryLetterCode", CountryLetterCode);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("defaultUsageLocation", DefaultUsageLocation);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteCollectionOfPrimitiveValues<string>("marketingNotificationEmails", MarketingNotificationEmails);
            writer.WriteEnumValue<MdmAuthority>("mobileDeviceManagementAuthority", MobileDeviceManagementAuthority);
            writer.WriteDateTimeOffsetValue("onPremisesLastSyncDateTime", OnPremisesLastSyncDateTime);
            writer.WriteBoolValue("onPremisesSyncEnabled", OnPremisesSyncEnabled);
            writer.WriteEnumValue<PartnerTenantType>("partnerTenantType", PartnerTenantType);
            writer.WriteStringValue("postalCode", PostalCode);
            writer.WriteStringValue("preferredLanguage", PreferredLanguage);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.PrivacyProfile>("privacyProfile", PrivacyProfile);
            writer.WriteCollectionOfObjectValues<ProvisionedPlan>("provisionedPlans", ProvisionedPlans);
            writer.WriteCollectionOfPrimitiveValues<string>("securityComplianceNotificationMails", SecurityComplianceNotificationMails);
            writer.WriteCollectionOfPrimitiveValues<string>("securityComplianceNotificationPhones", SecurityComplianceNotificationPhones);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("street", Street);
            writer.WriteCollectionOfPrimitiveValues<string>("technicalNotificationMails", TechnicalNotificationMails);
            writer.WriteStringValue("tenantType", TenantType);
            writer.WriteCollectionOfObjectValues<VerifiedDomain>("verifiedDomains", VerifiedDomains);
        }
    }
}
