using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class Hashes : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The CRC32 value of the file in little endian (if available). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Crc32Hash { get; set; }
#nullable restore
#else
        public string Crc32Hash { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>A proprietary hash of the file that can be used to determine if the contents of the file have changed (if available). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? QuickXorHash { get; set; }
#nullable restore
#else
        public string QuickXorHash { get; set; }
#endif
        /// <summary>SHA1 hash for the contents of the file (if available). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sha1Hash { get; set; }
#nullable restore
#else
        public string Sha1Hash { get; set; }
#endif
        /// <summary>SHA256 hash for the contents of the file (if available). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sha256Hash { get; set; }
#nullable restore
#else
        public string Sha256Hash { get; set; }
#endif
        /// <summary>
        /// Instantiates a new hashes and sets the default values.
        /// </summary>
        public Hashes() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Hashes CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Hashes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"crc32Hash", n => { Crc32Hash = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"quickXorHash", n => { QuickXorHash = n.GetStringValue(); } },
                {"sha1Hash", n => { Sha1Hash = n.GetStringValue(); } },
                {"sha256Hash", n => { Sha256Hash = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("crc32Hash", Crc32Hash);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("quickXorHash", QuickXorHash);
            writer.WriteStringValue("sha1Hash", Sha1Hash);
            writer.WriteStringValue("sha256Hash", Sha256Hash);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
