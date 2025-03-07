using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>
    /// Device Configuration.
    /// </summary>
    public class DeviceConfiguration : Entity, IParsable {
        /// <summary>The list of assignments for the device configuration profile.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceConfigurationAssignment>? Assignments { get; set; }
#nullable restore
#else
        public List<DeviceConfigurationAssignment> Assignments { get; set; }
#endif
        /// <summary>DateTime the object was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Admin provided description of the Device Configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Device Configuration Setting State Device Summary</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SettingStateDeviceSummary>? DeviceSettingStateSummaries { get; set; }
#nullable restore
#else
        public List<SettingStateDeviceSummary> DeviceSettingStateSummaries { get; set; }
#endif
        /// <summary>Device configuration installation status by device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceConfigurationDeviceStatus>? DeviceStatuses { get; set; }
#nullable restore
#else
        public List<DeviceConfigurationDeviceStatus> DeviceStatuses { get; set; }
#endif
        /// <summary>Device Configuration devices status overview</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceConfigurationDeviceOverview? DeviceStatusOverview { get; set; }
#nullable restore
#else
        public DeviceConfigurationDeviceOverview DeviceStatusOverview { get; set; }
#endif
        /// <summary>Admin provided name of the device configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>DateTime the object was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Device configuration installation status by user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceConfigurationUserStatus>? UserStatuses { get; set; }
#nullable restore
#else
        public List<DeviceConfigurationUserStatus> UserStatuses { get; set; }
#endif
        /// <summary>Device Configuration users status overview</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceConfigurationUserOverview? UserStatusOverview { get; set; }
#nullable restore
#else
        public DeviceConfigurationUserOverview UserStatusOverview { get; set; }
#endif
        /// <summary>Version of the device configuration.</summary>
        public int? Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.androidCustomConfiguration" => new AndroidCustomConfiguration(),
                "#microsoft.graph.androidGeneralDeviceConfiguration" => new AndroidGeneralDeviceConfiguration(),
                "#microsoft.graph.androidWorkProfileCustomConfiguration" => new AndroidWorkProfileCustomConfiguration(),
                "#microsoft.graph.androidWorkProfileGeneralDeviceConfiguration" => new AndroidWorkProfileGeneralDeviceConfiguration(),
                "#microsoft.graph.appleDeviceFeaturesConfigurationBase" => new AppleDeviceFeaturesConfigurationBase(),
                "#microsoft.graph.editionUpgradeConfiguration" => new EditionUpgradeConfiguration(),
                "#microsoft.graph.iosCertificateProfile" => new IosCertificateProfile(),
                "#microsoft.graph.iosCustomConfiguration" => new IosCustomConfiguration(),
                "#microsoft.graph.iosDeviceFeaturesConfiguration" => new IosDeviceFeaturesConfiguration(),
                "#microsoft.graph.iosGeneralDeviceConfiguration" => new IosGeneralDeviceConfiguration(),
                "#microsoft.graph.iosUpdateConfiguration" => new IosUpdateConfiguration(),
                "#microsoft.graph.macOSCustomConfiguration" => new MacOSCustomConfiguration(),
                "#microsoft.graph.macOSDeviceFeaturesConfiguration" => new MacOSDeviceFeaturesConfiguration(),
                "#microsoft.graph.macOSGeneralDeviceConfiguration" => new MacOSGeneralDeviceConfiguration(),
                "#microsoft.graph.sharedPCConfiguration" => new SharedPCConfiguration(),
                "#microsoft.graph.windows10CustomConfiguration" => new Windows10CustomConfiguration(),
                "#microsoft.graph.windows10EndpointProtectionConfiguration" => new Windows10EndpointProtectionConfiguration(),
                "#microsoft.graph.windows10EnterpriseModernAppManagementConfiguration" => new Windows10EnterpriseModernAppManagementConfiguration(),
                "#microsoft.graph.windows10GeneralConfiguration" => new Windows10GeneralConfiguration(),
                "#microsoft.graph.windows10SecureAssessmentConfiguration" => new Windows10SecureAssessmentConfiguration(),
                "#microsoft.graph.windows10TeamGeneralConfiguration" => new Windows10TeamGeneralConfiguration(),
                "#microsoft.graph.windows81GeneralConfiguration" => new Windows81GeneralConfiguration(),
                "#microsoft.graph.windowsDefenderAdvancedThreatProtectionConfiguration" => new WindowsDefenderAdvancedThreatProtectionConfiguration(),
                "#microsoft.graph.windowsPhone81CustomConfiguration" => new WindowsPhone81CustomConfiguration(),
                "#microsoft.graph.windowsPhone81GeneralConfiguration" => new WindowsPhone81GeneralConfiguration(),
                "#microsoft.graph.windowsUpdateForBusinessConfiguration" => new WindowsUpdateForBusinessConfiguration(),
                _ => new DeviceConfiguration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<DeviceConfigurationAssignment>(DeviceConfigurationAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"deviceSettingStateSummaries", n => { DeviceSettingStateSummaries = n.GetCollectionOfObjectValues<SettingStateDeviceSummary>(SettingStateDeviceSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceStatuses", n => { DeviceStatuses = n.GetCollectionOfObjectValues<DeviceConfigurationDeviceStatus>(DeviceConfigurationDeviceStatus.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceStatusOverview", n => { DeviceStatusOverview = n.GetObjectValue<DeviceConfigurationDeviceOverview>(DeviceConfigurationDeviceOverview.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"userStatuses", n => { UserStatuses = n.GetCollectionOfObjectValues<DeviceConfigurationUserStatus>(DeviceConfigurationUserStatus.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userStatusOverview", n => { UserStatusOverview = n.GetObjectValue<DeviceConfigurationUserOverview>(DeviceConfigurationUserOverview.CreateFromDiscriminatorValue); } },
                {"version", n => { Version = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DeviceConfigurationAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<SettingStateDeviceSummary>("deviceSettingStateSummaries", DeviceSettingStateSummaries);
            writer.WriteCollectionOfObjectValues<DeviceConfigurationDeviceStatus>("deviceStatuses", DeviceStatuses);
            writer.WriteObjectValue<DeviceConfigurationDeviceOverview>("deviceStatusOverview", DeviceStatusOverview);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<DeviceConfigurationUserStatus>("userStatuses", UserStatuses);
            writer.WriteObjectValue<DeviceConfigurationUserOverview>("userStatusOverview", UserStatusOverview);
            writer.WriteIntValue("version", Version);
        }
    }
}
