using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class RiskyUserHistoryItem : RiskyUser, IParsable {
        /// <summary>The activity related to user risk level change.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RiskUserActivity? Activity { get; set; }
#nullable restore
#else
        public RiskUserActivity Activity { get; set; }
#endif
        /// <summary>The ID of actor that does the operation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InitiatedBy { get; set; }
#nullable restore
#else
        public string InitiatedBy { get; set; }
#endif
        /// <summary>The ID of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RiskyUserHistoryItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RiskyUserHistoryItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activity", n => { Activity = n.GetObjectValue<RiskUserActivity>(RiskUserActivity.CreateFromDiscriminatorValue); } },
                {"initiatedBy", n => { InitiatedBy = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<RiskUserActivity>("activity", Activity);
            writer.WriteStringValue("initiatedBy", InitiatedBy);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
