using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GithubTodoDemo.MicrosoftGraph.Models {
    public class PrintJobStatus : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A human-readable description of the print job&apos;s current processing state. Read-only.</summary>
        public string Description { get; set; }
        /// <summary>Additional details for print job state. Valid values are described in the following table. Read-only.</summary>
        public List<PrintJobStateDetail?> Details { get; set; }
        /// <summary>True if the job was acknowledged by a printer; false otherwise. Read-only.</summary>
        public bool? IsAcquiredByPrinter { get; set; }
        /// <summary>The OdataType property</summary>
        public string OdataType { get; set; }
        /// <summary>The state property</summary>
        public PrintJobProcessingState? State { get; set; }
        /// <summary>
        /// Instantiates a new printJobStatus and sets the default values.
        /// </summary>
        public PrintJobStatus() {
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.printJobStatus";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PrintJobStatus CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrintJobStatus();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"details", n => { Details = n.GetCollectionOfEnumValues<PrintJobStateDetail>()?.ToList(); } },
                {"isAcquiredByPrinter", n => { IsAcquiredByPrinter = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<PrintJobProcessingState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfEnumValues<PrintJobStateDetail>("details", Details);
            writer.WriteBoolValue("isAcquiredByPrinter", IsAcquiredByPrinter);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<PrintJobProcessingState>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
