using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class Participant : Entity, IParsable {
        /// <summary>The info property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ParticipantInfo? Info { get; set; }
#nullable restore
#else
        public ParticipantInfo Info { get; set; }
#endif
        /// <summary>true if the participant is in lobby.</summary>
        public bool? IsInLobby { get; set; }
        /// <summary>true if the participant is muted (client or server muted).</summary>
        public bool? IsMuted { get; set; }
        /// <summary>The list of media streams.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MediaStream>? MediaStreams { get; set; }
#nullable restore
#else
        public List<MediaStream> MediaStreams { get; set; }
#endif
        /// <summary>A blob of data provided by the participant in the roster.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Metadata { get; set; }
#nullable restore
#else
        public string Metadata { get; set; }
#endif
        /// <summary>Information about whether the participant has recording capability.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.RecordingInfo? RecordingInfo { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.RecordingInfo RecordingInfo { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Participant CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Participant();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"info", n => { Info = n.GetObjectValue<ParticipantInfo>(ParticipantInfo.CreateFromDiscriminatorValue); } },
                {"isInLobby", n => { IsInLobby = n.GetBoolValue(); } },
                {"isMuted", n => { IsMuted = n.GetBoolValue(); } },
                {"mediaStreams", n => { MediaStreams = n.GetCollectionOfObjectValues<MediaStream>(MediaStream.CreateFromDiscriminatorValue)?.ToList(); } },
                {"metadata", n => { Metadata = n.GetStringValue(); } },
                {"recordingInfo", n => { RecordingInfo = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.RecordingInfo>(GitHubTodoDemo.MicrosoftGraph.Models.RecordingInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ParticipantInfo>("info", Info);
            writer.WriteBoolValue("isInLobby", IsInLobby);
            writer.WriteBoolValue("isMuted", IsMuted);
            writer.WriteCollectionOfObjectValues<MediaStream>("mediaStreams", MediaStreams);
            writer.WriteStringValue("metadata", Metadata);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.RecordingInfo>("recordingInfo", RecordingInfo);
        }
    }
}
