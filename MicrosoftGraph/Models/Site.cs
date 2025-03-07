using GitHubTodoDemo.MicrosoftGraph.Models.TermStore;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class Site : BaseItem, IParsable {
        /// <summary>Analytics about the view activities that took place in this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemAnalytics? Analytics { get; set; }
#nullable restore
#else
        public ItemAnalytics Analytics { get; set; }
#endif
        /// <summary>The collection of column definitions reusable across lists under this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ColumnDefinition>? Columns { get; set; }
#nullable restore
#else
        public List<ColumnDefinition> Columns { get; set; }
#endif
        /// <summary>The collection of content types defined for this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ContentType>? ContentTypes { get; set; }
#nullable restore
#else
        public List<ContentType> ContentTypes { get; set; }
#endif
        /// <summary>The full title for the site. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The default drive (document library) for this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.Drive? Drive { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.Drive Drive { get; set; }
#endif
        /// <summary>The collection of drives (document libraries) under this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GitHubTodoDemo.MicrosoftGraph.Models.Drive>? Drives { get; set; }
#nullable restore
#else
        public List<GitHubTodoDemo.MicrosoftGraph.Models.Drive> Drives { get; set; }
#endif
        /// <summary>The error property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PublicError? Error { get; set; }
#nullable restore
#else
        public PublicError Error { get; set; }
#endif
        /// <summary>The externalColumns property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ColumnDefinition>? ExternalColumns { get; set; }
#nullable restore
#else
        public List<ColumnDefinition> ExternalColumns { get; set; }
#endif
        /// <summary>Used to address any item contained in this site. This collection can&apos;t be enumerated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BaseItem>? Items { get; set; }
#nullable restore
#else
        public List<BaseItem> Items { get; set; }
#endif
        /// <summary>The collection of lists under this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<List>? Lists { get; set; }
#nullable restore
#else
        public List<List> Lists { get; set; }
#endif
        /// <summary>Calls the OneNote service for notebook related operations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.Onenote? Onenote { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.Onenote Onenote { get; set; }
#endif
        /// <summary>The collection of long-running operations on the site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RichLongRunningOperation>? Operations { get; set; }
#nullable restore
#else
        public List<RichLongRunningOperation> Operations { get; set; }
#endif
        /// <summary>The permissions associated with the site. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Permission>? Permissions { get; set; }
#nullable restore
#else
        public List<Permission> Permissions { get; set; }
#endif
        /// <summary>If present, indicates that this is the root site in the site collection. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.Root? Root { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.Root Root { get; set; }
#endif
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.SharepointIds? SharepointIds { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.SharepointIds SharepointIds { get; set; }
#endif
        /// <summary>Provides details about the site&apos;s site collection. Available only on the root site. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.SiteCollection? SiteCollection { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.SiteCollection SiteCollection { get; set; }
#endif
        /// <summary>The collection of the sub-sites under this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Site>? Sites { get; set; }
#nullable restore
#else
        public List<Site> Sites { get; set; }
#endif
        /// <summary>The default termStore under this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Store? TermStore { get; set; }
#nullable restore
#else
        public Store TermStore { get; set; }
#endif
        /// <summary>The collection of termStores under this site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Store>? TermStores { get; set; }
#nullable restore
#else
        public List<Store> TermStores { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Site and sets the default values.
        /// </summary>
        public Site() : base() {
            OdataType = "#microsoft.graph.site";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Site CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Site();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"analytics", n => { Analytics = n.GetObjectValue<ItemAnalytics>(ItemAnalytics.CreateFromDiscriminatorValue); } },
                {"columns", n => { Columns = n.GetCollectionOfObjectValues<ColumnDefinition>(ColumnDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"contentTypes", n => { ContentTypes = n.GetCollectionOfObjectValues<ContentType>(ContentType.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"drive", n => { Drive = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Drive>(GitHubTodoDemo.MicrosoftGraph.Models.Drive.CreateFromDiscriminatorValue); } },
                {"drives", n => { Drives = n.GetCollectionOfObjectValues<GitHubTodoDemo.MicrosoftGraph.Models.Drive>(GitHubTodoDemo.MicrosoftGraph.Models.Drive.CreateFromDiscriminatorValue)?.ToList(); } },
                {"error", n => { Error = n.GetObjectValue<PublicError>(PublicError.CreateFromDiscriminatorValue); } },
                {"externalColumns", n => { ExternalColumns = n.GetCollectionOfObjectValues<ColumnDefinition>(ColumnDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"items", n => { Items = n.GetCollectionOfObjectValues<BaseItem>(BaseItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"lists", n => { Lists = n.GetCollectionOfObjectValues<List>(List.CreateFromDiscriminatorValue)?.ToList(); } },
                {"onenote", n => { Onenote = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Onenote>(GitHubTodoDemo.MicrosoftGraph.Models.Onenote.CreateFromDiscriminatorValue); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<RichLongRunningOperation>(RichLongRunningOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"permissions", n => { Permissions = n.GetCollectionOfObjectValues<Permission>(Permission.CreateFromDiscriminatorValue)?.ToList(); } },
                {"root", n => { Root = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Root>(GitHubTodoDemo.MicrosoftGraph.Models.Root.CreateFromDiscriminatorValue); } },
                {"sharepointIds", n => { SharepointIds = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.SharepointIds>(GitHubTodoDemo.MicrosoftGraph.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                {"siteCollection", n => { SiteCollection = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.SiteCollection>(GitHubTodoDemo.MicrosoftGraph.Models.SiteCollection.CreateFromDiscriminatorValue); } },
                {"sites", n => { Sites = n.GetCollectionOfObjectValues<Site>(Site.CreateFromDiscriminatorValue)?.ToList(); } },
                {"termStore", n => { TermStore = n.GetObjectValue<Store>(Store.CreateFromDiscriminatorValue); } },
                {"termStores", n => { TermStores = n.GetCollectionOfObjectValues<Store>(Store.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ItemAnalytics>("analytics", Analytics);
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("columns", Columns);
            writer.WriteCollectionOfObjectValues<ContentType>("contentTypes", ContentTypes);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Drive>("drive", Drive);
            writer.WriteCollectionOfObjectValues<GitHubTodoDemo.MicrosoftGraph.Models.Drive>("drives", Drives);
            writer.WriteObjectValue<PublicError>("error", Error);
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("externalColumns", ExternalColumns);
            writer.WriteCollectionOfObjectValues<BaseItem>("items", Items);
            writer.WriteCollectionOfObjectValues<List>("lists", Lists);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Onenote>("onenote", Onenote);
            writer.WriteCollectionOfObjectValues<RichLongRunningOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<Permission>("permissions", Permissions);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Root>("root", Root);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.SiteCollection>("siteCollection", SiteCollection);
            writer.WriteCollectionOfObjectValues<Site>("sites", Sites);
            writer.WriteObjectValue<Store>("termStore", TermStore);
            writer.WriteCollectionOfObjectValues<Store>("termStores", TermStores);
        }
    }
}
