using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class EnrollmentTroubleshootingEvent : DeviceManagementTroubleshootingEvent, IParsable {
        /// <summary>Azure AD device identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceId { get; set; }
#nullable restore
#else
        public string DeviceId { get; set; }
#endif
        /// <summary>Possible ways of adding a mobile device to management.</summary>
        public DeviceEnrollmentType? EnrollmentType { get; set; }
        /// <summary>Top level failure categories for enrollment.</summary>
        public DeviceEnrollmentFailureReason? FailureCategory { get; set; }
        /// <summary>Detailed failure reason.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FailureReason { get; set; }
#nullable restore
#else
        public string FailureReason { get; set; }
#endif
        /// <summary>Device identifier created or collected by Intune.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedDeviceIdentifier { get; set; }
#nullable restore
#else
        public string ManagedDeviceIdentifier { get; set; }
#endif
        /// <summary>Operating System.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperatingSystem { get; set; }
#nullable restore
#else
        public string OperatingSystem { get; set; }
#endif
        /// <summary>OS Version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsVersion { get; set; }
#nullable restore
#else
        public string OsVersion { get; set; }
#endif
        /// <summary>Identifier for the user that tried to enroll the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EnrollmentTroubleshootingEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EnrollmentTroubleshootingEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"enrollmentType", n => { EnrollmentType = n.GetEnumValue<DeviceEnrollmentType>(); } },
                {"failureCategory", n => { FailureCategory = n.GetEnumValue<DeviceEnrollmentFailureReason>(); } },
                {"failureReason", n => { FailureReason = n.GetStringValue(); } },
                {"managedDeviceIdentifier", n => { ManagedDeviceIdentifier = n.GetStringValue(); } },
                {"operatingSystem", n => { OperatingSystem = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteEnumValue<DeviceEnrollmentType>("enrollmentType", EnrollmentType);
            writer.WriteEnumValue<DeviceEnrollmentFailureReason>("failureCategory", FailureCategory);
            writer.WriteStringValue("failureReason", FailureReason);
            writer.WriteStringValue("managedDeviceIdentifier", ManagedDeviceIdentifier);
            writer.WriteStringValue("operatingSystem", OperatingSystem);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
