using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class ContentType : Entity, IParsable {
        /// <summary>List of canonical URLs for hub sites with which this content type is associated to. This will contain all hub sites where this content type is queued to be enforced or is already enforced. Enforcing a content type means that the content type will be applied to the lists in the enforced sites.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AssociatedHubsUrls { get; set; }
#nullable restore
#else
        public List<string> AssociatedHubsUrls { get; set; }
#endif
        /// <summary>Parent contentType from which this content type is derived.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ContentType? Base { get; set; }
#nullable restore
#else
        public ContentType Base { get; set; }
#endif
        /// <summary>The collection of content types that are ancestors of this content type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ContentType>? BaseTypes { get; set; }
#nullable restore
#else
        public List<ContentType> BaseTypes { get; set; }
#endif
        /// <summary>The collection of columns that are required by this content type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ColumnLink>? ColumnLinks { get; set; }
#nullable restore
#else
        public List<ColumnLink> ColumnLinks { get; set; }
#endif
        /// <summary>Column order information in a content type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ColumnDefinition>? ColumnPositions { get; set; }
#nullable restore
#else
        public List<ColumnDefinition> ColumnPositions { get; set; }
#endif
        /// <summary>The collection of column definitions for this contentType.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ColumnDefinition>? Columns { get; set; }
#nullable restore
#else
        public List<ColumnDefinition> Columns { get; set; }
#endif
        /// <summary>The descriptive text for the item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Document Set metadata.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.DocumentSet? DocumentSet { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.DocumentSet DocumentSet { get; set; }
#endif
        /// <summary>Document template metadata. To make sure that documents have consistent content across a site and its subsites, you can associate a Word, Excel, or PowerPoint template with a site content type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DocumentSetContent? DocumentTemplate { get; set; }
#nullable restore
#else
        public DocumentSetContent DocumentTemplate { get; set; }
#endif
        /// <summary>The name of the group this content type belongs to. Helps organize related content types.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Group { get; set; }
#nullable restore
#else
        public string Group { get; set; }
#endif
        /// <summary>Indicates whether the content type is hidden in the list&apos;s &apos;New&apos; menu.</summary>
        public bool? Hidden { get; set; }
        /// <summary>If this content type is inherited from another scope (like a site), provides a reference to the item where the content type is defined.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemReference? InheritedFrom { get; set; }
#nullable restore
#else
        public ItemReference InheritedFrom { get; set; }
#endif
        /// <summary>Specifies if a content type is a built-in content type.</summary>
        public bool? IsBuiltIn { get; set; }
        /// <summary>The name of the content type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Specifies the order in which the content type appears in the selection UI.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ContentTypeOrder? Order { get; set; }
#nullable restore
#else
        public ContentTypeOrder Order { get; set; }
#endif
        /// <summary>The unique identifier of the content type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentId { get; set; }
#nullable restore
#else
        public string ParentId { get; set; }
#endif
        /// <summary>If true, any changes made to the content type will be pushed to inherited content types and lists that implement the content type.</summary>
        public bool? PropagateChanges { get; set; }
        /// <summary>If true, the content type can&apos;t be modified unless this value is first set to false.</summary>
        public bool? ReadOnly { get; set; }
        /// <summary>If true, the content type can&apos;t be modified by users or through push-down operations. Only site collection administrators can seal or unseal content types.</summary>
        public bool? Sealed { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ContentType CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ContentType();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"associatedHubsUrls", n => { AssociatedHubsUrls = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"base", n => { Base = n.GetObjectValue<ContentType>(ContentType.CreateFromDiscriminatorValue); } },
                {"baseTypes", n => { BaseTypes = n.GetCollectionOfObjectValues<ContentType>(ContentType.CreateFromDiscriminatorValue)?.ToList(); } },
                {"columnLinks", n => { ColumnLinks = n.GetCollectionOfObjectValues<ColumnLink>(ColumnLink.CreateFromDiscriminatorValue)?.ToList(); } },
                {"columnPositions", n => { ColumnPositions = n.GetCollectionOfObjectValues<ColumnDefinition>(ColumnDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"columns", n => { Columns = n.GetCollectionOfObjectValues<ColumnDefinition>(ColumnDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"documentSet", n => { DocumentSet = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.DocumentSet>(GitHubTodoDemo.MicrosoftGraph.Models.DocumentSet.CreateFromDiscriminatorValue); } },
                {"documentTemplate", n => { DocumentTemplate = n.GetObjectValue<DocumentSetContent>(DocumentSetContent.CreateFromDiscriminatorValue); } },
                {"group", n => { Group = n.GetStringValue(); } },
                {"hidden", n => { Hidden = n.GetBoolValue(); } },
                {"inheritedFrom", n => { InheritedFrom = n.GetObjectValue<ItemReference>(ItemReference.CreateFromDiscriminatorValue); } },
                {"isBuiltIn", n => { IsBuiltIn = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"order", n => { Order = n.GetObjectValue<ContentTypeOrder>(ContentTypeOrder.CreateFromDiscriminatorValue); } },
                {"parentId", n => { ParentId = n.GetStringValue(); } },
                {"propagateChanges", n => { PropagateChanges = n.GetBoolValue(); } },
                {"readOnly", n => { ReadOnly = n.GetBoolValue(); } },
                {"sealed", n => { Sealed = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("associatedHubsUrls", AssociatedHubsUrls);
            writer.WriteObjectValue<ContentType>("base", Base);
            writer.WriteCollectionOfObjectValues<ContentType>("baseTypes", BaseTypes);
            writer.WriteCollectionOfObjectValues<ColumnLink>("columnLinks", ColumnLinks);
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("columnPositions", ColumnPositions);
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("columns", Columns);
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.DocumentSet>("documentSet", DocumentSet);
            writer.WriteObjectValue<DocumentSetContent>("documentTemplate", DocumentTemplate);
            writer.WriteStringValue("group", Group);
            writer.WriteBoolValue("hidden", Hidden);
            writer.WriteObjectValue<ItemReference>("inheritedFrom", InheritedFrom);
            writer.WriteBoolValue("isBuiltIn", IsBuiltIn);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<ContentTypeOrder>("order", Order);
            writer.WriteStringValue("parentId", ParentId);
            writer.WriteBoolValue("propagateChanges", PropagateChanges);
            writer.WriteBoolValue("readOnly", ReadOnly);
            writer.WriteBoolValue("sealed", Sealed);
        }
    }
}
