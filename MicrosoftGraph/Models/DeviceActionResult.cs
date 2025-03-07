using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>
    /// Device action result
    /// </summary>
    public class DeviceActionResult : IAdditionalDataHolder, IParsable {
        /// <summary>Action name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActionName { get; set; }
#nullable restore
#else
        public string ActionName { get; set; }
#endif
        /// <summary>State of the action on the device</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.ActionState? ActionState { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Time the action state was last updated</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Time the action was initiated</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>
        /// Instantiates a new deviceActionResult and sets the default values.
        /// </summary>
        public DeviceActionResult() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceActionResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.deleteUserFromSharedAppleDeviceActionResult" => new DeleteUserFromSharedAppleDeviceActionResult(),
                "#microsoft.graph.locateDeviceActionResult" => new LocateDeviceActionResult(),
                "#microsoft.graph.remoteLockActionResult" => new RemoteLockActionResult(),
                "#microsoft.graph.resetPasscodeActionResult" => new ResetPasscodeActionResult(),
                "#microsoft.graph.windowsDefenderScanActionResult" => new WindowsDefenderScanActionResult(),
                _ => new DeviceActionResult(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actionName", n => { ActionName = n.GetStringValue(); } },
                {"actionState", n => { ActionState = n.GetEnumValue<ActionState>(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("actionName", ActionName);
            writer.WriteEnumValue<ActionState>("actionState", ActionState);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
