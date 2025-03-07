using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>
    /// BitLocker Removable Drive Policies.
    /// </summary>
    public class BitLockerRemovableDrivePolicy : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>This policy setting determines whether BitLocker protection is required for removable data drives to be writable on a computer.</summary>
        public bool? BlockCrossOrganizationWriteAccess { get; set; }
        /// <summary>Select the encryption method for removable  drives. Possible values are: aesCbc128, aesCbc256, xtsAes128, xtsAes256.</summary>
        public BitLockerEncryptionMethod? EncryptionMethod { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Indicates whether to block write access to devices configured in another organization.  If requireEncryptionForWriteAccess is false, this value does not affect.</summary>
        public bool? RequireEncryptionForWriteAccess { get; set; }
        /// <summary>
        /// Instantiates a new bitLockerRemovableDrivePolicy and sets the default values.
        /// </summary>
        public BitLockerRemovableDrivePolicy() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BitLockerRemovableDrivePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BitLockerRemovableDrivePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"blockCrossOrganizationWriteAccess", n => { BlockCrossOrganizationWriteAccess = n.GetBoolValue(); } },
                {"encryptionMethod", n => { EncryptionMethod = n.GetEnumValue<BitLockerEncryptionMethod>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"requireEncryptionForWriteAccess", n => { RequireEncryptionForWriteAccess = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("blockCrossOrganizationWriteAccess", BlockCrossOrganizationWriteAccess);
            writer.WriteEnumValue<BitLockerEncryptionMethod>("encryptionMethod", EncryptionMethod);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("requireEncryptionForWriteAccess", RequireEncryptionForWriteAccess);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
