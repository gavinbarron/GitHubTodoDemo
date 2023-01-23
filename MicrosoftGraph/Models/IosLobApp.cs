using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class IosLobApp : MobileLobApp, IParsable {
        /// <summary>Contains properties of the possible iOS device types the mobile app can run on.</summary>
        public IosDeviceType ApplicableDeviceType { get; set; }
        /// <summary>The build number of iOS Line of Business (LoB) app.</summary>
        public string BuildNumber { get; set; }
        /// <summary>The Identity Name.</summary>
        public string BundleId { get; set; }
        /// <summary>The expiration time.</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>The value for the minimum applicable operating system.</summary>
        public IosMinimumOperatingSystem MinimumSupportedOperatingSystem { get; set; }
        /// <summary>The version number of iOS Line of Business (LoB) app.</summary>
        public string VersionNumber { get; set; }
        /// <summary>
        /// Instantiates a new IosLobApp and sets the default values.
        /// </summary>
        public IosLobApp() : base() {
            OdataType = "#microsoft.graph.iosLobApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IosLobApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosLobApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicableDeviceType", n => { ApplicableDeviceType = n.GetObjectValue<IosDeviceType>(IosDeviceType.CreateFromDiscriminatorValue); } },
                {"buildNumber", n => { BuildNumber = n.GetStringValue(); } },
                {"bundleId", n => { BundleId = n.GetStringValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"minimumSupportedOperatingSystem", n => { MinimumSupportedOperatingSystem = n.GetObjectValue<IosMinimumOperatingSystem>(IosMinimumOperatingSystem.CreateFromDiscriminatorValue); } },
                {"versionNumber", n => { VersionNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<IosDeviceType>("applicableDeviceType", ApplicableDeviceType);
            writer.WriteStringValue("buildNumber", BuildNumber);
            writer.WriteStringValue("bundleId", BundleId);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteObjectValue<IosMinimumOperatingSystem>("minimumSupportedOperatingSystem", MinimumSupportedOperatingSystem);
            writer.WriteStringValue("versionNumber", VersionNumber);
        }
    }
}
