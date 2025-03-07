using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class PrinterLocation : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The altitude, in meters, that the printer is located at.</summary>
        public int? AltitudeInMeters { get; set; }
        /// <summary>The building that the printer is located in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Building { get; set; }
#nullable restore
#else
        public string Building { get; set; }
#endif
        /// <summary>The city that the printer is located in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? City { get; set; }
#nullable restore
#else
        public string City { get; set; }
#endif
        /// <summary>The country or region that the printer is located in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryOrRegion { get; set; }
#nullable restore
#else
        public string CountryOrRegion { get; set; }
#endif
        /// <summary>The floor that the printer is located on. Only numerical values are supported right now.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Floor { get; set; }
#nullable restore
#else
        public string Floor { get; set; }
#endif
        /// <summary>The description of the floor that the printer is located on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FloorDescription { get; set; }
#nullable restore
#else
        public string FloorDescription { get; set; }
#endif
        /// <summary>The latitude that the printer is located at.</summary>
        public double? Latitude { get; set; }
        /// <summary>The longitude that the printer is located at.</summary>
        public double? Longitude { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The organizational hierarchy that the printer belongs to. The elements should be in hierarchical order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Organization { get; set; }
#nullable restore
#else
        public List<string> Organization { get; set; }
#endif
        /// <summary>The postal code that the printer is located in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PostalCode { get; set; }
#nullable restore
#else
        public string PostalCode { get; set; }
#endif
        /// <summary>The description of the room that the printer is located in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoomDescription { get; set; }
#nullable restore
#else
        public string RoomDescription { get; set; }
#endif
        /// <summary>The room that the printer is located in. Only numerical values are supported right now.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoomName { get; set; }
#nullable restore
#else
        public string RoomName { get; set; }
#endif
        /// <summary>The site that the printer is located in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Site { get; set; }
#nullable restore
#else
        public string Site { get; set; }
#endif
        /// <summary>The state or province that the printer is located in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StateOrProvince { get; set; }
#nullable restore
#else
        public string StateOrProvince { get; set; }
#endif
        /// <summary>The street address where the printer is located.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StreetAddress { get; set; }
#nullable restore
#else
        public string StreetAddress { get; set; }
#endif
        /// <summary>The subdivision that the printer is located in. The elements should be in hierarchical order.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Subdivision { get; set; }
#nullable restore
#else
        public List<string> Subdivision { get; set; }
#endif
        /// <summary>The subunit property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Subunit { get; set; }
#nullable restore
#else
        public List<string> Subunit { get; set; }
#endif
        /// <summary>
        /// Instantiates a new printerLocation and sets the default values.
        /// </summary>
        public PrinterLocation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PrinterLocation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrinterLocation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"altitudeInMeters", n => { AltitudeInMeters = n.GetIntValue(); } },
                {"building", n => { Building = n.GetStringValue(); } },
                {"city", n => { City = n.GetStringValue(); } },
                {"countryOrRegion", n => { CountryOrRegion = n.GetStringValue(); } },
                {"floor", n => { Floor = n.GetStringValue(); } },
                {"floorDescription", n => { FloorDescription = n.GetStringValue(); } },
                {"latitude", n => { Latitude = n.GetDoubleValue(); } },
                {"longitude", n => { Longitude = n.GetDoubleValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"organization", n => { Organization = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"postalCode", n => { PostalCode = n.GetStringValue(); } },
                {"roomDescription", n => { RoomDescription = n.GetStringValue(); } },
                {"roomName", n => { RoomName = n.GetStringValue(); } },
                {"site", n => { Site = n.GetStringValue(); } },
                {"stateOrProvince", n => { StateOrProvince = n.GetStringValue(); } },
                {"streetAddress", n => { StreetAddress = n.GetStringValue(); } },
                {"subdivision", n => { Subdivision = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"subunit", n => { Subunit = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("altitudeInMeters", AltitudeInMeters);
            writer.WriteStringValue("building", Building);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("countryOrRegion", CountryOrRegion);
            writer.WriteStringValue("floor", Floor);
            writer.WriteStringValue("floorDescription", FloorDescription);
            writer.WriteDoubleValue("latitude", Latitude);
            writer.WriteDoubleValue("longitude", Longitude);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfPrimitiveValues<string>("organization", Organization);
            writer.WriteStringValue("postalCode", PostalCode);
            writer.WriteStringValue("roomDescription", RoomDescription);
            writer.WriteStringValue("roomName", RoomName);
            writer.WriteStringValue("site", Site);
            writer.WriteStringValue("stateOrProvince", StateOrProvince);
            writer.WriteStringValue("streetAddress", StreetAddress);
            writer.WriteCollectionOfPrimitiveValues<string>("subdivision", Subdivision);
            writer.WriteCollectionOfPrimitiveValues<string>("subunit", Subunit);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
