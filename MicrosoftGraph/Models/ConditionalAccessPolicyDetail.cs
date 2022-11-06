using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class ConditionalAccessPolicyDetail : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The conditions property</summary>
        public ConditionalAccessConditionSet Conditions { get; set; }
        /// <summary>Represents grant controls that must be fulfilled for the policy.</summary>
        public ConditionalAccessGrantControls GrantControls { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>Represents a complex type of session controls that is enforced after sign-in.</summary>
        public ConditionalAccessSessionControls SessionControls { get; set; }
        /// <summary>
        /// Instantiates a new conditionalAccessPolicyDetail and sets the default values.
        /// </summary>
        public ConditionalAccessPolicyDetail() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.conditionalAccessPolicyDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ConditionalAccessPolicyDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessPolicyDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"conditions", n => { Conditions = n.GetObjectValue<ConditionalAccessConditionSet>(ConditionalAccessConditionSet.CreateFromDiscriminatorValue); } },
                {"grantControls", n => { GrantControls = n.GetObjectValue<ConditionalAccessGrantControls>(ConditionalAccessGrantControls.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"sessionControls", n => { SessionControls = n.GetObjectValue<ConditionalAccessSessionControls>(ConditionalAccessSessionControls.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ConditionalAccessConditionSet>("conditions", Conditions);
            writer.WriteObjectValue<ConditionalAccessGrantControls>("grantControls", GrantControls);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<ConditionalAccessSessionControls>("sessionControls", SessionControls);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
