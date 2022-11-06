using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class RecordingInfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The identities of the recording initiator.</summary>
        public IdentitySet Initiator { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The recordingStatus property</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.RecordingStatus? RecordingStatus { get; set; }
        /// <summary>
        /// Instantiates a new recordingInfo and sets the default values.
        /// </summary>
        public RecordingInfo() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.recordingInfo";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RecordingInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RecordingInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"initiator", n => { Initiator = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"recordingStatus", n => { RecordingStatus = n.GetEnumValue<RecordingStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<IdentitySet>("initiator", Initiator);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<RecordingStatus>("recordingStatus", RecordingStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
