using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class Group : DirectoryObject, IParsable {
        /// <summary>The list of users or groups that are allowed to create post&apos;s or calendar events in this group. If this list is non-empty then only users or groups listed here are allowed to post.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? AcceptedSenders { get; set; }
#nullable restore
#else
        public List<DirectoryObject> AcceptedSenders { get; set; }
#endif
        /// <summary>Indicates if people external to the organization can send messages to the group. Default value is false. Returned only on $select. Supported only on the Get group API (GET /groups/{ID}).</summary>
        public bool? AllowExternalSenders { get; set; }
        /// <summary>Represents the app roles a group has been granted for an application. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AppRoleAssignment>? AppRoleAssignments { get; set; }
#nullable restore
#else
        public List<AppRoleAssignment> AppRoleAssignments { get; set; }
#endif
        /// <summary>The list of sensitivity label pairs (label ID, label name) associated with a Microsoft 365 group. Returned only on $select.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AssignedLabel>? AssignedLabels { get; set; }
#nullable restore
#else
        public List<AssignedLabel> AssignedLabels { get; set; }
#endif
        /// <summary>The licenses that are assigned to the group. Returned only on $select. Supports $filter (eq).Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AssignedLicense>? AssignedLicenses { get; set; }
#nullable restore
#else
        public List<AssignedLicense> AssignedLicenses { get; set; }
#endif
        /// <summary>Indicates if new members added to the group will be auto-subscribed to receive email notifications. You can set this property in a PATCH request for the group; do not set it in the initial POST request that creates the group. Default value is false. Returned only on $select. Supported only on the Get group API (GET /groups/{ID}).</summary>
        public bool? AutoSubscribeNewMembers { get; set; }
        /// <summary>The group&apos;s calendar. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.Calendar? Calendar { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.Calendar Calendar { get; set; }
#endif
        /// <summary>The calendar view for the calendar. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Event>? CalendarView { get; set; }
#nullable restore
#else
        public List<Event> CalendarView { get; set; }
#endif
        /// <summary>Describes a classification for the group (such as low, medium or high business impact). Valid values for this property are defined by creating a ClassificationList setting value, based on the template definition.Returned by default. Supports $filter (eq, ne, not, ge, le, startsWith).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Classification { get; set; }
#nullable restore
#else
        public string Classification { get; set; }
#endif
        /// <summary>The group&apos;s conversations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Conversation>? Conversations { get; set; }
#nullable restore
#else
        public List<Conversation> Conversations { get; set; }
#endif
        /// <summary>Timestamp of when the group was created. The value cannot be modified and is automatically populated when the group is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Returned by default. Supports $filter (eq, ne, not, ge, le, in). Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The user (or application) that created the group. NOTE: This is not set if the user is an administrator. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DirectoryObject? CreatedOnBehalfOf { get; set; }
#nullable restore
#else
        public DirectoryObject CreatedOnBehalfOf { get; set; }
#endif
        /// <summary>An optional description for the group. Returned by default. Supports $filter (eq, ne, not, ge, le, startsWith) and $search.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The display name for the group. This property is required when a group is created and cannot be cleared during updates. Maximum length is 256 characters. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The group&apos;s default drive. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.Drive? Drive { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.Drive Drive { get; set; }
#endif
        /// <summary>The group&apos;s drives. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GitHubTodoDemo.MicrosoftGraph.Models.Drive>? Drives { get; set; }
#nullable restore
#else
        public List<GitHubTodoDemo.MicrosoftGraph.Models.Drive> Drives { get; set; }
#endif
        /// <summary>The group&apos;s calendar events.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Event>? Events { get; set; }
#nullable restore
#else
        public List<Event> Events { get; set; }
#endif
        /// <summary>Timestamp of when the group is set to expire. The value cannot be modified and is automatically populated when the group is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Returned by default. Supports $filter (eq, ne, not, ge, le, in). Read-only.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>The collection of open extensions defined for the group. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Extension>? Extensions { get; set; }
#nullable restore
#else
        public List<Extension> Extensions { get; set; }
#endif
        /// <summary>The collection of lifecycle policies for this group. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GroupLifecyclePolicy>? GroupLifecyclePolicies { get; set; }
#nullable restore
#else
        public List<GroupLifecyclePolicy> GroupLifecyclePolicies { get; set; }
#endif
        /// <summary>Specifies the group type and its membership. If the collection contains Unified, the group is a Microsoft 365 group; otherwise, it&apos;s either a security group or distribution group. For details, see groups overview.If the collection includes DynamicMembership, the group has dynamic membership; otherwise, membership is static. Returned by default. Supports $filter (eq, not).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? GroupTypes { get; set; }
#nullable restore
#else
        public List<string> GroupTypes { get; set; }
#endif
        /// <summary>Indicates whether there are members in this group that have license errors from its group-based license assignment. This property is never returned on a GET operation. You can use it as a $filter argument to get groups that have members with license errors (that is, filter for this property being true). See an example. Supports $filter (eq).</summary>
        public bool? HasMembersWithLicenseErrors { get; set; }
        /// <summary>True if the group is not displayed in certain parts of the Outlook UI: the Address Book, address lists for selecting message recipients, and the Browse Groups dialog for searching groups; otherwise, false. Default value is false. Returned only on $select. Supported only on the Get group API (GET /groups/{ID}).</summary>
        public bool? HideFromAddressLists { get; set; }
        /// <summary>True if the group is not displayed in Outlook clients, such as Outlook for Windows and Outlook on the web; otherwise, false. Default value is false. Returned only on $select. Supported only on the Get group API (GET /groups/{ID}).</summary>
        public bool? HideFromOutlookClients { get; set; }
        /// <summary>When a group is associated with a team this property determines whether the team is in read-only mode.To read this property, use the /group/{groupId}/team endpoint or the Get team API. To update this property, use the archiveTeam and unarchiveTeam APIs.</summary>
        public bool? IsArchived { get; set; }
        /// <summary>Indicates whether this group can be assigned to an Azure Active Directory role or not. Optional. This property can only be set while creating the group and is immutable. If set to true, the securityEnabled property must also be set to true, visibility must be Hidden, and the group cannot be a dynamic group (that is, groupTypes cannot contain DynamicMembership). Only callers in Global Administrator and Privileged Role Administrator roles can set this property. The caller must also be assigned the RoleManagement.ReadWrite.Directory permission to set this property or update the membership of such groups. For more, see Using a group to manage Azure AD role assignmentsUsing this feature requires a Azure AD Premium P1 license. Returned by default. Supports $filter (eq, ne, not).</summary>
        public bool? IsAssignableToRole { get; set; }
        /// <summary>Indicates whether the signed-in user is subscribed to receive email conversations. Default value is true. Returned only on $select. Supported only on the Get group API (GET /groups/{ID}).</summary>
        public bool? IsSubscribedByMail { get; set; }
        /// <summary>Indicates status of the group license assignment to all members of the group. Default value is false. Read-only. Possible values: QueuedForProcessing, ProcessingInProgress, and ProcessingComplete.Returned only on $select. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.LicenseProcessingState? LicenseProcessingState { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.LicenseProcessingState LicenseProcessingState { get; set; }
#endif
        /// <summary>The SMTP address for the group, for example, &apos;serviceadmins@contoso.onmicrosoft.com&apos;. Returned by default. Read-only. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Mail { get; set; }
#nullable restore
#else
        public string Mail { get; set; }
#endif
        /// <summary>Specifies whether the group is mail-enabled. Required. Returned by default. Supports $filter (eq, ne, not).</summary>
        public bool? MailEnabled { get; set; }
        /// <summary>The mail alias for the group, unique for Microsoft 365 groups in the organization. Maximum length is 64 characters. This property can contain only characters in the ASCII character set 0 - 127 except the following: @ () / [] &apos; ; : &lt;&gt; , SPACE. Required. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MailNickname { get; set; }
#nullable restore
#else
        public string MailNickname { get; set; }
#endif
        /// <summary>Groups that this group is a member of. HTTP Methods: GET (supported for all groups). Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? MemberOf { get; set; }
#nullable restore
#else
        public List<DirectoryObject> MemberOf { get; set; }
#endif
        /// <summary>The members of this group, who can be users, devices, other groups, or service principals. Supports the List members, Add member, and Remove member operations. Nullable. Supports $expand including nested $select. For example, /groups?$filter=startsWith(displayName,&apos;Role&apos;)&amp;$select=id,displayName&amp;$expand=members($select=id,userPrincipalName,displayName).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? Members { get; set; }
#nullable restore
#else
        public List<DirectoryObject> Members { get; set; }
#endif
        /// <summary>The rule that determines members for this group if the group is a dynamic group (groupTypes contains DynamicMembership). For more information about the syntax of the membership rule, see Membership Rules syntax. Returned by default. Supports $filter (eq, ne, not, ge, le, startsWith).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MembershipRule { get; set; }
#nullable restore
#else
        public string MembershipRule { get; set; }
#endif
        /// <summary>Indicates whether the dynamic membership processing is on or paused. Possible values are On or Paused. Returned by default. Supports $filter (eq, ne, not, in).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MembershipRuleProcessingState { get; set; }
#nullable restore
#else
        public string MembershipRuleProcessingState { get; set; }
#endif
        /// <summary>A list of group members with license errors from this group-based license assignment. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? MembersWithLicenseErrors { get; set; }
#nullable restore
#else
        public List<DirectoryObject> MembersWithLicenseErrors { get; set; }
#endif
        /// <summary>The onenote property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.Onenote? Onenote { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.Onenote Onenote { get; set; }
#endif
        /// <summary>The onPremisesDomainName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnPremisesDomainName { get; set; }
#nullable restore
#else
        public string OnPremisesDomainName { get; set; }
#endif
        /// <summary>Indicates the last time at which the group was synced with the on-premises directory.The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Returned by default. Read-only. Supports $filter (eq, ne, not, ge, le, in).</summary>
        public DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }
        /// <summary>The onPremisesNetBiosName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnPremisesNetBiosName { get; set; }
