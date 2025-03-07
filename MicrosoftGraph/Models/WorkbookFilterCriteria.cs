using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class WorkbookFilterCriteria : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The color property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Color { get; set; }
#nullable restore
#else
        public string Color { get; set; }
#endif
        /// <summary>The criterion1 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Criterion1 { get; set; }
#nullable restore
#else
        public string Criterion1 { get; set; }
#endif
        /// <summary>The criterion2 property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Criterion2 { get; set; }
#nullable restore
#else
        public string Criterion2 { get; set; }
#endif
        /// <summary>The dynamicCriteria property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DynamicCriteria { get; set; }
#nullable restore
#else
        public string DynamicCriteria { get; set; }
#endif
        /// <summary>The filterOn property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FilterOn { get; set; }
#nullable restore
#else
        public string FilterOn { get; set; }
#endif
        /// <summary>The icon property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookIcon? Icon { get; set; }
#nullable restore
#else
        public WorkbookIcon Icon { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The operator property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Operator { get; set; }
#nullable restore
#else
        public string Operator { get; set; }
#endif
        /// <summary>The values property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? Values { get; set; }
#nullable restore
#else
        public Json Values { get; set; }
#endif
        /// <summary>
        /// Instantiates a new workbookFilterCriteria and sets the default values.
        /// </summary>
        public WorkbookFilterCriteria() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkbookFilterCriteria CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookFilterCriteria();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"color", n => { Color = n.GetStringValue(); } },
                {"criterion1", n => { Criterion1 = n.GetStringValue(); } },
                {"criterion2", n => { Criterion2 = n.GetStringValue(); } },
                {"dynamicCriteria", n => { DynamicCriteria = n.GetStringValue(); } },
                {"filterOn", n => { FilterOn = n.GetStringValue(); } },
                {"icon", n => { Icon = n.GetObjectValue<WorkbookIcon>(WorkbookIcon.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"operator", n => { Operator = n.GetStringValue(); } },
                {"values", n => { Values = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("color", Color);
            writer.WriteStringValue("criterion1", Criterion1);
            writer.WriteStringValue("criterion2", Criterion2);
            writer.WriteStringValue("dynamicCriteria", DynamicCriteria);
            writer.WriteStringValue("filterOn", FilterOn);
            writer.WriteObjectValue<WorkbookIcon>("icon", Icon);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("operator", Operator);
            writer.WriteObjectValue<Json>("values", Values);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
