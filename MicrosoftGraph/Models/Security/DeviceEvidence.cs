using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models.Security {
    public class DeviceEvidence : AlertEvidence, IParsable {
        /// <summary>A unique identifier assigned to a device by Azure Active Directory (Azure AD) when device is Azure AD-joined.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureAdDeviceId { get; set; }
#nullable restore
#else
        public string AzureAdDeviceId { get; set; }
#endif
        /// <summary>State of the Defender AntiMalware engine. The possible values are: notReporting, disabled, notUpdated, updated, unknown, notSupported, unknownFutureValue.</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.Security.DefenderAvStatus? DefenderAvStatus { get; set; }
        /// <summary>The fully qualified domain name (FQDN) for the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceDnsName { get; set; }
#nullable restore
#else
        public string DeviceDnsName { get; set; }
#endif
        /// <summary>The date and time when the device was first seen.</summary>
        public DateTimeOffset? FirstSeenDateTime { get; set; }
        /// <summary>The health state of the device.The possible values are: active, inactive, impairedCommunication, noSensorData, noSensorDataImpairedCommunication, unknown, unknownFutureValue.</summary>
        public DeviceHealthStatus? HealthStatus { get; set; }
        /// <summary>Users that were logged on the machine during the time of the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<LoggedOnUser>? LoggedOnUsers { get; set; }
#nullable restore
#else
        public List<LoggedOnUser> LoggedOnUsers { get; set; }
#endif
        /// <summary>A unique identifier assigned to a device by Microsoft Defender for Endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MdeDeviceId { get; set; }
#nullable restore
#else
        public string MdeDeviceId { get; set; }
#endif
        /// <summary>The status of the machine onboarding to Microsoft Defender for Endpoint.The possible values are: insufficientInfo, onboarded, canBeOnboarded, unsupported, unknownFutureValue.</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.Security.OnboardingStatus? OnboardingStatus { get; set; }
        /// <summary>The build version for the operating system the device is running.</summary>
        public long? OsBuild { get; set; }
        /// <summary>The operating system platform the device is running.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsPlatform { get; set; }
#nullable restore
#else
        public string OsPlatform { get; set; }
#endif
        /// <summary>The ID of the role-based access control (RBAC) device group.</summary>
        public int? RbacGroupId { get; set; }
        /// <summary>The name of the RBAC device group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RbacGroupName { get; set; }
#nullable restore
#else
        public string RbacGroupName { get; set; }
#endif
        /// <summary>Risk score as evaluated by Microsoft Defender for Endpoint. The possible values are: none, informational, low, medium, high, unknownFutureValue.</summary>
        public DeviceRiskScore? RiskScore { get; set; }
        /// <summary>The version of the operating system platform.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version { get; set; }
#nullable restore
#else
        public string Version { get; set; }
#endif
        /// <summary>Metadata of the virtual machine (VM) on which Microsoft Defender for Endpoint is running.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.Security.VmMetadata? VmMetadata { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.Security.VmMetadata VmMetadata { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"azureAdDeviceId", n => { AzureAdDeviceId = n.GetStringValue(); } },
                {"defenderAvStatus", n => { DefenderAvStatus = n.GetEnumValue<DefenderAvStatus>(); } },
                {"deviceDnsName", n => { DeviceDnsName = n.GetStringValue(); } },
                {"firstSeenDateTime", n => { FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"healthStatus", n => { HealthStatus = n.GetEnumValue<DeviceHealthStatus>(); } },
                {"loggedOnUsers", n => { LoggedOnUsers = n.GetCollectionOfObjectValues<LoggedOnUser>(LoggedOnUser.CreateFromDiscriminatorValue)?.ToList(); } },
                {"mdeDeviceId", n => { MdeDeviceId = n.GetStringValue(); } },
                {"onboardingStatus", n => { OnboardingStatus = n.GetEnumValue<OnboardingStatus>(); } },
                {"osBuild", n => { OsBuild = n.GetLongValue(); } },
                {"osPlatform", n => { OsPlatform = n.GetStringValue(); } },
                {"rbacGroupId", n => { RbacGroupId = n.GetIntValue(); } },
                {"rbacGroupName", n => { RbacGroupName = n.GetStringValue(); } },
                {"riskScore", n => { RiskScore = n.GetEnumValue<DeviceRiskScore>(); } },
                {"version", n => { Version = n.GetStringValue(); } },
                {"vmMetadata", n => { VmMetadata = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Security.VmMetadata>(GitHubTodoDemo.MicrosoftGraph.Models.Security.VmMetadata.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("azureAdDeviceId", AzureAdDeviceId);
            writer.WriteEnumValue<DefenderAvStatus>("defenderAvStatus", DefenderAvStatus);
            writer.WriteStringValue("deviceDnsName", DeviceDnsName);
            writer.WriteDateTimeOffsetValue("firstSeenDateTime", FirstSeenDateTime);
            writer.WriteEnumValue<DeviceHealthStatus>("healthStatus", HealthStatus);
            writer.WriteCollectionOfObjectValues<LoggedOnUser>("loggedOnUsers", LoggedOnUsers);
            writer.WriteStringValue("mdeDeviceId", MdeDeviceId);
            writer.WriteEnumValue<OnboardingStatus>("onboardingStatus", OnboardingStatus);
            writer.WriteLongValue("osBuild", OsBuild);
            writer.WriteStringValue("osPlatform", OsPlatform);
            writer.WriteIntValue("rbacGroupId", RbacGroupId);
            writer.WriteStringValue("rbacGroupName", RbacGroupName);
            writer.WriteEnumValue<DeviceRiskScore>("riskScore", RiskScore);
            writer.WriteStringValue("version", Version);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Security.VmMetadata>("vmMetadata", VmMetadata);
        }
    }
}