#nullable restore
#else
        public string OnPremisesNetBiosName { get; set; }
#endif
        /// <summary>Errors when using Microsoft synchronization product during provisioning. Returned by default. Supports $filter (eq, not).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnPremisesProvisioningError>? OnPremisesProvisioningErrors { get; set; }
#nullable restore
#else
        public List<OnPremisesProvisioningError> OnPremisesProvisioningErrors { get; set; }
#endif
        /// <summary>Contains the on-premises SAM account name synchronized from the on-premises directory. The property is only populated for customers who are synchronizing their on-premises directory to Azure Active Directory via Azure AD Connect.Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnPremisesSamAccountName { get; set; }
#nullable restore
#else
        public string OnPremisesSamAccountName { get; set; }
#endif
        /// <summary>Contains the on-premises security identifier (SID) for the group that was synchronized from on-premises to the cloud. Returned by default. Supports $filter (eq including on null values). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnPremisesSecurityIdentifier { get; set; }
#nullable restore
#else
        public string OnPremisesSecurityIdentifier { get; set; }
#endif
        /// <summary>true if this group is synced from an on-premises directory; false if this group was originally synced from an on-premises directory but is no longer synced; null if this object has never been synced from an on-premises directory (default). Returned by default. Read-only. Supports $filter (eq, ne, not, in, and eq on null values).</summary>
        public bool? OnPremisesSyncEnabled { get; set; }
        /// <summary>The owners of the group. Limited to 100 owners. Nullable. If this property is not specified when creating a Microsoft 365 group, the calling user is automatically assigned as the group owner.  Supports $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1). Supports $expand including nested $select. For example, /groups?$filter=startsWith(displayName,&apos;Role&apos;)&amp;$select=id,displayName&amp;$expand=owners($select=id,userPrincipalName,displayName).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? Owners { get; set; }
