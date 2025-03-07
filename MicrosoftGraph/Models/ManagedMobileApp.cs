using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>
    /// The identifier for the deployment an app.
    /// </summary>
    public class ManagedMobileApp : Entity, IParsable {
        /// <summary>The identifier for an app with it&apos;s operating system type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.MobileAppIdentifier? MobileAppIdentifier { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.MobileAppIdentifier MobileAppIdentifier { get; set; }
#endif
        /// <summary>Version of the entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version { get; set; }
#nullable restore
#else
        public string Version { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagedMobileApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedMobileApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"mobileAppIdentifier", n => { MobileAppIdentifier = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.MobileAppIdentifier>(GitHubTodoDemo.MicrosoftGraph.Models.MobileAppIdentifier.CreateFromDiscriminatorValue); } },
                {"version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.MobileAppIdentifier>("mobileAppIdentifier", MobileAppIdentifier);
            writer.WriteStringValue("version", Version);
        }
    }
}
