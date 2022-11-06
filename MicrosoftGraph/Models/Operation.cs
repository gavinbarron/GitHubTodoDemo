using GitHubTodoDemo.MicrosoftGraph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>Provides operations to manage the lists property of the microsoft.graph.todo entity.</summary>
    public class Operation : Entity, IParsable {
        /// <summary>The start time of the operation.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The time of the last action of the operation.</summary>
        public DateTimeOffset? LastActionDateTime { get; set; }
        /// <summary>The current status of the operation: notStarted, running, completed, failed</summary>
        public OperationStatus? Status { get; set; }
        /// <summary>
        /// Instantiates a new operation and sets the default values.
        /// </summary>
        public Operation() : base() {
            OdataType = "#microsoft.graph.operation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Operation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.onenoteOperation" => new OnenoteOperation(),
                _ => new Operation(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastActionDateTime", n => { LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetEnumValue<OperationStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteEnumValue<OperationStatus>("status", Status);
        }
    }
}
