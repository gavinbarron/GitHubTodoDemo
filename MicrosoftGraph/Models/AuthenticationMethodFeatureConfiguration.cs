using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class AuthenticationMethodFeatureConfiguration : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A single entity that is excluded from this feature.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FeatureTarget? ExcludeTarget { get; set; }
#nullable restore
#else
        public FeatureTarget ExcludeTarget { get; set; }
#endif
        /// <summary>A single entity that is included in this feature.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FeatureTarget? IncludeTarget { get; set; }
#nullable restore
#else
        public FeatureTarget IncludeTarget { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Enable or disable the feature. Possible values are: default, enabled, disabled, unknownFutureValue. The default value is used when the configuration hasn&apos;t been explicitly set and uses the default behavior of Azure AD for the setting. The default value is disabled.</summary>
        public AdvancedConfigState? State { get; set; }
        /// <summary>
        /// Instantiates a new authenticationMethodFeatureConfiguration and sets the default values.
        /// </summary>
        public AuthenticationMethodFeatureConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AuthenticationMethodFeatureConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationMethodFeatureConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"excludeTarget", n => { ExcludeTarget = n.GetObjectValue<FeatureTarget>(FeatureTarget.CreateFromDiscriminatorValue); } },
                {"includeTarget", n => { IncludeTarget = n.GetObjectValue<FeatureTarget>(FeatureTarget.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<AdvancedConfigState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<FeatureTarget>("excludeTarget", ExcludeTarget);
            writer.WriteObjectValue<FeatureTarget>("includeTarget", IncludeTarget);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<AdvancedConfigState>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
