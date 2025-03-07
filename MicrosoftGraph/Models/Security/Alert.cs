using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models.Security {
    public class Alert : Entity, IParsable {
        /// <summary>The adversary or activity group that is associated with this alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActorDisplayName { get; set; }
#nullable restore
#else
        public string ActorDisplayName { get; set; }
#endif
        /// <summary>URL for the alert page in the Microsoft 365 Defender portal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlertWebUrl { get; set; }
#nullable restore
#else
        public string AlertWebUrl { get; set; }
#endif
        /// <summary>Owner of the alert, or null if no owner is assigned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignedTo { get; set; }
#nullable restore
#else
        public string AssignedTo { get; set; }
#endif
        /// <summary>The attack kill-chain category that the alert belongs to. Aligned with the MITRE ATT&amp;CK framework.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Category { get; set; }
#nullable restore
#else
        public string Category { get; set; }
#endif
        /// <summary>Specifies whether the alert represents a true threat. Possible values are: unknown, falsePositive, truePositive, benignPositive, unknownFutureValue.</summary>
        public AlertClassification? Classification { get; set; }
        /// <summary>Array of comments created by the Security Operations (SecOps) team during the alert management process.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AlertComment>? Comments { get; set; }
#nullable restore
#else
        public List<AlertComment> Comments { get; set; }
#endif
        /// <summary>Time when Microsoft 365 Defender created the alert.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>String value describing each alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Detection technology or sensor that identified the notable component or activity.</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.Security.DetectionSource? DetectionSource { get; set; }
        /// <summary>The ID of the detector that triggered the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DetectorId { get; set; }
#nullable restore
#else
        public string DetectorId { get; set; }
#endif
        /// <summary>Specifies the result of the investigation, whether the alert represents a true attack and if so, the nature of the attack. Possible values are: unknown, apt, malware, securityPersonnel, securityTesting, unwantedSoftware, other, multiStagedAttack, compromisedUser, phishing, maliciousUserActivity, clean, insufficientData, confirmedUserActivity, lineOfBusinessApplication, unknownFutureValue.</summary>
        public AlertDetermination? Determination { get; set; }
        /// <summary>Collection of evidence related to the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AlertEvidence>? Evidence { get; set; }
#nullable restore
#else
        public List<AlertEvidence> Evidence { get; set; }
#endif
        /// <summary>The earliest activity associated with the alert.</summary>
        public DateTimeOffset? FirstActivityDateTime { get; set; }
        /// <summary>Unique identifier to represent the incident this alert resource is associated with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IncidentId { get; set; }
#nullable restore
#else
        public string IncidentId { get; set; }
#endif
        /// <summary>URL for the incident page in the Microsoft 365 Defender portal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IncidentWebUrl { get; set; }
#nullable restore
#else
        public string IncidentWebUrl { get; set; }
#endif
        /// <summary>The oldest activity associated with the alert.</summary>
        public DateTimeOffset? LastActivityDateTime { get; set; }
        /// <summary>Time when the alert was last updated at Microsoft 365 Defender.</summary>
        public DateTimeOffset? LastUpdateDateTime { get; set; }
        /// <summary>The attack techniques, as aligned with the MITRE ATT&amp;CK framework.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? MitreTechniques { get; set; }
#nullable restore
#else
        public List<string> MitreTechniques { get; set; }
#endif
        /// <summary>The ID of the alert as it appears in the security provider product that generated the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProviderAlertId { get; set; }
#nullable restore
#else
        public string ProviderAlertId { get; set; }
#endif
        /// <summary>Recommended response and remediation actions to take in the event this alert was generated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecommendedActions { get; set; }
#nullable restore
#else
        public string RecommendedActions { get; set; }
#endif
        /// <summary>Time when the alert was resolved.</summary>
        public DateTimeOffset? ResolvedDateTime { get; set; }
        /// <summary>The serviceSource property</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.Security.ServiceSource? ServiceSource { get; set; }
        /// <summary>The severity property</summary>
        public AlertSeverity? Severity { get; set; }
        /// <summary>The status property</summary>
        public AlertStatus? Status { get; set; }
        /// <summary>The Azure Active Directory tenant the alert was created in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>The threat associated with this alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThreatDisplayName { get; set; }
#nullable restore
#else
        public string ThreatDisplayName { get; set; }
#endif
        /// <summary>Threat family associated with this alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThreatFamilyName { get; set; }
#nullable restore
#else
        public string ThreatFamilyName { get; set; }
#endif
        /// <summary>Brief identifying string value describing the alert.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Alert CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Alert();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"actorDisplayName", n => { ActorDisplayName = n.GetStringValue(); } },
                {"alertWebUrl", n => { AlertWebUrl = n.GetStringValue(); } },
                {"assignedTo", n => { AssignedTo = n.GetStringValue(); } },
                {"category", n => { Category = n.GetStringValue(); } },
                {"classification", n => { Classification = n.GetEnumValue<AlertClassification>(); } },
                {"comments", n => { Comments = n.GetCollectionOfObjectValues<AlertComment>(AlertComment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"detectionSource", n => { DetectionSource = n.GetEnumValue<DetectionSource>(); } },
                {"detectorId", n => { DetectorId = n.GetStringValue(); } },
                {"determination", n => { Determination = n.GetEnumValue<AlertDetermination>(); } },
                {"evidence", n => { Evidence = n.GetCollectionOfObjectValues<AlertEvidence>(AlertEvidence.CreateFromDiscriminatorValue)?.ToList(); } },
                {"firstActivityDateTime", n => { FirstActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"incidentId", n => { IncidentId = n.GetStringValue(); } },
                {"incidentWebUrl", n => { IncidentWebUrl = n.GetStringValue(); } },
                {"lastActivityDateTime", n => { LastActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastUpdateDateTime", n => { LastUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"mitreTechniques", n => { MitreTechniques = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"providerAlertId", n => { ProviderAlertId = n.GetStringValue(); } },
                {"recommendedActions", n => { RecommendedActions = n.GetStringValue(); } },
                {"resolvedDateTime", n => { ResolvedDateTime = n.GetDateTimeOffsetValue(); } },
                {"serviceSource", n => { ServiceSource = n.GetEnumValue<ServiceSource>(); } },
                {"severity", n => { Severity = n.GetEnumValue<AlertSeverity>(); } },
                {"status", n => { Status = n.GetEnumValue<AlertStatus>(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"threatDisplayName", n => { ThreatDisplayName = n.GetStringValue(); } },
                {"threatFamilyName", n => { ThreatFamilyName = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("actorDisplayName", ActorDisplayName);
            writer.WriteStringValue("alertWebUrl", AlertWebUrl);
            writer.WriteStringValue("assignedTo", AssignedTo);
            writer.WriteStringValue("category", Category);
            writer.WriteEnumValue<AlertClassification>("classification", Classification);
            writer.WriteCollectionOfObjectValues<AlertComment>("comments", Comments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteEnumValue<DetectionSource>("detectionSource", DetectionSource);
            writer.WriteStringValue("detectorId", DetectorId);
            writer.WriteEnumValue<AlertDetermination>("determination", Determination);
            writer.WriteCollectionOfObjectValues<AlertEvidence>("evidence", Evidence);
            writer.WriteDateTimeOffsetValue("firstActivityDateTime", FirstActivityDateTime);
            writer.WriteStringValue("incidentId", IncidentId);
            writer.WriteStringValue("incidentWebUrl", IncidentWebUrl);
            writer.WriteDateTimeOffsetValue("lastActivityDateTime", LastActivityDateTime);
            writer.WriteDateTimeOffsetValue("lastUpdateDateTime", LastUpdateDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("mitreTechniques", MitreTechniques);
            writer.WriteStringValue("providerAlertId", ProviderAlertId);
            writer.WriteStringValue("recommendedActions", RecommendedActions);
            writer.WriteDateTimeOffsetValue("resolvedDateTime", ResolvedDateTime);
            writer.WriteEnumValue<ServiceSource>("serviceSource", ServiceSource);
            writer.WriteEnumValue<AlertSeverity>("severity", Severity);
            writer.WriteEnumValue<AlertStatus>("status", Status);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("threatDisplayName", ThreatDisplayName);
            writer.WriteStringValue("threatFamilyName", ThreatFamilyName);
            writer.WriteStringValue("title", Title);
        }
    }
}
