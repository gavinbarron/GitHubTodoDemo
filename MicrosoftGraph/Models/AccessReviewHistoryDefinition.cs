using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class AccessReviewHistoryDefinition : Entity, IParsable {
        /// <summary>The createdBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserIdentity? CreatedBy { get; set; }
#nullable restore
#else
        public UserIdentity CreatedBy { get; set; }
#endif
        /// <summary>Timestamp when the access review definition was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Determines which review decisions will be included in the fetched review history data if specified. Optional on create. All decisions will be included by default if no decisions are provided on create. Possible values are: approve, deny, dontKnow, notReviewed, and notNotified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessReviewHistoryDecisionFilter?>? Decisions { get; set; }
#nullable restore
#else
        public List<AccessReviewHistoryDecisionFilter?> Decisions { get; set; }
#endif
        /// <summary>Name for the access review history data collection. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>If the accessReviewHistoryDefinition is a recurring definition, instances represent each recurrence. A definition that does not recur will have exactly one instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessReviewHistoryInstance>? Instances { get; set; }
#nullable restore
#else
        public List<AccessReviewHistoryInstance> Instances { get; set; }
#endif
        /// <summary>A timestamp. Reviews ending on or before this date will be included in the fetched history data. Only required if scheduleSettings is not defined.</summary>
        public DateTimeOffset? ReviewHistoryPeriodEndDateTime { get; set; }
        /// <summary>A timestamp. Reviews starting on or before this date will be included in the fetched history data. Only required if scheduleSettings is not defined.</summary>
        public DateTimeOffset? ReviewHistoryPeriodStartDateTime { get; set; }
        /// <summary>The settings for a recurring access review history definition series. Only required if reviewHistoryPeriodStartDateTime or reviewHistoryPeriodEndDateTime are not defined. Not supported yet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccessReviewHistoryScheduleSettings? ScheduleSettings { get; set; }
#nullable restore
#else
        public AccessReviewHistoryScheduleSettings ScheduleSettings { get; set; }
#endif
        /// <summary>Used to scope what reviews are included in the fetched history data. Fetches reviews whose scope matches with this provided scope. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AccessReviewScope>? Scopes { get; set; }
#nullable restore
#else
        public List<AccessReviewScope> Scopes { get; set; }
#endif
        /// <summary>Represents the status of the review history data collection. The possible values are: done, inProgress, error, requested, unknownFutureValue.</summary>
        public AccessReviewHistoryStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessReviewHistoryDefinition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReviewHistoryDefinition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdBy", n => { CreatedBy = n.GetObjectValue<UserIdentity>(UserIdentity.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"decisions", n => { Decisions = n.GetCollectionOfEnumValues<AccessReviewHistoryDecisionFilter>()?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"instances", n => { Instances = n.GetCollectionOfObjectValues<AccessReviewHistoryInstance>(AccessReviewHistoryInstance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"reviewHistoryPeriodEndDateTime", n => { ReviewHistoryPeriodEndDateTime = n.GetDateTimeOffsetValue(); } },
                {"reviewHistoryPeriodStartDateTime", n => { ReviewHistoryPeriodStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"scheduleSettings", n => { ScheduleSettings = n.GetObjectValue<AccessReviewHistoryScheduleSettings>(AccessReviewHistoryScheduleSettings.CreateFromDiscriminatorValue); } },
                {"scopes", n => { Scopes = n.GetCollectionOfObjectValues<AccessReviewScope>(AccessReviewScope.CreateFromDiscriminatorValue)?.ToList(); } },
                {"status", n => { Status = n.GetEnumValue<AccessReviewHistoryStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<UserIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfEnumValues<AccessReviewHistoryDecisionFilter>("decisions", Decisions);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<AccessReviewHistoryInstance>("instances", Instances);
            writer.WriteDateTimeOffsetValue("reviewHistoryPeriodEndDateTime", ReviewHistoryPeriodEndDateTime);
            writer.WriteDateTimeOffsetValue("reviewHistoryPeriodStartDateTime", ReviewHistoryPeriodStartDateTime);
            writer.WriteObjectValue<AccessReviewHistoryScheduleSettings>("scheduleSettings", ScheduleSettings);
            writer.WriteCollectionOfObjectValues<AccessReviewScope>("scopes", Scopes);
            writer.WriteEnumValue<AccessReviewHistoryStatus>("status", Status);
        }
    }
}
