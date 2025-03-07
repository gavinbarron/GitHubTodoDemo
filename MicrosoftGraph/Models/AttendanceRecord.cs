using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class AttendanceRecord : Entity, IParsable {
        /// <summary>List of time periods between joining and leaving a meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AttendanceInterval>? AttendanceIntervals { get; set; }
#nullable restore
#else
        public List<AttendanceInterval> AttendanceIntervals { get; set; }
#endif
        /// <summary>Email address of the user associated with this atttendance record.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailAddress { get; set; }
#nullable restore
#else
        public string EmailAddress { get; set; }
#endif
        /// <summary>Identity of the user associated with this atttendance record.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.Identity? Identity { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.Identity Identity { get; set; }
#endif
        /// <summary>Role of the attendee. Possible values are: None, Attendee, Presenter, and Organizer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Role { get; set; }
#nullable restore
#else
        public string Role { get; set; }
#endif
        /// <summary>Total duration of the attendances in seconds.</summary>
        public int? TotalAttendanceInSeconds { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AttendanceRecord CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttendanceRecord();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"attendanceIntervals", n => { AttendanceIntervals = n.GetCollectionOfObjectValues<AttendanceInterval>(AttendanceInterval.CreateFromDiscriminatorValue)?.ToList(); } },
                {"emailAddress", n => { EmailAddress = n.GetStringValue(); } },
                {"identity", n => { Identity = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Identity>(GitHubTodoDemo.MicrosoftGraph.Models.Identity.CreateFromDiscriminatorValue); } },
                {"role", n => { Role = n.GetStringValue(); } },
                {"totalAttendanceInSeconds", n => { TotalAttendanceInSeconds = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AttendanceInterval>("attendanceIntervals", AttendanceIntervals);
            writer.WriteStringValue("emailAddress", EmailAddress);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Identity>("identity", Identity);
            writer.WriteStringValue("role", Role);
            writer.WriteIntValue("totalAttendanceInSeconds", TotalAttendanceInSeconds);
        }
    }
}
