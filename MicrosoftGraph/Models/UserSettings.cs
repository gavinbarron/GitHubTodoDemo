using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GithubTodoDemo.MicrosoftGraph.Models {
    public class UserSettings : Entity, IParsable {
        /// <summary>The contributionToContentDiscoveryAsOrganizationDisabled property</summary>
        public bool? ContributionToContentDiscoveryAsOrganizationDisabled { get; set; }
        /// <summary>The contributionToContentDiscoveryDisabled property</summary>
        public bool? ContributionToContentDiscoveryDisabled { get; set; }
        /// <summary>The shiftPreferences property</summary>
        public GithubTodoDemo.MicrosoftGraph.Models.ShiftPreferences ShiftPreferences { get; set; }
        /// <summary>
        /// Instantiates a new userSettings and sets the default values.
        /// </summary>
        public UserSettings() : base() {
            OdataType = "#microsoft.graph.userSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"contributionToContentDiscoveryAsOrganizationDisabled", n => { ContributionToContentDiscoveryAsOrganizationDisabled = n.GetBoolValue(); } },
                {"contributionToContentDiscoveryDisabled", n => { ContributionToContentDiscoveryDisabled = n.GetBoolValue(); } },
                {"shiftPreferences", n => { ShiftPreferences = n.GetObjectValue<GithubTodoDemo.MicrosoftGraph.Models.ShiftPreferences>(GithubTodoDemo.MicrosoftGraph.Models.ShiftPreferences.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("contributionToContentDiscoveryAsOrganizationDisabled", ContributionToContentDiscoveryAsOrganizationDisabled);
            writer.WriteBoolValue("contributionToContentDiscoveryDisabled", ContributionToContentDiscoveryDisabled);
            writer.WriteObjectValue<GithubTodoDemo.MicrosoftGraph.Models.ShiftPreferences>("shiftPreferences", ShiftPreferences);
        }
    }
}
