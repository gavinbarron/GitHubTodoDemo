using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>
    /// Contains installation experience properties for a Win32 App
    /// </summary>
    public class Win32LobAppInstallExperience : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates the type of restart action.</summary>
        public Win32LobAppRestartBehavior? DeviceRestartBehavior { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Indicates the type of execution context the app runs in.</summary>
        public RunAsAccountType? RunAsAccount { get; set; }
        /// <summary>
        /// Instantiates a new win32LobAppInstallExperience and sets the default values.
        /// </summary>
        public Win32LobAppInstallExperience() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Win32LobAppInstallExperience CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Win32LobAppInstallExperience();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deviceRestartBehavior", n => { DeviceRestartBehavior = n.GetEnumValue<Win32LobAppRestartBehavior>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"runAsAccount", n => { RunAsAccount = n.GetEnumValue<RunAsAccountType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Win32LobAppRestartBehavior>("deviceRestartBehavior", DeviceRestartBehavior);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<RunAsAccountType>("runAsAccount", RunAsAccount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
