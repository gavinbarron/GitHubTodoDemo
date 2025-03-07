using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class DeviceAppManagement : Entity, IParsable {
        /// <summary>Android managed app policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AndroidManagedAppProtection>? AndroidManagedAppProtections { get; set; }
#nullable restore
#else
        public List<AndroidManagedAppProtection> AndroidManagedAppProtections { get; set; }
#endif
        /// <summary>Default managed app policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DefaultManagedAppProtection>? DefaultManagedAppProtections { get; set; }
#nullable restore
#else
        public List<DefaultManagedAppProtection> DefaultManagedAppProtections { get; set; }
#endif
        /// <summary>iOS managed app policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IosManagedAppProtection>? IosManagedAppProtections { get; set; }
#nullable restore
#else
        public List<IosManagedAppProtection> IosManagedAppProtections { get; set; }
#endif
        /// <summary>Whether the account is enabled for syncing applications from the Microsoft Store for Business.</summary>
        public bool? IsEnabledForMicrosoftStoreForBusiness { get; set; }
        /// <summary>Managed app policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedAppPolicy>? ManagedAppPolicies { get; set; }
#nullable restore
#else
        public List<ManagedAppPolicy> ManagedAppPolicies { get; set; }
#endif
        /// <summary>The managed app registrations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedAppRegistration>? ManagedAppRegistrations { get; set; }
#nullable restore
#else
        public List<ManagedAppRegistration> ManagedAppRegistrations { get; set; }
#endif
        /// <summary>The managed app statuses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedAppStatus>? ManagedAppStatuses { get; set; }
#nullable restore
#else
        public List<ManagedAppStatus> ManagedAppStatuses { get; set; }
#endif
        /// <summary>The Managed eBook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedEBook>? ManagedEBooks { get; set; }
#nullable restore
#else
        public List<ManagedEBook> ManagedEBooks { get; set; }
#endif
        /// <summary>Windows information protection for apps running on devices which are MDM enrolled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MdmWindowsInformationProtectionPolicy>? MdmWindowsInformationProtectionPolicies { get; set; }
#nullable restore
#else
        public List<MdmWindowsInformationProtectionPolicy> MdmWindowsInformationProtectionPolicies { get; set; }
#endif
        /// <summary>The locale information used to sync applications from the Microsoft Store for Business. Cultures that are specific to a country/region. The names of these cultures follow RFC 4646 (Windows Vista and later). The format is -&lt;country/regioncode2&gt;, where  is a lowercase two-letter code derived from ISO 639-1 and &lt;country/regioncode2&gt; is an uppercase two-letter code derived from ISO 3166. For example, en-US for English (United States) is a specific culture.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MicrosoftStoreForBusinessLanguage { get; set; }
#nullable restore
#else
        public string MicrosoftStoreForBusinessLanguage { get; set; }
#endif
        /// <summary>The last time an application sync from the Microsoft Store for Business was completed.</summary>
        public DateTimeOffset? MicrosoftStoreForBusinessLastCompletedApplicationSyncTime { get; set; }
        /// <summary>The last time the apps from the Microsoft Store for Business were synced successfully for the account.</summary>
        public DateTimeOffset? MicrosoftStoreForBusinessLastSuccessfulSyncDateTime { get; set; }
        /// <summary>The mobile app categories.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MobileAppCategory>? MobileAppCategories { get; set; }
#nullable restore
#else
        public List<MobileAppCategory> MobileAppCategories { get; set; }
#endif
        /// <summary>The Managed Device Mobile Application Configurations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedDeviceMobileAppConfiguration>? MobileAppConfigurations { get; set; }
#nullable restore
#else
        public List<ManagedDeviceMobileAppConfiguration> MobileAppConfigurations { get; set; }
#endif
        /// <summary>The mobile apps.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MobileApp>? MobileApps { get; set; }
#nullable restore
#else
        public List<MobileApp> MobileApps { get; set; }
#endif
        /// <summary>Targeted managed app configurations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TargetedManagedAppConfiguration>? TargetedManagedAppConfigurations { get; set; }
#nullable restore
#else
        public List<TargetedManagedAppConfiguration> TargetedManagedAppConfigurations { get; set; }
#endif
        /// <summary>List of Vpp tokens for this organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<VppToken>? VppTokens { get; set; }
#nullable restore
#else
        public List<VppToken> VppTokens { get; set; }
#endif
        /// <summary>Windows information protection for apps running on devices which are not MDM enrolled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WindowsInformationProtectionPolicy>? WindowsInformationProtectionPolicies { get; set; }
#nullable restore
#else
        public List<WindowsInformationProtectionPolicy> WindowsInformationProtectionPolicies { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceAppManagement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceAppManagement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"androidManagedAppProtections", n => { AndroidManagedAppProtections = n.GetCollectionOfObjectValues<AndroidManagedAppProtection>(AndroidManagedAppProtection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"defaultManagedAppProtections", n => { DefaultManagedAppProtections = n.GetCollectionOfObjectValues<DefaultManagedAppProtection>(DefaultManagedAppProtection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"iosManagedAppProtections", n => { IosManagedAppProtections = n.GetCollectionOfObjectValues<IosManagedAppProtection>(IosManagedAppProtection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isEnabledForMicrosoftStoreForBusiness", n => { IsEnabledForMicrosoftStoreForBusiness = n.GetBoolValue(); } },
                {"managedAppPolicies", n => { ManagedAppPolicies = n.GetCollectionOfObjectValues<ManagedAppPolicy>(ManagedAppPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedAppRegistrations", n => { ManagedAppRegistrations = n.GetCollectionOfObjectValues<ManagedAppRegistration>(ManagedAppRegistration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedAppStatuses", n => { ManagedAppStatuses = n.GetCollectionOfObjectValues<ManagedAppStatus>(ManagedAppStatus.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedEBooks", n => { ManagedEBooks = n.GetCollectionOfObjectValues<ManagedEBook>(ManagedEBook.CreateFromDiscriminatorValue)?.ToList(); } },
                {"mdmWindowsInformationProtectionPolicies", n => { MdmWindowsInformationProtectionPolicies = n.GetCollectionOfObjectValues<MdmWindowsInformationProtectionPolicy>(MdmWindowsInformationProtectionPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"microsoftStoreForBusinessLanguage", n => { MicrosoftStoreForBusinessLanguage = n.GetStringValue(); } },
                {"microsoftStoreForBusinessLastCompletedApplicationSyncTime", n => { MicrosoftStoreForBusinessLastCompletedApplicationSyncTime = n.GetDateTimeOffsetValue(); } },
                {"microsoftStoreForBusinessLastSuccessfulSyncDateTime", n => { MicrosoftStoreForBusinessLastSuccessfulSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"mobileAppCategories", n => { MobileAppCategories = n.GetCollectionOfObjectValues<MobileAppCategory>(MobileAppCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"mobileAppConfigurations", n => { MobileAppConfigurations = n.GetCollectionOfObjectValues<ManagedDeviceMobileAppConfiguration>(ManagedDeviceMobileAppConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"mobileApps", n => { MobileApps = n.GetCollectionOfObjectValues<MobileApp>(MobileApp.CreateFromDiscriminatorValue)?.ToList(); } },
                {"targetedManagedAppConfigurations", n => { TargetedManagedAppConfigurations = n.GetCollectionOfObjectValues<TargetedManagedAppConfiguration>(TargetedManagedAppConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"vppTokens", n => { VppTokens = n.GetCollectionOfObjectValues<VppToken>(VppToken.CreateFromDiscriminatorValue)?.ToList(); } },
                {"windowsInformationProtectionPolicies", n => { WindowsInformationProtectionPolicies = n.GetCollectionOfObjectValues<WindowsInformationProtectionPolicy>(WindowsInformationProtectionPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AndroidManagedAppProtection>("androidManagedAppProtections", AndroidManagedAppProtections);
            writer.WriteCollectionOfObjectValues<DefaultManagedAppProtection>("defaultManagedAppProtections", DefaultManagedAppProtections);
            writer.WriteCollectionOfObjectValues<IosManagedAppProtection>("iosManagedAppProtections", IosManagedAppProtections);
            writer.WriteBoolValue("isEnabledForMicrosoftStoreForBusiness", IsEnabledForMicrosoftStoreForBusiness);
            writer.WriteCollectionOfObjectValues<ManagedAppPolicy>("managedAppPolicies", ManagedAppPolicies);
            writer.WriteCollectionOfObjectValues<ManagedAppRegistration>("managedAppRegistrations", ManagedAppRegistrations);
            writer.WriteCollectionOfObjectValues<ManagedAppStatus>("managedAppStatuses", ManagedAppStatuses);
            writer.WriteCollectionOfObjectValues<ManagedEBook>("managedEBooks", ManagedEBooks);
            writer.WriteCollectionOfObjectValues<MdmWindowsInformationProtectionPolicy>("mdmWindowsInformationProtectionPolicies", MdmWindowsInformationProtectionPolicies);
            writer.WriteStringValue("microsoftStoreForBusinessLanguage", MicrosoftStoreForBusinessLanguage);
            writer.WriteDateTimeOffsetValue("microsoftStoreForBusinessLastCompletedApplicationSyncTime", MicrosoftStoreForBusinessLastCompletedApplicationSyncTime);
            writer.WriteDateTimeOffsetValue("microsoftStoreForBusinessLastSuccessfulSyncDateTime", MicrosoftStoreForBusinessLastSuccessfulSyncDateTime);
            writer.WriteCollectionOfObjectValues<MobileAppCategory>("mobileAppCategories", MobileAppCategories);
            writer.WriteCollectionOfObjectValues<ManagedDeviceMobileAppConfiguration>("mobileAppConfigurations", MobileAppConfigurations);
            writer.WriteCollectionOfObjectValues<MobileApp>("mobileApps", MobileApps);
            writer.WriteCollectionOfObjectValues<TargetedManagedAppConfiguration>("targetedManagedAppConfigurations", TargetedManagedAppConfigurations);
            writer.WriteCollectionOfObjectValues<VppToken>("vppTokens", VppTokens);
            writer.WriteCollectionOfObjectValues<WindowsInformationProtectionPolicy>("windowsInformationProtectionPolicies", WindowsInformationProtectionPolicies);
        }
    }
}
