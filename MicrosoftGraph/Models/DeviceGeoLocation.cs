using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>
    /// Device location
    /// </summary>
    public class DeviceGeoLocation : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Altitude, given in meters above sea level</summary>
        public double? Altitude { get; set; }
        /// <summary>Heading in degrees from true north</summary>
        public double? Heading { get; set; }
        /// <summary>Accuracy of longitude and latitude in meters</summary>
        public double? HorizontalAccuracy { get; set; }
        /// <summary>Time at which location was recorded, relative to UTC</summary>
        public DateTimeOffset? LastCollectedDateTime { get; set; }
        /// <summary>Latitude coordinate of the device&apos;s location</summary>
        public double? Latitude { get; set; }
        /// <summary>Longitude coordinate of the device&apos;s location</summary>
        public double? Longitude { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Speed the device is traveling in meters per second</summary>
        public double? Speed { get; set; }
        /// <summary>Accuracy of altitude in meters</summary>
        public double? VerticalAccuracy { get; set; }
        /// <summary>
        /// Instantiates a new deviceGeoLocation and sets the default values.
        /// </summary>
        public DeviceGeoLocation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceGeoLocation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceGeoLocation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"altitude", n => { Altitude = n.GetDoubleValue(); } },
                {"heading", n => { Heading = n.GetDoubleValue(); } },
                {"horizontalAccuracy", n => { HorizontalAccuracy = n.GetDoubleValue(); } },
                {"lastCollectedDateTime", n => { LastCollectedDateTime = n.GetDateTimeOffsetValue(); } },
                {"latitude", n => { Latitude = n.GetDoubleValue(); } },
                {"longitude", n => { Longitude = n.GetDoubleValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"speed", n => { Speed = n.GetDoubleValue(); } },
                {"verticalAccuracy", n => { VerticalAccuracy = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDoubleValue("altitude", Altitude);
            writer.WriteDoubleValue("heading", Heading);
            writer.WriteDoubleValue("horizontalAccuracy", HorizontalAccuracy);
            writer.WriteDateTimeOffsetValue("lastCollectedDateTime", LastCollectedDateTime);
            writer.WriteDoubleValue("latitude", Latitude);
            writer.WriteDoubleValue("longitude", Longitude);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDoubleValue("speed", Speed);
            writer.WriteDoubleValue("verticalAccuracy", VerticalAccuracy);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
