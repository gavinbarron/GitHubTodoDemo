using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class ManagedApp : MobileApp, IParsable {
        /// <summary>A managed (MAM) application&apos;s availability.</summary>
        public ManagedAppAvailability? AppAvailability { get; set; }
        /// <summary>The Application&apos;s version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version { get; set; }
#nullable restore
#else
        public string Version { get; set; }
#endif
        /// <summary>
        /// Instantiates a new ManagedApp and sets the default values.
        /// </summary>
        public ManagedApp() : base() {
            OdataType = "#microsoft.graph.managedApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagedApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.managedAndroidLobApp" => new ManagedAndroidLobApp(),
                "#microsoft.graph.managedAndroidStoreApp" => new ManagedAndroidStoreApp(),
                "#microsoft.graph.managedIOSLobApp" => new ManagedIOSLobApp(),
                "#microsoft.graph.managedIOSStoreApp" => new ManagedIOSStoreApp(),
                "#microsoft.graph.managedMobileLobApp" => new ManagedMobileLobApp(),
                _ => new ManagedApp(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appAvailability", n => { AppAvailability = n.GetEnumValue<ManagedAppAvailability>(); } },
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
            writer.WriteEnumValue<ManagedAppAvailability>("appAvailability", AppAvailability);
            writer.WriteStringValue("version", Version);
        }
    }
}
