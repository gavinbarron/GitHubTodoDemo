using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class OnPremisesConditionalAccessSettings : Entity, IParsable {
        /// <summary>Indicates if on premises conditional access is enabled for this organization</summary>
        public bool? Enabled { get; set; }
        /// <summary>User groups that will be exempt by on premises conditional access. All users in these groups will be exempt from the conditional access policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? ExcludedGroups { get; set; }
#nullable restore
#else
        public List<Guid?> ExcludedGroups { get; set; }
#endif
        /// <summary>User groups that will be targeted by on premises conditional access. All users in these groups will be required to have mobile device managed and compliant for mail access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? IncludedGroups { get; set; }
#nullable restore
#else
        public List<Guid?> IncludedGroups { get; set; }
#endif
        /// <summary>Override the default access rule when allowing a device to ensure access is granted.</summary>
        public bool? OverrideDefaultRule { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OnPremisesConditionalAccessSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnPremisesConditionalAccessSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"enabled", n => { Enabled = n.GetBoolValue(); } },
                {"excludedGroups", n => { ExcludedGroups = n.GetCollectionOfPrimitiveValues<Guid?>()?.ToList(); } },
                {"includedGroups", n => { IncludedGroups = n.GetCollectionOfPrimitiveValues<Guid?>()?.ToList(); } },
                {"overrideDefaultRule", n => { OverrideDefaultRule = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("enabled", Enabled);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("excludedGroups", ExcludedGroups);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("includedGroups", IncludedGroups);
            writer.WriteBoolValue("overrideDefaultRule", OverrideDefaultRule);
        }
    }
}
