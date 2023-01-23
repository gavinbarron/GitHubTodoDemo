using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>
    /// A managed or unmanaged app that is installed on a managed device. Unmanaged apps will only appear for devices marked as corporate owned.
    /// </summary>
    public class DetectedApp : Entity, IParsable {
        /// <summary>The number of devices that have installed this application</summary>
        public int? DeviceCount { get; set; }
        /// <summary>Name of the discovered application. Read-only</summary>
        public string DisplayName { get; set; }
        /// <summary>The devices that have the discovered application installed</summary>
        public List<ManagedDevice> ManagedDevices { get; set; }
        /// <summary>Indicates the operating system / platform of the discovered application.  Some possible values are Windows, iOS, macOS. The default value is unknown (0).</summary>
        public DetectedAppPlatformType? Platform { get; set; }
        /// <summary>Indicates the publisher of the discovered application. For example: &apos;Microsoft&apos;.  The default value is an empty string.</summary>
        public string Publisher { get; set; }
        /// <summary>Discovered application size in bytes. Read-only</summary>
        public long? SizeInByte { get; set; }
        /// <summary>Version of the discovered application. Read-only</summary>
        public string Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DetectedApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DetectedApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceCount", n => { DeviceCount = n.GetIntValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"managedDevices", n => { ManagedDevices = n.GetCollectionOfObjectValues<ManagedDevice>(ManagedDevice.CreateFromDiscriminatorValue)?.ToList(); } },
                {"platform", n => { Platform = n.GetEnumValue<DetectedAppPlatformType>(); } },
                {"publisher", n => { Publisher = n.GetStringValue(); } },
                {"sizeInByte", n => { SizeInByte = n.GetLongValue(); } },
                {"version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("deviceCount", DeviceCount);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<ManagedDevice>("managedDevices", ManagedDevices);
            writer.WriteEnumValue<DetectedAppPlatformType>("platform", Platform);
            writer.WriteStringValue("publisher", Publisher);
            writer.WriteLongValue("sizeInByte", SizeInByte);
            writer.WriteStringValue("version", Version);
        }
    }
}
