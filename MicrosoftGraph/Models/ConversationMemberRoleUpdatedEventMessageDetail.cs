using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class ConversationMemberRoleUpdatedEventMessageDetail : EventMessageDetail, IParsable {
        /// <summary>Roles for the coversation member user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ConversationMemberRoles { get; set; }
#nullable restore
#else
        public List<string> ConversationMemberRoles { get; set; }
#endif
        /// <summary>Identity of the conversation member user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkUserIdentity? ConversationMemberUser { get; set; }
#nullable restore
#else
        public TeamworkUserIdentity ConversationMemberUser { get; set; }
#endif
        /// <summary>Initiator of the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? Initiator { get; set; }
#nullable restore
#else
        public IdentitySet Initiator { get; set; }
#endif
        /// <summary>
        /// Instantiates a new ConversationMemberRoleUpdatedEventMessageDetail and sets the default values.
        /// </summary>
        public ConversationMemberRoleUpdatedEventMessageDetail() : base() {
            OdataType = "#microsoft.graph.conversationMemberRoleUpdatedEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ConversationMemberRoleUpdatedEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConversationMemberRoleUpdatedEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"conversationMemberRoles", n => { ConversationMemberRoles = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"conversationMemberUser", n => { ConversationMemberUser = n.GetObjectValue<TeamworkUserIdentity>(TeamworkUserIdentity.CreateFromDiscriminatorValue); } },
                {"initiator", n => { Initiator = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("conversationMemberRoles", ConversationMemberRoles);
            writer.WriteObjectValue<TeamworkUserIdentity>("conversationMemberUser", ConversationMemberUser);
            writer.WriteObjectValue<IdentitySet>("initiator", Initiator);
        }
    }
}
