using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models.CallRecords {
    public class Media : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Device information associated with the callee endpoint of this media.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceInfo? CalleeDevice { get; set; }
#nullable restore
#else
        public DeviceInfo CalleeDevice { get; set; }
#endif
        /// <summary>Network information associated with the callee endpoint of this media.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NetworkInfo? CalleeNetwork { get; set; }
#nullable restore
#else
        public NetworkInfo CalleeNetwork { get; set; }
#endif
        /// <summary>Device information associated with the caller endpoint of this media.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceInfo? CallerDevice { get; set; }
#nullable restore
#else
        public DeviceInfo CallerDevice { get; set; }
#endif
        /// <summary>Network information associated with the caller endpoint of this media.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public NetworkInfo? CallerNetwork { get; set; }
#nullable restore
#else
        public NetworkInfo CallerNetwork { get; set; }
#endif
        /// <summary>How the media was identified during media negotiation stage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Label { get; set; }
#nullable restore
#else
        public string Label { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Network streams associated with this media.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MediaStream>? Streams { get; set; }
#nullable restore
#else
        public List<MediaStream> Streams { get; set; }
#endif
        /// <summary>
        /// Instantiates a new media and sets the default values.
        /// </summary>
        public Media() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Media CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Media();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"calleeDevice", n => { CalleeDevice = n.GetObjectValue<DeviceInfo>(DeviceInfo.CreateFromDiscriminatorValue); } },
                {"calleeNetwork", n => { CalleeNetwork = n.GetObjectValue<NetworkInfo>(NetworkInfo.CreateFromDiscriminatorValue); } },
                {"callerDevice", n => { CallerDevice = n.GetObjectValue<DeviceInfo>(DeviceInfo.CreateFromDiscriminatorValue); } },
                {"callerNetwork", n => { CallerNetwork = n.GetObjectValue<NetworkInfo>(NetworkInfo.CreateFromDiscriminatorValue); } },
                {"label", n => { Label = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"streams", n => { Streams = n.GetCollectionOfObjectValues<MediaStream>(MediaStream.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DeviceInfo>("calleeDevice", CalleeDevice);
            writer.WriteObjectValue<NetworkInfo>("calleeNetwork", CalleeNetwork);
            writer.WriteObjectValue<DeviceInfo>("callerDevice", CallerDevice);
            writer.WriteObjectValue<NetworkInfo>("callerNetwork", CallerNetwork);
            writer.WriteStringValue("label", Label);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<MediaStream>("streams", Streams);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
