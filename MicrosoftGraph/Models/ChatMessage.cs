using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class ChatMessage : Entity, IParsable {
        /// <summary>References to attached objects like files, tabs, meetings etc.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ChatMessageAttachment>? Attachments { get; set; }
#nullable restore
#else
        public List<ChatMessageAttachment> Attachments { get; set; }
#endif
        /// <summary>The body property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemBody? Body { get; set; }
#nullable restore
#else
        public ItemBody Body { get; set; }
#endif
        /// <summary>If the message was sent in a channel, represents identity of the channel.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.ChannelIdentity? ChannelIdentity { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.ChannelIdentity ChannelIdentity { get; set; }
#endif
        /// <summary>If the message was sent in a chat, represents the identity of the chat.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChatId { get; set; }
#nullable restore
#else
        public string ChatId { get; set; }
#endif
        /// <summary>Timestamp of when the chat message was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Read only. Timestamp at which the chat message was deleted, or null if not deleted.</summary>
        public DateTimeOffset? DeletedDateTime { get; set; }
        /// <summary>Read-only. Version number of the chat message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Etag { get; set; }
#nullable restore
#else
        public string Etag { get; set; }
#endif
        /// <summary>Read-only. If present, represents details of an event that happened in a chat, a channel, or a team, for example, adding new members. For event messages, the messageType property will be set to systemEventMessage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EventMessageDetail? EventDetail { get; set; }
#nullable restore
#else
        public EventMessageDetail EventDetail { get; set; }
#endif
        /// <summary>Details of the sender of the chat message. Can only be set during migration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ChatMessageFromIdentitySet? From { get; set; }
#nullable restore
#else
        public ChatMessageFromIdentitySet From { get; set; }
#endif
        /// <summary>Content in a message hosted by Microsoft Teams - for example, images or code snippets.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ChatMessageHostedContent>? HostedContents { get; set; }
#nullable restore
#else
        public List<ChatMessageHostedContent> HostedContents { get; set; }
#endif
        /// <summary>The importance property</summary>
        public ChatMessageImportance? Importance { get; set; }
        /// <summary>Read only. Timestamp when edits to the chat message were made. Triggers an &apos;Edited&apos; flag in the Teams UI. If no edits are made the value is null.</summary>
        public DateTimeOffset? LastEditedDateTime { get; set; }
        /// <summary>Read only. Timestamp when the chat message is created (initial setting) or modified, including when a reaction is added or removed.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Locale of the chat message set by the client. Always set to en-us.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Locale { get; set; }
#nullable restore
#else
        public string Locale { get; set; }
#endif
        /// <summary>List of entities mentioned in the chat message. Supported entities are: user, bot, team, and channel.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ChatMessageMention>? Mentions { get; set; }
#nullable restore
#else
        public List<ChatMessageMention> Mentions { get; set; }
#endif
        /// <summary>The messageType property</summary>
        public ChatMessageType? MessageType { get; set; }
        /// <summary>Defines the properties of a policy violation set by a data loss prevention (DLP) application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ChatMessagePolicyViolation? PolicyViolation { get; set; }
#nullable restore
#else
        public ChatMessagePolicyViolation PolicyViolation { get; set; }
#endif
        /// <summary>Reactions for this chat message (for example, Like).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ChatMessageReaction>? Reactions { get; set; }
#nullable restore
#else
        public List<ChatMessageReaction> Reactions { get; set; }
#endif
        /// <summary>Replies for a specified message. Supports $expand for channel messages.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ChatMessage>? Replies { get; set; }
#nullable restore
#else
        public List<ChatMessage> Replies { get; set; }
#endif
        /// <summary>Read-only. ID of the parent chat message or root chat message of the thread. (Only applies to chat messages in channels, not chats.)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReplyToId { get; set; }
#nullable restore
#else
        public string ReplyToId { get; set; }
#endif
        /// <summary>The subject of the chat message, in plaintext.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>Summary text of the chat message that could be used for push notifications and summary views or fall back views. Only applies to channel chat messages, not chat messages in a chat.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Summary { get; set; }
#nullable restore
#else
        public string Summary { get; set; }
#endif
        /// <summary>Read-only. Link to the message in Microsoft Teams.</summary>
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
        public static new ChatMessage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChatMessage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"attachments", n => { Attachments = n.GetCollectionOfObjectValues<ChatMessageAttachment>(ChatMessageAttachment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"body", n => { Body = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"channelIdentity", n => { ChannelIdentity = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.ChannelIdentity>(GitHubTodoDemo.MicrosoftGraph.Models.ChannelIdentity.CreateFromDiscriminatorValue); } },
                {"chatId", n => { ChatId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deletedDateTime", n => { DeletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"etag", n => { Etag = n.GetStringValue(); } },
                {"eventDetail", n => { EventDetail = n.GetObjectValue<EventMessageDetail>(EventMessageDetail.CreateFromDiscriminatorValue); } },
                {"from", n => { From = n.GetObjectValue<ChatMessageFromIdentitySet>(ChatMessageFromIdentitySet.CreateFromDiscriminatorValue); } },
                {"hostedContents", n => { HostedContents = n.GetCollectionOfObjectValues<ChatMessageHostedContent>(ChatMessageHostedContent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"importance", n => { Importance = n.GetEnumValue<ChatMessageImportance>(); } },
                {"lastEditedDateTime", n => { LastEditedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"locale", n => { Locale = n.GetStringValue(); } },
                {"mentions", n => { Mentions = n.GetCollectionOfObjectValues<ChatMessageMention>(ChatMessageMention.CreateFromDiscriminatorValue)?.ToList(); } },
                {"messageType", n => { MessageType = n.GetEnumValue<ChatMessageType>(); } },
                {"policyViolation", n => { PolicyViolation = n.GetObjectValue<ChatMessagePolicyViolation>(ChatMessagePolicyViolation.CreateFromDiscriminatorValue); } },
                {"reactions", n => { Reactions = n.GetCollectionOfObjectValues<ChatMessageReaction>(ChatMessageReaction.CreateFromDiscriminatorValue)?.ToList(); } },
                {"replies", n => { Replies = n.GetCollectionOfObjectValues<ChatMessage>(ChatMessage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"replyToId", n => { ReplyToId = n.GetStringValue(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"summary", n => { Summary = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<ChatMessageAttachment>("attachments", Attachments);
            writer.WriteObjectValue<ItemBody>("body", Body);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.ChannelIdentity>("channelIdentity", ChannelIdentity);
            writer.WriteStringValue("chatId", ChatId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("deletedDateTime", DeletedDateTime);
            writer.WriteStringValue("etag", Etag);
            writer.WriteObjectValue<EventMessageDetail>("eventDetail", EventDetail);
            writer.WriteObjectValue<ChatMessageFromIdentitySet>("from", From);
            writer.WriteCollectionOfObjectValues<ChatMessageHostedContent>("hostedContents", HostedContents);
            writer.WriteEnumValue<ChatMessageImportance>("importance", Importance);
            writer.WriteDateTimeOffsetValue("lastEditedDateTime", LastEditedDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("locale", Locale);
            writer.WriteCollectionOfObjectValues<ChatMessageMention>("mentions", Mentions);
            writer.WriteEnumValue<ChatMessageType>("messageType", MessageType);
            writer.WriteObjectValue<ChatMessagePolicyViolation>("policyViolation", PolicyViolation);
            writer.WriteCollectionOfObjectValues<ChatMessageReaction>("reactions", Reactions);
            writer.WriteCollectionOfObjectValues<ChatMessage>("replies", Replies);
            writer.WriteStringValue("replyToId", ReplyToId);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("summary", Summary);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
