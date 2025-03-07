using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class SearchHit : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The name of the content source that the externalItem is part of.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentSource { get; set; }
#nullable restore
#else
        public string ContentSource { get; set; }
#endif
        /// <summary>The internal identifier for the item. The format of the identifier varies based on the entity type. For details, see hitId format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HitId { get; set; }
#nullable restore
#else
        public string HitId { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The rank or the order of the result.</summary>
        public int? Rank { get; set; }
        /// <summary>The resource property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Entity? Resource { get; set; }
#nullable restore
#else
        public Entity Resource { get; set; }
#endif
        /// <summary>ID of the result template used to render the search result. This ID must map to a display layout in the resultTemplates dictionary that is also included in the searchResponse.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResultTemplateId { get; set; }
#nullable restore
#else
        public string ResultTemplateId { get; set; }
#endif
        /// <summary>A summary of the result, if a summary is available.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Summary { get; set; }
#nullable restore
#else
        public string Summary { get; set; }
#endif
        /// <summary>
        /// Instantiates a new searchHit and sets the default values.
        /// </summary>
        public SearchHit() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SearchHit CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchHit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"contentSource", n => { ContentSource = n.GetStringValue(); } },
                {"hitId", n => { HitId = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"rank", n => { Rank = n.GetIntValue(); } },
                {"resource", n => { Resource = n.GetObjectValue<Entity>(Entity.CreateFromDiscriminatorValue); } },
                {"resultTemplateId", n => { ResultTemplateId = n.GetStringValue(); } },
                {"summary", n => { Summary = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("contentSource", ContentSource);
            writer.WriteStringValue("hitId", HitId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("rank", Rank);
            writer.WriteObjectValue<Entity>("resource", Resource);
            writer.WriteStringValue("resultTemplateId", ResultTemplateId);
            writer.WriteStringValue("summary", Summary);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
