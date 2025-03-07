using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class PrinterBase : Entity, IParsable {
        /// <summary>The capabilities of the printer/printerShare.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PrinterCapabilities? Capabilities { get; set; }
#nullable restore
#else
        public PrinterCapabilities Capabilities { get; set; }
#endif
        /// <summary>The default print settings of printer/printerShare.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PrinterDefaults? Defaults { get; set; }
#nullable restore
#else
        public PrinterDefaults Defaults { get; set; }
#endif
        /// <summary>The name of the printer/printerShare.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Whether the printer/printerShare is currently accepting new print jobs.</summary>
        public bool? IsAcceptingJobs { get; set; }
        /// <summary>The list of jobs that are queued for printing by the printer/printerShare.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PrintJob>? Jobs { get; set; }
#nullable restore
#else
        public List<PrintJob> Jobs { get; set; }
#endif
        /// <summary>The physical and/or organizational location of the printer/printerShare.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PrinterLocation? Location { get; set; }
#nullable restore
#else
        public PrinterLocation Location { get; set; }
#endif
        /// <summary>The manufacturer of the printer/printerShare.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer { get; set; }
#nullable restore
#else
        public string Manufacturer { get; set; }
#endif
        /// <summary>The model name of the printer/printerShare.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model { get; set; }
#nullable restore
#else
        public string Model { get; set; }
#endif
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PrinterStatus? Status { get; set; }
#nullable restore
#else
        public PrinterStatus Status { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrinterBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.printer" => new Printer(),
                "#microsoft.graph.printerShare" => new PrinterShare(),
                _ => new PrinterBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"capabilities", n => { Capabilities = n.GetObjectValue<PrinterCapabilities>(PrinterCapabilities.CreateFromDiscriminatorValue); } },
                {"defaults", n => { Defaults = n.GetObjectValue<PrinterDefaults>(PrinterDefaults.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isAcceptingJobs", n => { IsAcceptingJobs = n.GetBoolValue(); } },
                {"jobs", n => { Jobs = n.GetCollectionOfObjectValues<PrintJob>(PrintJob.CreateFromDiscriminatorValue)?.ToList(); } },
                {"location", n => { Location = n.GetObjectValue<PrinterLocation>(PrinterLocation.CreateFromDiscriminatorValue); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"status", n => { Status = n.GetObjectValue<PrinterStatus>(PrinterStatus.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PrinterCapabilities>("capabilities", Capabilities);
            writer.WriteObjectValue<PrinterDefaults>("defaults", Defaults);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isAcceptingJobs", IsAcceptingJobs);
            writer.WriteCollectionOfObjectValues<PrintJob>("jobs", Jobs);
            writer.WriteObjectValue<PrinterLocation>("location", Location);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteObjectValue<PrinterStatus>("status", Status);
        }
    }
}
