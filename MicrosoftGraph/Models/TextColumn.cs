using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class TextColumn : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Whether to allow multiple lines of text.</summary>
        public bool? AllowMultipleLines { get; set; }
        /// <summary>Whether updates to this column should replace existing text, or append to it.</summary>
        public bool? AppendChangesToExistingText { get; set; }
        /// <summary>The size of the text box.</summary>
        public int? LinesForEditing { get; set; }
        /// <summary>The maximum number of characters for the value.</summary>
        public int? MaxLength { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The type of text being stored. Must be one of plain or richText</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TextType { get; set; }
#nullable restore
#else
        public string TextType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new textColumn and sets the default values.
        /// </summary>
        public TextColumn() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TextColumn CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TextColumn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowMultipleLines", n => { AllowMultipleLines = n.GetBoolValue(); } },
                {"appendChangesToExistingText", n => { AppendChangesToExistingText = n.GetBoolValue(); } },
                {"linesForEditing", n => { LinesForEditing = n.GetIntValue(); } },
                {"maxLength", n => { MaxLength = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"textType", n => { TextType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowMultipleLines", AllowMultipleLines);
            writer.WriteBoolValue("appendChangesToExistingText", AppendChangesToExistingText);
            writer.WriteIntValue("linesForEditing", LinesForEditing);
            writer.WriteIntValue("maxLength", MaxLength);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("textType", TextType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
