using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class AppConsentRequest : Entity, IParsable {
        /// <summary>The display name of the app for which consent is requested. Required. Supports $filter (eq only) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppDisplayName { get; set; }
#nullable restore
#else
        public string AppDisplayName { get; set; }
#endif
        /// <summary>The identifier of the application. Required. Supports $filter (eq only) and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId { get; set; }
#nullable restore
#else
        public string AppId { get; set; }
#endif
        /// <summary>A list of pending scopes waiting for approval. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AppConsentRequestScope>? PendingScopes { get; set; }
#nullable restore
#else
        public List<AppConsentRequestScope> PendingScopes { get; set; }
#endif
        /// <summary>A list of pending user consent requests. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserConsentRequest>? UserConsentRequests { get; set; }
#nullable restore
#else
        public List<UserConsentRequest> UserConsentRequests { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AppConsentRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AppConsentRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appDisplayName", n => { AppDisplayName = n.GetStringValue(); } },
                {"appId", n => { AppId = n.GetStringValue(); } },
                {"pendingScopes", n => { PendingScopes = n.GetCollectionOfObjectValues<AppConsentRequestScope>(AppConsentRequestScope.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userConsentRequests", n => { UserConsentRequests = n.GetCollectionOfObjectValues<UserConsentRequest>(UserConsentRequest.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("appId", AppId);
            writer.WriteCollectionOfObjectValues<AppConsentRequestScope>("pendingScopes", PendingScopes);
            writer.WriteCollectionOfObjectValues<UserConsentRequest>("userConsentRequests", UserConsentRequests);
        }
    }
}
