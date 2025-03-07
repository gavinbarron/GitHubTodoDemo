using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class ConditionalAccessConditionSet : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Applications and user actions included in and excluded from the policy. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ConditionalAccessApplications? Applications { get; set; }
#nullable restore
#else
        public ConditionalAccessApplications Applications { get; set; }
#endif
        /// <summary>Client applications (service principals and workload identities) included in and excluded from the policy. Either users or clientApplications is required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ConditionalAccessClientApplications? ClientApplications { get; set; }
#nullable restore
#else
        public ConditionalAccessClientApplications ClientApplications { get; set; }
#endif
        /// <summary>Client application types included in the policy. Possible values are: all, browser, mobileAppsAndDesktopClients, exchangeActiveSync, easSupported, other. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ConditionalAccessClientApp?>? ClientAppTypes { get; set; }
#nullable restore
#else
        public List<ConditionalAccessClientApp?> ClientAppTypes { get; set; }
#endif
        /// <summary>Devices in the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ConditionalAccessDevices? Devices { get; set; }
#nullable restore
#else
        public ConditionalAccessDevices Devices { get; set; }
#endif
        /// <summary>Locations included in and excluded from the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ConditionalAccessLocations? Locations { get; set; }
#nullable restore
#else
        public ConditionalAccessLocations Locations { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Platforms included in and excluded from the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ConditionalAccessPlatforms? Platforms { get; set; }
#nullable restore
#else
        public ConditionalAccessPlatforms Platforms { get; set; }
#endif
        /// <summary>Service principal risk levels included in the policy. Possible values are: low, medium, high, none, unknownFutureValue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RiskLevel?>? ServicePrincipalRiskLevels { get; set; }
#nullable restore
#else
        public List<RiskLevel?> ServicePrincipalRiskLevels { get; set; }
#endif
        /// <summary>Sign-in risk levels included in the policy. Possible values are: low, medium, high, hidden, none, unknownFutureValue. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RiskLevel?>? SignInRiskLevels { get; set; }
#nullable restore
#else
        public List<RiskLevel?> SignInRiskLevels { get; set; }
#endif
        /// <summary>User risk levels included in the policy. Possible values are: low, medium, high, hidden, none, unknownFutureValue. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RiskLevel?>? UserRiskLevels { get; set; }
#nullable restore
#else
        public List<RiskLevel?> UserRiskLevels { get; set; }
#endif
        /// <summary>Users, groups, and roles included in and excluded from the policy. Either users or clientApplications is required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ConditionalAccessUsers? Users { get; set; }
#nullable restore
#else
        public ConditionalAccessUsers Users { get; set; }
#endif
        /// <summary>
        /// Instantiates a new conditionalAccessConditionSet and sets the default values.
        /// </summary>
        public ConditionalAccessConditionSet() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ConditionalAccessConditionSet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConditionalAccessConditionSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"applications", n => { Applications = n.GetObjectValue<ConditionalAccessApplications>(ConditionalAccessApplications.CreateFromDiscriminatorValue); } },
                {"clientApplications", n => { ClientApplications = n.GetObjectValue<ConditionalAccessClientApplications>(ConditionalAccessClientApplications.CreateFromDiscriminatorValue); } },
                {"clientAppTypes", n => { ClientAppTypes = n.GetCollectionOfEnumValues<ConditionalAccessClientApp>()?.ToList(); } },
                {"devices", n => { Devices = n.GetObjectValue<ConditionalAccessDevices>(ConditionalAccessDevices.CreateFromDiscriminatorValue); } },
                {"locations", n => { Locations = n.GetObjectValue<ConditionalAccessLocations>(ConditionalAccessLocations.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"platforms", n => { Platforms = n.GetObjectValue<ConditionalAccessPlatforms>(ConditionalAccessPlatforms.CreateFromDiscriminatorValue); } },
                {"servicePrincipalRiskLevels", n => { ServicePrincipalRiskLevels = n.GetCollectionOfEnumValues<RiskLevel>()?.ToList(); } },
                {"signInRiskLevels", n => { SignInRiskLevels = n.GetCollectionOfEnumValues<RiskLevel>()?.ToList(); } },
                {"userRiskLevels", n => { UserRiskLevels = n.GetCollectionOfEnumValues<RiskLevel>()?.ToList(); } },
                {"users", n => { Users = n.GetObjectValue<ConditionalAccessUsers>(ConditionalAccessUsers.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ConditionalAccessApplications>("applications", Applications);
            writer.WriteObjectValue<ConditionalAccessClientApplications>("clientApplications", ClientApplications);
            writer.WriteCollectionOfEnumValues<ConditionalAccessClientApp>("clientAppTypes", ClientAppTypes);
            writer.WriteObjectValue<ConditionalAccessDevices>("devices", Devices);
            writer.WriteObjectValue<ConditionalAccessLocations>("locations", Locations);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<ConditionalAccessPlatforms>("platforms", Platforms);
            writer.WriteCollectionOfEnumValues<RiskLevel>("servicePrincipalRiskLevels", ServicePrincipalRiskLevels);
            writer.WriteCollectionOfEnumValues<RiskLevel>("signInRiskLevels", SignInRiskLevels);
            writer.WriteCollectionOfEnumValues<RiskLevel>("userRiskLevels", UserRiskLevels);
            writer.WriteObjectValue<ConditionalAccessUsers>("users", Users);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
