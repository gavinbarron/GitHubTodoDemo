using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class TeamMemberSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If set to true, members can add and remove apps.</summary>
        public bool? AllowAddRemoveApps { get; set; }
        /// <summary>If set to true, members can add and update private channels.</summary>
        public bool? AllowCreatePrivateChannels { get; set; }
        /// <summary>If set to true, members can add and update channels.</summary>
        public bool? AllowCreateUpdateChannels { get; set; }
        /// <summary>If set to true, members can add, update, and remove connectors.</summary>
        public bool? AllowCreateUpdateRemoveConnectors { get; set; }
        /// <summary>If set to true, members can add, update, and remove tabs.</summary>
        public bool? AllowCreateUpdateRemoveTabs { get; set; }
        /// <summary>If set to true, members can delete channels.</summary>
        public bool? AllowDeleteChannels { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new teamMemberSettings and sets the default values.
        /// </summary>
        public TeamMemberSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamMemberSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamMemberSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowAddRemoveApps", n => { AllowAddRemoveApps = n.GetBoolValue(); } },
                {"allowCreatePrivateChannels", n => { AllowCreatePrivateChannels = n.GetBoolValue(); } },
                {"allowCreateUpdateChannels", n => { AllowCreateUpdateChannels = n.GetBoolValue(); } },
                {"allowCreateUpdateRemoveConnectors", n => { AllowCreateUpdateRemoveConnectors = n.GetBoolValue(); } },
                {"allowCreateUpdateRemoveTabs", n => { AllowCreateUpdateRemoveTabs = n.GetBoolValue(); } },
                {"allowDeleteChannels", n => { AllowDeleteChannels = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowAddRemoveApps", AllowAddRemoveApps);
            writer.WriteBoolValue("allowCreatePrivateChannels", AllowCreatePrivateChannels);
            writer.WriteBoolValue("allowCreateUpdateChannels", AllowCreateUpdateChannels);
            writer.WriteBoolValue("allowCreateUpdateRemoveConnectors", AllowCreateUpdateRemoveConnectors);
            writer.WriteBoolValue("allowCreateUpdateRemoveTabs", AllowCreateUpdateRemoveTabs);
            writer.WriteBoolValue("allowDeleteChannels", AllowDeleteChannels);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
