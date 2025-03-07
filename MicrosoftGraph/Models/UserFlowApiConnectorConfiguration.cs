using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class UserFlowApiConnectorConfiguration : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The postAttributeCollection property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentityApiConnector? PostAttributeCollection { get; set; }
#nullable restore
#else
        public IdentityApiConnector PostAttributeCollection { get; set; }
#endif
        /// <summary>The postFederationSignup property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentityApiConnector? PostFederationSignup { get; set; }
#nullable restore
#else
        public IdentityApiConnector PostFederationSignup { get; set; }
#endif
        /// <summary>
        /// Instantiates a new userFlowApiConnectorConfiguration and sets the default values.
        /// </summary>
        public UserFlowApiConnectorConfiguration() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserFlowApiConnectorConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserFlowApiConnectorConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"postAttributeCollection", n => { PostAttributeCollection = n.GetObjectValue<IdentityApiConnector>(IdentityApiConnector.CreateFromDiscriminatorValue); } },
                {"postFederationSignup", n => { PostFederationSignup = n.GetObjectValue<IdentityApiConnector>(IdentityApiConnector.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<IdentityApiConnector>("postAttributeCollection", PostAttributeCollection);
            writer.WriteObjectValue<IdentityApiConnector>("postFederationSignup", PostFederationSignup);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
