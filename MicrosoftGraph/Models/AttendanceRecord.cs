using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GithubTodoDemo.MicrosoftGraph.Models {
    /// <summary>Provides operations to manage the lists property of the microsoft.graph.todo entity.</summary>
    public class AttendanceRecord : Entity, IParsable {
        /// <summary>List of time periods between joining and leaving a meeting.</summary>
        public List<AttendanceInterval> AttendanceIntervals { get; set; }
        /// <summary>Email address of the user associated with this atttendance record.</summary>
        public string EmailAddress { get; set; }
        /// <summary>Identity of the user associated with this atttendance record.</summary>
        public GithubTodoDemo.MicrosoftGraph.Models.Identity Identity { get; set; }
        /// <summary>Role of the attendee. Possible values are: None, Attendee, Presenter, and Organizer.</summary>
        public string Role { get; set; }
        /// <summary>Total duration of the attendances in seconds.</summary>
        public int? TotalAttendanceInSeconds { get; set; }
        /// <summary>
        /// Instantiates a new attendanceRecord and sets the default values.
        /// </summary>
        public AttendanceRecord() : base() {
            OdataType = "#microsoft.graph.attendanceRecord";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
                {"identity", n => { Identity = n.GetObjectValue<GithubTodoDemo.MicrosoftGraph.Models.Identity>(GithubTodoDemo.MicrosoftGraph.Models.Identity.CreateFromDiscriminatorValue); } },
                {"role", n => { Role = n.GetStringValue(); } },
                {"totalAttendanceInSeconds", n => { TotalAttendanceInSeconds = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AttendanceInterval>("attendanceIntervals", AttendanceIntervals);
            writer.WriteStringValue("emailAddress", EmailAddress);
            writer.WriteObjectValue<GithubTodoDemo.MicrosoftGraph.Models.Identity>("identity", Identity);
            writer.WriteStringValue("role", Role);
            writer.WriteIntValue("totalAttendanceInSeconds", TotalAttendanceInSeconds);
        }
    }
}
