using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class OnlineMeeting : Entity, IParsable {
        /// <summary>Indicates whether attendees can turn on their camera.</summary>
        public bool? AllowAttendeeToEnableCamera { get; set; }
        /// <summary>Indicates whether attendees can turn on their microphone.</summary>
        public bool? AllowAttendeeToEnableMic { get; set; }
        /// <summary>Specifies who can be a presenter in a meeting. Possible values are listed in the following table.</summary>
        public OnlineMeetingPresenters? AllowedPresenters { get; set; }
        /// <summary>Specifies the mode of meeting chat.</summary>
        public MeetingChatMode? AllowMeetingChat { get; set; }
        /// <summary>Indicates whether Teams reactions are enabled for the meeting.</summary>
        public bool? AllowTeamworkReactions { get; set; }
        /// <summary>The attendance reports of an online meeting. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MeetingAttendanceReport>? AttendanceReports { get; set; }
#nullable restore
#else
        public List<MeetingAttendanceReport> AttendanceReports { get; set; }
#endif
        /// <summary>The content stream of the attendee report of a Microsoft Teams live event. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? AttendeeReport { get; set; }
#nullable restore
#else
        public byte[] AttendeeReport { get; set; }
#endif
        /// <summary>The phone access (dial-in) information for an online meeting. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.AudioConferencing? AudioConferencing { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.AudioConferencing AudioConferencing { get; set; }
#endif
        /// <summary>Settings related to a live event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BroadcastMeetingSettings? BroadcastSettings { get; set; }
#nullable restore
#else
        public BroadcastMeetingSettings BroadcastSettings { get; set; }
#endif
        /// <summary>The chat information associated with this online meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.ChatInfo? ChatInfo { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.ChatInfo ChatInfo { get; set; }
#endif
        /// <summary>The meeting creation time in UTC. Read-only.</summary>
        public DateTimeOffset? CreationDateTime { get; set; }
        /// <summary>The meeting end time in UTC.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>The externalId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId { get; set; }
#nullable restore
#else
        public string ExternalId { get; set; }
#endif
        /// <summary>Indicates if this is a Teams live event.</summary>
        public bool? IsBroadcast { get; set; }
        /// <summary>Indicates whether to announce when callers join or leave.</summary>
        public bool? IsEntryExitAnnounced { get; set; }
        /// <summary>The join information in the language and locale variant specified in the Accept-Language request HTTP header. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemBody? JoinInformation { get; set; }
#nullable restore
#else
        public ItemBody JoinInformation { get; set; }
#endif
        /// <summary>Specifies the joinMeetingId, the meeting passcode, and the requirement for the passcode. Once an onlineMeeting is created, the joinMeetingIdSettings cannot be modified. To make any changes to this property, the meeting needs to be canceled and a new one needs to be created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.JoinMeetingIdSettings? JoinMeetingIdSettings { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.JoinMeetingIdSettings JoinMeetingIdSettings { get; set; }
#endif
        /// <summary>The join URL of the online meeting. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JoinWebUrl { get; set; }
#nullable restore
#else
        public string JoinWebUrl { get; set; }
#endif
        /// <summary>Specifies which participants can bypass the meeting   lobby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.LobbyBypassSettings? LobbyBypassSettings { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.LobbyBypassSettings LobbyBypassSettings { get; set; }
#endif
        /// <summary>The participants associated with the online meeting.  This includes the organizer and the attendees.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MeetingParticipants? Participants { get; set; }
#nullable restore
#else
        public MeetingParticipants Participants { get; set; }
#endif
        /// <summary>Indicates whether to record the meeting automatically.</summary>
        public bool? RecordAutomatically { get; set; }
        /// <summary>The meeting start time in UTC.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>The subject of the online meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>The video teleconferencing ID. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VideoTeleconferenceId { get; set; }
#nullable restore
#else
        public string VideoTeleconferenceId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OnlineMeeting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnlineMeeting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowAttendeeToEnableCamera", n => { AllowAttendeeToEnableCamera = n.GetBoolValue(); } },
                {"allowAttendeeToEnableMic", n => { AllowAttendeeToEnableMic = n.GetBoolValue(); } },
                {"allowedPresenters", n => { AllowedPresenters = n.GetEnumValue<OnlineMeetingPresenters>(); } },
                {"allowMeetingChat", n => { AllowMeetingChat = n.GetEnumValue<MeetingChatMode>(); } },
                {"allowTeamworkReactions", n => { AllowTeamworkReactions = n.GetBoolValue(); } },
                {"attendanceReports", n => { AttendanceReports = n.GetCollectionOfObjectValues<MeetingAttendanceReport>(MeetingAttendanceReport.CreateFromDiscriminatorValue)?.ToList(); } },
                {"attendeeReport", n => { AttendeeReport = n.GetByteArrayValue(); } },
                {"audioConferencing", n => { AudioConferencing = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.AudioConferencing>(GitHubTodoDemo.MicrosoftGraph.Models.AudioConferencing.CreateFromDiscriminatorValue); } },
                {"broadcastSettings", n => { BroadcastSettings = n.GetObjectValue<BroadcastMeetingSettings>(BroadcastMeetingSettings.CreateFromDiscriminatorValue); } },
                {"chatInfo", n => { ChatInfo = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.ChatInfo>(GitHubTodoDemo.MicrosoftGraph.Models.ChatInfo.CreateFromDiscriminatorValue); } },
                {"creationDateTime", n => { CreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"isBroadcast", n => { IsBroadcast = n.GetBoolValue(); } },
                {"isEntryExitAnnounced", n => { IsEntryExitAnnounced = n.GetBoolValue(); } },
                {"joinInformation", n => { JoinInformation = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"joinMeetingIdSettings", n => { JoinMeetingIdSettings = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.JoinMeetingIdSettings>(GitHubTodoDemo.MicrosoftGraph.Models.JoinMeetingIdSettings.CreateFromDiscriminatorValue); } },
                {"joinWebUrl", n => { JoinWebUrl = n.GetStringValue(); } },
                {"lobbyBypassSettings", n => { LobbyBypassSettings = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.LobbyBypassSettings>(GitHubTodoDemo.MicrosoftGraph.Models.LobbyBypassSettings.CreateFromDiscriminatorValue); } },
                {"participants", n => { Participants = n.GetObjectValue<MeetingParticipants>(MeetingParticipants.CreateFromDiscriminatorValue); } },
                {"recordAutomatically", n => { RecordAutomatically = n.GetBoolValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"videoTeleconferenceId", n => { VideoTeleconferenceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowAttendeeToEnableCamera", AllowAttendeeToEnableCamera);
            writer.WriteBoolValue("allowAttendeeToEnableMic", AllowAttendeeToEnableMic);
            writer.WriteEnumValue<OnlineMeetingPresenters>("allowedPresenters", AllowedPresenters);
            writer.WriteEnumValue<MeetingChatMode>("allowMeetingChat", AllowMeetingChat);
            writer.WriteBoolValue("allowTeamworkReactions", AllowTeamworkReactions);
            writer.WriteCollectionOfObjectValues<MeetingAttendanceReport>("attendanceReports", AttendanceReports);
            writer.WriteByteArrayValue("attendeeReport", AttendeeReport);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.AudioConferencing>("audioConferencing", AudioConferencing);
            writer.WriteObjectValue<BroadcastMeetingSettings>("broadcastSettings", BroadcastSettings);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.ChatInfo>("chatInfo", ChatInfo);
            writer.WriteDateTimeOffsetValue("creationDateTime", CreationDateTime);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteBoolValue("isBroadcast", IsBroadcast);
            writer.WriteBoolValue("isEntryExitAnnounced", IsEntryExitAnnounced);
            writer.WriteObjectValue<ItemBody>("joinInformation", JoinInformation);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.JoinMeetingIdSettings>("joinMeetingIdSettings", JoinMeetingIdSettings);
            writer.WriteStringValue("joinWebUrl", JoinWebUrl);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.LobbyBypassSettings>("lobbyBypassSettings", LobbyBypassSettings);
            writer.WriteObjectValue<MeetingParticipants>("participants", Participants);
            writer.WriteBoolValue("recordAutomatically", RecordAutomatically);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("videoTeleconferenceId", VideoTeleconferenceId);
        }
    }
}
