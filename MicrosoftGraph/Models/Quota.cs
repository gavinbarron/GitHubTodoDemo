using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class Quota : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Total space consumed by files in the recycle bin, in bytes. Read-only.</summary>
        public long? Deleted { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Total space remaining before reaching the quota limit, in bytes. Read-only.</summary>
        public long? Remaining { get; set; }
        /// <summary>Enumeration value that indicates the state of the storage space. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State { get; set; }
#nullable restore
#else
        public string State { get; set; }
#endif
        /// <summary>Information about the drive&apos;s storage quota plans. Only in Personal OneDrive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.StoragePlanInformation? StoragePlanInformation { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.StoragePlanInformation StoragePlanInformation { get; set; }
#endif
        /// <summary>Total allowed storage space, in bytes. Read-only.</summary>
        public long? Total { get; set; }
        /// <summary>Total space used, in bytes. Read-only.</summary>
        public long? Used { get; set; }
        /// <summary>
        /// Instantiates a new quota and sets the default values.
        /// </summary>
        public Quota() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Quota CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Quota();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deleted", n => { Deleted = n.GetLongValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"remaining", n => { Remaining = n.GetLongValue(); } },
                {"state", n => { State = n.GetStringValue(); } },
                {"storagePlanInformation", n => { StoragePlanInformation = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.StoragePlanInformation>(GitHubTodoDemo.MicrosoftGraph.Models.StoragePlanInformation.CreateFromDiscriminatorValue); } },
                {"total", n => { Total = n.GetLongValue(); } },
                {"used", n => { Used = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("deleted", Deleted);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteLongValue("remaining", Remaining);
            writer.WriteStringValue("state", State);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.StoragePlanInformation>("storagePlanInformation", StoragePlanInformation);
            writer.WriteLongValue("total", Total);
            writer.WriteLongValue("used", Used);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
