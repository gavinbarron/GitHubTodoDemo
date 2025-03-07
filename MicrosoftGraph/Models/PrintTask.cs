using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class PrintTask : Entity, IParsable {
        /// <summary>The definition property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PrintTaskDefinition? Definition { get; set; }
#nullable restore
#else
        public PrintTaskDefinition Definition { get; set; }
#endif
        /// <summary>The URL for the print entity that triggered this task. For example, https://graph.microsoft.com/v1.0/print/printers/{printerId}/jobs/{jobId}. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentUrl { get; set; }
#nullable restore
#else
        public string ParentUrl { get; set; }
#endif
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PrintTaskStatus? Status { get; set; }
#nullable restore
#else
        public PrintTaskStatus Status { get; set; }
#endif
        /// <summary>The trigger property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PrintTaskTrigger? Trigger { get; set; }
#nullable restore
#else
        public PrintTaskTrigger Trigger { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrintTask CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrintTask();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"definition", n => { Definition = n.GetObjectValue<PrintTaskDefinition>(PrintTaskDefinition.CreateFromDiscriminatorValue); } },
                {"parentUrl", n => { ParentUrl = n.GetStringValue(); } },
                {"status", n => { Status = n.GetObjectValue<PrintTaskStatus>(PrintTaskStatus.CreateFromDiscriminatorValue); } },
                {"trigger", n => { Trigger = n.GetObjectValue<PrintTaskTrigger>(PrintTaskTrigger.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PrintTaskDefinition>("definition", Definition);
            writer.WriteStringValue("parentUrl", ParentUrl);
            writer.WriteObjectValue<PrintTaskStatus>("status", Status);
            writer.WriteObjectValue<PrintTaskTrigger>("trigger", Trigger);
        }
    }
}
