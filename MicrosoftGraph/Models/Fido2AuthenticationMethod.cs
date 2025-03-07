using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class Fido2AuthenticationMethod : AuthenticationMethod, IParsable {
        /// <summary>Authenticator Attestation GUID, an identifier that indicates the type (e.g. make and model) of the authenticator.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AaGuid { get; set; }
#nullable restore
#else
        public string AaGuid { get; set; }
#endif
        /// <summary>The attestation certificate(s) attached to this security key.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AttestationCertificates { get; set; }
#nullable restore
#else
        public List<string> AttestationCertificates { get; set; }
#endif
        /// <summary>The attestation level of this FIDO2 security key. Possible values are: attested, or notAttested.</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.AttestationLevel? AttestationLevel { get; set; }
        /// <summary>The timestamp when this key was registered to the user.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The display name of the key as given by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The manufacturer-assigned model of the FIDO2 security key.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model { get; set; }
#nullable restore
#else
        public string Model { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Fido2AuthenticationMethod and sets the default values.
        /// </summary>
        public Fido2AuthenticationMethod() : base() {
            OdataType = "#microsoft.graph.fido2AuthenticationMethod";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Fido2AuthenticationMethod CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Fido2AuthenticationMethod();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"aaGuid", n => { AaGuid = n.GetStringValue(); } },
                {"attestationCertificates", n => { AttestationCertificates = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"attestationLevel", n => { AttestationLevel = n.GetEnumValue<AttestationLevel>(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("aaGuid", AaGuid);
            writer.WriteCollectionOfPrimitiveValues<string>("attestationCertificates", AttestationCertificates);
            writer.WriteEnumValue<AttestationLevel>("attestationLevel", AttestationLevel);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("model", Model);
        }
    }
}
