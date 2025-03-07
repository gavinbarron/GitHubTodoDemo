using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class ImportedWindowsAutopilotDeviceIdentityUpload : Entity, IParsable {
        /// <summary>DateTime when the entity is created.</summary>
        public DateTimeOffset? CreatedDateTimeUtc { get; set; }
        /// <summary>Collection of all Autopilot devices as a part of this upload.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ImportedWindowsAutopilotDeviceIdentity>? DeviceIdentities { get; set; }
#nullable restore
#else
        public List<ImportedWindowsAutopilotDeviceIdentity> DeviceIdentities { get; set; }
#endif
        /// <summary>The status property</summary>
        public ImportedWindowsAutopilotDeviceIdentityUploadStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ImportedWindowsAutopilotDeviceIdentityUpload CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ImportedWindowsAutopilotDeviceIdentityUpload();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTimeUtc", n => { CreatedDateTimeUtc = n.GetDateTimeOffsetValue(); } },
                {"deviceIdentities", n => { DeviceIdentities = n.GetCollectionOfObjectValues<ImportedWindowsAutopilotDeviceIdentity>(ImportedWindowsAutopilotDeviceIdentity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"status", n => { Status = n.GetEnumValue<ImportedWindowsAutopilotDeviceIdentityUploadStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTimeUtc", CreatedDateTimeUtc);
            writer.WriteCollectionOfObjectValues<ImportedWindowsAutopilotDeviceIdentity>("deviceIdentities", DeviceIdentities);
            writer.WriteEnumValue<ImportedWindowsAutopilotDeviceIdentityUploadStatus>("status", Status);
        }
    }
}
