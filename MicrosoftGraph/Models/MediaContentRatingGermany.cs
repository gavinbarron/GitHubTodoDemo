using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GithubTodoDemo.MicrosoftGraph.Models {
    public class MediaContentRatingGermany : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Movies rating labels in Germany</summary>
        public RatingGermanyMoviesType? MovieRating { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>TV content rating labels in Germany</summary>
        public RatingGermanyTelevisionType? TvRating { get; set; }
        /// <summary>
        /// Instantiates a new mediaContentRatingGermany and sets the default values.
        /// </summary>
        public MediaContentRatingGermany() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.mediaContentRatingGermany";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MediaContentRatingGermany CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MediaContentRatingGermany();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"movieRating", n => { MovieRating = n.GetEnumValue<RatingGermanyMoviesType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"tvRating", n => { TvRating = n.GetEnumValue<RatingGermanyTelevisionType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<RatingGermanyMoviesType>("movieRating", MovieRating);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<RatingGermanyTelevisionType>("tvRating", TvRating);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
