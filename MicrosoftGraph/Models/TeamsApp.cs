using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class TeamsApp : Entity, IParsable {
        /// <summary>The details for each version of the app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TeamsAppDefinition>? AppDefinitions { get; set; }
#nullable restore
#else
        public List<TeamsAppDefinition> AppDefinitions { get; set; }
#endif
        /// <summary>The name of the catalog app provided by the app developer in the Microsoft Teams zip app package.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The method of distribution for the app. Read-only.</summary>
        public TeamsAppDistributionMethod? DistributionMethod { get; set; }
        /// <summary>The ID of the catalog provided by the app developer in the Microsoft Teams zip app package.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId { get; set; }
#nullable restore
#else
        public string ExternalId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TeamsApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamsApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appDefinitions", n => { AppDefinitions = n.GetCollectionOfObjectValues<TeamsAppDefinition>(TeamsAppDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"distributionMethod", n => { DistributionMethod = n.GetEnumValue<TeamsAppDistributionMethod>(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<TeamsAppDefinition>("appDefinitions", AppDefinitions);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<TeamsAppDistributionMethod>("distributionMethod", DistributionMethod);
            writer.WriteStringValue("externalId", ExternalId);
        }
    }
}
