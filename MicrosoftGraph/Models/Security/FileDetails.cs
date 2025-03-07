using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models.Security {
    public class FileDetails : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The name of the file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileName { get; set; }
#nullable restore
#else
        public string FileName { get; set; }
#endif
        /// <summary>The file path (location) of the file instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FilePath { get; set; }
#nullable restore
#else
        public string FilePath { get; set; }
#endif
        /// <summary>The publisher of the file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FilePublisher { get; set; }
#nullable restore
#else
        public string FilePublisher { get; set; }
#endif
        /// <summary>The size of the file in bytes.</summary>
        public long? FileSize { get; set; }
        /// <summary>The certificate authority (CA) that issued the certificate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Issuer { get; set; }
#nullable restore
#else
        public string Issuer { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The Sha1 cryptographic hash of the file content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sha1 { get; set; }
#nullable restore
#else
        public string Sha1 { get; set; }
#endif
        /// <summary>The Sha256 cryptographic hash of the file content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sha256 { get; set; }
#nullable restore
#else
        public string Sha256 { get; set; }
#endif
        /// <summary>The signer of the signed file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Signer { get; set; }
#nullable restore
#else
        public string Signer { get; set; }
#endif
        /// <summary>
        /// Instantiates a new fileDetails and sets the default values.
        /// </summary>
        public FileDetails() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static FileDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FileDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"fileName", n => { FileName = n.GetStringValue(); } },
                {"filePath", n => { FilePath = n.GetStringValue(); } },
                {"filePublisher", n => { FilePublisher = n.GetStringValue(); } },
                {"fileSize", n => { FileSize = n.GetLongValue(); } },
                {"issuer", n => { Issuer = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"sha1", n => { Sha1 = n.GetStringValue(); } },
                {"sha256", n => { Sha256 = n.GetStringValue(); } },
                {"signer", n => { Signer = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("fileName", FileName);
            writer.WriteStringValue("filePath", FilePath);
            writer.WriteStringValue("filePublisher", FilePublisher);
            writer.WriteLongValue("fileSize", FileSize);
            writer.WriteStringValue("issuer", Issuer);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("sha1", Sha1);
            writer.WriteStringValue("sha256", Sha256);
            writer.WriteStringValue("signer", Signer);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
