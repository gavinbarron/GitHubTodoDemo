using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>
    /// Device compliance setting State for a given device.
    /// </summary>
    public class DeviceComplianceSettingState : Entity, IParsable {
        /// <summary>The DateTime when device compliance grace period expires</summary>
        public DateTimeOffset? ComplianceGracePeriodExpirationDateTime { get; set; }
        /// <summary>The Device Id that is being reported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId { get; set; }
#nullable restore
#else
        public string DeviceId { get; set; }
#endif
        /// <summary>The device model that is being reported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceModel { get; set; }
#nullable restore
#else
        public string DeviceModel { get; set; }
#endif
        /// <summary>The Device Name that is being reported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName { get; set; }
#nullable restore
#else
        public string DeviceName { get; set; }
#endif
        /// <summary>The setting class name and property name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Setting { get; set; }
#nullable restore
#else
        public string Setting { get; set; }
#endif
        /// <summary>The Setting Name that is being reported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SettingName { get; set; }
#nullable restore
#else
        public string SettingName { get; set; }
#endif
        /// <summary>The state property</summary>
        public ComplianceStatus? State { get; set; }
        /// <summary>The User email address that is being reported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserEmail { get; set; }
#nullable restore
#else
        public string UserEmail { get; set; }
#endif
        /// <summary>The user Id that is being reported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>The User Name that is being reported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserName { get; set; }
#nullable restore
#else
        public string UserName { get; set; }
#endif
        /// <summary>The User PrincipalName that is being reported</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName { get; set; }
#nullable restore
#else
        public string UserPrincipalName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceComplianceSettingState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceComplianceSettingState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"complianceGracePeriodExpirationDateTime", n => { ComplianceGracePeriodExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"deviceModel", n => { DeviceModel = n.GetStringValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"setting", n => { Setting = n.GetStringValue(); } },
                {"settingName", n => { SettingName = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<ComplianceStatus>(); } },
                {"userEmail", n => { UserEmail = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userName", n => { UserName = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("complianceGracePeriodExpirationDateTime", ComplianceGracePeriodExpirationDateTime);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("deviceModel", DeviceModel);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("setting", Setting);
            writer.WriteStringValue("settingName", SettingName);
            writer.WriteEnumValue<ComplianceStatus>("state", State);
            writer.WriteStringValue("userEmail", UserEmail);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userName", UserName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
