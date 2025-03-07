using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class UserActivity : Entity, IParsable {
        /// <summary>Required. URL used to launch the activity in the best native experience represented by the appId. Might launch a web-based app if no native app exists.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActivationUrl { get; set; }
#nullable restore
#else
        public string ActivationUrl { get; set; }
#endif
        /// <summary>Required. URL for the domain representing the cross-platform identity mapping for the app. Mapping is stored either as a JSON file hosted on the domain or configurable via Windows Dev Center. The JSON file is named cross-platform-app-identifiers and is hosted at root of your HTTPS domain, either at the top level domain or include a sub domain. For example: https://contoso.com or https://myapp.contoso.com but NOT https://myapp.contoso.com/somepath. You must have a unique file and domain (or sub domain) per cross-platform app identity. For example, a separate file and domain is needed for Word vs. PowerPoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActivitySourceHost { get; set; }
#nullable restore
#else
        public string ActivitySourceHost { get; set; }
#endif
        /// <summary>Required. The unique activity ID in the context of the app - supplied by caller and immutable thereafter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppActivityId { get; set; }
#nullable restore
#else
        public string AppActivityId { get; set; }
#endif
        /// <summary>Optional. Short text description of the app used to generate the activity for use in cases when the app is not installed on the user’s local device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppDisplayName { get; set; }
#nullable restore
#else
        public string AppDisplayName { get; set; }
#endif
        /// <summary>Optional. A custom piece of data - JSON-LD extensible description of content according to schema.org syntax.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? ContentInfo { get; set; }
#nullable restore
#else
        public Json ContentInfo { get; set; }
#endif
        /// <summary>Optional. Used in the event the content can be rendered outside of a native or web-based app experience (for example, a pointer to an item in an RSS feed).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentUrl { get; set; }
#nullable restore
#else
        public string ContentUrl { get; set; }
#endif
        /// <summary>Set by the server. DateTime in UTC when the object was created on the server.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Set by the server. DateTime in UTC when the object expired on the server.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>Optional. URL used to launch the activity in a web-based app, if available.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FallbackUrl { get; set; }
#nullable restore
#else
        public string FallbackUrl { get; set; }
#endif
        /// <summary>Optional. NavigationProperty/Containment; navigation property to the activity&apos;s historyItems.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ActivityHistoryItem>? HistoryItems { get; set; }
#nullable restore
#else
        public List<ActivityHistoryItem> HistoryItems { get; set; }
#endif
        /// <summary>Set by the server. DateTime in UTC when the object was modified on the server.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Set by the server. A status code used to identify valid objects. Values: active, updated, deleted, ignored.</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.Status? Status { get; set; }
        /// <summary>Optional. The timezone in which the user&apos;s device used to generate the activity was located at activity creation time; values supplied as Olson IDs in order to support cross-platform representation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserTimezone { get; set; }
#nullable restore
#else
        public string UserTimezone { get; set; }
#endif
        /// <summary>The visualElements property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public VisualInfo? VisualElements { get; set; }
#nullable restore
#else
        public VisualInfo VisualElements { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserActivity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserActivity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activationUrl", n => { ActivationUrl = n.GetStringValue(); } },
                {"activitySourceHost", n => { ActivitySourceHost = n.GetStringValue(); } },
                {"appActivityId", n => { AppActivityId = n.GetStringValue(); } },
                {"appDisplayName", n => { AppDisplayName = n.GetStringValue(); } },
                {"contentInfo", n => { ContentInfo = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"contentUrl", n => { ContentUrl = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"fallbackUrl", n => { FallbackUrl = n.GetStringValue(); } },
                {"historyItems", n => { HistoryItems = n.GetCollectionOfObjectValues<ActivityHistoryItem>(ActivityHistoryItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetEnumValue<Status>(); } },
                {"userTimezone", n => { UserTimezone = n.GetStringValue(); } },
                {"visualElements", n => { VisualElements = n.GetObjectValue<VisualInfo>(VisualInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("activationUrl", ActivationUrl);
            writer.WriteStringValue("activitySourceHost", ActivitySourceHost);
            writer.WriteStringValue("appActivityId", AppActivityId);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteObjectValue<Json>("contentInfo", ContentInfo);
            writer.WriteStringValue("contentUrl", ContentUrl);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("fallbackUrl", FallbackUrl);
            writer.WriteCollectionOfObjectValues<ActivityHistoryItem>("historyItems", HistoryItems);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteEnumValue<Status>("status", Status);
            writer.WriteStringValue("userTimezone", UserTimezone);
            writer.WriteObjectValue<VisualInfo>("visualElements", VisualElements);
        }
    }
}
