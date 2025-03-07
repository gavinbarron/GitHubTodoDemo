using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class SearchHitsContainer : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The aggregations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SearchAggregation>? Aggregations { get; set; }
#nullable restore
#else
        public List<SearchAggregation> Aggregations { get; set; }
#endif
        /// <summary>A collection of the search results.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SearchHit>? Hits { get; set; }
#nullable restore
#else
        public List<SearchHit> Hits { get; set; }
#endif
        /// <summary>Provides information if more results are available. Based on this information, you can adjust the from and size properties of the searchRequest accordingly.</summary>
        public bool? MoreResultsAvailable { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The total number of results. Note this is not the number of results on the page, but the total number of results satisfying the query.</summary>
        public int? Total { get; set; }
        /// <summary>
        /// Instantiates a new searchHitsContainer and sets the default values.
        /// </summary>
        public SearchHitsContainer() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SearchHitsContainer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchHitsContainer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"aggregations", n => { Aggregations = n.GetCollectionOfObjectValues<SearchAggregation>(SearchAggregation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hits", n => { Hits = n.GetCollectionOfObjectValues<SearchHit>(SearchHit.CreateFromDiscriminatorValue)?.ToList(); } },
                {"moreResultsAvailable", n => { MoreResultsAvailable = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"total", n => { Total = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<SearchAggregation>("aggregations", Aggregations);
            writer.WriteCollectionOfObjectValues<SearchHit>("hits", Hits);
            writer.WriteBoolValue("moreResultsAvailable", MoreResultsAvailable);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("total", Total);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
