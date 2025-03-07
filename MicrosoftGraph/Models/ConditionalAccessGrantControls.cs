using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class ConditionalAccessGrantControls : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>List of values of built-in controls required by the policy. Possible values: block, mfa, compliantDevice, domainJoinedDevice, approvedApplication, compliantApplication, passwordChange, unknownFutureValue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ConditionalAccessGrantControl?>? BuiltInControls { get; set; }
#nullable restore
#else
        public List<ConditionalAccessGrantControl?> BuiltInControls { get; set; }
#endif
        /// <summary>List of custom controls IDs required by the policy. For more information, see Custom controls.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CustomAuthenticationFactors { get; set; }
#nullable restore
#else
        public List<string> CustomAuthenticationFactors { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Defines the relationship of the grant controls. Possible values: AND, OR.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Operator { get; set; }
#nullable restore
#else
        public string Operator { get; set; }
#endif
        /// <summary>List of terms of use IDs required by the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? TermsOfUse { get; set; }
#nullable restore
#else
        public List<string> TermsOfUse { get; set; }
#endif
        /// <summary>
        /// Instantiates a new conditionalAccessGrantControls and sets the default values.
        /// </summary>
        public ConditionalAccessGrantControls() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ConditionalAccessGrantControls CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessGrantControls();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"builtInControls", n => { BuiltInControls = n.GetCollectionOfEnumValues<ConditionalAccessGrantControl>()?.ToList(); } },
                {"customAuthenticationFactors", n => { CustomAuthenticationFactors = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"operator", n => { Operator = n.GetStringValue(); } },
                {"termsOfUse", n => { TermsOfUse = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<ConditionalAccessGrantControl>("builtInControls", BuiltInControls);
            writer.WriteCollectionOfPrimitiveValues<string>("customAuthenticationFactors", CustomAuthenticationFactors);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("operator", Operator);
            writer.WriteCollectionOfPrimitiveValues<string>("termsOfUse", TermsOfUse);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
