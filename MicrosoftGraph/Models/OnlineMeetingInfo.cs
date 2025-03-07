using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class OnlineMeetingInfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ID of the conference.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConferenceId { get; set; }
#nullable restore
#else
        public string ConferenceId { get; set; }
#endif
        /// <summary>The external link that launches the online meeting. This is a URL that clients will launch into a browser and will redirect the user to join the meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JoinUrl { get; set; }
#nullable restore
#else
        public string JoinUrl { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>All of the phone numbers associated with this conference.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Phone>? Phones { get; set; }
#nullable restore
#else
        public List<Phone> Phones { get; set; }
#endif
        /// <summary>The pre-formatted quickdial for this call.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? QuickDial { get; set; }
#nullable restore
#else
        public string QuickDial { get; set; }
#endif
        /// <summary>The toll free numbers that can be used to join the conference.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? TollFreeNumbers { get; set; }
#nullable restore
#else
        public List<string> TollFreeNumbers { get; set; }
#endif
        /// <summary>The toll number that can be used to join the conference.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TollNumber { get; set; }
#nullable restore
#else
        public string TollNumber { get; set; }
#endif
        /// <summary>
        /// Instantiates a new onlineMeetingInfo and sets the default values.
        /// </summary>
        public OnlineMeetingInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OnlineMeetingInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnlineMeetingInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"conferenceId", n => { ConferenceId = n.GetStringValue(); } },
                {"joinUrl", n => { JoinUrl = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"phones", n => { Phones = n.GetCollectionOfObjectValues<Phone>(Phone.CreateFromDiscriminatorValue)?.ToList(); } },
                {"quickDial", n => { QuickDial = n.GetStringValue(); } },
                {"tollFreeNumbers", n => { TollFreeNumbers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"tollNumber", n => { TollNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("conferenceId", ConferenceId);
            writer.WriteStringValue("joinUrl", JoinUrl);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<Phone>("phones", Phones);
            writer.WriteStringValue("quickDial", QuickDial);
            writer.WriteCollectionOfPrimitiveValues<string>("tollFreeNumbers", TollFreeNumbers);
            writer.WriteStringValue("tollNumber", TollNumber);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
