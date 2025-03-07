using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class Fido2AuthenticationMethodConfiguration : AuthenticationMethodConfiguration, IParsable {
        /// <summary>A collection of groups that are enabled to use the authentication method.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthenticationMethodTarget>? IncludeTargets { get; set; }
#nullable restore
#else
        public List<AuthenticationMethodTarget> IncludeTargets { get; set; }
#endif
        /// <summary>Determines whether attestation must be enforced for FIDO2 security key registration.</summary>
        public bool? IsAttestationEnforced { get; set; }
        /// <summary>Determines if users can register new FIDO2 security keys.</summary>
        public bool? IsSelfServiceRegistrationAllowed { get; set; }
        /// <summary>Controls whether key restrictions are enforced on FIDO2 security keys, either allowing or disallowing certain key types as defined by Authenticator Attestation GUID (AAGUID), an identifier that indicates the type (e.g. make and model) of the authenticator.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Fido2KeyRestrictions? KeyRestrictions { get; set; }
#nullable restore
#else
        public Fido2KeyRestrictions KeyRestrictions { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Fido2AuthenticationMethodConfiguration and sets the default values.
        /// </summary>
        public Fido2AuthenticationMethodConfiguration() : base() {
            OdataType = "#microsoft.graph.fido2AuthenticationMethodConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Fido2AuthenticationMethodConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Fido2AuthenticationMethodConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"includeTargets", n => { IncludeTargets = n.GetCollectionOfObjectValues<AuthenticationMethodTarget>(AuthenticationMethodTarget.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isAttestationEnforced", n => { IsAttestationEnforced = n.GetBoolValue(); } },
                {"isSelfServiceRegistrationAllowed", n => { IsSelfServiceRegistrationAllowed = n.GetBoolValue(); } },
                {"keyRestrictions", n => { KeyRestrictions = n.GetObjectValue<Fido2KeyRestrictions>(Fido2KeyRestrictions.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AuthenticationMethodTarget>("includeTargets", IncludeTargets);
            writer.WriteBoolValue("isAttestationEnforced", IsAttestationEnforced);
            writer.WriteBoolValue("isSelfServiceRegistrationAllowed", IsSelfServiceRegistrationAllowed);
            writer.WriteObjectValue<Fido2KeyRestrictions>("keyRestrictions", KeyRestrictions);
        }
    }
}
