using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class AndroidCompliancePolicy : DeviceCompliancePolicy, IParsable {
        /// <summary>Require that devices have enabled device threat protection.</summary>
        public bool? DeviceThreatProtectionEnabled { get; set; }
        /// <summary>Device threat protection levels for the Device Threat Protection API.</summary>
        public DeviceThreatProtectionLevel? DeviceThreatProtectionRequiredSecurityLevel { get; set; }
        /// <summary>Minimum Android security patch level.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinAndroidSecurityPatchLevel { get; set; }
#nullable restore
#else
        public string MinAndroidSecurityPatchLevel { get; set; }
#endif
        /// <summary>Maximum Android version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsMaximumVersion { get; set; }
#nullable restore
#else
        public string OsMaximumVersion { get; set; }
#endif
        /// <summary>Minimum Android version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsMinimumVersion { get; set; }
#nullable restore
#else
        public string OsMinimumVersion { get; set; }
#endif
        /// <summary>Number of days before the password expires. Valid values 1 to 365</summary>
        public int? PasswordExpirationDays { get; set; }
        /// <summary>Minimum password length. Valid values 4 to 16</summary>
        public int? PasswordMinimumLength { get; set; }
        /// <summary>Minutes of inactivity before a password is required.</summary>
        public int? PasswordMinutesOfInactivityBeforeLock { get; set; }
        /// <summary>Number of previous passwords to block. Valid values 1 to 24</summary>
        public int? PasswordPreviousPasswordBlockCount { get; set; }
        /// <summary>Require a password to unlock device.</summary>
        public bool? PasswordRequired { get; set; }
        /// <summary>Android required password type.</summary>
        public AndroidRequiredPasswordType? PasswordRequiredType { get; set; }
        /// <summary>Devices must not be jailbroken or rooted.</summary>
        public bool? SecurityBlockJailbrokenDevices { get; set; }
        /// <summary>Disable USB debugging on Android devices.</summary>
        public bool? SecurityDisableUsbDebugging { get; set; }
        /// <summary>Require that devices disallow installation of apps from unknown sources.</summary>
        public bool? SecurityPreventInstallAppsFromUnknownSources { get; set; }
        /// <summary>Require the device to pass the Company Portal client app runtime integrity check.</summary>
        public bool? SecurityRequireCompanyPortalAppIntegrity { get; set; }
        /// <summary>Require Google Play Services to be installed and enabled on the device.</summary>
        public bool? SecurityRequireGooglePlayServices { get; set; }
        /// <summary>Require the device to pass the SafetyNet basic integrity check.</summary>
        public bool? SecurityRequireSafetyNetAttestationBasicIntegrity { get; set; }
        /// <summary>Require the device to pass the SafetyNet certified device check.</summary>
        public bool? SecurityRequireSafetyNetAttestationCertifiedDevice { get; set; }
        /// <summary>Require the device to have up to date security providers. The device will require Google Play Services to be enabled and up to date.</summary>
        public bool? SecurityRequireUpToDateSecurityProviders { get; set; }
        /// <summary>Require the Android Verify apps feature is turned on.</summary>
        public bool? SecurityRequireVerifyApps { get; set; }
        /// <summary>Require encryption on Android devices.</summary>
        public bool? StorageRequireEncryption { get; set; }
        /// <summary>
        /// Instantiates a new AndroidCompliancePolicy and sets the default values.
        /// </summary>
        public AndroidCompliancePolicy() : base() {
            OdataType = "#microsoft.graph.androidCompliancePolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidCompliancePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidCompliancePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceThreatProtectionEnabled", n => { DeviceThreatProtectionEnabled = n.GetBoolValue(); } },
                {"deviceThreatProtectionRequiredSecurityLevel", n => { DeviceThreatProtectionRequiredSecurityLevel = n.GetEnumValue<DeviceThreatProtectionLevel>(); } },
                {"minAndroidSecurityPatchLevel", n => { MinAndroidSecurityPatchLevel = n.GetStringValue(); } },
                {"osMaximumVersion", n => { OsMaximumVersion = n.GetStringValue(); } },
                {"osMinimumVersion", n => { OsMinimumVersion = n.GetStringValue(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeLock", n => { PasswordMinutesOfInactivityBeforeLock = n.GetIntValue(); } },
                {"passwordPreviousPasswordBlockCount", n => { PasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                {"passwordRequired", n => { PasswordRequired = n.GetBoolValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<AndroidRequiredPasswordType>(); } },
                {"securityBlockJailbrokenDevices", n => { SecurityBlockJailbrokenDevices = n.GetBoolValue(); } },
                {"securityDisableUsbDebugging", n => { SecurityDisableUsbDebugging = n.GetBoolValue(); } },
                {"securityPreventInstallAppsFromUnknownSources", n => { SecurityPreventInstallAppsFromUnknownSources = n.GetBoolValue(); } },
                {"securityRequireCompanyPortalAppIntegrity", n => { SecurityRequireCompanyPortalAppIntegrity = n.GetBoolValue(); } },
                {"securityRequireGooglePlayServices", n => { SecurityRequireGooglePlayServices = n.GetBoolValue(); } },
                {"securityRequireSafetyNetAttestationBasicIntegrity", n => { SecurityRequireSafetyNetAttestationBasicIntegrity = n.GetBoolValue(); } },
                {"securityRequireSafetyNetAttestationCertifiedDevice", n => { SecurityRequireSafetyNetAttestationCertifiedDevice = n.GetBoolValue(); } },
                {"securityRequireUpToDateSecurityProviders", n => { SecurityRequireUpToDateSecurityProviders = n.GetBoolValue(); } },
                {"securityRequireVerifyApps", n => { SecurityRequireVerifyApps = n.GetBoolValue(); } },
                {"storageRequireEncryption", n => { StorageRequireEncryption = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("deviceThreatProtectionEnabled", DeviceThreatProtectionEnabled);
            writer.WriteEnumValue<DeviceThreatProtectionLevel>("deviceThreatProtectionRequiredSecurityLevel", DeviceThreatProtectionRequiredSecurityLevel);
            writer.WriteStringValue("minAndroidSecurityPatchLevel", MinAndroidSecurityPatchLevel);
            writer.WriteStringValue("osMaximumVersion", OsMaximumVersion);
            writer.WriteStringValue("osMinimumVersion", OsMinimumVersion);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeLock", PasswordMinutesOfInactivityBeforeLock);
            writer.WriteIntValue("passwordPreviousPasswordBlockCount", PasswordPreviousPasswordBlockCount);
            writer.WriteBoolValue("passwordRequired", PasswordRequired);
            writer.WriteEnumValue<AndroidRequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteBoolValue("securityBlockJailbrokenDevices", SecurityBlockJailbrokenDevices);
            writer.WriteBoolValue("securityDisableUsbDebugging", SecurityDisableUsbDebugging);
            writer.WriteBoolValue("securityPreventInstallAppsFromUnknownSources", SecurityPreventInstallAppsFromUnknownSources);
            writer.WriteBoolValue("securityRequireCompanyPortalAppIntegrity", SecurityRequireCompanyPortalAppIntegrity);
            writer.WriteBoolValue("securityRequireGooglePlayServices", SecurityRequireGooglePlayServices);
            writer.WriteBoolValue("securityRequireSafetyNetAttestationBasicIntegrity", SecurityRequireSafetyNetAttestationBasicIntegrity);
            writer.WriteBoolValue("securityRequireSafetyNetAttestationCertifiedDevice", SecurityRequireSafetyNetAttestationCertifiedDevice);
            writer.WriteBoolValue("securityRequireUpToDateSecurityProviders", SecurityRequireUpToDateSecurityProviders);
            writer.WriteBoolValue("securityRequireVerifyApps", SecurityRequireVerifyApps);
            writer.WriteBoolValue("storageRequireEncryption", StorageRequireEncryption);
        }
    }
}
