using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class FileAttachment : Attachment, IParsable {
        /// <summary>The base64-encoded contents of the file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? ContentBytes { get; set; }
#nullable restore
#else
        public byte[] ContentBytes { get; set; }
#endif
        /// <summary>The ID of the attachment in the Exchange store.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentId { get; set; }
#nullable restore
#else
        public string ContentId { get; set; }
#endif
        /// <summary>Do not use this property as it is not supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentLocation { get; set; }
#nullable restore
#else
        public string ContentLocation { get; set; }
#endif
        /// <summary>
        /// Instantiates a new FileAttachment and sets the default values.
        /// </summary>
        public FileAttachment() : base() {
            OdataType = "#microsoft.graph.fileAttachment";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new FileAttachment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FileAttachment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"contentBytes", n => { ContentBytes = n.GetByteArrayValue(); } },
                {"contentId", n => { ContentId = n.GetStringValue(); } },
                {"contentLocation", n => { ContentLocation = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteByteArrayValue("contentBytes", ContentBytes);
            writer.WriteStringValue("contentId", ContentId);
            writer.WriteStringValue("contentLocation", ContentLocation);
        }
    }
}
