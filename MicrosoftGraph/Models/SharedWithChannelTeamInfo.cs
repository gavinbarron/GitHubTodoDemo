using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class SharedWithChannelTeamInfo : TeamInfo, IParsable {
        /// <summary>A collection of team members who have access to the shared channel.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ConversationMember>? AllowedMembers { get; set; }
#nullable restore
#else
        public List<ConversationMember> AllowedMembers { get; set; }
#endif
        /// <summary>Indicates whether the team is the host of the channel.</summary>
        public bool? IsHostTeam { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SharedWithChannelTeamInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharedWithChannelTeamInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedMembers", n => { AllowedMembers = n.GetCollectionOfObjectValues<ConversationMember>(ConversationMember.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isHostTeam", n => { IsHostTeam = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ConversationMember>("allowedMembers", AllowedMembers);
            writer.WriteBoolValue("isHostTeam", IsHostTeam);
        }
    }
}
