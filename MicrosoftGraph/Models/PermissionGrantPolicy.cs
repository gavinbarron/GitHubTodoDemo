using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class PermissionGrantPolicy : PolicyBase, IParsable {
        /// <summary>Condition sets which are excluded in this permission grant policy. Automatically expanded on GET.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PermissionGrantConditionSet>? Excludes { get; set; }
#nullable restore
#else
        public List<PermissionGrantConditionSet> Excludes { get; set; }
#endif
        /// <summary>Condition sets which are included in this permission grant policy. Automatically expanded on GET.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PermissionGrantConditionSet>? Includes { get; set; }
#nullable restore
#else
        public List<PermissionGrantConditionSet> Includes { get; set; }
#endif
        /// <summary>
        /// Instantiates a new PermissionGrantPolicy and sets the default values.
        /// </summary>
        public PermissionGrantPolicy() : base() {
            OdataType = "#microsoft.graph.permissionGrantPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PermissionGrantPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PermissionGrantPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"excludes", n => { Excludes = n.GetCollectionOfObjectValues<PermissionGrantConditionSet>(PermissionGrantConditionSet.CreateFromDiscriminatorValue)?.ToList(); } },
                {"includes", n => { Includes = n.GetCollectionOfObjectValues<PermissionGrantConditionSet>(PermissionGrantConditionSet.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<PermissionGrantConditionSet>("excludes", Excludes);
            writer.WriteCollectionOfObjectValues<PermissionGrantConditionSet>("includes", Includes);
        }
    }
}
