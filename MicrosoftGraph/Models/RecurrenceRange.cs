using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class RecurrenceRange : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The date to stop applying the recurrence pattern. Depending on the recurrence pattern of the event, the last occurrence of the meeting may not be this date. Required if type is endDate.</summary>
        public Date? EndDate { get; set; }
        /// <summary>The number of times to repeat the event. Required and must be positive if type is numbered.</summary>
        public int? NumberOfOccurrences { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Time zone for the startDate and endDate properties. Optional. If not specified, the time zone of the event is used.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecurrenceTimeZone { get; set; }
#nullable restore
#else
        public string RecurrenceTimeZone { get; set; }
#endif
        /// <summary>The date to start applying the recurrence pattern. The first occurrence of the meeting may be this date or later, depending on the recurrence pattern of the event. Must be the same value as the start property of the recurring event. Required.</summary>
        public Date? StartDate { get; set; }
        /// <summary>The recurrence range. The possible values are: endDate, noEnd, numbered. Required.</summary>
        public RecurrenceRangeType? Type { get; set; }
        /// <summary>
        /// Instantiates a new recurrenceRange and sets the default values.
        /// </summary>
        public RecurrenceRange() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RecurrenceRange CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RecurrenceRange();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"endDate", n => { EndDate = n.GetDateValue(); } },
                {"numberOfOccurrences", n => { NumberOfOccurrences = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"recurrenceTimeZone", n => { RecurrenceTimeZone = n.GetStringValue(); } },
                {"startDate", n => { StartDate = n.GetDateValue(); } },
                {"type", n => { Type = n.GetEnumValue<RecurrenceRangeType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateValue("endDate", EndDate);
            writer.WriteIntValue("numberOfOccurrences", NumberOfOccurrences);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("recurrenceTimeZone", RecurrenceTimeZone);
            writer.WriteDateValue("startDate", StartDate);
            writer.WriteEnumValue<RecurrenceRangeType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
