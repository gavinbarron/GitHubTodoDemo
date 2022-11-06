using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class InvitationParticipantInfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Optional. Whether to hide the participant from the roster.</summary>
        public bool? Hidden { get; set; }
        /// <summary>The identity property</summary>
        public IdentitySet Identity { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>Optional. The ID of the target participant.</summary>
        public string ParticipantId { get; set; }
        /// <summary>Optional. Whether to remove them from the main mixer.</summary>
        public bool? RemoveFromDefaultAudioRoutingGroup { get; set; }
        /// <summary>Optional. The call which the target identity is currently a part of. For peer-to-peer case, the call will be dropped once the participant is added successfully.</summary>
        public string ReplacesCallId { get; set; }
        /// <summary>
        /// Instantiates a new invitationParticipantInfo and sets the default values.
        /// </summary>
        public InvitationParticipantInfo() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.invitationParticipantInfo";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static InvitationParticipantInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InvitationParticipantInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"hidden", n => { Hidden = n.GetBoolValue(); } },
                {"identity", n => { Identity = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"participantId", n => { ParticipantId = n.GetStringValue(); } },
                {"removeFromDefaultAudioRoutingGroup", n => { RemoveFromDefaultAudioRoutingGroup = n.GetBoolValue(); } },
                {"replacesCallId", n => { ReplacesCallId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("hidden", Hidden);
            writer.WriteObjectValue<IdentitySet>("identity", Identity);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("participantId", ParticipantId);
            writer.WriteBoolValue("removeFromDefaultAudioRoutingGroup", RemoveFromDefaultAudioRoutingGroup);
            writer.WriteStringValue("replacesCallId", ReplacesCallId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
