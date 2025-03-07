using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class VisualInfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Optional. JSON object used to represent an icon which represents the application used to generate the activity</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ImageInfo? Attribution { get; set; }
#nullable restore
#else
        public ImageInfo Attribution { get; set; }
#endif
        /// <summary>Optional. Background color used to render the activity in the UI - brand color for the application source of the activity. Must be a valid hex color</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BackgroundColor { get; set; }
#nullable restore
#else
        public string BackgroundColor { get; set; }
#endif
        /// <summary>Optional. Custom piece of data - JSON object used to provide custom content to render the activity in the Windows Shell UI</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Content { get; set; }
#nullable restore
#else
        public Json Content { get; set; }
#endif
        /// <summary>Optional. Longer text description of the user&apos;s unique activity (example: document name, first sentence, and/or metadata)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Required. Short text description of the user&apos;s unique activity (for example, document name in cases where an activity refers to document creation)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayText { get; set; }
#nullable restore
#else
        public string DisplayText { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new visualInfo and sets the default values.
        /// </summary>
        public VisualInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static VisualInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VisualInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"attribution", n => { Attribution = n.GetObjectValue<ImageInfo>(ImageInfo.CreateFromDiscriminatorValue); } },
                {"backgroundColor", n => { BackgroundColor = n.GetStringValue(); } },
                {"content", n => { Content = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayText", n => { DisplayText = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ImageInfo>("attribution", Attribution);
            writer.WriteStringValue("backgroundColor", BackgroundColor);
            writer.WriteObjectValue<Json>("content", Content);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayText", DisplayText);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
