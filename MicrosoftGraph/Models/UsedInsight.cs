using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class UsedInsight : Entity, IParsable {
        /// <summary>Information about when the item was last viewed or modified by the user. Read only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UsageDetails? LastUsed { get; set; }
#nullable restore
#else
        public UsageDetails LastUsed { get; set; }
#endif
        /// <summary>Used for navigating to the item that was used. For file attachments, the type is fileAttachment. For linked attachments, the type is driveItem.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Entity? Resource { get; set; }
#nullable restore
#else
        public Entity Resource { get; set; }
#endif
        /// <summary>Reference properties of the used document, such as the url and type of the document. Read-only</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.ResourceReference? ResourceReference { get; private set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.ResourceReference ResourceReference { get; private set; }
#endif
        /// <summary>Properties that you can use to visualize the document in your experience. Read-only</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.ResourceVisualization? ResourceVisualization { get; private set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.ResourceVisualization ResourceVisualization { get; private set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UsedInsight CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UsedInsight();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"lastUsed", n => { LastUsed = n.GetObjectValue<UsageDetails>(UsageDetails.CreateFromDiscriminatorValue); } },
                {"resource", n => { Resource = n.GetObjectValue<Entity>(Entity.CreateFromDiscriminatorValue); } },
                {"resourceReference", n => { ResourceReference = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.ResourceReference>(GitHubTodoDemo.MicrosoftGraph.Models.ResourceReference.CreateFromDiscriminatorValue); } },
                {"resourceVisualization", n => { ResourceVisualization = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.ResourceVisualization>(GitHubTodoDemo.MicrosoftGraph.Models.ResourceVisualization.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<UsageDetails>("lastUsed", LastUsed);
            writer.WriteObjectValue<Entity>("resource", Resource);
        }
    }
}
