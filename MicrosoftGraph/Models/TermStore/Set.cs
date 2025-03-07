using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models.TermStore {
    public class Set : Entity, IParsable {
        /// <summary>Children terms of set in term [store].</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Term>? Children { get; set; }
#nullable restore
#else
        public List<Term> Children { get; set; }
#endif
        /// <summary>Date and time of set creation. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Description that gives details on the term usage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Name of the set for each languageTag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<LocalizedName>? LocalizedNames { get; set; }
#nullable restore
#else
        public List<LocalizedName> LocalizedNames { get; set; }
#endif
        /// <summary>The parentGroup property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Group? ParentGroup { get; set; }
#nullable restore
#else
        public Group ParentGroup { get; set; }
#endif
        /// <summary>Custom properties for the set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GitHubTodoDemo.MicrosoftGraph.Models.KeyValue>? Properties { get; set; }
#nullable restore
#else
        public List<GitHubTodoDemo.MicrosoftGraph.Models.KeyValue> Properties { get; set; }
#endif
        /// <summary>Indicates which terms have been pinned or reused directly under the set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Relation>? Relations { get; set; }
#nullable restore
#else
        public List<Relation> Relations { get; set; }
#endif
        /// <summary>All the terms under the set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Term>? Terms { get; set; }
#nullable restore
#else
        public List<Term> Terms { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Set CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Set();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"children", n => { Children = n.GetCollectionOfObjectValues<Term>(Term.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"localizedNames", n => { LocalizedNames = n.GetCollectionOfObjectValues<LocalizedName>(LocalizedName.CreateFromDiscriminatorValue)?.ToList(); } },
                {"parentGroup", n => { ParentGroup = n.GetObjectValue<Group>(Group.CreateFromDiscriminatorValue); } },
                {"properties", n => { Properties = n.GetCollectionOfObjectValues<GitHubTodoDemo.MicrosoftGraph.Models.KeyValue>(GitHubTodoDemo.MicrosoftGraph.Models.KeyValue.CreateFromDiscriminatorValue)?.ToList(); } },
                {"relations", n => { Relations = n.GetCollectionOfObjectValues<Relation>(Relation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"terms", n => { Terms = n.GetCollectionOfObjectValues<Term>(Term.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Term>("children", Children);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<LocalizedName>("localizedNames", LocalizedNames);
            writer.WriteObjectValue<Group>("parentGroup", ParentGroup);
            writer.WriteCollectionOfObjectValues<GitHubTodoDemo.MicrosoftGraph.Models.KeyValue>("properties", Properties);
            writer.WriteCollectionOfObjectValues<Relation>("relations", Relations);
            writer.WriteCollectionOfObjectValues<Term>("terms", Terms);
        }
    }
}