#nullable restore
#else
        public List<DirectoryObject> Owners { get; set; }
#endif
        /// <summary>The permission that has been granted for a group to a specific application. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ResourceSpecificPermissionGrant>? PermissionGrants { get; set; }
#nullable restore
#else
        public List<ResourceSpecificPermissionGrant> PermissionGrants { get; set; }
#endif
        /// <summary>The group&apos;s profile photo</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProfilePhoto? Photo { get; set; }
#nullable restore
#else
        public ProfilePhoto Photo { get; set; }
#endif
        /// <summary>The profile photos owned by the group. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ProfilePhoto>? Photos { get; set; }
#nullable restore
#else
        public List<ProfilePhoto> Photos { get; set; }
#endif
        /// <summary>Entry-point to Planner resource that might exist for a Unified Group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerGroup? Planner { get; set; }
#nullable restore
#else
        public PlannerGroup Planner { get; set; }
#endif
        /// <summary>The preferred data location for the Microsoft 365 group. By default, the group inherits the group creator&apos;s preferred data location. To set this property, the calling user must be assigned one of the following Azure AD roles:  Global Administrator  User Account Administrator Directory Writer  Exchange Administrator  SharePoint Administrator  For more information about this property, see OneDrive Online Multi-Geo. Nullable. Returned by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreferredDataLocation { get; set; }
