using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class ServiceHealth : Entity, IParsable {
        /// <summary>A collection of issues that happened on the service, with detailed information for each issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ServiceHealthIssue>? Issues { get; set; }
#nullable restore
#else
        public List<ServiceHealthIssue> Issues { get; set; }
#endif
        /// <summary>The service name. Use the list healthOverviews operation to get exact string names for services subscribed by the tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Service { get; set; }
#nullable restore
#else
        public string Service { get; set; }
#endif
        /// <summary>The status property</summary>
        public ServiceHealthStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ServiceHealth CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServiceHealth();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"issues", n => { Issues = n.GetCollectionOfObjectValues<ServiceHealthIssue>(ServiceHealthIssue.CreateFromDiscriminatorValue)?.ToList(); } },
                {"service", n => { Service = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<ServiceHealthStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ServiceHealthIssue>("issues", Issues);
            writer.WriteStringValue("service", Service);
            writer.WriteEnumValue<ServiceHealthStatus>("status", Status);
        }
    }
}
