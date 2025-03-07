using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class Agreement : Entity, IParsable {
        /// <summary>Read-only. Information about acceptances of this agreement.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AgreementAcceptance>? Acceptances { get; set; }
#nullable restore
#else
        public List<AgreementAcceptance> Acceptances { get; set; }
#endif
        /// <summary>Display name of the agreement. The display name is used for internal tracking of the agreement but is not shown to end users who view the agreement. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Default PDF linked to this agreement.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AgreementFile? File { get; set; }
#nullable restore
#else
        public AgreementFile File { get; set; }
#endif
        /// <summary>PDFs linked to this agreement. This property is in the process of being deprecated. Use the  file property instead. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AgreementFileLocalization>? Files { get; set; }
#nullable restore
#else
        public List<AgreementFileLocalization> Files { get; set; }
#endif
        /// <summary>Indicates whether end users are required to accept this agreement on every device that they access it from. The end user is required to register their device in Azure AD, if they haven&apos;t already done so. Supports $filter (eq).</summary>
        public bool? IsPerDeviceAcceptanceRequired { get; set; }
        /// <summary>Indicates whether the user has to expand the agreement before accepting. Supports $filter (eq).</summary>
        public bool? IsViewingBeforeAcceptanceRequired { get; set; }
        /// <summary>Expiration schedule and frequency of agreement for all users. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.TermsExpiration? TermsExpiration { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.TermsExpiration TermsExpiration { get; set; }
#endif
        /// <summary>The duration after which the user must re-accept the terms of use. The value is represented in ISO 8601 format for durations. Supports $filter (eq).</summary>
        public TimeSpan? UserReacceptRequiredFrequency { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Agreement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Agreement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"acceptances", n => { Acceptances = n.GetCollectionOfObjectValues<AgreementAcceptance>(AgreementAcceptance.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"file", n => { File = n.GetObjectValue<AgreementFile>(AgreementFile.CreateFromDiscriminatorValue); } },
                {"files", n => { Files = n.GetCollectionOfObjectValues<AgreementFileLocalization>(AgreementFileLocalization.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isPerDeviceAcceptanceRequired", n => { IsPerDeviceAcceptanceRequired = n.GetBoolValue(); } },
                {"isViewingBeforeAcceptanceRequired", n => { IsViewingBeforeAcceptanceRequired = n.GetBoolValue(); } },
                {"termsExpiration", n => { TermsExpiration = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.TermsExpiration>(GitHubTodoDemo.MicrosoftGraph.Models.TermsExpiration.CreateFromDiscriminatorValue); } },
                {"userReacceptRequiredFrequency", n => { UserReacceptRequiredFrequency = n.GetTimeSpanValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AgreementAcceptance>("acceptances", Acceptances);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<AgreementFile>("file", File);
            writer.WriteCollectionOfObjectValues<AgreementFileLocalization>("files", Files);
            writer.WriteBoolValue("isPerDeviceAcceptanceRequired", IsPerDeviceAcceptanceRequired);
            writer.WriteBoolValue("isViewingBeforeAcceptanceRequired", IsViewingBeforeAcceptanceRequired);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.TermsExpiration>("termsExpiration", TermsExpiration);
            writer.WriteTimeSpanValue("userReacceptRequiredFrequency", UserReacceptRequiredFrequency);
        }
    }
}
