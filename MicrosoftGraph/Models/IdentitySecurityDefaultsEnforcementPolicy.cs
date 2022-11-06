using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class IdentitySecurityDefaultsEnforcementPolicy : PolicyBase, IParsable {
        /// <summary>If set to true, Azure Active Directory security defaults is enabled for the tenant.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>
        /// Instantiates a new IdentitySecurityDefaultsEnforcementPolicy and sets the default values.
        /// </summary>
        public IdentitySecurityDefaultsEnforcementPolicy() : base() {
            OdataType = "#microsoft.graph.identitySecurityDefaultsEnforcementPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IdentitySecurityDefaultsEnforcementPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IdentitySecurityDefaultsEnforcementPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isEnabled", IsEnabled);
        }
    }
}
