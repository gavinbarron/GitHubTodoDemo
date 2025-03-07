using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class ProvisioningObjectSummary : Entity, IParsable {
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ActivityDateTime { get; set; }
        /// <summary>Unique ID of this change in this cycle.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChangeId { get; set; }
#nullable restore
#else
        public string ChangeId { get; set; }
#endif
        /// <summary>Unique ID per job iteration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CycleId { get; set; }
#nullable restore
#else
        public string CycleId { get; set; }
#endif
        /// <summary>Indicates how long this provisioning action took to finish. Measured in milliseconds.</summary>
        public int? DurationInMilliseconds { get; set; }
        /// <summary>Details of who initiated this provisioning.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Initiator? InitiatedBy { get; set; }
#nullable restore
#else
        public Initiator InitiatedBy { get; set; }
#endif
        /// <summary>The unique ID for the whole provisioning job.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobId { get; set; }
#nullable restore
#else
        public string JobId { get; set; }
#endif
        /// <summary>Details of each property that was modified in this provisioning action on this object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ModifiedProperty>? ModifiedProperties { get; set; }
#nullable restore
#else
        public List<ModifiedProperty> ModifiedProperties { get; set; }
#endif
        /// <summary>Indicates the activity name or the operation name. Possible values are: create, update, delete, stageddelete, disable, other and unknownFutureValue. For a list of activities logged, refer to Azure AD activity list.</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.ProvisioningAction? ProvisioningAction { get; set; }
        /// <summary>Details of provisioning status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.ProvisioningStatusInfo? ProvisioningStatusInfo { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.ProvisioningStatusInfo ProvisioningStatusInfo { get; set; }
#endif
        /// <summary>Details of each step in provisioning.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ProvisioningStep>? ProvisioningSteps { get; set; }
#nullable restore
#else
        public List<ProvisioningStep> ProvisioningSteps { get; set; }
#endif
        /// <summary>Represents the service principal used for provisioning.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProvisioningServicePrincipal? ServicePrincipal { get; set; }
#nullable restore
#else
        public ProvisioningServicePrincipal ServicePrincipal { get; set; }
#endif
        /// <summary>Details of source object being provisioned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProvisionedIdentity? SourceIdentity { get; set; }
#nullable restore
#else
        public ProvisionedIdentity SourceIdentity { get; set; }
#endif
        /// <summary>Details of source system of the object being provisioned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProvisioningSystem? SourceSystem { get; set; }
#nullable restore
#else
        public ProvisioningSystem SourceSystem { get; set; }
#endif
        /// <summary>Details of target object being provisioned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProvisionedIdentity? TargetIdentity { get; set; }
#nullable restore
#else
        public ProvisionedIdentity TargetIdentity { get; set; }
#endif
        /// <summary>Details of target system of the object being provisioned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProvisioningSystem? TargetSystem { get; set; }
#nullable restore
#else
        public ProvisioningSystem TargetSystem { get; set; }
#endif
        /// <summary>Unique Azure AD tenant ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ProvisioningObjectSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProvisioningObjectSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activityDateTime", n => { ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"changeId", n => { ChangeId = n.GetStringValue(); } },
                {"cycleId", n => { CycleId = n.GetStringValue(); } },
                {"durationInMilliseconds", n => { DurationInMilliseconds = n.GetIntValue(); } },
                {"initiatedBy", n => { InitiatedBy = n.GetObjectValue<Initiator>(Initiator.CreateFromDiscriminatorValue); } },
                {"jobId", n => { JobId = n.GetStringValue(); } },
                {"modifiedProperties", n => { ModifiedProperties = n.GetCollectionOfObjectValues<ModifiedProperty>(ModifiedProperty.CreateFromDiscriminatorValue)?.ToList(); } },
                {"provisioningAction", n => { ProvisioningAction = n.GetEnumValue<ProvisioningAction>(); } },
                {"provisioningStatusInfo", n => { ProvisioningStatusInfo = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.ProvisioningStatusInfo>(GitHubTodoDemo.MicrosoftGraph.Models.ProvisioningStatusInfo.CreateFromDiscriminatorValue); } },
                {"provisioningSteps", n => { ProvisioningSteps = n.GetCollectionOfObjectValues<ProvisioningStep>(ProvisioningStep.CreateFromDiscriminatorValue)?.ToList(); } },
                {"servicePrincipal", n => { ServicePrincipal = n.GetObjectValue<ProvisioningServicePrincipal>(ProvisioningServicePrincipal.CreateFromDiscriminatorValue); } },
                {"sourceIdentity", n => { SourceIdentity = n.GetObjectValue<ProvisionedIdentity>(ProvisionedIdentity.CreateFromDiscriminatorValue); } },
                {"sourceSystem", n => { SourceSystem = n.GetObjectValue<ProvisioningSystem>(ProvisioningSystem.CreateFromDiscriminatorValue); } },
                {"targetIdentity", n => { TargetIdentity = n.GetObjectValue<ProvisionedIdentity>(ProvisionedIdentity.CreateFromDiscriminatorValue); } },
                {"targetSystem", n => { TargetSystem = n.GetObjectValue<ProvisioningSystem>(ProvisioningSystem.CreateFromDiscriminatorValue); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("activityDateTime", ActivityDateTime);
            writer.WriteStringValue("changeId", ChangeId);
            writer.WriteStringValue("cycleId", CycleId);
            writer.WriteIntValue("durationInMilliseconds", DurationInMilliseconds);
            writer.WriteObjectValue<Initiator>("initiatedBy", InitiatedBy);
            writer.WriteStringValue("jobId", JobId);
            writer.WriteCollectionOfObjectValues<ModifiedProperty>("modifiedProperties", ModifiedProperties);
            writer.WriteEnumValue<ProvisioningAction>("provisioningAction", ProvisioningAction);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.ProvisioningStatusInfo>("provisioningStatusInfo", ProvisioningStatusInfo);
            writer.WriteCollectionOfObjectValues<ProvisioningStep>("provisioningSteps", ProvisioningSteps);
            writer.WriteObjectValue<ProvisioningServicePrincipal>("servicePrincipal", ServicePrincipal);
            writer.WriteObjectValue<ProvisionedIdentity>("sourceIdentity", SourceIdentity);
            writer.WriteObjectValue<ProvisioningSystem>("sourceSystem", SourceSystem);
            writer.WriteObjectValue<ProvisionedIdentity>("targetIdentity", TargetIdentity);
            writer.WriteObjectValue<ProvisioningSystem>("targetSystem", TargetSystem);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
