using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class Notebook : OnenoteEntityHierarchyModel, IParsable {
        /// <summary>Indicates whether this is the user&apos;s default notebook. Read-only.</summary>
        public bool? IsDefault { get; set; }
        /// <summary>Indicates whether the notebook is shared. If true, the contents of the notebook can be seen by people other than the owner. Read-only.</summary>
        public bool? IsShared { get; set; }
        /// <summary>Links for opening the notebook. The oneNoteClientURL link opens the notebook in the OneNote native client if it&apos;s installed. The oneNoteWebURL link opens the notebook in OneNote on the web.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NotebookLinks? Links { get; set; }
#nullable restore
#else
        public NotebookLinks Links { get; set; }
#endif
        /// <summary>The section groups in the notebook. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SectionGroup>? SectionGroups { get; set; }
#nullable restore
#else
        public List<SectionGroup> SectionGroups { get; set; }
#endif
        /// <summary>The URL for the sectionGroups navigation property, which returns all the section groups in the notebook. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SectionGroupsUrl { get; set; }
#nullable restore
#else
        public string SectionGroupsUrl { get; set; }
#endif
        /// <summary>The sections in the notebook. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<OnenoteSection>? Sections { get; set; }
#nullable restore
#else
        public List<OnenoteSection> Sections { get; set; }
#endif
        /// <summary>The URL for the sections navigation property, which returns all the sections in the notebook. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SectionsUrl { get; set; }
#nullable restore
#else
        public string SectionsUrl { get; set; }
#endif
        /// <summary>Possible values are: Owner, Contributor, Reader, None. Owner represents owner-level access to the notebook. Contributor represents read/write access to the notebook. Reader represents read-only access to the notebook. Read-only.</summary>
        public OnenoteUserRole? UserRole { get; set; }
        /// <summary>
        /// Instantiates a new Notebook and sets the default values.
        /// </summary>
        public Notebook() : base() {
            OdataType = "#microsoft.graph.notebook";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Notebook CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Notebook();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"isDefault", n => { IsDefault = n.GetBoolValue(); } },
                {"isShared", n => { IsShared = n.GetBoolValue(); } },
                {"links", n => { Links = n.GetObjectValue<NotebookLinks>(NotebookLinks.CreateFromDiscriminatorValue); } },
                {"sectionGroups", n => { SectionGroups = n.GetCollectionOfObjectValues<SectionGroup>(SectionGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sectionGroupsUrl", n => { SectionGroupsUrl = n.GetStringValue(); } },
                {"sections", n => { Sections = n.GetCollectionOfObjectValues<OnenoteSection>(OnenoteSection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sectionsUrl", n => { SectionsUrl = n.GetStringValue(); } },
                {"userRole", n => { UserRole = n.GetEnumValue<OnenoteUserRole>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteBoolValue("isShared", IsShared);
            writer.WriteObjectValue<NotebookLinks>("links", Links);
            writer.WriteCollectionOfObjectValues<SectionGroup>("sectionGroups", SectionGroups);
            writer.WriteStringValue("sectionGroupsUrl", SectionGroupsUrl);
            writer.WriteCollectionOfObjectValues<OnenoteSection>("sections", Sections);
            writer.WriteStringValue("sectionsUrl", SectionsUrl);
            writer.WriteEnumValue<OnenoteUserRole>("userRole", UserRole);
        }
    }
}
