using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class WorkbookChartAxis : Entity, IParsable {
        /// <summary>Represents the formatting of a chart object, which includes line and font formatting. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookChartAxisFormat? Format { get; set; }
#nullable restore
#else
        public WorkbookChartAxisFormat Format { get; set; }
#endif
        /// <summary>Returns a gridlines object that represents the major gridlines for the specified axis. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookChartGridlines? MajorGridlines { get; set; }
#nullable restore
#else
        public WorkbookChartGridlines MajorGridlines { get; set; }
#endif
        /// <summary>Represents the interval between two major tick marks. Can be set to a numeric value or an empty string.  The returned value is always a number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? MajorUnit { get; set; }
#nullable restore
#else
        public Json MajorUnit { get; set; }
#endif
        /// <summary>Represents the maximum value on the value axis.  Can be set to a numeric value or an empty string (for automatic axis values).  The returned value is always a number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Maximum { get; set; }
#nullable restore
#else
        public Json Maximum { get; set; }
#endif
        /// <summary>Represents the minimum value on the value axis. Can be set to a numeric value or an empty string (for automatic axis values).  The returned value is always a number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Minimum { get; set; }
#nullable restore
#else
        public Json Minimum { get; set; }
#endif
        /// <summary>Returns a Gridlines object that represents the minor gridlines for the specified axis. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookChartGridlines? MinorGridlines { get; set; }
#nullable restore
#else
        public WorkbookChartGridlines MinorGridlines { get; set; }
#endif
        /// <summary>Represents the interval between two minor tick marks. &apos;Can be set to a numeric value or an empty string (for automatic axis values). The returned value is always a number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? MinorUnit { get; set; }
#nullable restore
#else
        public Json MinorUnit { get; set; }
#endif
        /// <summary>Represents the axis title. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookChartAxisTitle? Title { get; set; }
#nullable restore
#else
        public WorkbookChartAxisTitle Title { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WorkbookChartAxis CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookChartAxis();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"format", n => { Format = n.GetObjectValue<WorkbookChartAxisFormat>(WorkbookChartAxisFormat.CreateFromDiscriminatorValue); } },
                {"majorGridlines", n => { MajorGridlines = n.GetObjectValue<WorkbookChartGridlines>(WorkbookChartGridlines.CreateFromDiscriminatorValue); } },
                {"majorUnit", n => { MajorUnit = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"maximum", n => { Maximum = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"minimum", n => { Minimum = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"minorGridlines", n => { MinorGridlines = n.GetObjectValue<WorkbookChartGridlines>(WorkbookChartGridlines.CreateFromDiscriminatorValue); } },
                {"minorUnit", n => { MinorUnit = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"title", n => { Title = n.GetObjectValue<WorkbookChartAxisTitle>(WorkbookChartAxisTitle.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookChartAxisFormat>("format", Format);
            writer.WriteObjectValue<WorkbookChartGridlines>("majorGridlines", MajorGridlines);
            writer.WriteObjectValue<Json>("majorUnit", MajorUnit);
            writer.WriteObjectValue<Json>("maximum", Maximum);
            writer.WriteObjectValue<Json>("minimum", Minimum);
            writer.WriteObjectValue<WorkbookChartGridlines>("minorGridlines", MinorGridlines);
            writer.WriteObjectValue<Json>("minorUnit", MinorUnit);
            writer.WriteObjectValue<WorkbookChartAxisTitle>("title", Title);
        }
    }
}
