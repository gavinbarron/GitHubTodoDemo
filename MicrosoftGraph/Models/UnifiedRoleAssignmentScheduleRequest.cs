using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class UnifiedRoleAssignmentScheduleRequest : Request, IParsable {
        /// <summary>Represents the type of the operation on the role assignment request. The possible values are: adminAssign, adminUpdate, adminRemove, selfActivate, selfDeactivate, adminExtend, adminRenew, selfExtend, selfRenew, unknownFutureValue. adminAssign: For administrators to assign roles to principals.adminRemove: For administrators to remove principals from roles. adminUpdate: For administrators to change existing role assignments.adminExtend: For administrators to extend expiring assignments.adminRenew: For administrators to renew expired assignments.selfActivate: For principals to activate their assignments.selfDeactivate: For principals to deactivate their active assignments.selfExtend: For principals to request to extend their expiring assignments.selfRenew: For principals to request to renew their expired assignments.</summary>
        public UnifiedRoleScheduleRequestActions? Action { get; set; }
        /// <summary>If the request is from an eligible administrator to activate a role, this parameter will show the related eligible assignment for that activation. Otherwise, it&apos;s null. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UnifiedRoleEligibilitySchedule? ActivatedUsing { get; set; }
#nullable restore
#else
        public UnifiedRoleEligibilitySchedule ActivatedUsing { get; set; }
#endif
        /// <summary>Read-only property with details of the app-specific scope when the assignment is scoped to an app. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.AppScope? AppScope { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.AppScope AppScope { get; set; }
#endif
        /// <summary>Identifier of the app-specific scope when the assignment is scoped to an app. The scope of an assignment determines the set of resources for which the principal has been granted access. App scopes are scopes that are defined and understood by this application only. Use / for tenant-wide app scopes. Use directoryScopeId to limit the scope to particular directory objects, for example, administrative units. Supports $filter (eq, ne, and on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppScopeId { get; set; }
#nullable restore
#else
        public string AppScopeId { get; set; }
#endif
        /// <summary>The directory object that is the scope of the assignment. Read-only. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DirectoryObject? DirectoryScope { get; set; }
#nullable restore
#else
        public DirectoryObject DirectoryScope { get; set; }
#endif
        /// <summary>Identifier of the directory object representing the scope of the assignment. The scope of an assignment determines the set of resources for which the principal has been granted access. Directory scopes are shared scopes stored in the directory that are understood by multiple applications. Use / for tenant-wide scope. Use appScopeId to limit the scope to an application only. Supports $filter (eq, ne, and on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DirectoryScopeId { get; set; }
#nullable restore
#else
        public string DirectoryScopeId { get; set; }
#endif
        /// <summary>Determines whether the call is a validation or an actual call. Only set this property if you want to check whether an activation is subject to additional rules like MFA before actually submitting the request.</summary>
        public bool? IsValidationOnly { get; set; }
        /// <summary>A message provided by users and administrators when create they create the unifiedRoleAssignmentScheduleRequest object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Justification { get; set; }
#nullable restore
#else
        public string Justification { get; set; }
#endif
        /// <summary>The principal that&apos;s getting a role assignment through the request. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DirectoryObject? Principal { get; set; }
#nullable restore
#else
        public DirectoryObject Principal { get; set; }
#endif
        /// <summary>Identifier of the principal that has been granted the assignment. Can be a user, role-assignable group, or a service principal. Supports $filter (eq, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrincipalId { get; set; }
#nullable restore
#else
        public string PrincipalId { get; set; }
#endif
        /// <summary>Detailed information for the unifiedRoleDefinition object that is referenced through the roleDefinitionId property. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UnifiedRoleDefinition? RoleDefinition { get; set; }
#nullable restore
#else
        public UnifiedRoleDefinition RoleDefinition { get; set; }
#endif
        /// <summary>Identifier of the unifiedRoleDefinition object that is being assigned to the principal. Supports $filter (eq, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleDefinitionId { get; set; }
#nullable restore
#else
        public string RoleDefinitionId { get; set; }
#endif
        /// <summary>The period of the role assignment. Recurring schedules are currently unsupported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestSchedule? ScheduleInfo { get; set; }
#nullable restore
#else
        public RequestSchedule ScheduleInfo { get; set; }
#endif
        /// <summary>The schedule for an eligible role assignment that is referenced through the targetScheduleId property. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UnifiedRoleAssignmentSchedule? TargetSchedule { get; set; }
#nullable restore
#else
        public UnifiedRoleAssignmentSchedule TargetSchedule { get; set; }
#endif
        /// <summary>Identifier of the schedule object that&apos;s linked to the assignment request. Supports $filter (eq, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetScheduleId { get; set; }
#nullable restore
#else
        public string TargetScheduleId { get; set; }
#endif
        /// <summary>Ticket details linked to the role assignment request including details of the ticket number and ticket system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.TicketInfo? TicketInfo { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.TicketInfo TicketInfo { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UnifiedRoleAssignmentScheduleRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleAssignmentScheduleRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"action", n => { Action = n.GetEnumValue<UnifiedRoleScheduleRequestActions>(); } },
                {"activatedUsing", n => { ActivatedUsing = n.GetObjectValue<UnifiedRoleEligibilitySchedule>(UnifiedRoleEligibilitySchedule.CreateFromDiscriminatorValue); } },
                {"appScope", n => { AppScope = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.AppScope>(GitHubTodoDemo.MicrosoftGraph.Models.AppScope.CreateFromDiscriminatorValue); } },
                {"appScopeId", n => { AppScopeId = n.GetStringValue(); } },
                {"directoryScope", n => { DirectoryScope = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"directoryScopeId", n => { DirectoryScopeId = n.GetStringValue(); } },
                {"isValidationOnly", n => { IsValidationOnly = n.GetBoolValue(); } },
                {"justification", n => { Justification = n.GetStringValue(); } },
                {"principal", n => { Principal = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"principalId", n => { PrincipalId = n.GetStringValue(); } },
                {"roleDefinition", n => { RoleDefinition = n.GetObjectValue<UnifiedRoleDefinition>(UnifiedRoleDefinition.CreateFromDiscriminatorValue); } },
                {"roleDefinitionId", n => { RoleDefinitionId = n.GetStringValue(); } },
                {"scheduleInfo", n => { ScheduleInfo = n.GetObjectValue<RequestSchedule>(RequestSchedule.CreateFromDiscriminatorValue); } },
                {"targetSchedule", n => { TargetSchedule = n.GetObjectValue<UnifiedRoleAssignmentSchedule>(UnifiedRoleAssignmentSchedule.CreateFromDiscriminatorValue); } },
                {"targetScheduleId", n => { TargetScheduleId = n.GetStringValue(); } },
                {"ticketInfo", n => { TicketInfo = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.TicketInfo>(GitHubTodoDemo.MicrosoftGraph.Models.TicketInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<UnifiedRoleScheduleRequestActions>("action", Action);
            writer.WriteObjectValue<UnifiedRoleEligibilitySchedule>("activatedUsing", ActivatedUsing);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.AppScope>("appScope", AppScope);
            writer.WriteStringValue("appScopeId", AppScopeId);
            writer.WriteObjectValue<DirectoryObject>("directoryScope", DirectoryScope);
            writer.WriteStringValue("directoryScopeId", DirectoryScopeId);
            writer.WriteBoolValue("isValidationOnly", IsValidationOnly);
            writer.WriteStringValue("justification", Justification);
            writer.WriteObjectValue<DirectoryObject>("principal", Principal);
            writer.WriteStringValue("principalId", PrincipalId);
            writer.WriteObjectValue<UnifiedRoleDefinition>("roleDefinition", RoleDefinition);
            writer.WriteStringValue("roleDefinitionId", RoleDefinitionId);
            writer.WriteObjectValue<RequestSchedule>("scheduleInfo", ScheduleInfo);
            writer.WriteObjectValue<UnifiedRoleAssignmentSchedule>("targetSchedule", TargetSchedule);
            writer.WriteStringValue("targetScheduleId", TargetScheduleId);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.TicketInfo>("ticketInfo", TicketInfo);
        }
    }
}
