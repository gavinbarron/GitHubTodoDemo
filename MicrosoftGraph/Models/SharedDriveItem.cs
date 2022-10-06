using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GithubTodoDemo.MicrosoftGraph.Models {
    public class SharedDriveItem : BaseItem, IParsable {
        /// <summary>Used to access the underlying driveItem</summary>
        public GithubTodoDemo.MicrosoftGraph.Models.DriveItem DriveItem { get; set; }
        /// <summary>All driveItems contained in the sharing root. This collection cannot be enumerated.</summary>
        public List<GithubTodoDemo.MicrosoftGraph.Models.DriveItem> Items { get; set; }
        /// <summary>Used to access the underlying list</summary>
        public GithubTodoDemo.MicrosoftGraph.Models.List List { get; set; }
        /// <summary>Used to access the underlying listItem</summary>
        public GithubTodoDemo.MicrosoftGraph.Models.ListItem ListItem { get; set; }
        /// <summary>Information about the owner of the shared item being referenced.</summary>
        public IdentitySet Owner { get; set; }
        /// <summary>Used to access the permission representing the underlying sharing link</summary>
        public GithubTodoDemo.MicrosoftGraph.Models.Permission Permission { get; set; }
        /// <summary>Used to access the underlying driveItem. Deprecated -- use driveItem instead.</summary>
        public GithubTodoDemo.MicrosoftGraph.Models.DriveItem Root { get; set; }
        /// <summary>Used to access the underlying site</summary>
        public GithubTodoDemo.MicrosoftGraph.Models.Site Site { get; set; }
        /// <summary>
        /// Instantiates a new SharedDriveItem and sets the default values.
        /// </summary>
        public SharedDriveItem() : base() {
            OdataType = "#microsoft.graph.sharedDriveItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SharedDriveItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharedDriveItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"driveItem", n => { DriveItem = n.GetObjectValue<GithubTodoDemo.MicrosoftGraph.Models.DriveItem>(GithubTodoDemo.MicrosoftGraph.Models.DriveItem.CreateFromDiscriminatorValue); } },
                {"items", n => { Items = n.GetCollectionOfObjectValues<GithubTodoDemo.MicrosoftGraph.Models.DriveItem>(GithubTodoDemo.MicrosoftGraph.Models.DriveItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"list", n => { List = n.GetObjectValue<GithubTodoDemo.MicrosoftGraph.Models.List>(GithubTodoDemo.MicrosoftGraph.Models.List.CreateFromDiscriminatorValue); } },
                {"listItem", n => { ListItem = n.GetObjectValue<GithubTodoDemo.MicrosoftGraph.Models.ListItem>(GithubTodoDemo.MicrosoftGraph.Models.ListItem.CreateFromDiscriminatorValue); } },
                {"owner", n => { Owner = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"permission", n => { Permission = n.GetObjectValue<GithubTodoDemo.MicrosoftGraph.Models.Permission>(GithubTodoDemo.MicrosoftGraph.Models.Permission.CreateFromDiscriminatorValue); } },
                {"root", n => { Root = n.GetObjectValue<GithubTodoDemo.MicrosoftGraph.Models.DriveItem>(GithubTodoDemo.MicrosoftGraph.Models.DriveItem.CreateFromDiscriminatorValue); } },
                {"site", n => { Site = n.GetObjectValue<GithubTodoDemo.MicrosoftGraph.Models.Site>(GithubTodoDemo.MicrosoftGraph.Models.Site.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<GithubTodoDemo.MicrosoftGraph.Models.DriveItem>("driveItem", DriveItem);
            writer.WriteCollectionOfObjectValues<GithubTodoDemo.MicrosoftGraph.Models.DriveItem>("items", Items);
            writer.WriteObjectValue<GithubTodoDemo.MicrosoftGraph.Models.List>("list", List);
            writer.WriteObjectValue<GithubTodoDemo.MicrosoftGraph.Models.ListItem>("listItem", ListItem);
            writer.WriteObjectValue<IdentitySet>("owner", Owner);
            writer.WriteObjectValue<GithubTodoDemo.MicrosoftGraph.Models.Permission>("permission", Permission);
            writer.WriteObjectValue<GithubTodoDemo.MicrosoftGraph.Models.DriveItem>("root", Root);
            writer.WriteObjectValue<GithubTodoDemo.MicrosoftGraph.Models.Site>("site", Site);
        }
    }
}
