using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models.Security {
    public class AnalyzedMessageEvidence : AlertEvidence, IParsable {
        /// <summary>Direction of the email relative to your network. The possible values are: inbound, outbound or intraorg.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AntiSpamDirection { get; set; }
#nullable restore
#else
        public string AntiSpamDirection { get; set; }
#endif
        /// <summary>Number of attachments in the email.</summary>
        public long? AttachmentsCount { get; set; }
        /// <summary>Delivery action of the email. The possible values are: delivered, deliveredAsSpam, junked, blocked, or replaced.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeliveryAction { get; set; }
#nullable restore
#else
        public string DeliveryAction { get; set; }
#endif
        /// <summary>Location where the email was delivered. The possible values are: inbox, external, junkFolder, quarantine, failed, dropped, deletedFolder or forwarded.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeliveryLocation { get; set; }
#nullable restore
#else
        public string DeliveryLocation { get; set; }
#endif
        /// <summary>Public-facing identifier for the email that is set by the sending email system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InternetMessageId { get; set; }
#nullable restore
#else
        public string InternetMessageId { get; set; }
#endif
        /// <summary>Detected language of the email content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Language { get; set; }
#nullable restore
#else
        public string Language { get; set; }
#endif
        /// <summary>Unique identifier for the email, generated by Microsoft 365.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NetworkMessageId { get; set; }
#nullable restore
#else
        public string NetworkMessageId { get; set; }
#endif
        /// <summary>The P1 sender.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EmailSender? P1Sender { get; set; }
#nullable restore
#else
        public EmailSender P1Sender { get; set; }
#endif
        /// <summary>The P2 sender.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EmailSender? P2Sender { get; set; }
#nullable restore
#else
        public EmailSender P2Sender { get; set; }
#endif
        /// <summary>Date and time when the email was received.</summary>
        public DateTimeOffset? ReceivedDateTime { get; set; }
        /// <summary>Email address of the recipient, or email address of the recipient after distribution list expansion.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecipientEmailAddress { get; set; }
#nullable restore
#else
        public string RecipientEmailAddress { get; set; }
#endif
        /// <summary>IP address of the last detected mail server that relayed the message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SenderIp { get; set; }
#nullable restore
#else
        public string SenderIp { get; set; }
#endif
        /// <summary>Subject of the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>Collection of methods used to detect malware, phishing, or other threats found in the email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ThreatDetectionMethods { get; set; }
#nullable restore
#else
        public List<string> ThreatDetectionMethods { get; set; }
#endif
        /// <summary>Collection of detection names for malware or other threats found.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Threats { get; set; }
#nullable restore
#else
        public List<string> Threats { get; set; }
#endif
        /// <summary>Number of embedded URLs in the email.</summary>
        public long? UrlCount { get; set; }
        /// <summary>Collection of the URLs contained in this email.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Urls { get; set; }
#nullable restore
#else
        public List<string> Urls { get; set; }
#endif
        /// <summary>Uniform resource name (URN) of the automated investigation where the cluster was identified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Urn { get; set; }
#nullable restore
#else
        public string Urn { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AnalyzedMessageEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AnalyzedMessageEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"antiSpamDirection", n => { AntiSpamDirection = n.GetStringValue(); } },
                {"attachmentsCount", n => { AttachmentsCount = n.GetLongValue(); } },
                {"deliveryAction", n => { DeliveryAction = n.GetStringValue(); } },
                {"deliveryLocation", n => { DeliveryLocation = n.GetStringValue(); } },
                {"internetMessageId", n => { InternetMessageId = n.GetStringValue(); } },
                {"language", n => { Language = n.GetStringValue(); } },
                {"networkMessageId", n => { NetworkMessageId = n.GetStringValue(); } },
                {"p1Sender", n => { P1Sender = n.GetObjectValue<EmailSender>(EmailSender.CreateFromDiscriminatorValue); } },
                {"p2Sender", n => { P2Sender = n.GetObjectValue<EmailSender>(EmailSender.CreateFromDiscriminatorValue); } },
                {"receivedDateTime", n => { ReceivedDateTime = n.GetDateTimeOffsetValue(); } },
                {"recipientEmailAddress", n => { RecipientEmailAddress = n.GetStringValue(); } },
                {"senderIp", n => { SenderIp = n.GetStringValue(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"threatDetectionMethods", n => { ThreatDetectionMethods = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"threats", n => { Threats = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"urlCount", n => { UrlCount = n.GetLongValue(); } },
                {"urls", n => { Urls = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"urn", n => { Urn = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("antiSpamDirection", AntiSpamDirection);
            writer.WriteLongValue("attachmentsCount", AttachmentsCount);
            writer.WriteStringValue("deliveryAction", DeliveryAction);
            writer.WriteStringValue("deliveryLocation", DeliveryLocation);
            writer.WriteStringValue("internetMessageId", InternetMessageId);
            writer.WriteStringValue("language", Language);
            writer.WriteStringValue("networkMessageId", NetworkMessageId);
            writer.WriteObjectValue<EmailSender>("p1Sender", P1Sender);
            writer.WriteObjectValue<EmailSender>("p2Sender", P2Sender);
            writer.WriteDateTimeOffsetValue("receivedDateTime", ReceivedDateTime);
            writer.WriteStringValue("recipientEmailAddress", RecipientEmailAddress);
            writer.WriteStringValue("senderIp", SenderIp);
            writer.WriteStringValue("subject", Subject);
            writer.WriteCollectionOfPrimitiveValues<string>("threatDetectionMethods", ThreatDetectionMethods);
            writer.WriteCollectionOfPrimitiveValues<string>("threats", Threats);
            writer.WriteLongValue("urlCount", UrlCount);
            writer.WriteCollectionOfPrimitiveValues<string>("urls", Urls);
            writer.WriteStringValue("urn", Urn);
        }
    }
}
