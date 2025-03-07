using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>
    /// This type represents when and to whom to send an e-mail reminder.
    /// </summary>
    public class BookingReminder : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The message in the reminder.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message { get; set; }
#nullable restore
#else
        public string Message { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The amount of time before the start of an appointment that the reminder should be sent. It&apos;s denoted in ISO 8601 format.</summary>
        public TimeSpan? Offset { get; set; }
        /// <summary>The recipients property</summary>
        public BookingReminderRecipients? Recipients { get; set; }
        /// <summary>
        /// Instantiates a new bookingReminder and sets the default values.
        /// </summary>
        public BookingReminder() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BookingReminder CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BookingReminder();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"message", n => { Message = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"offset", n => { Offset = n.GetTimeSpanValue(); } },
                {"recipients", n => { Recipients = n.GetEnumValue<BookingReminderRecipients>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("message", Message);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteTimeSpanValue("offset", Offset);
            writer.WriteEnumValue<BookingReminderRecipients>("recipients", Recipients);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
