using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class Drive : BaseItem, IParsable {
        /// <summary>Collection of [bundles][bundle] (albums and multi-select-shared sets of items). Only in personal OneDrive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DriveItem>? Bundles { get; set; }
#nullable restore
#else
        public List<DriveItem> Bundles { get; set; }
#endif
        /// <summary>Describes the type of drive represented by this resource. OneDrive personal drives will return personal. OneDrive for Business will return business. SharePoint document libraries will return documentLibrary. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DriveType { get; set; }
#nullable restore
#else
        public string DriveType { get; set; }
#endif
        /// <summary>The list of items the user is following. Only in OneDrive for Business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DriveItem>? Following { get; set; }
#nullable restore
#else
        public List<DriveItem> Following { get; set; }
#endif
        /// <summary>All items contained in the drive. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DriveItem>? Items { get; set; }
#nullable restore
#else
        public List<DriveItem> Items { get; set; }
#endif
        /// <summary>For drives in SharePoint, the underlying document library list. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.List? List { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.List List { get; set; }
#endif
        /// <summary>Optional. The user account that owns the drive. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? Owner { get; set; }
#nullable restore
#else
        public IdentitySet Owner { get; set; }
#endif
        /// <summary>Optional. Information about the drive&apos;s storage space quota. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.Quota? Quota { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.Quota Quota { get; set; }
#endif
        /// <summary>The root folder of the drive. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DriveItem? Root { get; set; }
#nullable restore
#else
        public DriveItem Root { get; set; }
#endif
        /// <summary>The sharePointIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.SharepointIds? SharePointIds { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.SharepointIds SharePointIds { get; set; }
#endif
        /// <summary>Collection of common folders available in OneDrive. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DriveItem>? Special { get; set; }
#nullable restore
#else
        public List<DriveItem> Special { get; set; }
#endif
        /// <summary>If present, indicates that this is a system-managed drive. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SystemFacet? System { get; set; }
#nullable restore
#else
        public SystemFacet System { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Drive and sets the default values.
        /// </summary>
        public Drive() : base() {
            OdataType = "#microsoft.graph.drive";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Drive CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Drive();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"bundles", n => { Bundles = n.GetCollectionOfObjectValues<DriveItem>(DriveItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"driveType", n => { DriveType = n.GetStringValue(); } },
                {"following", n => { Following = n.GetCollectionOfObjectValues<DriveItem>(DriveItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"items", n => { Items = n.GetCollectionOfObjectValues<DriveItem>(DriveItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"list", n => { List = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.List>(GitHubTodoDemo.MicrosoftGraph.Models.List.CreateFromDiscriminatorValue); } },
                {"owner", n => { Owner = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"quota", n => { Quota = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Quota>(GitHubTodoDemo.MicrosoftGraph.Models.Quota.CreateFromDiscriminatorValue); } },
                {"root", n => { Root = n.GetObjectValue<DriveItem>(DriveItem.CreateFromDiscriminatorValue); } },
                {"sharePointIds", n => { SharePointIds = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.SharepointIds>(GitHubTodoDemo.MicrosoftGraph.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                {"special", n => { Special = n.GetCollectionOfObjectValues<DriveItem>(DriveItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"system", n => { System = n.GetObjectValue<SystemFacet>(SystemFacet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DriveItem>("bundles", Bundles);
            writer.WriteStringValue("driveType", DriveType);
            writer.WriteCollectionOfObjectValues<DriveItem>("following", Following);
            writer.WriteCollectionOfObjectValues<DriveItem>("items", Items);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.List>("list", List);
            writer.WriteObjectValue<IdentitySet>("owner", Owner);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Quota>("quota", Quota);
            writer.WriteObjectValue<DriveItem>("root", Root);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.SharepointIds>("sharePointIds", SharePointIds);
            writer.WriteCollectionOfObjectValues<DriveItem>("special", Special);
            writer.WriteObjectValue<SystemFacet>("system", System);
        }
    }
}
