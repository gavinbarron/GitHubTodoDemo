using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class Chat : Entity, IParsable {
        /// <summary>The chatType property</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.ChatType? ChatType { get; set; }
        /// <summary>Date and time at which the chat was created. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>A collection of all the apps in the chat. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TeamsAppInstallation>? InstalledApps { get; set; }
#nullable restore
#else
        public List<TeamsAppInstallation> InstalledApps { get; set; }
#endif
        /// <summary>Preview of the last message sent in the chat. Null if no messages have been sent in the chat. Currently, only the list chats operation supports this property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ChatMessageInfo? LastMessagePreview { get; set; }
#nullable restore
#else
        public ChatMessageInfo LastMessagePreview { get; set; }
#endif
        /// <summary>Date and time at which the chat was renamed or list of members were last changed. Read-only.</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>A collection of all the members in the chat. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ConversationMember>? Members { get; set; }
#nullable restore
#else
        public List<ConversationMember> Members { get; set; }
#endif
        /// <summary>A collection of all the messages in the chat. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ChatMessage>? Messages { get; set; }
#nullable restore
#else
        public List<ChatMessage> Messages { get; set; }
#endif
        /// <summary>Represents details about an online meeting. If the chat isn&apos;t associated with an online meeting, the property is empty. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkOnlineMeetingInfo? OnlineMeetingInfo { get; set; }
#nullable restore
#else
        public TeamworkOnlineMeetingInfo OnlineMeetingInfo { get; set; }
#endif
        /// <summary>A collection of all the pinned messages in the chat. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PinnedChatMessageInfo>? PinnedMessages { get; set; }
#nullable restore
#else
        public List<PinnedChatMessageInfo> PinnedMessages { get; set; }
#endif
        /// <summary>A collection of all the tabs in the chat. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TeamsTab>? Tabs { get; set; }
#nullable restore
#else
        public List<TeamsTab> Tabs { get; set; }
#endif
        /// <summary>The identifier of the tenant in which the chat was created. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>(Optional) Subject or topic for the chat. Only available for group chats.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Topic { get; set; }
#nullable restore
#else
        public string Topic { get; set; }
#endif
        /// <summary>Represents caller-specific information about the chat, such as last message read date and time. This property is populated only when the request is made in a delegated context.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ChatViewpoint? Viewpoint { get; set; }
#nullable restore
#else
        public ChatViewpoint Viewpoint { get; set; }
#endif
        /// <summary>The URL for the chat in Microsoft Teams. The URL should be treated as an opaque blob, and not parsed. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl { get; set; }
#nullable restore
#else
        public string WebUrl { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Chat CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Chat();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"chatType", n => { ChatType = n.GetEnumValue<ChatType>(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"installedApps", n => { InstalledApps = n.GetCollectionOfObjectValues<TeamsAppInstallation>(TeamsAppInstallation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"lastMessagePreview", n => { LastMessagePreview = n.GetObjectValue<ChatMessageInfo>(ChatMessageInfo.CreateFromDiscriminatorValue); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"members", n => { Members = n.GetCollectionOfObjectValues<ConversationMember>(ConversationMember.CreateFromDiscriminatorValue)?.ToList(); } },
                {"messages", n => { Messages = n.GetCollectionOfObjectValues<ChatMessage>(ChatMessage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"onlineMeetingInfo", n => { OnlineMeetingInfo = n.GetObjectValue<TeamworkOnlineMeetingInfo>(TeamworkOnlineMeetingInfo.CreateFromDiscriminatorValue); } },
                {"pinnedMessages", n => { PinnedMessages = n.GetCollectionOfObjectValues<PinnedChatMessageInfo>(PinnedChatMessageInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tabs", n => { Tabs = n.GetCollectionOfObjectValues<TeamsTab>(TeamsTab.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"topic", n => { Topic = n.GetStringValue(); } },
                {"viewpoint", n => { Viewpoint = n.GetObjectValue<ChatViewpoint>(ChatViewpoint.CreateFromDiscriminatorValue); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ChatType>("chatType", ChatType);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<TeamsAppInstallation>("installedApps", InstalledApps);
            writer.WriteObjectValue<ChatMessageInfo>("lastMessagePreview", LastMessagePreview);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteCollectionOfObjectValues<ConversationMember>("members", Members);
            writer.WriteCollectionOfObjectValues<ChatMessage>("messages", Messages);
            writer.WriteObjectValue<TeamworkOnlineMeetingInfo>("onlineMeetingInfo", OnlineMeetingInfo);
            writer.WriteCollectionOfObjectValues<PinnedChatMessageInfo>("pinnedMessages", PinnedMessages);
            writer.WriteCollectionOfObjectValues<TeamsTab>("tabs", Tabs);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("topic", Topic);
            writer.WriteObjectValue<ChatViewpoint>("viewpoint", Viewpoint);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
