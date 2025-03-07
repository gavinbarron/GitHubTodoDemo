using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class SecureScoreControlProfile : Entity, IParsable {
        /// <summary>Control action type (Config, Review, Behavior).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActionType { get; set; }
#nullable restore
#else
        public string ActionType { get; set; }
#endif
        /// <summary>URL to where the control can be actioned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActionUrl { get; set; }
#nullable restore
#else
        public string ActionUrl { get; set; }
#endif
        /// <summary>GUID string for tenant ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureTenantId { get; set; }
#nullable restore
#else
        public string AzureTenantId { get; set; }
#endif
        /// <summary>The collection of compliance information associated with secure score control</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<GitHubTodoDemo.MicrosoftGraph.Models.ComplianceInformation>? ComplianceInformation { get; set; }
#nullable restore
#else
        public List<GitHubTodoDemo.MicrosoftGraph.Models.ComplianceInformation> ComplianceInformation { get; set; }
#endif
        /// <summary>Control action category (Identity, Data, Device, Apps, Infrastructure).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ControlCategory { get; set; }
#nullable restore
#else
        public string ControlCategory { get; set; }
#endif
        /// <summary>Flag to indicate where the tenant has marked a control (ignored, thirdParty, reviewed) (supports update).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SecureScoreControlStateUpdate>? ControlStateUpdates { get; set; }
#nullable restore
#else
        public List<SecureScoreControlStateUpdate> ControlStateUpdates { get; set; }
#endif
        /// <summary>Flag to indicate if a control is depreciated.</summary>
        public bool? Deprecated { get; set; }
        /// <summary>Resource cost of implemmentating control (low, moderate, high).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImplementationCost { get; set; }
#nullable restore
#else
        public string ImplementationCost { get; set; }
#endif
        /// <summary>Time at which the control profile entity was last modified. The Timestamp type represents date and time</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>max attainable score for the control.</summary>
        public double? MaxScore { get; set; }
        /// <summary>Microsoft&apos;s stack ranking of control.</summary>
        public int? Rank { get; set; }
        /// <summary>Description of what the control will help remediate.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Remediation { get; set; }
#nullable restore
#else
        public string Remediation { get; set; }
#endif
        /// <summary>Description of the impact on users of the remediation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemediationImpact { get; set; }
#nullable restore
#else
        public string RemediationImpact { get; set; }
#endif
        /// <summary>Service that owns the control (Exchange, Sharepoint, Azure AD).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Service { get; set; }
#nullable restore
#else
        public string Service { get; set; }
#endif
        /// <summary>List of threats the control mitigates (accountBreach,dataDeletion,dataExfiltration,dataSpillage,</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Threats { get; set; }
#nullable restore
#else
        public List<string> Threats { get; set; }
#endif
        /// <summary>The tier property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Tier { get; set; }
#nullable restore
#else
        public string Tier { get; set; }
#endif
        /// <summary>The title property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>The userImpact property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserImpact { get; set; }
#nullable restore
#else
        public string UserImpact { get; set; }
#endif
        /// <summary>The vendorInformation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SecurityVendorInformation? VendorInformation { get; set; }
#nullable restore
#else
        public SecurityVendorInformation VendorInformation { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SecureScoreControlProfile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecureScoreControlProfile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actionType", n => { ActionType = n.GetStringValue(); } },
                {"actionUrl", n => { ActionUrl = n.GetStringValue(); } },
                {"azureTenantId", n => { AzureTenantId = n.GetStringValue(); } },
                {"complianceInformation", n => { ComplianceInformation = n.GetCollectionOfObjectValues<GitHubTodoDemo.MicrosoftGraph.Models.ComplianceInformation>(GitHubTodoDemo.MicrosoftGraph.Models.ComplianceInformation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"controlCategory", n => { ControlCategory = n.GetStringValue(); } },
                {"controlStateUpdates", n => { ControlStateUpdates = n.GetCollectionOfObjectValues<SecureScoreControlStateUpdate>(SecureScoreControlStateUpdate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deprecated", n => { Deprecated = n.GetBoolValue(); } },
                {"implementationCost", n => { ImplementationCost = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"maxScore", n => { MaxScore = n.GetDoubleValue(); } },
                {"rank", n => { Rank = n.GetIntValue(); } },
                {"remediation", n => { Remediation = n.GetStringValue(); } },
                {"remediationImpact", n => { RemediationImpact = n.GetStringValue(); } },
                {"service", n => { Service = n.GetStringValue(); } },
                {"threats", n => { Threats = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"tier", n => { Tier = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"userImpact", n => { UserImpact = n.GetStringValue(); } },
                {"vendorInformation", n => { VendorInformation = n.GetObjectValue<SecurityVendorInformation>(SecurityVendorInformation.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("actionType", ActionType);
            writer.WriteStringValue("actionUrl", ActionUrl);
            writer.WriteStringValue("azureTenantId", AzureTenantId);
            writer.WriteCollectionOfObjectValues<GitHubTodoDemo.MicrosoftGraph.Models.ComplianceInformation>("complianceInformation", ComplianceInformation);
            writer.WriteStringValue("controlCategory", ControlCategory);
            writer.WriteCollectionOfObjectValues<SecureScoreControlStateUpdate>("controlStateUpdates", ControlStateUpdates);
            writer.WriteBoolValue("deprecated", Deprecated);
            writer.WriteStringValue("implementationCost", ImplementationCost);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteDoubleValue("maxScore", MaxScore);
            writer.WriteIntValue("rank", Rank);
            writer.WriteStringValue("remediation", Remediation);
            writer.WriteStringValue("remediationImpact", RemediationImpact);
            writer.WriteStringValue("service", Service);
            writer.WriteCollectionOfPrimitiveValues<string>("threats", Threats);
            writer.WriteStringValue("tier", Tier);
            writer.WriteStringValue("title", Title);
            writer.WriteStringValue("userImpact", UserImpact);
            writer.WriteObjectValue<SecurityVendorInformation>("vendorInformation", VendorInformation);
        }
    }
}
