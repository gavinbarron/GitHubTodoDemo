using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class Printer : PrinterBase, IParsable {
        /// <summary>The connectors that are associated with the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintConnector>? Connectors { get; set; }
#nullable restore
#else
        public List<PrintConnector> Connectors { get; set; }
#endif
        /// <summary>True if the printer has a physical device for printing. Read-only.</summary>
        public bool? HasPhysicalDevice { get; set; }
        /// <summary>True if the printer is shared; false otherwise. Read-only.</summary>
        public bool? IsShared { get; set; }
        /// <summary>The most recent dateTimeOffset when a printer interacted with Universal Print. Read-only.</summary>
        public DateTimeOffset? LastSeenDateTime { get; set; }
        /// <summary>The DateTimeOffset when the printer was registered. Read-only.</summary>
        public DateTimeOffset? RegisteredDateTime { get; set; }
        /// <summary>The list of printerShares that are associated with the printer. Currently, only one printerShare can be associated with the printer. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrinterShare>? Shares { get; set; }
#nullable restore
#else
        public List<PrinterShare> Shares { get; set; }
#endif
        /// <summary>A list of task triggers that are associated with the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintTaskTrigger>? TaskTriggers { get; set; }
#nullable restore
#else
        public List<PrintTaskTrigger> TaskTriggers { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Printer and sets the default values.
        /// </summary>
        public Printer() : base() {
            OdataType = "#microsoft.graph.printer";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Printer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Printer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"connectors", n => { Connectors = n.GetCollectionOfObjectValues<PrintConnector>(PrintConnector.CreateFromDiscriminatorValue)?.ToList(); } },
                {"hasPhysicalDevice", n => { HasPhysicalDevice = n.GetBoolValue(); } },
                {"isShared", n => { IsShared = n.GetBoolValue(); } },
                {"lastSeenDateTime", n => { LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                {"registeredDateTime", n => { RegisteredDateTime = n.GetDateTimeOffsetValue(); } },
                {"shares", n => { Shares = n.GetCollectionOfObjectValues<PrinterShare>(PrinterShare.CreateFromDiscriminatorValue)?.ToList(); } },
                {"taskTriggers", n => { TaskTriggers = n.GetCollectionOfObjectValues<PrintTaskTrigger>(PrintTaskTrigger.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<PrintConnector>("connectors", Connectors);
            writer.WriteBoolValue("hasPhysicalDevice", HasPhysicalDevice);
            writer.WriteBoolValue("isShared", IsShared);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteDateTimeOffsetValue("registeredDateTime", RegisteredDateTime);
            writer.WriteCollectionOfObjectValues<PrinterShare>("shares", Shares);
            writer.WriteCollectionOfObjectValues<PrintTaskTrigger>("taskTriggers", TaskTriggers);
        }
    }
}
