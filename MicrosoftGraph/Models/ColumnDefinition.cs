using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class ColumnDefinition : Entity, IParsable {
        /// <summary>This column stores boolean values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BooleanColumn? Boolean { get; set; }
#nullable restore
#else
        public BooleanColumn Boolean { get; set; }
#endif
        /// <summary>This column&apos;s data is calculated based on other columns.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CalculatedColumn? Calculated { get; set; }
#nullable restore
#else
        public CalculatedColumn Calculated { get; set; }
#endif
        /// <summary>This column stores data from a list of choices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ChoiceColumn? Choice { get; set; }
#nullable restore
#else
        public ChoiceColumn Choice { get; set; }
#endif
        /// <summary>For site columns, the name of the group this column belongs to. Helps organize related columns.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ColumnGroup { get; set; }
#nullable restore
#else
        public string ColumnGroup { get; set; }
#endif
        /// <summary>This column stores content approval status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ContentApprovalStatusColumn? ContentApprovalStatus { get; set; }
#nullable restore
#else
        public ContentApprovalStatusColumn ContentApprovalStatus { get; set; }
#endif
        /// <summary>This column stores currency values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CurrencyColumn? Currency { get; set; }
#nullable restore
#else
        public CurrencyColumn Currency { get; set; }
#endif
        /// <summary>This column stores DateTime values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DateTimeColumn? DateTime { get; set; }
#nullable restore
#else
        public DateTimeColumn DateTime { get; set; }
#endif
        /// <summary>The default value for this column.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DefaultColumnValue? DefaultValue { get; set; }
#nullable restore
#else
        public DefaultColumnValue DefaultValue { get; set; }
#endif
        /// <summary>The user-facing description of the column.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The user-facing name of the column.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>If true, no two list items may have the same value for this column.</summary>
        public bool? EnforceUniqueValues { get; set; }
        /// <summary>This column stores a geolocation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GeolocationColumn? Geolocation { get; set; }
#nullable restore
#else
        public GeolocationColumn Geolocation { get; set; }
#endif
        /// <summary>Specifies whether the column is displayed in the user interface.</summary>
        public bool? Hidden { get; set; }
        /// <summary>This column stores hyperlink or picture values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public HyperlinkOrPictureColumn? HyperlinkOrPicture { get; set; }
#nullable restore
#else
        public HyperlinkOrPictureColumn HyperlinkOrPicture { get; set; }
#endif
        /// <summary>Specifies whether the column values can be used for sorting and searching.</summary>
        public bool? Indexed { get; set; }
        /// <summary>Indicates whether this column can be deleted.</summary>
        public bool? IsDeletable { get; set; }
        /// <summary>Indicates whether values in the column can be reordered. Read-only.</summary>
        public bool? IsReorderable { get; set; }
        /// <summary>Specifies whether the column can be changed.</summary>
        public bool? IsSealed { get; set; }
        /// <summary>This column&apos;s data is looked up from another source in the site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public LookupColumn? Lookup { get; set; }
#nullable restore
#else
        public LookupColumn Lookup { get; set; }
#endif
        /// <summary>The API-facing name of the column as it appears in the [fields][] on a [listItem][]. For the user-facing name, see displayName.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>This column stores number values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NumberColumn? Number { get; set; }
#nullable restore
#else
        public NumberColumn Number { get; set; }
#endif
        /// <summary>This column stores Person or Group values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PersonOrGroupColumn? PersonOrGroup { get; set; }
#nullable restore
#else
        public PersonOrGroupColumn PersonOrGroup { get; set; }
#endif
        /// <summary>If &apos;true&apos;, changes to this column will be propagated to lists that implement the column.</summary>
        public bool? PropagateChanges { get; set; }
        /// <summary>Specifies whether the column values can be modified.</summary>
        public bool? ReadOnly { get; set; }
        /// <summary>Specifies whether the column value isn&apos;t optional.</summary>
        public bool? Required { get; set; }
        /// <summary>The source column for the content type column.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ColumnDefinition? SourceColumn { get; set; }
#nullable restore
#else
        public ColumnDefinition SourceColumn { get; set; }
#endif
        /// <summary>ContentType from which this column is inherited from. Present only in contentTypes columns response. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ContentTypeInfo? SourceContentType { get; set; }
#nullable restore
#else
        public ContentTypeInfo SourceContentType { get; set; }
#endif
        /// <summary>This column stores taxonomy terms.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TermColumn? Term { get; set; }
#nullable restore
#else
        public TermColumn Term { get; set; }
#endif
        /// <summary>This column stores text values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TextColumn? Text { get; set; }
#nullable restore
#else
        public TextColumn Text { get; set; }
#endif
        /// <summary>This column stores thumbnail values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ThumbnailColumn? Thumbnail { get; set; }
#nullable restore
#else
        public ThumbnailColumn Thumbnail { get; set; }
#endif
        /// <summary>For site columns, the type of column. Read-only.</summary>
        public ColumnTypes? Type { get; set; }
        /// <summary>This column stores validation formula and message for the column.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ColumnValidation? Validation { get; set; }
#nullable restore
#else
        public ColumnValidation Validation { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ColumnDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ColumnDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"boolean", n => { Boolean = n.GetObjectValue<BooleanColumn>(BooleanColumn.CreateFromDiscriminatorValue); } },
                {"calculated", n => { Calculated = n.GetObjectValue<CalculatedColumn>(CalculatedColumn.CreateFromDiscriminatorValue); } },
                {"choice", n => { Choice = n.GetObjectValue<ChoiceColumn>(ChoiceColumn.CreateFromDiscriminatorValue); } },
                {"columnGroup", n => { ColumnGroup = n.GetStringValue(); } },
                {"contentApprovalStatus", n => { ContentApprovalStatus = n.GetObjectValue<ContentApprovalStatusColumn>(ContentApprovalStatusColumn.CreateFromDiscriminatorValue); } },
                {"currency", n => { Currency = n.GetObjectValue<CurrencyColumn>(CurrencyColumn.CreateFromDiscriminatorValue); } },
                {"dateTime", n => { DateTime = n.GetObjectValue<DateTimeColumn>(DateTimeColumn.CreateFromDiscriminatorValue); } },
                {"defaultValue", n => { DefaultValue = n.GetObjectValue<DefaultColumnValue>(DefaultColumnValue.CreateFromDiscriminatorValue); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"enforceUniqueValues", n => { EnforceUniqueValues = n.GetBoolValue(); } },
                {"geolocation", n => { Geolocation = n.GetObjectValue<GeolocationColumn>(GeolocationColumn.CreateFromDiscriminatorValue); } },
                {"hidden", n => { Hidden = n.GetBoolValue(); } },
                {"hyperlinkOrPicture", n => { HyperlinkOrPicture = n.GetObjectValue<HyperlinkOrPictureColumn>(HyperlinkOrPictureColumn.CreateFromDiscriminatorValue); } },
                {"indexed", n => { Indexed = n.GetBoolValue(); } },
                {"isDeletable", n => { IsDeletable = n.GetBoolValue(); } },
                {"isReorderable", n => { IsReorderable = n.GetBoolValue(); } },
                {"isSealed", n => { IsSealed = n.GetBoolValue(); } },
                {"lookup", n => { Lookup = n.GetObjectValue<LookupColumn>(LookupColumn.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"number", n => { Number = n.GetObjectValue<NumberColumn>(NumberColumn.CreateFromDiscriminatorValue); } },
                {"personOrGroup", n => { PersonOrGroup = n.GetObjectValue<PersonOrGroupColumn>(PersonOrGroupColumn.CreateFromDiscriminatorValue); } },
                {"propagateChanges", n => { PropagateChanges = n.GetBoolValue(); } },
                {"readOnly", n => { ReadOnly = n.GetBoolValue(); } },
                {"required", n => { Required = n.GetBoolValue(); } },
                {"sourceColumn", n => { SourceColumn = n.GetObjectValue<ColumnDefinition>(ColumnDefinition.CreateFromDiscriminatorValue); } },
                {"sourceContentType", n => { SourceContentType = n.GetObjectValue<ContentTypeInfo>(ContentTypeInfo.CreateFromDiscriminatorValue); } },
                {"term", n => { Term = n.GetObjectValue<TermColumn>(TermColumn.CreateFromDiscriminatorValue); } },
                {"text", n => { Text = n.GetObjectValue<TextColumn>(TextColumn.CreateFromDiscriminatorValue); } },
                {"thumbnail", n => { Thumbnail = n.GetObjectValue<ThumbnailColumn>(ThumbnailColumn.CreateFromDiscriminatorValue); } },
                {"type", n => { Type = n.GetEnumValue<ColumnTypes>(); } },
                {"validation", n => { Validation = n.GetObjectValue<ColumnValidation>(ColumnValidation.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<BooleanColumn>("boolean", Boolean);
            writer.WriteObjectValue<CalculatedColumn>("calculated", Calculated);
            writer.WriteObjectValue<ChoiceColumn>("choice", Choice);
            writer.WriteStringValue("columnGroup", ColumnGroup);
            writer.WriteObjectValue<ContentApprovalStatusColumn>("contentApprovalStatus", ContentApprovalStatus);
            writer.WriteObjectValue<CurrencyColumn>("currency", Currency);
            writer.WriteObjectValue<DateTimeColumn>("dateTime", DateTime);
            writer.WriteObjectValue<DefaultColumnValue>("defaultValue", DefaultValue);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("enforceUniqueValues", EnforceUniqueValues);
            writer.WriteObjectValue<GeolocationColumn>("geolocation", Geolocation);
            writer.WriteBoolValue("hidden", Hidden);
            writer.WriteObjectValue<HyperlinkOrPictureColumn>("hyperlinkOrPicture", HyperlinkOrPicture);
            writer.WriteBoolValue("indexed", Indexed);
            writer.WriteBoolValue("isDeletable", IsDeletable);
            writer.WriteBoolValue("isReorderable", IsReorderable);
            writer.WriteBoolValue("isSealed", IsSealed);
            writer.WriteObjectValue<LookupColumn>("lookup", Lookup);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<NumberColumn>("number", Number);
            writer.WriteObjectValue<PersonOrGroupColumn>("personOrGroup", PersonOrGroup);
            writer.WriteBoolValue("propagateChanges", PropagateChanges);
            writer.WriteBoolValue("readOnly", ReadOnly);
            writer.WriteBoolValue("required", Required);
            writer.WriteObjectValue<ColumnDefinition>("sourceColumn", SourceColumn);
            writer.WriteObjectValue<ContentTypeInfo>("sourceContentType", SourceContentType);
            writer.WriteObjectValue<TermColumn>("term", Term);
            writer.WriteObjectValue<TextColumn>("text", Text);
            writer.WriteObjectValue<ThumbnailColumn>("thumbnail", Thumbnail);
            writer.WriteEnumValue<ColumnTypes>("type", Type);
            writer.WriteObjectValue<ColumnValidation>("validation", Validation);
        }
    }
}
