using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class TeamFunSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If set to true, enables users to include custom memes.</summary>
        public bool? AllowCustomMemes { get; set; }
        /// <summary>If set to true, enables Giphy use.</summary>
        public bool? AllowGiphy { get; set; }
        /// <summary>If set to true, enables users to include stickers and memes.</summary>
        public bool? AllowStickersAndMemes { get; set; }
        /// <summary>Giphy content rating. Possible values are: moderate, strict.</summary>
        public GiphyRatingType? GiphyContentRating { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new teamFunSettings and sets the default values.
        /// </summary>
        public TeamFunSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamFunSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamFunSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowCustomMemes", n => { AllowCustomMemes = n.GetBoolValue(); } },
                {"allowGiphy", n => { AllowGiphy = n.GetBoolValue(); } },
                {"allowStickersAndMemes", n => { AllowStickersAndMemes = n.GetBoolValue(); } },
                {"giphyContentRating", n => { GiphyContentRating = n.GetEnumValue<GiphyRatingType>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowCustomMemes", AllowCustomMemes);
            writer.WriteBoolValue("allowGiphy", AllowGiphy);
            writer.WriteBoolValue("allowStickersAndMemes", AllowStickersAndMemes);
            writer.WriteEnumValue<GiphyRatingType>("giphyContentRating", GiphyContentRating);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
