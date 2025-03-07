using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class AccessPackageSubject : Entity, IParsable {
        /// <summary>The connected organization of the subject. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.ConnectedOrganization? ConnectedOrganization { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.ConnectedOrganization ConnectedOrganization { get; set; }
#endif
        /// <summary>The display name of the subject.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The email address of the subject.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The object identifier of the subject. null if the subject is not yet a user in the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObjectId { get; set; }
#nullable restore
#else
        public string ObjectId { get; set; }
#endif
        /// <summary>A string representation of the principal&apos;s security identifier, if known, or null if the subject does not have a security identifier.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnPremisesSecurityIdentifier { get; set; }
#nullable restore
#else
        public string OnPremisesSecurityIdentifier { get; set; }
#endif
        /// <summary>The principal name, if known, of the subject.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrincipalName { get; set; }
#nullable restore
#else
        public string PrincipalName { get; set; }
#endif
        /// <summary>The resource type of the subject. The possible values are: notSpecified, user, servicePrincipal, unknownFutureValue.</summary>
        public AccessPackageSubjectType? SubjectType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessPackageSubject CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageSubject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"connectedOrganization", n => { ConnectedOrganization = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.ConnectedOrganization>(GitHubTodoDemo.MicrosoftGraph.Models.ConnectedOrganization.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"objectId", n => { ObjectId = n.GetStringValue(); } },
                {"onPremisesSecurityIdentifier", n => { OnPremisesSecurityIdentifier = n.GetStringValue(); } },
                {"principalName", n => { PrincipalName = n.GetStringValue(); } },
                {"subjectType", n => { SubjectType = n.GetEnumValue<AccessPackageSubjectType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.ConnectedOrganization>("connectedOrganization", ConnectedOrganization);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("objectId", ObjectId);
            writer.WriteStringValue("onPremisesSecurityIdentifier", OnPremisesSecurityIdentifier);
            writer.WriteStringValue("principalName", PrincipalName);
            writer.WriteEnumValue<AccessPackageSubjectType>("subjectType", SubjectType);
        }
    }
}
