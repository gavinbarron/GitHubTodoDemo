using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>
    /// A termsAndConditions entity represents the metadata and contents of a given Terms and Conditions (T&amp;C) policy. T&amp;C policies’ contents are presented to users upon their first attempt to enroll into Intune and subsequently upon edits where an administrator has required re-acceptance. They enable administrators to communicate the provisions to which a user must agree in order to have devices enrolled into Intune.
    /// </summary>
    public class TermsAndConditions : Entity, IParsable {
        /// <summary>Administrator-supplied explanation of the terms and conditions, typically describing what it means to accept the terms and conditions set out in the T&amp;C policy. This is shown to the user on prompts to accept the T&amp;C policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AcceptanceStatement { get; set; }
#nullable restore
#else
        public string AcceptanceStatement { get; set; }
#endif
        /// <summary>The list of acceptance statuses for this T&amp;C policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TermsAndConditionsAcceptanceStatus>? AcceptanceStatuses { get; set; }
#nullable restore
#else
        public List<TermsAndConditionsAcceptanceStatus> AcceptanceStatuses { get; set; }
#endif
        /// <summary>The list of assignments for this T&amp;C policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TermsAndConditionsAssignment>? Assignments { get; set; }
#nullable restore
#else
        public List<TermsAndConditionsAssignment> Assignments { get; set; }
#endif
        /// <summary>Administrator-supplied body text of the terms and conditions, typically the terms themselves. This is shown to the user on prompts to accept the T&amp;C policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BodyText { get; set; }
#nullable restore
#else
        public string BodyText { get; set; }
#endif
        /// <summary>DateTime the object was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Administrator-supplied description of the T&amp;C policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Administrator-supplied name for the T&amp;C policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>DateTime the object was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Administrator-supplied title of the terms and conditions. This is shown to the user on prompts to accept the T&amp;C policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>Integer indicating the current version of the terms. Incremented when an administrator makes a change to the terms and wishes to require users to re-accept the modified T&amp;C policy.</summary>
        public int? Version { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TermsAndConditions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TermsAndConditions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"acceptanceStatement", n => { AcceptanceStatement = n.GetStringValue(); } },
                {"acceptanceStatuses", n => { AcceptanceStatuses = n.GetCollectionOfObjectValues<TermsAndConditionsAcceptanceStatus>(TermsAndConditionsAcceptanceStatus.CreateFromDiscriminatorValue)?.ToList(); } },
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<TermsAndConditionsAssignment>(TermsAndConditionsAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"bodyText", n => { BodyText = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"version", n => { Version = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("acceptanceStatement", AcceptanceStatement);
            writer.WriteCollectionOfObjectValues<TermsAndConditionsAcceptanceStatus>("acceptanceStatuses", AcceptanceStatuses);
            writer.WriteCollectionOfObjectValues<TermsAndConditionsAssignment>("assignments", Assignments);
            writer.WriteStringValue("bodyText", BodyText);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("title", Title);
            writer.WriteIntValue("version", Version);
        }
    }
}
