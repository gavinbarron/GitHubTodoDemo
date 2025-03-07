using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class ParticipantInfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ISO 3166-1 Alpha-2 country code of the participant&apos;s best estimated physical location at the start of the call. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryCode { get; set; }
#nullable restore
#else
        public string CountryCode { get; set; }
#endif
        /// <summary>The type of endpoint the participant is using. Possible values are: default, skypeForBusiness, or skypeForBusinessVoipPhone. Read-only.</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.EndpointType? EndpointType { get; set; }
        /// <summary>The identity property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? Identity { get; set; }
#nullable restore
#else
        public IdentitySet Identity { get; set; }
#endif
        /// <summary>The language culture string. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LanguageId { get; set; }
#nullable restore
#else
        public string LanguageId { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The participant ID of the participant. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParticipantId { get; set; }
#nullable restore
#else
        public string ParticipantId { get; set; }
#endif
        /// <summary>The home region of the participant. This can be a country, a continent, or a larger geographic region. This does not change based on the participant&apos;s current physical location. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Region { get; set; }
#nullable restore
#else
        public string Region { get; set; }
#endif
        /// <summary>
        /// Instantiates a new participantInfo and sets the default values.
        /// </summary>
        public ParticipantInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ParticipantInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ParticipantInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"countryCode", n => { CountryCode = n.GetStringValue(); } },
                {"endpointType", n => { EndpointType = n.GetEnumValue<EndpointType>(); } },
                {"identity", n => { Identity = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"languageId", n => { LanguageId = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"participantId", n => { ParticipantId = n.GetStringValue(); } },
                {"region", n => { Region = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("countryCode", CountryCode);
            writer.WriteEnumValue<EndpointType>("endpointType", EndpointType);
            writer.WriteObjectValue<IdentitySet>("identity", Identity);
            writer.WriteStringValue("languageId", LanguageId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("participantId", ParticipantId);
            writer.WriteStringValue("region", Region);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
