using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class TargetedManagedAppConfiguration : ManagedAppConfiguration, IParsable {
        /// <summary>List of apps to which the policy is deployed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ManagedMobileApp>? Apps { get; set; }
#nullable restore
#else
        public List<ManagedMobileApp> Apps { get; set; }
#endif
        /// <summary>Navigation property to list of inclusion and exclusion groups to which the policy is deployed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TargetedManagedAppPolicyAssignment>? Assignments { get; set; }
#nullable restore
#else
        public List<TargetedManagedAppPolicyAssignment> Assignments { get; set; }
#endif
        /// <summary>Count of apps to which the current policy is deployed.</summary>
        public int? DeployedAppCount { get; set; }
        /// <summary>Navigation property to deployment summary of the configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ManagedAppPolicyDeploymentSummary? DeploymentSummary { get; set; }
#nullable restore
#else
        public ManagedAppPolicyDeploymentSummary DeploymentSummary { get; set; }
#endif
        /// <summary>Indicates if the policy is deployed to any inclusion groups or not.</summary>
        public bool? IsAssigned { get; set; }
        /// <summary>
        /// Instantiates a new TargetedManagedAppConfiguration and sets the default values.
        /// </summary>
        public TargetedManagedAppConfiguration() : base() {
            OdataType = "#microsoft.graph.targetedManagedAppConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TargetedManagedAppConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TargetedManagedAppConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"apps", n => { Apps = n.GetCollectionOfObjectValues<ManagedMobileApp>(ManagedMobileApp.CreateFromDiscriminatorValue)?.ToList(); } },
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<TargetedManagedAppPolicyAssignment>(TargetedManagedAppPolicyAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deployedAppCount", n => { DeployedAppCount = n.GetIntValue(); } },
                {"deploymentSummary", n => { DeploymentSummary = n.GetObjectValue<ManagedAppPolicyDeploymentSummary>(ManagedAppPolicyDeploymentSummary.CreateFromDiscriminatorValue); } },
                {"isAssigned", n => { IsAssigned = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ManagedMobileApp>("apps", Apps);
            writer.WriteCollectionOfObjectValues<TargetedManagedAppPolicyAssignment>("assignments", Assignments);
            writer.WriteIntValue("deployedAppCount", DeployedAppCount);
            writer.WriteObjectValue<ManagedAppPolicyDeploymentSummary>("deploymentSummary", DeploymentSummary);
            writer.WriteBoolValue("isAssigned", IsAssigned);
        }
    }
}
