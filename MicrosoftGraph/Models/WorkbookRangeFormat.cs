using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class WorkbookRangeFormat : Entity, IParsable {
        /// <summary>Collection of border objects that apply to the overall range selected Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkbookRangeBorder>? Borders { get; set; }
#nullable restore
#else
        public List<WorkbookRangeBorder> Borders { get; set; }
#endif
        /// <summary>Gets or sets the width of all colums within the range. If the column widths are not uniform, null will be returned.</summary>
        public double? ColumnWidth { get; set; }
        /// <summary>Returns the fill object defined on the overall range. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookRangeFill? Fill { get; set; }
#nullable restore
#else
        public WorkbookRangeFill Fill { get; set; }
#endif
        /// <summary>Returns the font object defined on the overall range selected Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookRangeFont? Font { get; set; }
#nullable restore
#else
        public WorkbookRangeFont Font { get; set; }
#endif
        /// <summary>Represents the horizontal alignment for the specified object. The possible values are: General, Left, Center, Right, Fill, Justify, CenterAcrossSelection, Distributed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HorizontalAlignment { get; set; }
#nullable restore
#else
        public string HorizontalAlignment { get; set; }
#endif
        /// <summary>Returns the format protection object for a range. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookFormatProtection? Protection { get; set; }
#nullable restore
#else
        public WorkbookFormatProtection Protection { get; set; }
#endif
        /// <summary>Gets or sets the height of all rows in the range. If the row heights are not uniform null will be returned.</summary>
        public double? RowHeight { get; set; }
        /// <summary>Represents the vertical alignment for the specified object. The possible values are: Top, Center, Bottom, Justify, Distributed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VerticalAlignment { get; set; }
#nullable restore
#else
        public string VerticalAlignment { get; set; }
#endif
        /// <summary>Indicates if Excel wraps the text in the object. A null value indicates that the entire range doesn&apos;t have uniform wrap setting</summary>
        public bool? WrapText { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WorkbookRangeFormat CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookRangeFormat();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"borders", n => { Borders = n.GetCollectionOfObjectValues<WorkbookRangeBorder>(WorkbookRangeBorder.CreateFromDiscriminatorValue)?.ToList(); } },
                {"columnWidth", n => { ColumnWidth = n.GetDoubleValue(); } },
                {"fill", n => { Fill = n.GetObjectValue<WorkbookRangeFill>(WorkbookRangeFill.CreateFromDiscriminatorValue); } },
                {"font", n => { Font = n.GetObjectValue<WorkbookRangeFont>(WorkbookRangeFont.CreateFromDiscriminatorValue); } },
                {"horizontalAlignment", n => { HorizontalAlignment = n.GetStringValue(); } },
                {"protection", n => { Protection = n.GetObjectValue<WorkbookFormatProtection>(WorkbookFormatProtection.CreateFromDiscriminatorValue); } },
                {"rowHeight", n => { RowHeight = n.GetDoubleValue(); } },
                {"verticalAlignment", n => { VerticalAlignment = n.GetStringValue(); } },
                {"wrapText", n => { WrapText = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<WorkbookRangeBorder>("borders", Borders);
            writer.WriteDoubleValue("columnWidth", ColumnWidth);
            writer.WriteObjectValue<WorkbookRangeFill>("fill", Fill);
            writer.WriteObjectValue<WorkbookRangeFont>("font", Font);
            writer.WriteStringValue("horizontalAlignment", HorizontalAlignment);
            writer.WriteObjectValue<WorkbookFormatProtection>("protection", Protection);
            writer.WriteDoubleValue("rowHeight", RowHeight);
            writer.WriteStringValue("verticalAlignment", VerticalAlignment);
            writer.WriteBoolValue("wrapText", WrapText);
        }
    }
}
