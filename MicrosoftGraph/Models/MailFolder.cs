using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class MailFolder : Entity, IParsable {
        /// <summary>The number of immediate child mailFolders in the current mailFolder.</summary>
        public int? ChildFolderCount { get; set; }
        /// <summary>The collection of child folders in the mailFolder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MailFolder>? ChildFolders { get; set; }
#nullable restore
#else
        public List<MailFolder> ChildFolders { get; set; }
#endif
        /// <summary>The mailFolder&apos;s display name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Indicates whether the mailFolder is hidden. This property can be set only when creating the folder. Find more information in Hidden mail folders.</summary>
        public bool? IsHidden { get; set; }
        /// <summary>The collection of rules that apply to the user&apos;s Inbox folder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MessageRule>? MessageRules { get; set; }
#nullable restore
#else
        public List<MessageRule> MessageRules { get; set; }
#endif
        /// <summary>The collection of messages in the mailFolder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Message>? Messages { get; set; }
#nullable restore
#else
        public List<Message> Messages { get; set; }
#endif
        /// <summary>The collection of multi-value extended properties defined for the mailFolder. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MultiValueLegacyExtendedProperty>? MultiValueExtendedProperties { get; set; }
#nullable restore
#else
        public List<MultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }
#endif
        /// <summary>The unique identifier for the mailFolder&apos;s parent mailFolder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentFolderId { get; set; }
#nullable restore
#else
        public string ParentFolderId { get; set; }
#endif
        /// <summary>The collection of single-value extended properties defined for the mailFolder. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SingleValueLegacyExtendedProperty>? SingleValueExtendedProperties { get; set; }
#nullable restore
#else
        public List<SingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }
#endif
        /// <summary>The number of items in the mailFolder.</summary>
        public int? TotalItemCount { get; set; }
        /// <summary>The number of items in the mailFolder marked as unread.</summary>
        public int? UnreadItemCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MailFolder CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.mailSearchFolder" => new MailSearchFolder(),
                _ => new MailFolder(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"childFolderCount", n => { ChildFolderCount = n.GetIntValue(); } },
                {"childFolders", n => { ChildFolders = n.GetCollectionOfObjectValues<MailFolder>(MailFolder.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isHidden", n => { IsHidden = n.GetBoolValue(); } },
                {"messageRules", n => { MessageRules = n.GetCollectionOfObjectValues<MessageRule>(MessageRule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"messages", n => { Messages = n.GetCollectionOfObjectValues<Message>(Message.CreateFromDiscriminatorValue)?.ToList(); } },
                {"multiValueExtendedProperties", n => { MultiValueExtendedProperties = n.GetCollectionOfObjectValues<MultiValueLegacyExtendedProperty>(MultiValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.ToList(); } },
                {"parentFolderId", n => { ParentFolderId = n.GetStringValue(); } },
                {"singleValueExtendedProperties", n => { SingleValueExtendedProperties = n.GetCollectionOfObjectValues<SingleValueLegacyExtendedProperty>(SingleValueLegacyExtendedProperty.CreateFromDiscriminatorValue)?.ToList(); } },
                {"totalItemCount", n => { TotalItemCount = n.GetIntValue(); } },
                {"unreadItemCount", n => { UnreadItemCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("childFolderCount", ChildFolderCount);
            writer.WriteCollectionOfObjectValues<MailFolder>("childFolders", ChildFolders);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isHidden", IsHidden);
            writer.WriteCollectionOfObjectValues<MessageRule>("messageRules", MessageRules);
            writer.WriteCollectionOfObjectValues<Message>("messages", Messages);
            writer.WriteCollectionOfObjectValues<MultiValueLegacyExtendedProperty>("multiValueExtendedProperties", MultiValueExtendedProperties);
            writer.WriteStringValue("parentFolderId", ParentFolderId);
            writer.WriteCollectionOfObjectValues<SingleValueLegacyExtendedProperty>("singleValueExtendedProperties", SingleValueExtendedProperties);
            writer.WriteIntValue("totalItemCount", TotalItemCount);
            writer.WriteIntValue("unreadItemCount", UnreadItemCount);
        }
    }
}
