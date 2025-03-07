using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class CalendarGroup : Entity, IParsable {
        /// <summary>The calendars in the calendar group. Navigation property. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Calendar>? Calendars { get; set; }
#nullable restore
#else
        public List<Calendar> Calendars { get; set; }
#endif
        /// <summary>Identifies the version of the calendar group. Every time the calendar group is changed, ChangeKey changes as well. This allows Exchange to apply changes to the correct version of the object. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChangeKey { get; set; }
#nullable restore
#else
        public string ChangeKey { get; set; }
#endif
        /// <summary>The class identifier. Read-only.</summary>
        public Guid? ClassId { get; set; }
        /// <summary>The group name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CalendarGroup CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CalendarGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"calendars", n => { Calendars = n.GetCollectionOfObjectValues<Calendar>(Calendar.CreateFromDiscriminatorValue)?.ToList(); } },
                {"changeKey", n => { ChangeKey = n.GetStringValue(); } },
                {"classId", n => { ClassId = n.GetGuidValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Calendar>("calendars", Calendars);
            writer.WriteStringValue("changeKey", ChangeKey);
            writer.WriteGuidValue("classId", ClassId);
            writer.WriteStringValue("name", Name);
        }
    }
}
