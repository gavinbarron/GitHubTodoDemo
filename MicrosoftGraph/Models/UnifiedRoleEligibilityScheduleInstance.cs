using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class UnifiedRoleEligibilityScheduleInstance : UnifiedRoleScheduleInstanceBase, IParsable {
        /// <summary>The end date of the schedule instance.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>How the role eligibility is inherited. It can either be Inherited, Direct, or Group. It can further imply whether the unifiedRoleEligibilitySchedule can be managed by the caller. Supports $filter (eq, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MemberType { get; set; }
#nullable restore
#else
        public string MemberType { get; set; }
#endif
        /// <summary>The identifier of the unifiedRoleEligibilitySchedule object from which this instance was created. Supports $filter (eq, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RoleEligibilityScheduleId { get; set; }
#nullable restore
#else
        public string RoleEligibilityScheduleId { get; set; }
#endif
        /// <summary>When this instance starts.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UnifiedRoleEligibilityScheduleInstance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleEligibilityScheduleInstance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"memberType", n => { MemberType = n.GetStringValue(); } },
                {"roleEligibilityScheduleId", n => { RoleEligibilityScheduleId = n.GetStringValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("memberType", MemberType);
            writer.WriteStringValue("roleEligibilityScheduleId", RoleEligibilityScheduleId);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
        }
    }
}
