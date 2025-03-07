using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class CloudAppSecuritySessionControl : ConditionalAccessSessionControl, IParsable {
        /// <summary>Possible values are: mcasConfigured, monitorOnly, blockDownloads, unknownFutureValue. For more information, see Deploy Conditional Access App Control for featured apps.</summary>
        public CloudAppSecuritySessionControlType? CloudAppSecurityType { get; set; }
        /// <summary>
        /// Instantiates a new CloudAppSecuritySessionControl and sets the default values.
        /// </summary>
        public CloudAppSecuritySessionControl() : base() {
            OdataType = "#microsoft.graph.cloudAppSecuritySessionControl";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CloudAppSecuritySessionControl CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudAppSecuritySessionControl();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"cloudAppSecurityType", n => { CloudAppSecurityType = n.GetEnumValue<CloudAppSecuritySessionControlType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<CloudAppSecuritySessionControlType>("cloudAppSecurityType", CloudAppSecurityType);
        }
    }
}
