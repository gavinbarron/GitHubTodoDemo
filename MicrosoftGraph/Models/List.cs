using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class List : BaseItem, IParsable {
        /// <summary>The collection of field definitions for this list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ColumnDefinition>? Columns { get; set; }
#nullable restore
#else
        public List<ColumnDefinition> Columns { get; set; }
#endif
        /// <summary>The collection of content types present in this list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ContentType>? ContentTypes { get; set; }
#nullable restore
#else
        public List<ContentType> ContentTypes { get; set; }
#endif
        /// <summary>The displayable title of the list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Only present on document libraries. Allows access to the list as a [drive][] resource with [driveItems][driveItem].</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.Drive? Drive { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.Drive Drive { get; set; }
#endif
        /// <summary>All items contained in the list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ListItem>? Items { get; set; }
#nullable restore
#else
        public List<ListItem> Items { get; set; }
#endif
        /// <summary>Provides additional details about the list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ListInfo? List_prop { get; set; }
#nullable restore
#else
        public ListInfo List_prop { get; set; }
#endif
        /// <summary>The collection of long-running operations on the list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RichLongRunningOperation>? Operations { get; set; }
#nullable restore
#else
        public List<RichLongRunningOperation> Operations { get; set; }
#endif
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.SharepointIds? SharepointIds { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.SharepointIds SharepointIds { get; set; }
#endif
        /// <summary>The set of subscriptions on the list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Subscription>? Subscriptions { get; set; }
#nullable restore
#else
        public List<Subscription> Subscriptions { get; set; }
#endif
        /// <summary>If present, indicates that this is a system-managed list. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SystemFacet? System { get; set; }
#nullable restore
#else
        public SystemFacet System { get; set; }
#endif
        /// <summary>
        /// Instantiates a new list and sets the default values.
        /// </summary>
        public List() : base() {
            OdataType = "#microsoft.graph.list";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new List CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new List();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"columns", n => { Columns = n.GetCollectionOfObjectValues<ColumnDefinition>(ColumnDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"contentTypes", n => { ContentTypes = n.GetCollectionOfObjectValues<ContentType>(ContentType.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"drive", n => { Drive = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Drive>(GitHubTodoDemo.MicrosoftGraph.Models.Drive.CreateFromDiscriminatorValue); } },
                {"items", n => { Items = n.GetCollectionOfObjectValues<ListItem>(ListItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"list", n => { List_prop = n.GetObjectValue<ListInfo>(ListInfo.CreateFromDiscriminatorValue); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<RichLongRunningOperation>(RichLongRunningOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"sharepointIds", n => { SharepointIds = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.SharepointIds>(GitHubTodoDemo.MicrosoftGraph.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                {"subscriptions", n => { Subscriptions = n.GetCollectionOfObjectValues<Subscription>(Subscription.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("columns", Columns);
            writer.WriteCollectionOfObjectValues<ContentType>("contentTypes", ContentTypes);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Drive>("drive", Drive);
            writer.WriteCollectionOfObjectValues<ListItem>("items", Items);
            writer.WriteObjectValue<ListInfo>("list", List_prop);
            writer.WriteCollectionOfObjectValues<RichLongRunningOperation>("operations", Operations);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteCollectionOfObjectValues<Subscription>("subscriptions", Subscriptions);
            writer.WriteObjectValue<SystemFacet>("system", System);
        }
    }
}
