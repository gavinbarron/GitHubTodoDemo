using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class AuthenticationMethodsRegistrationCampaign : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Users and groups of users that are excluded from being prompted to set up the authentication method.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ExcludeTarget>? ExcludeTargets { get; set; }
#nullable restore
#else
        public List<ExcludeTarget> ExcludeTargets { get; set; }
#endif
        /// <summary>Users and groups of users that are prompted to set up the authentication method.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthenticationMethodsRegistrationCampaignIncludeTarget>? IncludeTargets { get; set; }
#nullable restore
#else
        public List<AuthenticationMethodsRegistrationCampaignIncludeTarget> IncludeTargets { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Specifies the number of days that the user sees a prompt again if they select &apos;Not now&apos; and snoozes the prompt. Minimum: 0 days. Maximum: 14 days. If the value is &apos;0&apos;, the user is prompted during every MFA attempt.</summary>
        public int? SnoozeDurationInDays { get; set; }
        /// <summary>The state property</summary>
        public AdvancedConfigState? State { get; set; }
        /// <summary>
        /// Instantiates a new authenticationMethodsRegistrationCampaign and sets the default values.
        /// </summary>
        public AuthenticationMethodsRegistrationCampaign() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AuthenticationMethodsRegistrationCampaign CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationMethodsRegistrationCampaign();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"excludeTargets", n => { ExcludeTargets = n.GetCollectionOfObjectValues<ExcludeTarget>(ExcludeTarget.CreateFromDiscriminatorValue)?.ToList(); } },
                {"includeTargets", n => { IncludeTargets = n.GetCollectionOfObjectValues<AuthenticationMethodsRegistrationCampaignIncludeTarget>(AuthenticationMethodsRegistrationCampaignIncludeTarget.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"snoozeDurationInDays", n => { SnoozeDurationInDays = n.GetIntValue(); } },
                {"state", n => { State = n.GetEnumValue<AdvancedConfigState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ExcludeTarget>("excludeTargets", ExcludeTargets);
            writer.WriteCollectionOfObjectValues<AuthenticationMethodsRegistrationCampaignIncludeTarget>("includeTargets", IncludeTargets);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("snoozeDurationInDays", SnoozeDurationInDays);
            writer.WriteEnumValue<AdvancedConfigState>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
