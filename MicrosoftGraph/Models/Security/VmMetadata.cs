using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models.Security {
    public class VmMetadata : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The cloudProvider property</summary>
        public VmCloudProvider? CloudProvider { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Unique identifier of the Azure resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceId { get; set; }
#nullable restore
#else
        public string ResourceId { get; set; }
#endif
        /// <summary>Unique identifier of the Azure subscription the customer tenant belongs to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubscriptionId { get; set; }
#nullable restore
#else
        public string SubscriptionId { get; set; }
#endif
        /// <summary>Unique identifier of the virtual machine instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VmId { get; set; }
#nullable restore
#else
        public string VmId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new vmMetadata and sets the default values.
        /// </summary>
        public VmMetadata() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static VmMetadata CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VmMetadata();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"cloudProvider", n => { CloudProvider = n.GetEnumValue<VmCloudProvider>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"resourceId", n => { ResourceId = n.GetStringValue(); } },
                {"subscriptionId", n => { SubscriptionId = n.GetStringValue(); } },
                {"vmId", n => { VmId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<VmCloudProvider>("cloudProvider", CloudProvider);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteStringValue("subscriptionId", SubscriptionId);
            writer.WriteStringValue("vmId", VmId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
