using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class PlannerPlan : Entity, IParsable {
        /// <summary>Read-only. Nullable. Collection of buckets in the plan.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PlannerBucket>? Buckets { get; set; }
#nullable restore
#else
        public List<PlannerBucket> Buckets { get; set; }
#endif
        /// <summary>Identifies the container of the plan. Specify only the url, the containerId and type, or all properties. After it is set, this property can’t be updated. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerPlanContainer? Container { get; set; }
#nullable restore
#else
        public PlannerPlanContainer Container { get; set; }
#endif
        /// <summary>Read-only. The user who created the plan.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? CreatedBy { get; set; }
#nullable restore
#else
        public IdentitySet CreatedBy { get; set; }
#endif
        /// <summary>Read-only. Date and time at which the plan is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Read-only. Nullable. Additional details about the plan.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PlannerPlanDetails? Details { get; set; }
#nullable restore
#else
        public PlannerPlanDetails Details { get; set; }
#endif
        /// <summary>The owner property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Owner { get; set; }
#nullable restore
#else
        public string Owner { get; set; }
#endif
        /// <summary>Read-only. Nullable. Collection of tasks in the plan.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<PlannerTask>? Tasks { get; set; }
#nullable restore
#else
        public List<PlannerTask> Tasks { get; set; }
#endif
        /// <summary>Required. Title of the plan.</summary>
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
        public static new PlannerPlan CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerPlan();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"buckets", n => { Buckets = n.GetCollectionOfObjectValues<PlannerBucket>(PlannerBucket.CreateFromDiscriminatorValue)?.ToList(); } },
                {"container", n => { Container = n.GetObjectValue<PlannerPlanContainer>(PlannerPlanContainer.CreateFromDiscriminatorValue); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"details", n => { Details = n.GetObjectValue<PlannerPlanDetails>(PlannerPlanDetails.CreateFromDiscriminatorValue); } },
                {"owner", n => { Owner = n.GetStringValue(); } },
                {"tasks", n => { Tasks = n.GetCollectionOfObjectValues<PlannerTask>(PlannerTask.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<PlannerBucket>("buckets", Buckets);
            writer.WriteObjectValue<PlannerPlanContainer>("container", Container);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<PlannerPlanDetails>("details", Details);
            writer.WriteStringValue("owner", Owner);
            writer.WriteCollectionOfObjectValues<PlannerTask>("tasks", Tasks);
            writer.WriteStringValue("title", Title);
        }
    }
}
