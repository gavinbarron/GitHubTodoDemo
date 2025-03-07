using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class UnifiedRoleManagementPolicyAuthenticationContextRule : UnifiedRoleManagementPolicyRule, IParsable {
        /// <summary>The value of the authentication context claim.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClaimValue { get; set; }
#nullable restore
#else
        public string ClaimValue { get; set; }
#endif
        /// <summary>Whether this rule is enabled.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>
        /// Instantiates a new UnifiedRoleManagementPolicyAuthenticationContextRule and sets the default values.
        /// </summary>
        public UnifiedRoleManagementPolicyAuthenticationContextRule() : base() {
            OdataType = "#microsoft.graph.unifiedRoleManagementPolicyAuthenticationContextRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UnifiedRoleManagementPolicyAuthenticationContextRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleManagementPolicyAuthenticationContextRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"claimValue", n => { ClaimValue = n.GetStringValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("claimValue", ClaimValue);
            writer.WriteBoolValue("isEnabled", IsEnabled);
        }
    }
}
