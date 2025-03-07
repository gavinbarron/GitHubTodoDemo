using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class AndroidManagedAppProtection : TargetedManagedAppProtection, IParsable {
        /// <summary>List of apps to which the policy is deployed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedMobileApp>? Apps { get; set; }
#nullable restore
#else
        public List<ManagedMobileApp> Apps { get; set; }
#endif
        /// <summary>Friendly name of the preferred custom browser to open weblink on Android. When this property is configured, ManagedBrowserToOpenLinksRequired should be true.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomBrowserDisplayName { get; set; }
#nullable restore
#else
        public string CustomBrowserDisplayName { get; set; }
#endif
        /// <summary>Unique identifier of the preferred custom browser to open weblink on Android. When this property is configured, ManagedBrowserToOpenLinksRequired should be true.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomBrowserPackageId { get; set; }
#nullable restore
#else
        public string CustomBrowserPackageId { get; set; }
#endif
        /// <summary>Count of apps to which the current policy is deployed.</summary>
        public int? DeployedAppCount { get; set; }
        /// <summary>Navigation property to deployment summary of the configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ManagedAppPolicyDeploymentSummary? DeploymentSummary { get; set; }
#nullable restore
#else
        public ManagedAppPolicyDeploymentSummary DeploymentSummary { get; set; }
#endif
        /// <summary>When this setting is enabled, app level encryption is disabled if device level encryption is enabled</summary>
        public bool? DisableAppEncryptionIfDeviceEncryptionIsEnabled { get; set; }
        /// <summary>Indicates whether application data for managed apps should be encrypted</summary>
        public bool? EncryptAppData { get; set; }
        /// <summary>Define the oldest required Android security patch level a user can have to gain secure access to the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumRequiredPatchVersion { get; set; }
#nullable restore
#else
        public string MinimumRequiredPatchVersion { get; set; }
#endif
        /// <summary>Define the oldest recommended Android security patch level a user can have for secure access to the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MinimumWarningPatchVersion { get; set; }
#nullable restore
#else
        public string MinimumWarningPatchVersion { get; set; }
#endif
        /// <summary>Indicates whether a managed user can take screen captures of managed apps</summary>
        public bool? ScreenCaptureBlocked { get; set; }
        /// <summary>
        /// Instantiates a new AndroidManagedAppProtection and sets the default values.
        /// </summary>
        public AndroidManagedAppProtection() : base() {
            OdataType = "#microsoft.graph.androidManagedAppProtection";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidManagedAppProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidManagedAppProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"apps", n => { Apps = n.GetCollectionOfObjectValues<ManagedMobileApp>(ManagedMobileApp.CreateFromDiscriminatorValue)?.ToList(); } },
                {"customBrowserDisplayName", n => { CustomBrowserDisplayName = n.GetStringValue(); } },
                {"customBrowserPackageId", n => { CustomBrowserPackageId = n.GetStringValue(); } },
                {"deployedAppCount", n => { DeployedAppCount = n.GetIntValue(); } },
                {"deploymentSummary", n => { DeploymentSummary = n.GetObjectValue<ManagedAppPolicyDeploymentSummary>(ManagedAppPolicyDeploymentSummary.CreateFromDiscriminatorValue); } },
                {"disableAppEncryptionIfDeviceEncryptionIsEnabled", n => { DisableAppEncryptionIfDeviceEncryptionIsEnabled = n.GetBoolValue(); } },
                {"encryptAppData", n => { EncryptAppData = n.GetBoolValue(); } },
                {"minimumRequiredPatchVersion", n => { MinimumRequiredPatchVersion = n.GetStringValue(); } },
                {"minimumWarningPatchVersion", n => { MinimumWarningPatchVersion = n.GetStringValue(); } },
                {"screenCaptureBlocked", n => { ScreenCaptureBlocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ManagedMobileApp>("apps", Apps);
            writer.WriteStringValue("customBrowserDisplayName", CustomBrowserDisplayName);
            writer.WriteStringValue("customBrowserPackageId", CustomBrowserPackageId);
            writer.WriteIntValue("deployedAppCount", DeployedAppCount);
            writer.WriteObjectValue<ManagedAppPolicyDeploymentSummary>("deploymentSummary", DeploymentSummary);
            writer.WriteBoolValue("disableAppEncryptionIfDeviceEncryptionIsEnabled", DisableAppEncryptionIfDeviceEncryptionIsEnabled);
            writer.WriteBoolValue("encryptAppData", EncryptAppData);
            writer.WriteStringValue("minimumRequiredPatchVersion", MinimumRequiredPatchVersion);
            writer.WriteStringValue("minimumWarningPatchVersion", MinimumWarningPatchVersion);
            writer.WriteBoolValue("screenCaptureBlocked", ScreenCaptureBlocked);
        }
    }
}
