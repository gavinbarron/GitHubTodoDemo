using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class ProvisioningErrorInfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Additional details in case of error.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AdditionalDetails { get; set; }
#nullable restore
#else
        public string AdditionalDetails { get; set; }
#endif
        /// <summary>Categorizes the error code. Possible values are failure, nonServiceFailure, success, unknownFutureValue</summary>
        public ProvisioningStatusErrorCategory? ErrorCategory { get; set; }
        /// <summary>Unique error code if any occurred. Learn more</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ErrorCode { get; set; }
#nullable restore
#else
        public string ErrorCode { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Summarizes the status and describes why the status happened.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Reason { get; set; }
#nullable restore
#else
        public string Reason { get; set; }
#endif
        /// <summary>Provides the resolution for the corresponding error.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecommendedAction { get; set; }
#nullable restore
#else
        public string RecommendedAction { get; set; }
#endif
        /// <summary>
        /// Instantiates a new provisioningErrorInfo and sets the default values.
        /// </summary>
        public ProvisioningErrorInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ProvisioningErrorInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProvisioningErrorInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"additionalDetails", n => { AdditionalDetails = n.GetStringValue(); } },
                {"errorCategory", n => { ErrorCategory = n.GetEnumValue<ProvisioningStatusErrorCategory>(); } },
                {"errorCode", n => { ErrorCode = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"reason", n => { Reason = n.GetStringValue(); } },
                {"recommendedAction", n => { RecommendedAction = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("additionalDetails", AdditionalDetails);
            writer.WriteEnumValue<ProvisioningStatusErrorCategory>("errorCategory", ErrorCategory);
            writer.WriteStringValue("errorCode", ErrorCode);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("reason", Reason);
            writer.WriteStringValue("recommendedAction", RecommendedAction);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
