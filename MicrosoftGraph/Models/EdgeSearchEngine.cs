using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class EdgeSearchEngine : EdgeSearchEngineBase, IParsable {
        /// <summary>Allows IT admind to set a predefined default search engine for MDM-Controlled devices</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.EdgeSearchEngineType? EdgeSearchEngineType { get; set; }
        /// <summary>
        /// Instantiates a new EdgeSearchEngine and sets the default values.
        /// </summary>
        public EdgeSearchEngine() : base() {
            OdataType = "#microsoft.graph.edgeSearchEngine";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EdgeSearchEngine CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EdgeSearchEngine();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"edgeSearchEngineType", n => { EdgeSearchEngineType = n.GetEnumValue<EdgeSearchEngineType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<EdgeSearchEngineType>("edgeSearchEngineType", EdgeSearchEngineType);
        }
    }
}
