using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class MeetingAttendanceReport : Entity, IParsable {
        /// <summary>List of attendance records of an attendance report. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AttendanceRecord>? AttendanceRecords { get; set; }
#nullable restore
#else
        public List<AttendanceRecord> AttendanceRecords { get; set; }
#endif
        /// <summary>UTC time when the meeting ended. Read-only.</summary>
        public DateTimeOffset? MeetingEndDateTime { get; set; }
        /// <summary>UTC time when the meeting started. Read-only.</summary>
        public DateTimeOffset? MeetingStartDateTime { get; set; }
        /// <summary>Total number of participants. Read-only.</summary>
        public int? TotalParticipantCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MeetingAttendanceReport CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MeetingAttendanceReport();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"attendanceRecords", n => { AttendanceRecords = n.GetCollectionOfObjectValues<AttendanceRecord>(AttendanceRecord.CreateFromDiscriminatorValue)?.ToList(); } },
                {"meetingEndDateTime", n => { MeetingEndDateTime = n.GetDateTimeOffsetValue(); } },
                {"meetingStartDateTime", n => { MeetingStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"totalParticipantCount", n => { TotalParticipantCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AttendanceRecord>("attendanceRecords", AttendanceRecords);
            writer.WriteDateTimeOffsetValue("meetingEndDateTime", MeetingEndDateTime);
            writer.WriteDateTimeOffsetValue("meetingStartDateTime", MeetingStartDateTime);
            writer.WriteIntValue("totalParticipantCount", TotalParticipantCount);
        }
    }
}
