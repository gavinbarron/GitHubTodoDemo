using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class AccessPackageApprovalStage : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The number of days that a request can be pending a response before it is automatically denied.</summary>
        public TimeSpan? DurationBeforeAutomaticDenial { get; set; }
        /// <summary>If escalation is required, the time a request can be pending a response from a primary approver.</summary>
        public TimeSpan? DurationBeforeEscalation { get; set; }
        /// <summary>If escalation is enabled and the primary approvers do not respond before the escalation time, the escalationApprovers are the users who will be asked to approve requests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SubjectSet>? EscalationApprovers { get; set; }
#nullable restore
#else
        public List<SubjectSet> EscalationApprovers { get; set; }
#endif
        /// <summary>The subjects, typically users, who are the fallback escalation approvers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SubjectSet>? FallbackEscalationApprovers { get; set; }
#nullable restore
#else
        public List<SubjectSet> FallbackEscalationApprovers { get; set; }
#endif
        /// <summary>The subjects, typically users, who are the fallback primary approvers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SubjectSet>? FallbackPrimaryApprovers { get; set; }
#nullable restore
#else
        public List<SubjectSet> FallbackPrimaryApprovers { get; set; }
#endif
        /// <summary>Indicates whether the approver is required to provide a justification for approving a request.</summary>
        public bool? IsApproverJustificationRequired { get; set; }
        /// <summary>If true, then one or more escalationApprovers are configured in this approval stage.</summary>
        public bool? IsEscalationEnabled { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The subjects, typically users, who will be asked to approve requests. A collection of singleUser, groupMembers, requestorManager, internalSponsors or externalSponsors.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SubjectSet>? PrimaryApprovers { get; set; }
#nullable restore
#else
        public List<SubjectSet> PrimaryApprovers { get; set; }
#endif
        /// <summary>
        /// Instantiates a new accessPackageApprovalStage and sets the default values.
        /// </summary>
        public AccessPackageApprovalStage() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AccessPackageApprovalStage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageApprovalStage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"durationBeforeAutomaticDenial", n => { DurationBeforeAutomaticDenial = n.GetTimeSpanValue(); } },
                {"durationBeforeEscalation", n => { DurationBeforeEscalation = n.GetTimeSpanValue(); } },
                {"escalationApprovers", n => { EscalationApprovers = n.GetCollectionOfObjectValues<SubjectSet>(SubjectSet.CreateFromDiscriminatorValue)?.ToList(); } },
                {"fallbackEscalationApprovers", n => { FallbackEscalationApprovers = n.GetCollectionOfObjectValues<SubjectSet>(SubjectSet.CreateFromDiscriminatorValue)?.ToList(); } },
                {"fallbackPrimaryApprovers", n => { FallbackPrimaryApprovers = n.GetCollectionOfObjectValues<SubjectSet>(SubjectSet.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isApproverJustificationRequired", n => { IsApproverJustificationRequired = n.GetBoolValue(); } },
                {"isEscalationEnabled", n => { IsEscalationEnabled = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"primaryApprovers", n => { PrimaryApprovers = n.GetCollectionOfObjectValues<SubjectSet>(SubjectSet.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteTimeSpanValue("durationBeforeAutomaticDenial", DurationBeforeAutomaticDenial);
            writer.WriteTimeSpanValue("durationBeforeEscalation", DurationBeforeEscalation);
            writer.WriteCollectionOfObjectValues<SubjectSet>("escalationApprovers", EscalationApprovers);
            writer.WriteCollectionOfObjectValues<SubjectSet>("fallbackEscalationApprovers", FallbackEscalationApprovers);
            writer.WriteCollectionOfObjectValues<SubjectSet>("fallbackPrimaryApprovers", FallbackPrimaryApprovers);
            writer.WriteBoolValue("isApproverJustificationRequired", IsApproverJustificationRequired);
            writer.WriteBoolValue("isEscalationEnabled", IsEscalationEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<SubjectSet>("primaryApprovers", PrimaryApprovers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
