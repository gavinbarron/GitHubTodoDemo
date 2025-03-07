using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class ConditionalAccessRoot : Entity, IParsable {
        /// <summary>Read-only. Nullable. Returns a collection of the specified authentication context class references.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthenticationContextClassReference>? AuthenticationContextClassReferences { get; set; }
#nullable restore
#else
        public List<AuthenticationContextClassReference> AuthenticationContextClassReferences { get; set; }
#endif
        /// <summary>Read-only. Nullable. Returns a collection of the specified named locations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<NamedLocation>? NamedLocations { get; set; }
#nullable restore
#else
        public List<NamedLocation> NamedLocations { get; set; }
#endif
        /// <summary>Read-only. Nullable. Returns a collection of the specified Conditional Access (CA) policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ConditionalAccessPolicy>? Policies { get; set; }
#nullable restore
#else
        public List<ConditionalAccessPolicy> Policies { get; set; }
#endif
        /// <summary>Read-only. Nullable. Returns a collection of the specified Conditional Access templates.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ConditionalAccessTemplate>? Templates { get; set; }
#nullable restore
#else
        public List<ConditionalAccessTemplate> Templates { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ConditionalAccessRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authenticationContextClassReferences", n => { AuthenticationContextClassReferences = n.GetCollectionOfObjectValues<AuthenticationContextClassReference>(AuthenticationContextClassReference.CreateFromDiscriminatorValue)?.ToList(); } },
                {"namedLocations", n => { NamedLocations = n.GetCollectionOfObjectValues<NamedLocation>(NamedLocation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"policies", n => { Policies = n.GetCollectionOfObjectValues<ConditionalAccessPolicy>(ConditionalAccessPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"templates", n => { Templates = n.GetCollectionOfObjectValues<ConditionalAccessTemplate>(ConditionalAccessTemplate.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AuthenticationContextClassReference>("authenticationContextClassReferences", AuthenticationContextClassReferences);
            writer.WriteCollectionOfObjectValues<NamedLocation>("namedLocations", NamedLocations);
            writer.WriteCollectionOfObjectValues<ConditionalAccessPolicy>("policies", Policies);
            writer.WriteCollectionOfObjectValues<ConditionalAccessTemplate>("templates", Templates);
        }
    }
}
