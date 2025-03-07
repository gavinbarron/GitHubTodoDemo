using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class AccessReviewInstanceDecisionItem : Entity, IParsable {
        /// <summary>The identifier of the accessReviewInstance parent. Supports $select. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccessReviewId { get; set; }
#nullable restore
#else
        public string AccessReviewId { get; set; }
#endif
        /// <summary>The identifier of the user who applied the decision. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserIdentity? AppliedBy { get; set; }
#nullable restore
#else
        public UserIdentity AppliedBy { get; set; }
#endif
        /// <summary>The timestamp when the approval decision was applied.00000000-0000-0000-0000-000000000000 if the assigned reviewer hasn&apos;t applied the decision or it was automatically applied. The DatetimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.  Supports $select. Read-only.</summary>
        public DateTimeOffset? AppliedDateTime { get; set; }
        /// <summary>The result of applying the decision. Possible values: New, AppliedSuccessfully, AppliedWithUnknownFailure, AppliedSuccessfullyButObjectNotFound and ApplyNotSupported. Supports $select, $orderby, and $filter (eq only). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApplyResult { get; set; }
#nullable restore
#else
        public string ApplyResult { get; set; }
#endif
        /// <summary>Result of the review. Possible values: Approve, Deny, NotReviewed, or DontKnow. Supports $select, $orderby, and $filter (eq only).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Decision { get; set; }
#nullable restore
#else
        public string Decision { get; set; }
#endif
        /// <summary>Justification left by the reviewer when they made the decision.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Justification { get; set; }
#nullable restore
#else
        public string Justification { get; set; }
#endif
        /// <summary>Every decision item in an access review represents a principal&apos;s access to a resource. This property represents details of the principal. For example, if a decision item represents access of User &apos;Bob&apos; to Group &apos;Sales&apos; - The principal is &apos;Bob&apos; and the resource is &apos;Sales&apos;. Principals can be of two types - userIdentity and servicePrincipalIdentity. Supports $select. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Identity? Principal { get; set; }
#nullable restore
#else
        public Identity Principal { get; set; }
#endif
        /// <summary>A link to the principal object. For example, https://graph.microsoft.com/v1.0/users/a6c7aecb-cbfd-4763-87ef-e91b4bd509d9. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrincipalLink { get; set; }
#nullable restore
#else
        public string PrincipalLink { get; set; }
#endif
        /// <summary>A system-generated recommendation for the approval decision based off last interactive sign-in to tenant. Recommend approve if sign-in is within thirty days of start of review. Recommend deny if sign-in is greater than thirty days of start of review. Recommendation not available otherwise. Possible values: Approve, Deny, or NoInfoAvailable. Supports $select, $orderby, and $filter (eq only). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Recommendation { get; set; }
#nullable restore
#else
        public string Recommendation { get; set; }
#endif
        /// <summary>Every decision item in an access review represents a principal&apos;s access to a resource. This property represents details of the resource. For example, if a decision item represents access of User &apos;Bob&apos; to Group &apos;Sales&apos; - The principal is Bob and the resource is &apos;Sales&apos;. Resources can be of multiple types. See accessReviewInstanceDecisionItemResource. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccessReviewInstanceDecisionItemResource? Resource { get; set; }
#nullable restore
#else
        public AccessReviewInstanceDecisionItemResource Resource { get; set; }
#endif
        /// <summary>A link to the resource. For example, https://graph.microsoft.com/v1.0/servicePrincipals/c86300f3-8695-4320-9f6e-32a2555f5ff8. Supports $select. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceLink { get; set; }
#nullable restore
#else
        public string ResourceLink { get; set; }
#endif
        /// <summary>The identifier of the reviewer.00000000-0000-0000-0000-000000000000 if the assigned reviewer hasn&apos;t reviewed. Supports $select. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserIdentity? ReviewedBy { get; set; }
#nullable restore
#else
        public UserIdentity ReviewedBy { get; set; }
#endif
        /// <summary>The timestamp when the review decision occurred. Supports $select. Read-only.</summary>
        public DateTimeOffset? ReviewedDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessReviewInstanceDecisionItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReviewInstanceDecisionItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessReviewId", n => { AccessReviewId = n.GetStringValue(); } },
                {"appliedBy", n => { AppliedBy = n.GetObjectValue<UserIdentity>(UserIdentity.CreateFromDiscriminatorValue); } },
                {"appliedDateTime", n => { AppliedDateTime = n.GetDateTimeOffsetValue(); } },
                {"applyResult", n => { ApplyResult = n.GetStringValue(); } },
                {"decision", n => { Decision = n.GetStringValue(); } },
                {"justification", n => { Justification = n.GetStringValue(); } },
                {"principal", n => { Principal = n.GetObjectValue<Identity>(Identity.CreateFromDiscriminatorValue); } },
                {"principalLink", n => { PrincipalLink = n.GetStringValue(); } },
                {"recommendation", n => { Recommendation = n.GetStringValue(); } },
                {"resource", n => { Resource = n.GetObjectValue<AccessReviewInstanceDecisionItemResource>(AccessReviewInstanceDecisionItemResource.CreateFromDiscriminatorValue); } },
                {"resourceLink", n => { ResourceLink = n.GetStringValue(); } },
                {"reviewedBy", n => { ReviewedBy = n.GetObjectValue<UserIdentity>(UserIdentity.CreateFromDiscriminatorValue); } },
                {"reviewedDateTime", n => { ReviewedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("accessReviewId", AccessReviewId);
            writer.WriteObjectValue<UserIdentity>("appliedBy", AppliedBy);
            writer.WriteDateTimeOffsetValue("appliedDateTime", AppliedDateTime);
            writer.WriteStringValue("applyResult", ApplyResult);
            writer.WriteStringValue("decision", Decision);
            writer.WriteStringValue("justification", Justification);
            writer.WriteObjectValue<Identity>("principal", Principal);
            writer.WriteStringValue("principalLink", PrincipalLink);
            writer.WriteStringValue("recommendation", Recommendation);
            writer.WriteObjectValue<AccessReviewInstanceDecisionItemResource>("resource", Resource);
            writer.WriteStringValue("resourceLink", ResourceLink);
            writer.WriteObjectValue<UserIdentity>("reviewedBy", ReviewedBy);
            writer.WriteDateTimeOffsetValue("reviewedDateTime", ReviewedDateTime);
        }
    }
}
