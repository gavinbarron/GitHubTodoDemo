using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class AccessPackageAssignmentPolicy : Entity, IParsable {
        /// <summary>Access package containing this policy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.AccessPackage? AccessPackage { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.AccessPackage AccessPackage { get; set; }
#endif
        /// <summary>Principals that can be assigned the access package through this policy. The possible values are: notSpecified, specificDirectoryUsers, specificConnectedOrganizationUsers, specificDirectoryServicePrincipals, allMemberUsers, allDirectoryUsers, allDirectoryServicePrincipals, allConfiguredConnectedOrganizationUsers, allExternalUsers, unknownFutureValue.</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.AllowedTargetScope? AllowedTargetScope { get; set; }
        /// <summary>This property is only present for an auto assignment policy; if absent, this is a request-based policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccessPackageAutomaticRequestSettings? AutomaticRequestSettings { get; set; }
#nullable restore
#else
        public AccessPackageAutomaticRequestSettings AutomaticRequestSettings { get; set; }
#endif
        /// <summary>Catalog of the access package containing this policy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccessPackageCatalog? Catalog { get; set; }
#nullable restore
#else
        public AccessPackageCatalog Catalog { get; set; }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The description of the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The display name of the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The expiration date for assignments created in this policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ExpirationPattern? Expiration { get; set; }
#nullable restore
#else
        public ExpirationPattern Expiration { get; set; }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
        /// <summary>Specifies the settings for approval of requests for an access package assignment through this policy. For example, if approval is required for new requests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccessPackageAssignmentApprovalSettings? RequestApprovalSettings { get; set; }
#nullable restore
#else
        public AccessPackageAssignmentApprovalSettings RequestApprovalSettings { get; set; }
#endif
        /// <summary>Provides additional settings to select who can create a request for an access package assignment through this policy, and what they can include in their request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccessPackageAssignmentRequestorSettings? RequestorSettings { get; set; }
#nullable restore
#else
        public AccessPackageAssignmentRequestorSettings RequestorSettings { get; set; }
#endif
        /// <summary>Settings for access reviews of assignments through this policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccessPackageAssignmentReviewSettings? ReviewSettings { get; set; }
#nullable restore
#else
        public AccessPackageAssignmentReviewSettings ReviewSettings { get; set; }
#endif
        /// <summary>The principals that can be assigned access from an access package through this policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SubjectSet>? SpecificAllowedTargets { get; set; }
#nullable restore
#else
        public List<SubjectSet> SpecificAllowedTargets { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessPackageAssignmentPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignmentPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessPackage", n => { AccessPackage = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.AccessPackage>(GitHubTodoDemo.MicrosoftGraph.Models.AccessPackage.CreateFromDiscriminatorValue); } },
                {"allowedTargetScope", n => { AllowedTargetScope = n.GetEnumValue<AllowedTargetScope>(); } },
                {"automaticRequestSettings", n => { AutomaticRequestSettings = n.GetObjectValue<AccessPackageAutomaticRequestSettings>(AccessPackageAutomaticRequestSettings.CreateFromDiscriminatorValue); } },
                {"catalog", n => { Catalog = n.GetObjectValue<AccessPackageCatalog>(AccessPackageCatalog.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"expiration", n => { Expiration = n.GetObjectValue<ExpirationPattern>(ExpirationPattern.CreateFromDiscriminatorValue); } },
                {"modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"requestApprovalSettings", n => { RequestApprovalSettings = n.GetObjectValue<AccessPackageAssignmentApprovalSettings>(AccessPackageAssignmentApprovalSettings.CreateFromDiscriminatorValue); } },
                {"requestorSettings", n => { RequestorSettings = n.GetObjectValue<AccessPackageAssignmentRequestorSettings>(AccessPackageAssignmentRequestorSettings.CreateFromDiscriminatorValue); } },
                {"reviewSettings", n => { ReviewSettings = n.GetObjectValue<AccessPackageAssignmentReviewSettings>(AccessPackageAssignmentReviewSettings.CreateFromDiscriminatorValue); } },
                {"specificAllowedTargets", n => { SpecificAllowedTargets = n.GetCollectionOfObjectValues<SubjectSet>(SubjectSet.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.AccessPackage>("accessPackage", AccessPackage);
            writer.WriteEnumValue<AllowedTargetScope>("allowedTargetScope", AllowedTargetScope);
            writer.WriteObjectValue<AccessPackageAutomaticRequestSettings>("automaticRequestSettings", AutomaticRequestSettings);
            writer.WriteObjectValue<AccessPackageCatalog>("catalog", Catalog);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<ExpirationPattern>("expiration", Expiration);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteObjectValue<AccessPackageAssignmentApprovalSettings>("requestApprovalSettings", RequestApprovalSettings);
            writer.WriteObjectValue<AccessPackageAssignmentRequestorSettings>("requestorSettings", RequestorSettings);
            writer.WriteObjectValue<AccessPackageAssignmentReviewSettings>("reviewSettings", ReviewSettings);
            writer.WriteCollectionOfObjectValues<SubjectSet>("specificAllowedTargets", SpecificAllowedTargets);
        }
    }
}
