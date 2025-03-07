using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class Team : Entity, IParsable {
        /// <summary>List of channels either hosted in or shared with the team (incoming channels).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Channel>? AllChannels { get; set; }
#nullable restore
#else
        public List<Channel> AllChannels { get; set; }
#endif
        /// <summary>The collection of channels and messages associated with the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Channel>? Channels { get; set; }
#nullable restore
#else
        public List<Channel> Channels { get; set; }
#endif
        /// <summary>An optional label. Typically describes the data or business sensitivity of the team. Must match one of a pre-configured set in the tenant&apos;s directory.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Classification { get; set; }
#nullable restore
#else
        public string Classification { get; set; }
#endif
        /// <summary>Timestamp at which the team was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>An optional description for the team. Maximum length: 1024 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The name of the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Settings to configure use of Giphy, memes, and stickers in the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamFunSettings? FunSettings { get; set; }
#nullable restore
#else
        public TeamFunSettings FunSettings { get; set; }
#endif
        /// <summary>The group property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.Group? Group { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.Group Group { get; set; }
#endif
        /// <summary>Settings to configure whether guests can create, update, or delete channels in the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamGuestSettings? GuestSettings { get; set; }
#nullable restore
#else
        public TeamGuestSettings GuestSettings { get; set; }
#endif
        /// <summary>List of channels shared with the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Channel>? IncomingChannels { get; set; }
#nullable restore
#else
        public List<Channel> IncomingChannels { get; set; }
#endif
        /// <summary>The apps installed in this team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TeamsAppInstallation>? InstalledApps { get; set; }
#nullable restore
#else
        public List<TeamsAppInstallation> InstalledApps { get; set; }
#endif
        /// <summary>A unique ID for the team that has been used in a few places such as the audit log/Office 365 Management Activity API.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InternalId { get; set; }
#nullable restore
#else
        public string InternalId { get; set; }
#endif
        /// <summary>Whether this team is in read-only mode.</summary>
        public bool? IsArchived { get; set; }
        /// <summary>Members and owners of the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ConversationMember>? Members { get; set; }
#nullable restore
#else
        public List<ConversationMember> Members { get; set; }
#endif
        /// <summary>Settings to configure whether members can perform certain actions, for example, create channels and add bots, in the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamMemberSettings? MemberSettings { get; set; }
#nullable restore
#else
        public TeamMemberSettings MemberSettings { get; set; }
#endif
        /// <summary>Settings to configure messaging and mentions in the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamMessagingSettings? MessagingSettings { get; set; }
#nullable restore
#else
        public TeamMessagingSettings MessagingSettings { get; set; }
#endif
        /// <summary>The async operations that ran or are running on this team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TeamsAsyncOperation>? Operations { get; set; }
#nullable restore
#else
        public List<TeamsAsyncOperation> Operations { get; set; }
#endif
        /// <summary>The profile photo for the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProfilePhoto? Photo { get; set; }
#nullable restore
#else
        public ProfilePhoto Photo { get; set; }
#endif
        /// <summary>The general channel for the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Channel? PrimaryChannel { get; set; }
#nullable restore
#else
        public Channel PrimaryChannel { get; set; }
#endif
        /// <summary>The schedule of shifts for this team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.Schedule? Schedule { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.Schedule Schedule { get; set; }
#endif
        /// <summary>Optional. Indicates whether the team is intended for a particular use case.  Each team specialization has access to unique behaviors and experiences targeted to its use case.</summary>
        public TeamSpecialization? Specialization { get; set; }
        /// <summary>The summary property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamSummary? Summary { get; set; }
#nullable restore
#else
        public TeamSummary Summary { get; set; }
#endif
        /// <summary>The tags associated with the team.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TeamworkTag>? Tags { get; set; }
#nullable restore
#else
        public List<TeamworkTag> Tags { get; set; }
#endif
        /// <summary>The template this team was created from. See available templates.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamsTemplate? Template { get; set; }
#nullable restore
#else
        public TeamsTemplate Template { get; set; }
#endif
        /// <summary>The ID of the Azure Active Directory tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>The visibility of the group and team. Defaults to Public.</summary>
        public TeamVisibilityType? Visibility { get; set; }
        /// <summary>A hyperlink that will go to the team in the Microsoft Teams client. This is the URL that you get when you right-click a team in the Microsoft Teams client and select Get link to team. This URL should be treated as an opaque blob, and not parsed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl { get; set; }
#nullable restore
#else
        public string WebUrl { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Team CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Team();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allChannels", n => { AllChannels = n.GetCollectionOfObjectValues<Channel>(Channel.CreateFromDiscriminatorValue)?.ToList(); } },
                {"channels", n => { Channels = n.GetCollectionOfObjectValues<Channel>(Channel.CreateFromDiscriminatorValue)?.ToList(); } },
                {"classification", n => { Classification = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"funSettings", n => { FunSettings = n.GetObjectValue<TeamFunSettings>(TeamFunSettings.CreateFromDiscriminatorValue); } },
                {"group", n => { Group = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Group>(GitHubTodoDemo.MicrosoftGraph.Models.Group.CreateFromDiscriminatorValue); } },
                {"guestSettings", n => { GuestSettings = n.GetObjectValue<TeamGuestSettings>(TeamGuestSettings.CreateFromDiscriminatorValue); } },
                {"incomingChannels", n => { IncomingChannels = n.GetCollectionOfObjectValues<Channel>(Channel.CreateFromDiscriminatorValue)?.ToList(); } },
                {"installedApps", n => { InstalledApps = n.GetCollectionOfObjectValues<TeamsAppInstallation>(TeamsAppInstallation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"internalId", n => { InternalId = n.GetStringValue(); } },
                {"isArchived", n => { IsArchived = n.GetBoolValue(); } },
                {"members", n => { Members = n.GetCollectionOfObjectValues<ConversationMember>(ConversationMember.CreateFromDiscriminatorValue)?.ToList(); } },
                {"memberSettings", n => { MemberSettings = n.GetObjectValue<TeamMemberSettings>(TeamMemberSettings.CreateFromDiscriminatorValue); } },
                {"messagingSettings", n => { MessagingSettings = n.GetObjectValue<TeamMessagingSettings>(TeamMessagingSettings.CreateFromDiscriminatorValue); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<TeamsAsyncOperation>(TeamsAsyncOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"photo", n => { Photo = n.GetObjectValue<ProfilePhoto>(ProfilePhoto.CreateFromDiscriminatorValue); } },
                {"primaryChannel", n => { PrimaryChannel = n.GetObjectValue<Channel>(Channel.CreateFromDiscriminatorValue); } },
                {"schedule", n => { Schedule = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Schedule>(GitHubTodoDemo.MicrosoftGraph.Models.Schedule.CreateFromDiscriminatorValue); } },
                {"specialization", n => { Specialization = n.GetEnumValue<TeamSpecialization>(); } },
                {"summary", n => { Summary = n.GetObjectValue<TeamSummary>(TeamSummary.CreateFromDiscriminatorValue); } },
                {"tags", n => { Tags = n.GetCollectionOfObjectValues<TeamworkTag>(TeamworkTag.CreateFromDiscriminatorValue)?.ToList(); } },
                {"template", n => { Template = n.GetObjectValue<TeamsTemplate>(TeamsTemplate.CreateFromDiscriminatorValue); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"visibility", n => { Visibility = n.GetEnumValue<TeamVisibilityType>(); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Channel>("allChannels", AllChannels);
            writer.WriteCollectionOfObjectValues<Channel>("channels", Channels);
            writer.WriteStringValue("classification", Classification);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<TeamFunSettings>("funSettings", FunSettings);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Group>("group", Group);
            writer.WriteObjectValue<TeamGuestSettings>("guestSettings", GuestSettings);
            writer.WriteCollectionOfObjectValues<Channel>("incomingChannels", IncomingChannels);
            writer.WriteCollectionOfObjectValues<TeamsAppInstallation>("installedApps", InstalledApps);
            writer.WriteStringValue("internalId", InternalId);
            writer.WriteBoolValue("isArchived", IsArchived);
            writer.WriteCollectionOfObjectValues<ConversationMember>("members", Members);
            writer.WriteObjectValue<TeamMemberSettings>("memberSettings", MemberSettings);
            writer.WriteObjectValue<TeamMessagingSettings>("messagingSettings", MessagingSettings);
            writer.WriteCollectionOfObjectValues<TeamsAsyncOperation>("operations", Operations);
            writer.WriteObjectValue<ProfilePhoto>("photo", Photo);
            writer.WriteObjectValue<Channel>("primaryChannel", PrimaryChannel);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Schedule>("schedule", Schedule);
            writer.WriteEnumValue<TeamSpecialization>("specialization", Specialization);
            writer.WriteObjectValue<TeamSummary>("summary", Summary);
            writer.WriteCollectionOfObjectValues<TeamworkTag>("tags", Tags);
            writer.WriteObjectValue<TeamsTemplate>("template", Template);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteEnumValue<TeamVisibilityType>("visibility", Visibility);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
