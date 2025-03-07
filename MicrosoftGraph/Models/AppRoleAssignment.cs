using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class AppRoleAssignment : DirectoryObject, IParsable {
        /// <summary>The identifier (id) for the app role which is assigned to the principal. This app role must be exposed in the appRoles property on the resource application&apos;s service principal (resourceId). If the resource application has not declared any app roles, a default app role ID of 00000000-0000-0000-0000-000000000000 can be specified to signal that the principal is assigned to the resource app without any specific app roles. Required on create.</summary>
        public Guid? AppRoleId { get; set; }
        /// <summary>The time when the app role assignment was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The display name of the user, group, or service principal that was granted the app role assignment. Read-only. Supports $filter (eq and startswith).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrincipalDisplayName { get; set; }
#nullable restore
#else
        public string PrincipalDisplayName { get; set; }
#endif
        /// <summary>The unique identifier (id) for the user, security group, or service principal being granted the app role. Security groups with dynamic memberships are supported. Required on create.</summary>
        public Guid? PrincipalId { get; set; }
        /// <summary>The type of the assigned principal. This can either be User, Group, or ServicePrincipal. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrincipalType { get; set; }
#nullable restore
#else
        public string PrincipalType { get; set; }
#endif
        /// <summary>The display name of the resource app&apos;s service principal to which the assignment is made.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceDisplayName { get; set; }
#nullable restore
#else
        public string ResourceDisplayName { get; set; }
#endif
        /// <summary>The unique identifier (id) for the resource service principal for which the assignment is made. Required on create. Supports $filter (eq only).</summary>
        public Guid? ResourceId { get; set; }
        /// <summary>
        /// Instantiates a new appRoleAssignment and sets the default values.
        /// </summary>
        public AppRoleAssignment() : base() {
            OdataType = "#microsoft.graph.appRoleAssignment";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AppRoleAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppRoleAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appRoleId", n => { AppRoleId = n.GetGuidValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"principalDisplayName", n => { PrincipalDisplayName = n.GetStringValue(); } },
                {"principalId", n => { PrincipalId = n.GetGuidValue(); } },
                {"principalType", n => { PrincipalType = n.GetStringValue(); } },
                {"resourceDisplayName", n => { ResourceDisplayName = n.GetStringValue(); } },
                {"resourceId", n => { ResourceId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteGuidValue("appRoleId", AppRoleId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("principalDisplayName", PrincipalDisplayName);
            writer.WriteGuidValue("principalId", PrincipalId);
            writer.WriteStringValue("principalType", PrincipalType);
            writer.WriteStringValue("resourceDisplayName", ResourceDisplayName);
            writer.WriteGuidValue("resourceId", ResourceId);
        }
    }
}
