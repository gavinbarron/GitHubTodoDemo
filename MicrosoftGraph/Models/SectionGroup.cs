using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class SectionGroup : OnenoteEntityHierarchyModel, IParsable {
        /// <summary>The notebook that contains the section group. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Notebook? ParentNotebook { get; set; }
#nullable restore
#else
        public Notebook ParentNotebook { get; set; }
#endif
        /// <summary>The section group that contains the section group. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SectionGroup? ParentSectionGroup { get; set; }
#nullable restore
#else
        public SectionGroup ParentSectionGroup { get; set; }
#endif
        /// <summary>The section groups in the section. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SectionGroup>? SectionGroups { get; set; }
#nullable restore
#else
        public List<SectionGroup> SectionGroups { get; set; }
#endif
        /// <summary>The URL for the sectionGroups navigation property, which returns all the section groups in the section group. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SectionGroupsUrl { get; set; }
#nullable restore
#else
        public string SectionGroupsUrl { get; set; }
#endif
        /// <summary>The sections in the section group. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnenoteSection>? Sections { get; set; }
#nullable restore
#else
        public List<OnenoteSection> Sections { get; set; }
#endif
        /// <summary>The URL for the sections navigation property, which returns all the sections in the section group. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SectionsUrl { get; set; }
#nullable restore
#else
        public string SectionsUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new sectionGroup and sets the default values.
        /// </summary>
        public SectionGroup() : base() {
            OdataType = "#microsoft.graph.sectionGroup";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SectionGroup CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SectionGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"parentNotebook", n => { ParentNotebook = n.GetObjectValue<Notebook>(Notebook.CreateFromDiscriminatorValue); } },
                {"parentSectionGroup", n => { ParentSectionGroup = n.GetObjectValue<SectionGroup>(SectionGroup.CreateFromDiscriminatorValue); } },
                {"sectionGroups", n => { SectionGroups = n.GetCollectionOfObjectValues<SectionGroup>(SectionGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sectionGroupsUrl", n => { SectionGroupsUrl = n.GetStringValue(); } },
                {"sections", n => { Sections = n.GetCollectionOfObjectValues<OnenoteSection>(OnenoteSection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sectionsUrl", n => { SectionsUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Notebook>("parentNotebook", ParentNotebook);
            writer.WriteObjectValue<SectionGroup>("parentSectionGroup", ParentSectionGroup);
            writer.WriteCollectionOfObjectValues<SectionGroup>("sectionGroups", SectionGroups);
            writer.WriteStringValue("sectionGroupsUrl", SectionGroupsUrl);
            writer.WriteCollectionOfObjectValues<OnenoteSection>("sections", Sections);
            writer.WriteStringValue("sectionsUrl", SectionsUrl);
        }
    }
}
