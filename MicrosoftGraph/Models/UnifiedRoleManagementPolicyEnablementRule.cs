using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class UnifiedRoleManagementPolicyEnablementRule : UnifiedRoleManagementPolicyRule, IParsable {
        /// <summary>The collection of rules that are enabled for this policy rule. For example, MultiFactorAuthentication, Ticketing, and Justification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? EnabledRules { get; set; }
#nullable restore
#else
        public List<string> EnabledRules { get; set; }
#endif
        /// <summary>
        /// Instantiates a new UnifiedRoleManagementPolicyEnablementRule and sets the default values.
        /// </summary>
        public UnifiedRoleManagementPolicyEnablementRule() : base() {
            OdataType = "#microsoft.graph.unifiedRoleManagementPolicyEnablementRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UnifiedRoleManagementPolicyEnablementRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleManagementPolicyEnablementRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"enabledRules", n => { EnabledRules = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("enabledRules", EnabledRules);
        }
    }
}