#nullable restore
#else
        public string PreferredDataLocation { get; set; }
#endif
        /// <summary>The preferred language for a Microsoft 365 group. Should follow ISO 639-1 Code; for example en-US. Returned by default. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PreferredLanguage { get; set; }
#nullable restore
#else
        public string PreferredLanguage { get; set; }
#endif
        /// <summary>Email addresses for the group that direct to the same group mailbox. For example: [&apos;SMTP: bob@contoso.com&apos;, &apos;smtp: bob@sales.contoso.com&apos;]. The any operator is required to filter expressions on multi-valued properties. Returned by default. Read-only. Not nullable. Supports $filter (eq, not, ge, le, startsWith, endsWith, /$count eq 0, /$count ne 0).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ProxyAddresses { get; set; }
#nullable restore
#else
        public List<string> ProxyAddresses { get; set; }
#endif
        /// <summary>The list of users or groups that are not allowed to create posts or calendar events in this group. Nullable</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? RejectedSenders { get; set; }
#nullable restore
#else
        public List<DirectoryObject> RejectedSenders { get; set; }
#endif
        /// <summary>Timestamp of when the group was last renewed. This cannot be modified directly and is only updated via the renew service action. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Returned by default. Supports $filter (eq, ne, not, ge, le, in). Read-only.</summary>
        public DateTimeOffset? RenewedDateTime { get; set; }
        /// <summary>Specifies whether the group is a security group. Required. Returned by default. Supports $filter (eq, ne, not, in).</summary>
        public bool? SecurityEnabled { get; set; }
        /// <summary>Security identifier of the group, used in Windows scenarios. Returned by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SecurityIdentifier { get; set; }
#nullable restore
#else
        public string SecurityIdentifier { get; set; }
#endif
        /// <summary>Settings that can govern this group&apos;s behavior, like whether members can invite guest users to the group. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GroupSetting>? Settings { get; set; }
#nullable restore
#else
        public List<GroupSetting> Settings { get; set; }
#endif
        /// <summary>The list of SharePoint sites in this group. Access the default site with /sites/root.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Site>? Sites { get; set; }
#nullable restore
#else
        public List<Site> Sites { get; set; }
#endif
        /// <summary>The team associated with this group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.Team? Team { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.Team Team { get; set; }
#endif
        /// <summary>Specifies a Microsoft 365 group&apos;s color theme. Possible values are Teal, Purple, Green, Blue, Pink, Orange or Red. Returned by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Theme { get; set; }
#nullable restore
#else
        public string Theme { get; set; }
#endif
        /// <summary>The group&apos;s conversation threads. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ConversationThread>? Threads { get; set; }
#nullable restore
#else
        public List<ConversationThread> Threads { get; set; }
#endif
        /// <summary>The groups that a group is a member of, either directly and through nested membership. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? TransitiveMemberOf { get; set; }
#nullable restore
#else
        public List<DirectoryObject> TransitiveMemberOf { get; set; }
#endif
        /// <summary>The direct and transitive members of a group. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? TransitiveMembers { get; set; }
#nullable restore
#else
        public List<DirectoryObject> TransitiveMembers { get; set; }
