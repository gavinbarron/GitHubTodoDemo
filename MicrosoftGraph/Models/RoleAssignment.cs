using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>
    /// The Role Assignment resource. Role assignments tie together a role definition with members and scopes. There can be one or more role assignments per role. This applies to custom and built-in roles.
    /// </summary>
    public class RoleAssignment : Entity, IParsable {
        /// <summary>Description of the Role Assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The display or friendly name of the role Assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>List of ids of role scope member security groups.  These are IDs from Azure Active Directory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ResourceScopes { get; set; }
#nullable restore
#else
        public List<string> ResourceScopes { get; set; }
#endif
        /// <summary>Role definition this assignment is part of.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.RoleDefinition? RoleDefinition { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.RoleDefinition RoleDefinition { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RoleAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.deviceAndAppManagementRoleAssignment" => new DeviceAndAppManagementRoleAssignment(),
                _ => new RoleAssignment(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"resourceScopes", n => { ResourceScopes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"roleDefinition", n => { RoleDefinition = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.RoleDefinition>(GitHubTodoDemo.MicrosoftGraph.Models.RoleDefinition.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfPrimitiveValues<string>("resourceScopes", ResourceScopes);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.RoleDefinition>("roleDefinition", RoleDefinition);
        }
    }
}
