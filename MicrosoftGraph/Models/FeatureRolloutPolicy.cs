using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class FeatureRolloutPolicy : Entity, IParsable {
        /// <summary>Nullable. Specifies a list of directoryObjects that feature is enabled for.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? AppliesTo { get; set; }
#nullable restore
#else
        public List<DirectoryObject> AppliesTo { get; set; }
#endif
        /// <summary>A description for this feature rollout policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The display name for this  feature rollout policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The feature property</summary>
        public StagedFeatureName? Feature { get; set; }
        /// <summary>Indicates whether this feature rollout policy should be applied to the entire organization.</summary>
        public bool? IsAppliedToOrganization { get; set; }
        /// <summary>Indicates whether the feature rollout is enabled.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new FeatureRolloutPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FeatureRolloutPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appliesTo", n => { AppliesTo = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"feature", n => { Feature = n.GetEnumValue<StagedFeatureName>(); } },
                {"isAppliedToOrganization", n => { IsAppliedToOrganization = n.GetBoolValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("appliesTo", AppliesTo);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<StagedFeatureName>("feature", Feature);
            writer.WriteBoolValue("isAppliedToOrganization", IsAppliedToOrganization);
            writer.WriteBoolValue("isEnabled", IsEnabled);
        }
    }
}
