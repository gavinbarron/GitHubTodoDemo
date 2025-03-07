using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class DaylightTimeZoneOffset : StandardTimeZoneOffset, IParsable {
        /// <summary>The time offset from Coordinated Universal Time (UTC) for daylight saving time. This value is in minutes.</summary>
        public int? DaylightBias { get; set; }
        /// <summary>
        /// Instantiates a new DaylightTimeZoneOffset and sets the default values.
        /// </summary>
        public DaylightTimeZoneOffset() : base() {
            OdataType = "#microsoft.graph.daylightTimeZoneOffset";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DaylightTimeZoneOffset CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DaylightTimeZoneOffset();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"daylightBias", n => { DaylightBias = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("daylightBias", DaylightBias);
        }
    }
}
