using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class ProvisionedIdentity : Identity, IParsable {
        /// <summary>Details of the identity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DetailsInfo? Details { get; set; }
#nullable restore
#else
        public DetailsInfo Details { get; set; }
#endif
        /// <summary>Type of identity that has been provisioned, such as &apos;user&apos; or &apos;group&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IdentityType { get; set; }
#nullable restore
#else
        public string IdentityType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new ProvisionedIdentity and sets the default values.
        /// </summary>
        public ProvisionedIdentity() : base() {
            OdataType = "#microsoft.graph.provisionedIdentity";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ProvisionedIdentity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProvisionedIdentity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"details", n => { Details = n.GetObjectValue<DetailsInfo>(DetailsInfo.CreateFromDiscriminatorValue); } },
                {"identityType", n => { IdentityType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<DetailsInfo>("details", Details);
            writer.WriteStringValue("identityType", IdentityType);
        }
    }
}
