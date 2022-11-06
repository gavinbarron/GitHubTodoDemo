using GitHubTodoDemo.MicrosoftGraph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>OMA Settings definition.</summary>
    public class OmaSetting : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Description.</summary>
        public string Description { get; set; }
        /// <summary>Display Name.</summary>
        public string DisplayName { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>OMA.</summary>
        public string OmaUri { get; set; }
        /// <summary>
        /// Instantiates a new omaSetting and sets the default values.
        /// </summary>
        public OmaSetting() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.omaSetting";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OmaSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.omaSettingBase64" => new OmaSettingBase64(),
                "#microsoft.graph.omaSettingBoolean" => new OmaSettingBoolean(),
                "#microsoft.graph.omaSettingDateTime" => new OmaSettingDateTime(),
                "#microsoft.graph.omaSettingFloatingPoint" => new OmaSettingFloatingPoint(),
                "#microsoft.graph.omaSettingInteger" => new OmaSettingInteger(),
                "#microsoft.graph.omaSettingString" => new OmaSettingString(),
                "#microsoft.graph.omaSettingStringXml" => new OmaSettingStringXml(),
                _ => new OmaSetting(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"omaUri", n => { OmaUri = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("omaUri", OmaUri);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
