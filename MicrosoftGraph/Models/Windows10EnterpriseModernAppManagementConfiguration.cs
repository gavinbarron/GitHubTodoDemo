using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class Windows10EnterpriseModernAppManagementConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Indicates whether or not to uninstall a fixed list of built-in Windows apps.</summary>
        public bool? UninstallBuiltInApps { get; set; }
        /// <summary>
        /// Instantiates a new Windows10EnterpriseModernAppManagementConfiguration and sets the default values.
        /// </summary>
        public Windows10EnterpriseModernAppManagementConfiguration() : base() {
            OdataType = "#microsoft.graph.windows10EnterpriseModernAppManagementConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Windows10EnterpriseModernAppManagementConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10EnterpriseModernAppManagementConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"uninstallBuiltInApps", n => { UninstallBuiltInApps = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("uninstallBuiltInApps", UninstallBuiltInApps);
        }
    }
}
