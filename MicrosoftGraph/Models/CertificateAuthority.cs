using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class CertificateAuthority : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Required. The base64 encoded string representing the public certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Certificate { get; set; }
#nullable restore
#else
        public byte[] Certificate { get; set; }
#endif
        /// <summary>The URL of the certificate revocation list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CertificateRevocationListUrl { get; set; }
#nullable restore
#else
        public string CertificateRevocationListUrl { get; set; }
#endif
        /// <summary>The URL contains the list of all revoked certificates since the last time a full certificate revocaton list was created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeltaCertificateRevocationListUrl { get; set; }
#nullable restore
#else
        public string DeltaCertificateRevocationListUrl { get; set; }
#endif
        /// <summary>Required. true if the trusted certificate is a root authority, false if the trusted certificate is an intermediate authority.</summary>
        public bool? IsRootAuthority { get; set; }
        /// <summary>The issuer of the certificate, calculated from the certificate value. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Issuer { get; set; }
#nullable restore
#else
        public string Issuer { get; set; }
#endif
        /// <summary>The subject key identifier of the certificate, calculated from the certificate value. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssuerSki { get; set; }
#nullable restore
#else
        public string IssuerSki { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new certificateAuthority and sets the default values.
        /// </summary>
        public CertificateAuthority() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CertificateAuthority CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CertificateAuthority();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"certificate", n => { Certificate = n.GetByteArrayValue(); } },
                {"certificateRevocationListUrl", n => { CertificateRevocationListUrl = n.GetStringValue(); } },
                {"deltaCertificateRevocationListUrl", n => { DeltaCertificateRevocationListUrl = n.GetStringValue(); } },
                {"isRootAuthority", n => { IsRootAuthority = n.GetBoolValue(); } },
                {"issuer", n => { Issuer = n.GetStringValue(); } },
                {"issuerSki", n => { IssuerSki = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteByteArrayValue("certificate", Certificate);
            writer.WriteStringValue("certificateRevocationListUrl", CertificateRevocationListUrl);
            writer.WriteStringValue("deltaCertificateRevocationListUrl", DeltaCertificateRevocationListUrl);
            writer.WriteBoolValue("isRootAuthority", IsRootAuthority);
            writer.WriteStringValue("issuer", Issuer);
            writer.WriteStringValue("issuerSki", IssuerSki);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
