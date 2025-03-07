using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class Trending : Entity, IParsable {
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Used for navigating to the trending document.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Entity? Resource { get; set; }
#nullable restore
#else
        public Entity Resource { get; set; }
#endif
        /// <summary>Reference properties of the trending document, such as the url and type of the document.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.ResourceReference? ResourceReference { get; private set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.ResourceReference ResourceReference { get; private set; }
#endif
        /// <summary>Properties that you can use to visualize the document in your experience.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.ResourceVisualization? ResourceVisualization { get; private set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.ResourceVisualization ResourceVisualization { get; private set; }
#endif
        /// <summary>Value indicating how much the document is currently trending. The larger the number, the more the document is currently trending around the user (the more relevant it is). Returned documents are sorted by this value.</summary>
        public double? Weight { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Trending CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Trending();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"resource", n => { Resource = n.GetObjectValue<Entity>(Entity.CreateFromDiscriminatorValue); } },
                {"resourceReference", n => { ResourceReference = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.ResourceReference>(GitHubTodoDemo.MicrosoftGraph.Models.ResourceReference.CreateFromDiscriminatorValue); } },
                {"resourceVisualization", n => { ResourceVisualization = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.ResourceVisualization>(GitHubTodoDemo.MicrosoftGraph.Models.ResourceVisualization.CreateFromDiscriminatorValue); } },
                {"weight", n => { Weight = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<Entity>("resource", Resource);
            writer.WriteDoubleValue("weight", Weight);
        }
    }
}
