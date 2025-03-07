using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class UserSimulationEventInfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Browser information from where the simulation event was initiated by a user in an attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Browser { get; set; }
#nullable restore
#else
        public string Browser { get; set; }
#endif
        /// <summary>Date and time of the simulation event by a user in an attack simulation and training campaign.</summary>
        public DateTimeOffset? EventDateTime { get; set; }
        /// <summary>Name of the simulation event by a user in an attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventName { get; set; }
#nullable restore
#else
        public string EventName { get; set; }
#endif
        /// <summary>IP address from where the simulation event was initiated by a user in an attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IpAddress { get; set; }
#nullable restore
#else
        public string IpAddress { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The operating system, platform, and device details from where the simulation event was initiated by a user in an attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsPlatformDeviceDetails { get; set; }
#nullable restore
#else
        public string OsPlatformDeviceDetails { get; set; }
#endif
        /// <summary>
        /// Instantiates a new userSimulationEventInfo and sets the default values.
        /// </summary>
        public UserSimulationEventInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserSimulationEventInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserSimulationEventInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"browser", n => { Browser = n.GetStringValue(); } },
                {"eventDateTime", n => { EventDateTime = n.GetDateTimeOffsetValue(); } },
                {"eventName", n => { EventName = n.GetStringValue(); } },
                {"ipAddress", n => { IpAddress = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"osPlatformDeviceDetails", n => { OsPlatformDeviceDetails = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("browser", Browser);
            writer.WriteDateTimeOffsetValue("eventDateTime", EventDateTime);
            writer.WriteStringValue("eventName", EventName);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("osPlatformDeviceDetails", OsPlatformDeviceDetails);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
