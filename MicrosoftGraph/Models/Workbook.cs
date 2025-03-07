using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class Workbook : Entity, IParsable {
        /// <summary>The application property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookApplication? Application { get; set; }
#nullable restore
#else
        public WorkbookApplication Application { get; set; }
#endif
        /// <summary>The comments property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkbookComment>? Comments { get; set; }
#nullable restore
#else
        public List<WorkbookComment> Comments { get; set; }
#endif
        /// <summary>The functions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookFunctions? Functions { get; set; }
#nullable restore
#else
        public WorkbookFunctions Functions { get; set; }
#endif
        /// <summary>Represents a collection of workbooks scoped named items (named ranges and constants). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkbookNamedItem>? Names { get; set; }
#nullable restore
#else
        public List<WorkbookNamedItem> Names { get; set; }
#endif
        /// <summary>The status of workbook operations. Getting an operation collection is not supported, but you can get the status of a long-running operation if the Location header is returned in the response. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkbookOperation>? Operations { get; set; }
#nullable restore
#else
        public List<WorkbookOperation> Operations { get; set; }
#endif
        /// <summary>Represents a collection of tables associated with the workbook. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkbookTable>? Tables { get; set; }
#nullable restore
#else
        public List<WorkbookTable> Tables { get; set; }
#endif
        /// <summary>Represents a collection of worksheets associated with the workbook. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkbookWorksheet>? Worksheets { get; set; }
#nullable restore
#else
        public List<WorkbookWorksheet> Worksheets { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Workbook CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Workbook();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"application", n => { Application = n.GetObjectValue<WorkbookApplication>(WorkbookApplication.CreateFromDiscriminatorValue); } },
                {"comments", n => { Comments = n.GetCollectionOfObjectValues<WorkbookComment>(WorkbookComment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"functions", n => { Functions = n.GetObjectValue<WorkbookFunctions>(WorkbookFunctions.CreateFromDiscriminatorValue); } },
                {"names", n => { Names = n.GetCollectionOfObjectValues<WorkbookNamedItem>(WorkbookNamedItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<WorkbookOperation>(WorkbookOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tables", n => { Tables = n.GetCollectionOfObjectValues<WorkbookTable>(WorkbookTable.CreateFromDiscriminatorValue)?.ToList(); } },
                {"worksheets", n => { Worksheets = n.GetCollectionOfObjectValues<WorkbookWorksheet>(WorkbookWorksheet.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookApplication>("application", Application);
            writer.WriteCollectionOfObjectValues<WorkbookComment>("comments", Comments);
            writer.WriteObjectValue<WorkbookFunctions>("functions", Functions);
            writer.WriteCollectionOfObjectValues<WorkbookNamedItem>("names", Names);
            writer.WriteCollectionOfObjectValues<WorkbookOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<WorkbookTable>("tables", Tables);
            writer.WriteCollectionOfObjectValues<WorkbookWorksheet>("worksheets", Worksheets);
        }
    }
}