#endif
        /// <summary>Count of conversations that have received new posts since the signed-in user last visited the group. Returned only on $select. Supported only on the Get group API (GET /groups/{ID}).</summary>
        public int? UnseenCount { get; set; }
        /// <summary>Specifies the group join policy and group content visibility for groups. Possible values are: Private, Public, or HiddenMembership. HiddenMembership can be set only for Microsoft 365 groups, when the groups are created. It can&apos;t be updated later. Other values of visibility can be updated after group creation. If visibility value is not specified during group creation on Microsoft Graph, a security group is created as Private by default and Microsoft 365 group is Public. Groups assignable to roles are always Private. See group visibility options to learn more. Returned by default. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Visibility { get; set; }
#nullable restore
#else
        public string Visibility { get; set; }
#endif
        /// <summary>
        /// Instantiates a new group and sets the default values.
        /// </summary>
        public Group() : base() {
            OdataType = "#microsoft.graph.group";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Group CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Group();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"acceptedSenders", n => { AcceptedSenders = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"allowExternalSenders", n => { AllowExternalSenders = n.GetBoolValue(); } },
                {"appRoleAssignments", n => { AppRoleAssignments = n.GetCollectionOfObjectValues<AppRoleAssignment>(AppRoleAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"assignedLabels", n => { AssignedLabels = n.GetCollectionOfObjectValues<AssignedLabel>(AssignedLabel.CreateFromDiscriminatorValue)?.ToList(); } },
                {"assignedLicenses", n => { AssignedLicenses = n.GetCollectionOfObjectValues<AssignedLicense>(AssignedLicense.CreateFromDiscriminatorValue)?.ToList(); } },
                {"autoSubscribeNewMembers", n => { AutoSubscribeNewMembers = n.GetBoolValue(); } },
                {"calendar", n => { Calendar = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Calendar>(GitHubTodoDemo.MicrosoftGraph.Models.Calendar.CreateFromDiscriminatorValue); } },
                {"calendarView", n => { CalendarView = n.GetCollectionOfObjectValues<Event>(Event.CreateFromDiscriminatorValue)?.ToList(); } },
                {"classification", n => { Classification = n.GetStringValue(); } },
                {"conversations", n => { Conversations = n.GetCollectionOfObjectValues<Conversation>(Conversation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdOnBehalfOf", n => { CreatedOnBehalfOf = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"drive", n => { Drive = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Drive>(GitHubTodoDemo.MicrosoftGraph.Models.Drive.CreateFromDiscriminatorValue); } },
                {"drives", n => { Drives = n.GetCollectionOfObjectValues<GitHubTodoDemo.MicrosoftGraph.Models.Drive>(GitHubTodoDemo.MicrosoftGraph.Models.Drive.CreateFromDiscriminatorValue)?.ToList(); } },
                {"events", n => { Events = n.GetCollectionOfObjectValues<Event>(Event.CreateFromDiscriminatorValue)?.ToList(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue)?.ToList(); } },
                {"groupLifecyclePolicies", n => { GroupLifecyclePolicies = n.GetCollectionOfObjectValues<GroupLifecyclePolicy>(GroupLifecyclePolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"groupTypes", n => { GroupTypes = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"hasMembersWithLicenseErrors", n => { HasMembersWithLicenseErrors = n.GetBoolValue(); } },
                {"hideFromAddressLists", n => { HideFromAddressLists = n.GetBoolValue(); } },
                {"hideFromOutlookClients", n => { HideFromOutlookClients = n.GetBoolValue(); } },
                {"isArchived", n => { IsArchived = n.GetBoolValue(); } },
                {"isAssignableToRole", n => { IsAssignableToRole = n.GetBoolValue(); } },
                {"isSubscribedByMail", n => { IsSubscribedByMail = n.GetBoolValue(); } },
                {"licenseProcessingState", n => { LicenseProcessingState = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.LicenseProcessingState>(GitHubTodoDemo.MicrosoftGraph.Models.LicenseProcessingState.CreateFromDiscriminatorValue); } },
                {"mail", n => { Mail = n.GetStringValue(); } },
                {"mailEnabled", n => { MailEnabled = n.GetBoolValue(); } },
                {"mailNickname", n => { MailNickname = n.GetStringValue(); } },
                {"memberOf", n => { MemberOf = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"members", n => { Members = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"membershipRule", n => { MembershipRule = n.GetStringValue(); } },
                {"membershipRuleProcessingState", n => { MembershipRuleProcessingState = n.GetStringValue(); } },
                {"membersWithLicenseErrors", n => { MembersWithLicenseErrors = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"onenote", n => { Onenote = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Onenote>(GitHubTodoDemo.MicrosoftGraph.Models.Onenote.CreateFromDiscriminatorValue); } },
                {"onPremisesDomainName", n => { OnPremisesDomainName = n.GetStringValue(); } },
                {"onPremisesLastSyncDateTime", n => { OnPremisesLastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"onPremisesNetBiosName", n => { OnPremisesNetBiosName = n.GetStringValue(); } },
                {"onPremisesProvisioningErrors", n => { OnPremisesProvisioningErrors = n.GetCollectionOfObjectValues<OnPremisesProvisioningError>(OnPremisesProvisioningError.CreateFromDiscriminatorValue)?.ToList(); } },
                {"onPremisesSamAccountName", n => { OnPremisesSamAccountName = n.GetStringValue(); } },
                {"onPremisesSecurityIdentifier", n => { OnPremisesSecurityIdentifier = n.GetStringValue(); } },
                {"onPremisesSyncEnabled", n => { OnPremisesSyncEnabled = n.GetBoolValue(); } },
                {"owners", n => { Owners = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"permissionGrants", n => { PermissionGrants = n.GetCollectionOfObjectValues<ResourceSpecificPermissionGrant>(ResourceSpecificPermissionGrant.CreateFromDiscriminatorValue)?.ToList(); } },
                {"photo", n => { Photo = n.GetObjectValue<ProfilePhoto>(ProfilePhoto.CreateFromDiscriminatorValue); } },
                {"photos", n => { Photos = n.GetCollectionOfObjectValues<ProfilePhoto>(ProfilePhoto.CreateFromDiscriminatorValue)?.ToList(); } },
                {"planner", n => { Planner = n.GetObjectValue<PlannerGroup>(PlannerGroup.CreateFromDiscriminatorValue); } },
                {"preferredDataLocation", n => { PreferredDataLocation = n.GetStringValue(); } },
                {"preferredLanguage", n => { PreferredLanguage = n.GetStringValue(); } },
                {"proxyAddresses", n => { ProxyAddresses = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"rejectedSenders", n => { RejectedSenders = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"renewedDateTime", n => { RenewedDateTime = n.GetDateTimeOffsetValue(); } },
                {"securityEnabled", n => { SecurityEnabled = n.GetBoolValue(); } },
                {"securityIdentifier", n => { SecurityIdentifier = n.GetStringValue(); } },
                {"settings", n => { Settings = n.GetCollectionOfObjectValues<GroupSetting>(GroupSetting.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sites", n => { Sites = n.GetCollectionOfObjectValues<Site>(Site.CreateFromDiscriminatorValue)?.ToList(); } },
                {"team", n => { Team = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Team>(GitHubTodoDemo.MicrosoftGraph.Models.Team.CreateFromDiscriminatorValue); } },
                {"theme", n => { Theme = n.GetStringValue(); } },
                {"threads", n => { Threads = n.GetCollectionOfObjectValues<ConversationThread>(ConversationThread.CreateFromDiscriminatorValue)?.ToList(); } },
                {"transitiveMemberOf", n => { TransitiveMemberOf = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"transitiveMembers", n => { TransitiveMembers = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"unseenCount", n => { UnseenCount = n.GetIntValue(); } },
                {"visibility", n => { Visibility = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("acceptedSenders", AcceptedSenders);
            writer.WriteBoolValue("allowExternalSenders", AllowExternalSenders);
            writer.WriteCollectionOfObjectValues<AppRoleAssignment>("appRoleAssignments", AppRoleAssignments);
            writer.WriteCollectionOfObjectValues<AssignedLabel>("assignedLabels", AssignedLabels);
            writer.WriteCollectionOfObjectValues<AssignedLicense>("assignedLicenses", AssignedLicenses);
            writer.WriteBoolValue("autoSubscribeNewMembers", AutoSubscribeNewMembers);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Calendar>("calendar", Calendar);
            writer.WriteCollectionOfObjectValues<Event>("calendarView", CalendarView);
            writer.WriteStringValue("classification", Classification);
            writer.WriteCollectionOfObjectValues<Conversation>("conversations", Conversations);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<DirectoryObject>("createdOnBehalfOf", CreatedOnBehalfOf);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Drive>("drive", Drive);
            writer.WriteCollectionOfObjectValues<GitHubTodoDemo.MicrosoftGraph.Models.Drive>("drives", Drives);
            writer.WriteCollectionOfObjectValues<Event>("events", Events);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteCollectionOfObjectValues<GroupLifecyclePolicy>("groupLifecyclePolicies", GroupLifecyclePolicies);
            writer.WriteCollectionOfPrimitiveValues<string>("groupTypes", GroupTypes);
            writer.WriteBoolValue("hasMembersWithLicenseErrors", HasMembersWithLicenseErrors);
            writer.WriteBoolValue("hideFromAddressLists", HideFromAddressLists);
            writer.WriteBoolValue("hideFromOutlookClients", HideFromOutlookClients);
            writer.WriteBoolValue("isArchived", IsArchived);
            writer.WriteBoolValue("isAssignableToRole", IsAssignableToRole);
            writer.WriteBoolValue("isSubscribedByMail", IsSubscribedByMail);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.LicenseProcessingState>("licenseProcessingState", LicenseProcessingState);
            writer.WriteStringValue("mail", Mail);
            writer.WriteBoolValue("mailEnabled", MailEnabled);
            writer.WriteStringValue("mailNickname", MailNickname);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("memberOf", MemberOf);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("members", Members);
            writer.WriteStringValue("membershipRule", MembershipRule);
            writer.WriteStringValue("membershipRuleProcessingState", MembershipRuleProcessingState);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("membersWithLicenseErrors", MembersWithLicenseErrors);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Onenote>("onenote", Onenote);
            writer.WriteStringValue("onPremisesDomainName", OnPremisesDomainName);
            writer.WriteDateTimeOffsetValue("onPremisesLastSyncDateTime", OnPremisesLastSyncDateTime);
            writer.WriteStringValue("onPremisesNetBiosName", OnPremisesNetBiosName);
            writer.WriteCollectionOfObjectValues<OnPremisesProvisioningError>("onPremisesProvisioningErrors", OnPremisesProvisioningErrors);
            writer.WriteStringValue("onPremisesSamAccountName", OnPremisesSamAccountName);
            writer.WriteStringValue("onPremisesSecurityIdentifier", OnPremisesSecurityIdentifier);
            writer.WriteBoolValue("onPremisesSyncEnabled", OnPremisesSyncEnabled);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("owners", Owners);
            writer.WriteCollectionOfObjectValues<ResourceSpecificPermissionGrant>("permissionGrants", PermissionGrants);
            writer.WriteObjectValue<ProfilePhoto>("photo", Photo);
            writer.WriteCollectionOfObjectValues<ProfilePhoto>("photos", Photos);
            writer.WriteObjectValue<PlannerGroup>("planner", Planner);
            writer.WriteStringValue("preferredDataLocation", PreferredDataLocation);
            writer.WriteStringValue("preferredLanguage", PreferredLanguage);
            writer.WriteCollectionOfPrimitiveValues<string>("proxyAddresses", ProxyAddresses);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("rejectedSenders", RejectedSenders);
            writer.WriteDateTimeOffsetValue("renewedDateTime", RenewedDateTime);
            writer.WriteBoolValue("securityEnabled", SecurityEnabled);
            writer.WriteStringValue("securityIdentifier", SecurityIdentifier);
            writer.WriteCollectionOfObjectValues<GroupSetting>("settings", Settings);
            writer.WriteCollectionOfObjectValues<Site>("sites", Sites);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Team>("team", Team);
            writer.WriteStringValue("theme", Theme);
            writer.WriteCollectionOfObjectValues<ConversationThread>("threads", Threads);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("transitiveMemberOf", TransitiveMemberOf);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("transitiveMembers", TransitiveMembers);
            writer.WriteIntValue("unseenCount", UnseenCount);
            writer.WriteStringValue("visibility", Visibility);
        }
    }
}
