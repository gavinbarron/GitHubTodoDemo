using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>
    /// A class containing the properties used for Group Assignment of a Mobile App.
    /// </summary>
    public class MobileAppAssignment : Entity, IParsable {
        /// <summary>Possible values for the install intent chosen by the admin.</summary>
        public InstallIntent? Intent { get; set; }
        /// <summary>The settings for target assignment defined by the admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MobileAppAssignmentSettings? Settings { get; set; }
#nullable restore
#else
        public MobileAppAssignmentSettings Settings { get; set; }
#endif
        /// <summary>The target group assignment defined by the admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceAndAppManagementAssignmentTarget? Target { get; set; }
#nullable restore
#else
        public DeviceAndAppManagementAssignmentTarget Target { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MobileAppAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileAppAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"intent", n => { Intent = n.GetEnumValue<InstallIntent>(); } },
                {"settings", n => { Settings = n.GetObjectValue<MobileAppAssignmentSettings>(MobileAppAssignmentSettings.CreateFromDiscriminatorValue); } },
                {"target", n => { Target = n.GetObjectValue<DeviceAndAppManagementAssignmentTarget>(DeviceAndAppManagementAssignmentTarget.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<InstallIntent>("intent", Intent);
            writer.WriteObjectValue<MobileAppAssignmentSettings>("settings", Settings);
            writer.WriteObjectValue<DeviceAndAppManagementAssignmentTarget>("target", Target);
        }
    }
}
