using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class WorkbookWorksheetProtectionOptions : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Represents the worksheet protection option of allowing using auto filter feature.</summary>
        public bool? AllowAutoFilter { get; set; }
        /// <summary>Represents the worksheet protection option of allowing deleting columns.</summary>
        public bool? AllowDeleteColumns { get; set; }
        /// <summary>Represents the worksheet protection option of allowing deleting rows.</summary>
        public bool? AllowDeleteRows { get; set; }
        /// <summary>Represents the worksheet protection option of allowing formatting cells.</summary>
        public bool? AllowFormatCells { get; set; }
        /// <summary>Represents the worksheet protection option of allowing formatting columns.</summary>
        public bool? AllowFormatColumns { get; set; }
        /// <summary>Represents the worksheet protection option of allowing formatting rows.</summary>
        public bool? AllowFormatRows { get; set; }
        /// <summary>Represents the worksheet protection option of allowing inserting columns.</summary>
        public bool? AllowInsertColumns { get; set; }
        /// <summary>Represents the worksheet protection option of allowing inserting hyperlinks.</summary>
        public bool? AllowInsertHyperlinks { get; set; }
        /// <summary>Represents the worksheet protection option of allowing inserting rows.</summary>
        public bool? AllowInsertRows { get; set; }
        /// <summary>Represents the worksheet protection option of allowing using pivot table feature.</summary>
        public bool? AllowPivotTables { get; set; }
        /// <summary>Represents the worksheet protection option of allowing using sort feature.</summary>
        public bool? AllowSort { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new workbookWorksheetProtectionOptions and sets the default values.
        /// </summary>
        public WorkbookWorksheetProtectionOptions() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkbookWorksheetProtectionOptions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookWorksheetProtectionOptions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowAutoFilter", n => { AllowAutoFilter = n.GetBoolValue(); } },
                {"allowDeleteColumns", n => { AllowDeleteColumns = n.GetBoolValue(); } },
                {"allowDeleteRows", n => { AllowDeleteRows = n.GetBoolValue(); } },
                {"allowFormatCells", n => { AllowFormatCells = n.GetBoolValue(); } },
                {"allowFormatColumns", n => { AllowFormatColumns = n.GetBoolValue(); } },
                {"allowFormatRows", n => { AllowFormatRows = n.GetBoolValue(); } },
                {"allowInsertColumns", n => { AllowInsertColumns = n.GetBoolValue(); } },
                {"allowInsertHyperlinks", n => { AllowInsertHyperlinks = n.GetBoolValue(); } },
                {"allowInsertRows", n => { AllowInsertRows = n.GetBoolValue(); } },
                {"allowPivotTables", n => { AllowPivotTables = n.GetBoolValue(); } },
                {"allowSort", n => { AllowSort = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowAutoFilter", AllowAutoFilter);
            writer.WriteBoolValue("allowDeleteColumns", AllowDeleteColumns);
            writer.WriteBoolValue("allowDeleteRows", AllowDeleteRows);
            writer.WriteBoolValue("allowFormatCells", AllowFormatCells);
            writer.WriteBoolValue("allowFormatColumns", AllowFormatColumns);
            writer.WriteBoolValue("allowFormatRows", AllowFormatRows);
            writer.WriteBoolValue("allowInsertColumns", AllowInsertColumns);
            writer.WriteBoolValue("allowInsertHyperlinks", AllowInsertHyperlinks);
            writer.WriteBoolValue("allowInsertRows", AllowInsertRows);
            writer.WriteBoolValue("allowPivotTables", AllowPivotTables);
            writer.WriteBoolValue("allowSort", AllowSort);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
