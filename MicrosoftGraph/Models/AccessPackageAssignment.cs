using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class AccessPackageAssignment : Entity, IParsable {
        /// <summary>Read-only. Nullable. Supports $filter (eq) on the id property and $expand query parameters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.AccessPackage? AccessPackage { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.AccessPackage AccessPackage { get; set; }
#endif
        /// <summary>Read-only. Supports $filter (eq) on the id property and $expand query parameters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccessPackageAssignmentPolicy? AssignmentPolicy { get; set; }
#nullable restore
#else
        public AccessPackageAssignmentPolicy AssignmentPolicy { get; set; }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? ExpiredDateTime { get; set; }
        /// <summary>When the access assignment is to be in place. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EntitlementManagementSchedule? Schedule { get; set; }
#nullable restore
#else
        public EntitlementManagementSchedule Schedule { get; set; }
#endif
        /// <summary>The state of the access package assignment. The possible values are: delivering, partiallyDelivered, delivered, expired, deliveryFailed, unknownFutureValue. Read-only. Supports $filter (eq).</summary>
        public AccessPackageAssignmentState? State { get; set; }
        /// <summary>More information about the assignment lifecycle.  Possible values include Delivering, Delivered, NearExpiry1DayNotificationTriggered, or ExpiredNotificationTriggered.  Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>The subject of the access package assignment. Read-only. Nullable. Supports $expand. Supports $filter (eq) on objectId.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccessPackageSubject? Target { get; set; }
#nullable restore
#else
        public AccessPackageSubject Target { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessPackageAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessPackage", n => { AccessPackage = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.AccessPackage>(GitHubTodoDemo.MicrosoftGraph.Models.AccessPackage.CreateFromDiscriminatorValue); } },
                {"assignmentPolicy", n => { AssignmentPolicy = n.GetObjectValue<AccessPackageAssignmentPolicy>(AccessPackageAssignmentPolicy.CreateFromDiscriminatorValue); } },
                {"expiredDateTime", n => { ExpiredDateTime = n.GetDateTimeOffsetValue(); } },
                {"schedule", n => { Schedule = n.GetObjectValue<EntitlementManagementSchedule>(EntitlementManagementSchedule.CreateFromDiscriminatorValue); } },
                {"state", n => { State = n.GetEnumValue<AccessPackageAssignmentState>(); } },
                {"status", n => { Status = n.GetStringValue(); } },
                {"target", n => { Target = n.GetObjectValue<AccessPackageSubject>(AccessPackageSubject.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.AccessPackage>("accessPackage", AccessPackage);
            writer.WriteObjectValue<AccessPackageAssignmentPolicy>("assignmentPolicy", AssignmentPolicy);
            writer.WriteDateTimeOffsetValue("expiredDateTime", ExpiredDateTime);
            writer.WriteObjectValue<EntitlementManagementSchedule>("schedule", Schedule);
            writer.WriteEnumValue<AccessPackageAssignmentState>("state", State);
            writer.WriteStringValue("status", Status);
            writer.WriteObjectValue<AccessPackageSubject>("target", Target);
        }
    }
}
