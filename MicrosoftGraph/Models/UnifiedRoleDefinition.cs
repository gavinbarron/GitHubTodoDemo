using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class UnifiedRoleDefinition : Entity, IParsable {
        /// <summary>The description for the unifiedRoleDefinition. Read-only when isBuiltIn is true.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The display name for the unifiedRoleDefinition. Read-only when isBuiltIn is true. Required.  Supports $filter (eq, in).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Read-only collection of role definitions that the given role definition inherits from. Only Azure AD built-in roles (isBuiltIn is true) support this attribute. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRoleDefinition>? InheritsPermissionsFrom { get; set; }
#nullable restore
#else
        public List<UnifiedRoleDefinition> InheritsPermissionsFrom { get; set; }
#endif
        /// <summary>Flag indicating whether the role definition is part of the default set included in Azure Active Directory (Azure AD) or a custom definition. Read-only. Supports $filter (eq, in).</summary>
        public bool? IsBuiltIn { get; set; }
        /// <summary>Flag indicating whether the role is enabled for assignment. If false the role is not available for assignment. Read-only when isBuiltIn is true.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>List of the scopes or permissions the role definition applies to. Currently only / is supported. Read-only when isBuiltIn is true. DO NOT USE. This will be deprecated soon. Attach scope to role assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ResourceScopes { get; set; }
#nullable restore
#else
        public List<string> ResourceScopes { get; set; }
#endif
        /// <summary>List of permissions included in the role. Read-only when isBuiltIn is true. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UnifiedRolePermission>? RolePermissions { get; set; }
#nullable restore
#else
        public List<UnifiedRolePermission> RolePermissions { get; set; }
#endif
        /// <summary>Custom template identifier that can be set when isBuiltIn is false but is read-only when isBuiltIn is true. This identifier is typically used if one needs an identifier to be the same across different directories.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TemplateId { get; set; }
#nullable restore
#else
        public string TemplateId { get; set; }
#endif
        /// <summary>Indicates version of the role definition. Read-only when isBuiltIn is true.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version { get; set; }
#nullable restore
#else
        public string Version { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UnifiedRoleDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"inheritsPermissionsFrom", n => { InheritsPermissionsFrom = n.GetCollectionOfObjectValues<UnifiedRoleDefinition>(UnifiedRoleDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isBuiltIn", n => { IsBuiltIn = n.GetBoolValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"resourceScopes", n => { ResourceScopes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"rolePermissions", n => { RolePermissions = n.GetCollectionOfObjectValues<UnifiedRolePermission>(UnifiedRolePermission.CreateFromDiscriminatorValue)?.ToList(); } },
                {"templateId", n => { TemplateId = n.GetStringValue(); } },
                {"version", n => { Version = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<UnifiedRoleDefinition>("inheritsPermissionsFrom", InheritsPermissionsFrom);
            writer.WriteBoolValue("isBuiltIn", IsBuiltIn);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteCollectionOfPrimitiveValues<string>("resourceScopes", ResourceScopes);
            writer.WriteCollectionOfObjectValues<UnifiedRolePermission>("rolePermissions", RolePermissions);
            writer.WriteStringValue("templateId", TemplateId);
            writer.WriteStringValue("version", Version);
        }
    }
}
