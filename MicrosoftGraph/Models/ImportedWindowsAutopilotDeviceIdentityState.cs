using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class ImportedWindowsAutopilotDeviceIdentityState : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Device error code reported by Device Directory Service(DDS).</summary>
        public int? DeviceErrorCode { get; set; }
        /// <summary>Device error name reported by Device Directory Service(DDS).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceErrorName { get; set; }
#nullable restore
#else
        public string DeviceErrorName { get; set; }
#endif
        /// <summary>The deviceImportStatus property</summary>
        public ImportedWindowsAutopilotDeviceIdentityImportStatus? DeviceImportStatus { get; set; }
        /// <summary>Device Registration ID for successfully added device reported by Device Directory Service(DDS).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceRegistrationId { get; set; }
#nullable restore
#else
        public string DeviceRegistrationId { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new importedWindowsAutopilotDeviceIdentityState and sets the default values.
        /// </summary>
        public ImportedWindowsAutopilotDeviceIdentityState() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ImportedWindowsAutopilotDeviceIdentityState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ImportedWindowsAutopilotDeviceIdentityState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deviceErrorCode", n => { DeviceErrorCode = n.GetIntValue(); } },
                {"deviceErrorName", n => { DeviceErrorName = n.GetStringValue(); } },
                {"deviceImportStatus", n => { DeviceImportStatus = n.GetEnumValue<ImportedWindowsAutopilotDeviceIdentityImportStatus>(); } },
                {"deviceRegistrationId", n => { DeviceRegistrationId = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("deviceErrorCode", DeviceErrorCode);
            writer.WriteStringValue("deviceErrorName", DeviceErrorName);
            writer.WriteEnumValue<ImportedWindowsAutopilotDeviceIdentityImportStatus>("deviceImportStatus", DeviceImportStatus);
            writer.WriteStringValue("deviceRegistrationId", DeviceRegistrationId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
