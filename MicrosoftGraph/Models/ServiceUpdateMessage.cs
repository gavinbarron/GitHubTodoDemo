using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class ServiceUpdateMessage : ServiceAnnouncementBase, IParsable {
        /// <summary>The expected deadline of the action for the message.</summary>
        public DateTimeOffset? ActionRequiredByDateTime { get; set; }
        /// <summary>A collection of serviceAnnouncementAttachments.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ServiceAnnouncementAttachment>? Attachments { get; set; }
#nullable restore
#else
        public List<ServiceAnnouncementAttachment> Attachments { get; set; }
#endif
        /// <summary>The zip file that contains all attachments for a message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? AttachmentsArchive { get; set; }
#nullable restore
#else
        public byte[] AttachmentsArchive { get; set; }
#endif
        /// <summary>The body property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemBody? Body { get; set; }
#nullable restore
#else
        public ItemBody Body { get; set; }
#endif
        /// <summary>The category property</summary>
        public ServiceUpdateCategory? Category { get; set; }
        /// <summary>Indicates whether the message has any attachment.</summary>
        public bool? HasAttachments { get; set; }
        /// <summary>Indicates whether the message describes a major update for the service.</summary>
        public bool? IsMajorChange { get; set; }
        /// <summary>The affected services by the service message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Services { get; set; }
#nullable restore
#else
        public List<string> Services { get; set; }
#endif
        /// <summary>The severity property</summary>
        public ServiceUpdateSeverity? Severity { get; set; }
        /// <summary>A collection of tags for the service message. Tags are provided by the service team/support team who post the message to tell whether this message contains privacy data, or whether this message is for a service new feature update, and so on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags { get; set; }
#nullable restore
#else
        public List<string> Tags { get; set; }
#endif
        /// <summary>Represents user viewpoints data of the service message. This data includes message status such as whether the user has archived, read, or marked the message as favorite. This property is null when accessed with application permissions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ServiceUpdateMessageViewpoint? ViewPoint { get; set; }
#nullable restore
#else
        public ServiceUpdateMessageViewpoint ViewPoint { get; set; }
#endif
        /// <summary>
        /// Instantiates a new ServiceUpdateMessage and sets the default values.
        /// </summary>
        public ServiceUpdateMessage() : base() {
            OdataType = "#microsoft.graph.serviceUpdateMessage";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ServiceUpdateMessage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServiceUpdateMessage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actionRequiredByDateTime", n => { ActionRequiredByDateTime = n.GetDateTimeOffsetValue(); } },
                {"attachments", n => { Attachments = n.GetCollectionOfObjectValues<ServiceAnnouncementAttachment>(ServiceAnnouncementAttachment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"attachmentsArchive", n => { AttachmentsArchive = n.GetByteArrayValue(); } },
                {"body", n => { Body = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"category", n => { Category = n.GetEnumValue<ServiceUpdateCategory>(); } },
                {"hasAttachments", n => { HasAttachments = n.GetBoolValue(); } },
                {"isMajorChange", n => { IsMajorChange = n.GetBoolValue(); } },
                {"services", n => { Services = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"severity", n => { Severity = n.GetEnumValue<ServiceUpdateSeverity>(); } },
                {"tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"viewPoint", n => { ViewPoint = n.GetObjectValue<ServiceUpdateMessageViewpoint>(ServiceUpdateMessageViewpoint.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("actionRequiredByDateTime", ActionRequiredByDateTime);
            writer.WriteCollectionOfObjectValues<ServiceAnnouncementAttachment>("attachments", Attachments);
            writer.WriteByteArrayValue("attachmentsArchive", AttachmentsArchive);
            writer.WriteObjectValue<ItemBody>("body", Body);
            writer.WriteEnumValue<ServiceUpdateCategory>("category", Category);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteBoolValue("isMajorChange", IsMajorChange);
            writer.WriteCollectionOfPrimitiveValues<string>("services", Services);
            writer.WriteEnumValue<ServiceUpdateSeverity>("severity", Severity);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteObjectValue<ServiceUpdateMessageViewpoint>("viewPoint", ViewPoint);
        }
    }
}
