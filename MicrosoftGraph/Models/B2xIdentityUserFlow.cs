using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class B2xIdentityUserFlow : IdentityUserFlow, IParsable {
        /// <summary>Configuration for enabling an API connector for use as part of the self-service sign-up user flow. You can only obtain the value of this object using Get userFlowApiConnectorConfiguration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserFlowApiConnectorConfiguration? ApiConnectorConfiguration { get; set; }
#nullable restore
#else
        public UserFlowApiConnectorConfiguration ApiConnectorConfiguration { get; set; }
#endif
        /// <summary>The identity providers included in the user flow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IdentityProvider>? IdentityProviders { get; set; }
#nullable restore
#else
        public List<IdentityProvider> IdentityProviders { get; set; }
#endif
        /// <summary>The languages supported for customization within the user flow. Language customization is enabled by default in self-service sign-up user flow. You cannot create custom languages in self-service sign-up user flows.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserFlowLanguageConfiguration>? Languages { get; set; }
#nullable restore
#else
        public List<UserFlowLanguageConfiguration> Languages { get; set; }
#endif
        /// <summary>The user attribute assignments included in the user flow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IdentityUserFlowAttributeAssignment>? UserAttributeAssignments { get; set; }
#nullable restore
#else
        public List<IdentityUserFlowAttributeAssignment> UserAttributeAssignments { get; set; }
#endif
        /// <summary>The userFlowIdentityProviders property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IdentityProviderBase>? UserFlowIdentityProviders { get; set; }
#nullable restore
#else
        public List<IdentityProviderBase> UserFlowIdentityProviders { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new B2xIdentityUserFlow CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new B2xIdentityUserFlow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"apiConnectorConfiguration", n => { ApiConnectorConfiguration = n.GetObjectValue<UserFlowApiConnectorConfiguration>(UserFlowApiConnectorConfiguration.CreateFromDiscriminatorValue); } },
                {"identityProviders", n => { IdentityProviders = n.GetCollectionOfObjectValues<IdentityProvider>(IdentityProvider.CreateFromDiscriminatorValue)?.ToList(); } },
                {"languages", n => { Languages = n.GetCollectionOfObjectValues<UserFlowLanguageConfiguration>(UserFlowLanguageConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userAttributeAssignments", n => { UserAttributeAssignments = n.GetCollectionOfObjectValues<IdentityUserFlowAttributeAssignment>(IdentityUserFlowAttributeAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userFlowIdentityProviders", n => { UserFlowIdentityProviders = n.GetCollectionOfObjectValues<IdentityProviderBase>(IdentityProviderBase.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<UserFlowApiConnectorConfiguration>("apiConnectorConfiguration", ApiConnectorConfiguration);
            writer.WriteCollectionOfObjectValues<IdentityProvider>("identityProviders", IdentityProviders);
            writer.WriteCollectionOfObjectValues<UserFlowLanguageConfiguration>("languages", Languages);
            writer.WriteCollectionOfObjectValues<IdentityUserFlowAttributeAssignment>("userAttributeAssignments", UserAttributeAssignments);
            writer.WriteCollectionOfObjectValues<IdentityProviderBase>("userFlowIdentityProviders", UserFlowIdentityProviders);
        }
    }
}
