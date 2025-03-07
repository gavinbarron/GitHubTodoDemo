using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class TeamCreatedEventMessageDetail : EventMessageDetail, IParsable {
        /// <summary>Initiator of the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? Initiator { get; set; }
#nullable restore
#else
        public IdentitySet Initiator { get; set; }
#endif
        /// <summary>Description for the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamDescription { get; set; }
#nullable restore
#else
        public string TeamDescription { get; set; }
#endif
        /// <summary>Display name of the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamDisplayName { get; set; }
#nullable restore
#else
        public string TeamDisplayName { get; set; }
#endif
        /// <summary>Unique identifier of the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TeamId { get; set; }
#nullable restore
#else
        public string TeamId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new TeamCreatedEventMessageDetail and sets the default values.
        /// </summary>
        public TeamCreatedEventMessageDetail() : base() {
            OdataType = "#microsoft.graph.teamCreatedEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TeamCreatedEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamCreatedEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"initiator", n => { Initiator = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"teamDescription", n => { TeamDescription = n.GetStringValue(); } },
                {"teamDisplayName", n => { TeamDisplayName = n.GetStringValue(); } },
                {"teamId", n => { TeamId = n.GetStringValue(); } },
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
            writer.WriteStringValue("teamDescription", TeamDescription);
            writer.WriteStringValue("teamDisplayName", TeamDisplayName);
            writer.WriteStringValue("teamId", TeamId);
        }
    }
}
