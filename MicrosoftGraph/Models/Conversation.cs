using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class Conversation : Entity, IParsable {
        /// <summary>Indicates whether any of the posts within this Conversation has at least one attachment. Supports $filter (eq, ne) and $search.</summary>
        public bool? HasAttachments { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastDeliveredDateTime { get; set; }
        /// <summary>A short summary from the body of the latest post in this conversation. Supports $filter (eq, ne, le, ge).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Preview { get; set; }
#nullable restore
#else
        public string Preview { get; set; }
#endif
        /// <summary>A collection of all the conversation threads in the conversation. A navigation property. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ConversationThread>? Threads { get; set; }
#nullable restore
#else
        public List<ConversationThread> Threads { get; set; }
#endif
        /// <summary>The topic of the conversation. This property can be set when the conversation is created, but it cannot be updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Topic { get; set; }
#nullable restore
#else
        public string Topic { get; set; }
#endif
        /// <summary>All the users that sent a message to this Conversation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? UniqueSenders { get; set; }
#nullable restore
#else
        public List<string> UniqueSenders { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Conversation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Conversation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"hasAttachments", n => { HasAttachments = n.GetBoolValue(); } },
                {"lastDeliveredDateTime", n => { LastDeliveredDateTime = n.GetDateTimeOffsetValue(); } },
                {"preview", n => { Preview = n.GetStringValue(); } },
                {"threads", n => { Threads = n.GetCollectionOfObjectValues<ConversationThread>(ConversationThread.CreateFromDiscriminatorValue)?.ToList(); } },
                {"topic", n => { Topic = n.GetStringValue(); } },
                {"uniqueSenders", n => { UniqueSenders = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteDateTimeOffsetValue("lastDeliveredDateTime", LastDeliveredDateTime);
            writer.WriteStringValue("preview", Preview);
            writer.WriteCollectionOfObjectValues<ConversationThread>("threads", Threads);
            writer.WriteStringValue("topic", Topic);
            writer.WriteCollectionOfPrimitiveValues<string>("uniqueSenders", UniqueSenders);
        }
    }
}
