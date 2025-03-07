using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>
    /// Represents policy deployment summary per app.
    /// </summary>
    public class ManagedAppPolicyDeploymentSummaryPerApp : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Number of users the policy is applied.</summary>
        public int? ConfigurationAppliedUserCount { get; set; }
        /// <summary>Deployment of an app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.MobileAppIdentifier? MobileAppIdentifier { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.MobileAppIdentifier MobileAppIdentifier { get; set; }
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
        /// Instantiates a new managedAppPolicyDeploymentSummaryPerApp and sets the default values.
        /// </summary>
        public ManagedAppPolicyDeploymentSummaryPerApp() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ManagedAppPolicyDeploymentSummaryPerApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedAppPolicyDeploymentSummaryPerApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"configurationAppliedUserCount", n => { ConfigurationAppliedUserCount = n.GetIntValue(); } },
                {"mobileAppIdentifier", n => { MobileAppIdentifier = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.MobileAppIdentifier>(GitHubTodoDemo.MicrosoftGraph.Models.MobileAppIdentifier.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("configurationAppliedUserCount", ConfigurationAppliedUserCount);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.MobileAppIdentifier>("mobileAppIdentifier", MobileAppIdentifier);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
