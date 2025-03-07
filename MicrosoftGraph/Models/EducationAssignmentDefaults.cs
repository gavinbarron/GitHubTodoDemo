using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class EducationAssignmentDefaults : Entity, IParsable {
        /// <summary>Class-level default behavior for handling students who are added after the assignment is published. Possible values are: none, assignIfOpen.</summary>
        public EducationAddedStudentAction? AddedStudentAction { get; set; }
        /// <summary>Optional field to control adding assignments to students&apos; and teachers&apos; calendars when the assignment is published. The possible values are: none, studentsAndPublisher, studentsAndTeamOwners, unknownFutureValue, and studentsOnly. Note that you must use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: studentsOnly. The default value is none.</summary>
        public EducationAddToCalendarOptions? AddToCalendarAction { get; set; }
        /// <summary>Class-level default value for due time field. Default value is 23:59:00.</summary>
        public Time? DueTime { get; set; }
        /// <summary>Default Teams channel to which notifications will be sent. Default value is null.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NotificationChannelUrl { get; set; }
#nullable restore
#else
        public string NotificationChannelUrl { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EducationAssignmentDefaults CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationAssignmentDefaults();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"addedStudentAction", n => { AddedStudentAction = n.GetEnumValue<EducationAddedStudentAction>(); } },
                {"addToCalendarAction", n => { AddToCalendarAction = n.GetEnumValue<EducationAddToCalendarOptions>(); } },
                {"dueTime", n => { DueTime = n.GetTimeValue(); } },
                {"notificationChannelUrl", n => { NotificationChannelUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<EducationAddedStudentAction>("addedStudentAction", AddedStudentAction);
            writer.WriteEnumValue<EducationAddToCalendarOptions>("addToCalendarAction", AddToCalendarAction);
            writer.WriteTimeValue("dueTime", DueTime);
            writer.WriteStringValue("notificationChannelUrl", NotificationChannelUrl);
        }
    }
}
