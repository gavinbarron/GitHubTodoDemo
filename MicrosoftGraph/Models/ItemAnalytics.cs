using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class ItemAnalytics : Entity, IParsable {
        /// <summary>The allTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemActivityStat? AllTime { get; set; }
#nullable restore
#else
        public ItemActivityStat AllTime { get; set; }
#endif
        /// <summary>The itemActivityStats property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ItemActivityStat>? ItemActivityStats { get; set; }
#nullable restore
#else
        public List<ItemActivityStat> ItemActivityStats { get; set; }
#endif
        /// <summary>The lastSevenDays property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemActivityStat? LastSevenDays { get; set; }
#nullable restore
#else
        public ItemActivityStat LastSevenDays { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ItemAnalytics CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ItemAnalytics();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allTime", n => { AllTime = n.GetObjectValue<ItemActivityStat>(ItemActivityStat.CreateFromDiscriminatorValue); } },
                {"itemActivityStats", n => { ItemActivityStats = n.GetCollectionOfObjectValues<ItemActivityStat>(ItemActivityStat.CreateFromDiscriminatorValue)?.ToList(); } },
                {"lastSevenDays", n => { LastSevenDays = n.GetObjectValue<ItemActivityStat>(ItemActivityStat.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ItemActivityStat>("allTime", AllTime);
            writer.WriteCollectionOfObjectValues<ItemActivityStat>("itemActivityStats", ItemActivityStats);
            writer.WriteObjectValue<ItemActivityStat>("lastSevenDays", LastSevenDays);
        }
    }
}
