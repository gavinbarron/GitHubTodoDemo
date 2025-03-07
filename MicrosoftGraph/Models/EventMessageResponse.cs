using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class EventMessageResponse : EventMessage, IParsable {
        /// <summary>The proposedNewTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TimeSlot? ProposedNewTime { get; set; }
#nullable restore
#else
        public TimeSlot ProposedNewTime { get; set; }
#endif
        /// <summary>The responseType property</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.ResponseType? ResponseType { get; set; }
        /// <summary>
        /// Instantiates a new EventMessageResponse and sets the default values.
        /// </summary>
        public EventMessageResponse() : base() {
            OdataType = "#microsoft.graph.eventMessageResponse";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EventMessageResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EventMessageResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"proposedNewTime", n => { ProposedNewTime = n.GetObjectValue<TimeSlot>(TimeSlot.CreateFromDiscriminatorValue); } },
                {"responseType", n => { ResponseType = n.GetEnumValue<ResponseType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<TimeSlot>("proposedNewTime", ProposedNewTime);
            writer.WriteEnumValue<ResponseType>("responseType", ResponseType);
        }
    }
}
