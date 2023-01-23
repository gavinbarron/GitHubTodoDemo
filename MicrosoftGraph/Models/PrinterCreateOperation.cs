using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class PrinterCreateOperation : PrintOperation, IParsable {
        /// <summary>The signed certificate created during the registration process. Read-only.</summary>
        public string Certificate { get; set; }
        /// <summary>The created printer entity. Read-only.</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.Printer Printer { get; set; }
        /// <summary>
        /// Instantiates a new PrinterCreateOperation and sets the default values.
        /// </summary>
        public PrinterCreateOperation() : base() {
            OdataType = "#microsoft.graph.printerCreateOperation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrinterCreateOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrinterCreateOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"certificate", n => { Certificate = n.GetStringValue(); } },
                {"printer", n => { Printer = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Printer>(GitHubTodoDemo.MicrosoftGraph.Models.Printer.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("certificate", Certificate);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Printer>("printer", Printer);
        }
    }
}
