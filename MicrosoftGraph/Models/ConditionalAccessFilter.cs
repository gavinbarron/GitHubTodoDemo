using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class ConditionalAccessFilter : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The mode property</summary>
        public FilterMode? Mode { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Rule syntax is similar to that used for membership rules for groups in Azure Active Directory (Azure AD). For details, see rules with multiple expressions</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Rule { get; set; }
#nullable restore
#else
        public string Rule { get; set; }
#endif
        /// <summary>
        /// Instantiates a new conditionalAccessFilter and sets the default values.
        /// </summary>
        public ConditionalAccessFilter() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ConditionalAccessFilter CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessFilter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"mode", n => { Mode = n.GetEnumValue<FilterMode>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"rule", n => { Rule = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<FilterMode>("mode", Mode);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("rule", Rule);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
