using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class MessageRulePredicates : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Represents the strings that should appear in the body of an incoming message in order for the condition or exception to apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? BodyContains { get; set; }
#nullable restore
#else
        public List<string> BodyContains { get; set; }
#endif
        /// <summary>Represents the strings that should appear in the body or subject of an incoming message in order for the condition or exception to apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? BodyOrSubjectContains { get; set; }
#nullable restore
#else
        public List<string> BodyOrSubjectContains { get; set; }
#endif
        /// <summary>Represents the categories that an incoming message should be labeled with in order for the condition or exception to apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Categories { get; set; }
#nullable restore
#else
        public List<string> Categories { get; set; }
#endif
        /// <summary>Represents the specific sender email addresses of an incoming message in order for the condition or exception to apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Recipient>? FromAddresses { get; set; }
#nullable restore
#else
        public List<Recipient> FromAddresses { get; set; }
#endif
        /// <summary>Indicates whether an incoming message must have attachments in order for the condition or exception to apply.</summary>
        public bool? HasAttachments { get; set; }
        /// <summary>Represents the strings that appear in the headers of an incoming message in order for the condition or exception to apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? HeaderContains { get; set; }
#nullable restore
#else
        public List<string> HeaderContains { get; set; }
#endif
        /// <summary>The importance that is stamped on an incoming message in order for the condition or exception to apply: low, normal, high.</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.Importance? Importance { get; set; }
        /// <summary>Indicates whether an incoming message must be an approval request in order for the condition or exception to apply.</summary>
        public bool? IsApprovalRequest { get; set; }
        /// <summary>Indicates whether an incoming message must be automatically forwarded in order for the condition or exception to apply.</summary>
        public bool? IsAutomaticForward { get; set; }
        /// <summary>Indicates whether an incoming message must be an auto reply in order for the condition or exception to apply.</summary>
        public bool? IsAutomaticReply { get; set; }
        /// <summary>Indicates whether an incoming message must be encrypted in order for the condition or exception to apply.</summary>
        public bool? IsEncrypted { get; set; }
        /// <summary>Indicates whether an incoming message must be a meeting request in order for the condition or exception to apply.</summary>
        public bool? IsMeetingRequest { get; set; }
        /// <summary>Indicates whether an incoming message must be a meeting response in order for the condition or exception to apply.</summary>
        public bool? IsMeetingResponse { get; set; }
        /// <summary>Indicates whether an incoming message must be a non-delivery report in order for the condition or exception to apply.</summary>
        public bool? IsNonDeliveryReport { get; set; }
        /// <summary>Indicates whether an incoming message must be permission controlled (RMS-protected) in order for the condition or exception to apply.</summary>
        public bool? IsPermissionControlled { get; set; }
        /// <summary>Indicates whether an incoming message must be a read receipt in order for the condition or exception to apply.</summary>
        public bool? IsReadReceipt { get; set; }
        /// <summary>Indicates whether an incoming message must be S/MIME-signed in order for the condition or exception to apply.</summary>
        public bool? IsSigned { get; set; }
        /// <summary>Indicates whether an incoming message must be a voice mail in order for the condition or exception to apply.</summary>
        public bool? IsVoicemail { get; set; }
        /// <summary>Represents the flag-for-action value that appears on an incoming message in order for the condition or exception to apply. The possible values are: any, call, doNotForward, followUp, fyi, forward, noResponseNecessary, read, reply, replyToAll, review.</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.MessageActionFlag? MessageActionFlag { get; set; }
        /// <summary>Indicates whether the owner of the mailbox must not be a recipient of an incoming message in order for the condition or exception to apply.</summary>
        public bool? NotSentToMe { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Represents the strings that appear in either the toRecipients or ccRecipients properties of an incoming message in order for the condition or exception to apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RecipientContains { get; set; }
#nullable restore
#else
        public List<string> RecipientContains { get; set; }
#endif
        /// <summary>Represents the strings that appear in the from property of an incoming message in order for the condition or exception to apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SenderContains { get; set; }
#nullable restore
#else
        public List<string> SenderContains { get; set; }
#endif
        /// <summary>Represents the sensitivity level that must be stamped on an incoming message in order for the condition or exception to apply. The possible values are: normal, personal, private, confidential.</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.Sensitivity? Sensitivity { get; set; }
        /// <summary>Indicates whether the owner of the mailbox must be in the ccRecipients property of an incoming message in order for the condition or exception to apply.</summary>
        public bool? SentCcMe { get; set; }
        /// <summary>Indicates whether the owner of the mailbox must be the only recipient in an incoming message in order for the condition or exception to apply.</summary>
        public bool? SentOnlyToMe { get; set; }
        /// <summary>Represents the email addresses that an incoming message must have been sent to in order for the condition or exception to apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Recipient>? SentToAddresses { get; set; }
#nullable restore
#else
        public List<Recipient> SentToAddresses { get; set; }
#endif
        /// <summary>Indicates whether the owner of the mailbox must be in the toRecipients property of an incoming message in order for the condition or exception to apply.</summary>
        public bool? SentToMe { get; set; }
        /// <summary>Indicates whether the owner of the mailbox must be in either a toRecipients or ccRecipients property of an incoming message in order for the condition or exception to apply.</summary>
        public bool? SentToOrCcMe { get; set; }
        /// <summary>Represents the strings that appear in the subject of an incoming message in order for the condition or exception to apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SubjectContains { get; set; }
#nullable restore
#else
        public List<string> SubjectContains { get; set; }
#endif
        /// <summary>Represents the minimum and maximum sizes (in kilobytes) that an incoming message must fall in between in order for the condition or exception to apply.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SizeRange? WithinSizeRange { get; set; }
#nullable restore
#else
        public SizeRange WithinSizeRange { get; set; }
#endif
        /// <summary>
        /// Instantiates a new messageRulePredicates and sets the default values.
        /// </summary>
        public MessageRulePredicates() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MessageRulePredicates CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MessageRulePredicates();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"bodyContains", n => { BodyContains = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"bodyOrSubjectContains", n => { BodyOrSubjectContains = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"categories", n => { Categories = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"fromAddresses", n => { FromAddresses = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hasAttachments", n => { HasAttachments = n.GetBoolValue(); } },
                {"headerContains", n => { HeaderContains = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"importance", n => { Importance = n.GetEnumValue<Importance>(); } },
                {"isApprovalRequest", n => { IsApprovalRequest = n.GetBoolValue(); } },
                {"isAutomaticForward", n => { IsAutomaticForward = n.GetBoolValue(); } },
                {"isAutomaticReply", n => { IsAutomaticReply = n.GetBoolValue(); } },
                {"isEncrypted", n => { IsEncrypted = n.GetBoolValue(); } },
                {"isMeetingRequest", n => { IsMeetingRequest = n.GetBoolValue(); } },
                {"isMeetingResponse", n => { IsMeetingResponse = n.GetBoolValue(); } },
                {"isNonDeliveryReport", n => { IsNonDeliveryReport = n.GetBoolValue(); } },
                {"isPermissionControlled", n => { IsPermissionControlled = n.GetBoolValue(); } },
                {"isReadReceipt", n => { IsReadReceipt = n.GetBoolValue(); } },
                {"isSigned", n => { IsSigned = n.GetBoolValue(); } },
                {"isVoicemail", n => { IsVoicemail = n.GetBoolValue(); } },
                {"messageActionFlag", n => { MessageActionFlag = n.GetEnumValue<MessageActionFlag>(); } },
                {"notSentToMe", n => { NotSentToMe = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"recipientContains", n => { RecipientContains = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"senderContains", n => { SenderContains = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"sensitivity", n => { Sensitivity = n.GetEnumValue<Sensitivity>(); } },
                {"sentCcMe", n => { SentCcMe = n.GetBoolValue(); } },
                {"sentOnlyToMe", n => { SentOnlyToMe = n.GetBoolValue(); } },
                {"sentToAddresses", n => { SentToAddresses = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sentToMe", n => { SentToMe = n.GetBoolValue(); } },
                {"sentToOrCcMe", n => { SentToOrCcMe = n.GetBoolValue(); } },
                {"subjectContains", n => { SubjectContains = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"withinSizeRange", n => { WithinSizeRange = n.GetObjectValue<SizeRange>(SizeRange.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("bodyContains", BodyContains);
            writer.WriteCollectionOfPrimitiveValues<string>("bodyOrSubjectContains", BodyOrSubjectContains);
            writer.WriteCollectionOfPrimitiveValues<string>("categories", Categories);
            writer.WriteCollectionOfObjectValues<Recipient>("fromAddresses", FromAddresses);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteCollectionOfPrimitiveValues<string>("headerContains", HeaderContains);
            writer.WriteEnumValue<Importance>("importance", Importance);
            writer.WriteBoolValue("isApprovalRequest", IsApprovalRequest);
            writer.WriteBoolValue("isAutomaticForward", IsAutomaticForward);
            writer.WriteBoolValue("isAutomaticReply", IsAutomaticReply);
            writer.WriteBoolValue("isEncrypted", IsEncrypted);
            writer.WriteBoolValue("isMeetingRequest", IsMeetingRequest);
            writer.WriteBoolValue("isMeetingResponse", IsMeetingResponse);
            writer.WriteBoolValue("isNonDeliveryReport", IsNonDeliveryReport);
            writer.WriteBoolValue("isPermissionControlled", IsPermissionControlled);
            writer.WriteBoolValue("isReadReceipt", IsReadReceipt);
            writer.WriteBoolValue("isSigned", IsSigned);
            writer.WriteBoolValue("isVoicemail", IsVoicemail);
            writer.WriteEnumValue<MessageActionFlag>("messageActionFlag", MessageActionFlag);
            writer.WriteBoolValue("notSentToMe", NotSentToMe);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("recipientContains", RecipientContains);
            writer.WriteCollectionOfPrimitiveValues<string>("senderContains", SenderContains);
            writer.WriteEnumValue<Sensitivity>("sensitivity", Sensitivity);
            writer.WriteBoolValue("sentCcMe", SentCcMe);
            writer.WriteBoolValue("sentOnlyToMe", SentOnlyToMe);
            writer.WriteCollectionOfObjectValues<Recipient>("sentToAddresses", SentToAddresses);
            writer.WriteBoolValue("sentToMe", SentToMe);
            writer.WriteBoolValue("sentToOrCcMe", SentToOrCcMe);
            writer.WriteCollectionOfPrimitiveValues<string>("subjectContains", SubjectContains);
            writer.WriteObjectValue<SizeRange>("withinSizeRange", WithinSizeRange);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
