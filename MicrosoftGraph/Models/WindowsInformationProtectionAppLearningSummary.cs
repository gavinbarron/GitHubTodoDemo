using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>
    /// Windows Information Protection AppLearning Summary entity.
    /// </summary>
    public class WindowsInformationProtectionAppLearningSummary : Entity, IParsable {
        /// <summary>Application Name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApplicationName { get; set; }
#nullable restore
#else
        public string ApplicationName { get; set; }
#endif
        /// <summary>Possible types of Application</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.ApplicationType? ApplicationType { get; set; }
        /// <summary>Device Count</summary>
        public int? DeviceCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsInformationProtectionAppLearningSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsInformationProtectionAppLearningSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicationName", n => { ApplicationName = n.GetStringValue(); } },
                {"applicationType", n => { ApplicationType = n.GetEnumValue<ApplicationType>(); } },
                {"deviceCount", n => { DeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("applicationName", ApplicationName);
            writer.WriteEnumValue<ApplicationType>("applicationType", ApplicationType);
            writer.WriteIntValue("deviceCount", DeviceCount);
        }
    }
}
