using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class UnifiedRoleManagementPolicyApprovalRule : UnifiedRoleManagementPolicyRule, IParsable {
        /// <summary>The settings for approval of the role assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ApprovalSettings? Setting { get; set; }
#nullable restore
#else
        public ApprovalSettings Setting { get; set; }
#endif
        /// <summary>
        /// Instantiates a new UnifiedRoleManagementPolicyApprovalRule and sets the default values.
        /// </summary>
        public UnifiedRoleManagementPolicyApprovalRule() : base() {
            OdataType = "#microsoft.graph.unifiedRoleManagementPolicyApprovalRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UnifiedRoleManagementPolicyApprovalRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleManagementPolicyApprovalRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"setting", n => { Setting = n.GetObjectValue<ApprovalSettings>(ApprovalSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApprovalSettings>("setting", Setting);
        }
    }
}
