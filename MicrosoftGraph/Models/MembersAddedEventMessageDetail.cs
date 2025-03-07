using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class MembersAddedEventMessageDetail : EventMessageDetail, IParsable {
        /// <summary>Initiator of the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? Initiator { get; set; }
#nullable restore
#else
        public IdentitySet Initiator { get; set; }
#endif
        /// <summary>List of members added.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TeamworkUserIdentity>? Members { get; set; }
#nullable restore
#else
        public List<TeamworkUserIdentity> Members { get; set; }
#endif
        /// <summary>The timestamp that denotes how far back a conversation&apos;s history is shared with the conversation members.</summary>
        public DateTimeOffset? VisibleHistoryStartDateTime { get; set; }
        /// <summary>
        /// Instantiates a new MembersAddedEventMessageDetail and sets the default values.
        /// </summary>
        public MembersAddedEventMessageDetail() : base() {
            OdataType = "#microsoft.graph.membersAddedEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MembersAddedEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MembersAddedEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"initiator", n => { Initiator = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"members", n => { Members = n.GetCollectionOfObjectValues<TeamworkUserIdentity>(TeamworkUserIdentity.CreateFromDiscriminatorValue)?.ToList(); } },
                {"visibleHistoryStartDateTime", n => { VisibleHistoryStartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<IdentitySet>("initiator", Initiator);
            writer.WriteCollectionOfObjectValues<TeamworkUserIdentity>("members", Members);
            writer.WriteDateTimeOffsetValue("visibleHistoryStartDateTime", VisibleHistoryStartDateTime);
        }
    }
}
