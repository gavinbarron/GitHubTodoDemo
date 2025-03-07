using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models.ExternalConnectors {
    public class ConnectionOperation : Entity, IParsable {
        /// <summary>If status is failed, provides more information about the error that caused the failure.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.PublicError? Error { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.PublicError Error { get; set; }
#endif
        /// <summary>Indicates the status of the asynchronous operation. Possible values are: unspecified, inprogress, completed, failed, unknownFutureValue.</summary>
        public ConnectionOperationStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ConnectionOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConnectionOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"error", n => { Error = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.PublicError>(GitHubTodoDemo.MicrosoftGraph.Models.PublicError.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetEnumValue<ConnectionOperationStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.PublicError>("error", Error);
            writer.WriteEnumValue<ConnectionOperationStatus>("status", Status);
        }
    }
}
