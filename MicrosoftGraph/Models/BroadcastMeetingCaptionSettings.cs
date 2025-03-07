using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class BroadcastMeetingCaptionSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether captions are enabled for this Teams live event.</summary>
        public bool? IsCaptionEnabled { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The spoken language.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SpokenLanguage { get; set; }
#nullable restore
#else
        public string SpokenLanguage { get; set; }
#endif
        /// <summary>The translation languages (choose up to 6).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? TranslationLanguages { get; set; }
#nullable restore
#else
        public List<string> TranslationLanguages { get; set; }
#endif
        /// <summary>
        /// Instantiates a new broadcastMeetingCaptionSettings and sets the default values.
        /// </summary>
        public BroadcastMeetingCaptionSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BroadcastMeetingCaptionSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BroadcastMeetingCaptionSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isCaptionEnabled", n => { IsCaptionEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"spokenLanguage", n => { SpokenLanguage = n.GetStringValue(); } },
                {"translationLanguages", n => { TranslationLanguages = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isCaptionEnabled", IsCaptionEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("spokenLanguage", SpokenLanguage);
            writer.WriteCollectionOfPrimitiveValues<string>("translationLanguages", TranslationLanguages);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
