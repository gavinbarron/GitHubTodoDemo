using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models.Security {
    public class SiteSource : DataSource, IParsable {
        /// <summary>The site property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.Site? Site { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.Site Site { get; set; }
#endif
        /// <summary>
        /// Instantiates a new SiteSource and sets the default values.
        /// </summary>
        public SiteSource() : base() {
            OdataType = "#microsoft.graph.security.siteSource";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SiteSource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SiteSource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"site", n => { Site = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Site>(GitHubTodoDemo.MicrosoftGraph.Models.Site.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Site>("site", Site);
        }
    }
}
