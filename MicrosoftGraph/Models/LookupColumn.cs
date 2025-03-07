using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class LookupColumn : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether multiple values can be selected from the source.</summary>
        public bool? AllowMultipleValues { get; set; }
        /// <summary>Indicates whether values in the column should be able to exceed the standard limit of 255 characters.</summary>
        public bool? AllowUnlimitedLength { get; set; }
        /// <summary>The name of the lookup source column.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ColumnName { get; set; }
#nullable restore
#else
        public string ColumnName { get; set; }
#endif
        /// <summary>The unique identifier of the lookup source list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ListId { get; set; }
#nullable restore
#else
        public string ListId { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>If specified, this column is a secondary lookup, pulling an additional field from the list item looked up by the primary lookup. Use the list item looked up by the primary as the source for the column named here.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrimaryLookupColumnId { get; set; }
#nullable restore
#else
        public string PrimaryLookupColumnId { get; set; }
#endif
        /// <summary>
        /// Instantiates a new lookupColumn and sets the default values.
        /// </summary>
        public LookupColumn() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static LookupColumn CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LookupColumn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowMultipleValues", n => { AllowMultipleValues = n.GetBoolValue(); } },
                {"allowUnlimitedLength", n => { AllowUnlimitedLength = n.GetBoolValue(); } },
                {"columnName", n => { ColumnName = n.GetStringValue(); } },
                {"listId", n => { ListId = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"primaryLookupColumnId", n => { PrimaryLookupColumnId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowMultipleValues", AllowMultipleValues);
            writer.WriteBoolValue("allowUnlimitedLength", AllowUnlimitedLength);
            writer.WriteStringValue("columnName", ColumnName);
            writer.WriteStringValue("listId", ListId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("primaryLookupColumnId", PrimaryLookupColumnId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
