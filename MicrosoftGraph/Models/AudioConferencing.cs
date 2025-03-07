using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class AudioConferencing : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The conference id of the online meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConferenceId { get; set; }
#nullable restore
#else
        public string ConferenceId { get; set; }
#endif
        /// <summary>A URL to the externally-accessible web page that contains dial-in information.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DialinUrl { get; set; }
#nullable restore
#else
        public string DialinUrl { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The tollFreeNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TollFreeNumber { get; set; }
#nullable restore
#else
        public string TollFreeNumber { get; set; }
#endif
        /// <summary>List of toll-free numbers that are displayed in the meeting invite.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? TollFreeNumbers { get; set; }
#nullable restore
#else
        public List<string> TollFreeNumbers { get; set; }
#endif
        /// <summary>The tollNumber property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TollNumber { get; set; }
#nullable restore
#else
        public string TollNumber { get; set; }
#endif
        /// <summary>List of toll numbers that are displayed in the meeting invite.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? TollNumbers { get; set; }
#nullable restore
#else
        public List<string> TollNumbers { get; set; }
#endif
        /// <summary>
        /// Instantiates a new audioConferencing and sets the default values.
        /// </summary>
        public AudioConferencing() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AudioConferencing CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AudioConferencing();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"conferenceId", n => { ConferenceId = n.GetStringValue(); } },
                {"dialinUrl", n => { DialinUrl = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"tollFreeNumber", n => { TollFreeNumber = n.GetStringValue(); } },
                {"tollFreeNumbers", n => { TollFreeNumbers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"tollNumber", n => { TollNumber = n.GetStringValue(); } },
                {"tollNumbers", n => { TollNumbers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("conferenceId", ConferenceId);
            writer.WriteStringValue("dialinUrl", DialinUrl);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("tollFreeNumber", TollFreeNumber);
            writer.WriteCollectionOfPrimitiveValues<string>("tollFreeNumbers", TollFreeNumbers);
            writer.WriteStringValue("tollNumber", TollNumber);
            writer.WriteCollectionOfPrimitiveValues<string>("tollNumbers", TollNumbers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
