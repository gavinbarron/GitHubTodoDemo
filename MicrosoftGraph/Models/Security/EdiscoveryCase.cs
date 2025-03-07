using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models.Security {
    public class EdiscoveryCase : Case, IParsable {
        /// <summary>The user who closed the case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.IdentitySet? ClosedBy { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.IdentitySet ClosedBy { get; set; }
#endif
        /// <summary>The date and time when the case was closed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ClosedDateTime { get; set; }
        /// <summary>Returns a list of case ediscoveryCustodian objects for this case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EdiscoveryCustodian>? Custodians { get; set; }
#nullable restore
#else
        public List<EdiscoveryCustodian> Custodians { get; set; }
#endif
        /// <summary>The external case number for customer reference.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId { get; set; }
#nullable restore
#else
        public string ExternalId { get; set; }
#endif
        /// <summary>Returns a list of case ediscoveryNoncustodialDataSource objects for this case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EdiscoveryNoncustodialDataSource>? NoncustodialDataSources { get; set; }
#nullable restore
#else
        public List<EdiscoveryNoncustodialDataSource> NoncustodialDataSources { get; set; }
#endif
        /// <summary>Returns a list of case caseOperation objects for this case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CaseOperation>? Operations { get; set; }
#nullable restore
#else
        public List<CaseOperation> Operations { get; set; }
#endif
        /// <summary>Returns a list of eDiscoveryReviewSet objects in the case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EdiscoveryReviewSet>? ReviewSets { get; set; }
#nullable restore
#else
        public List<EdiscoveryReviewSet> ReviewSets { get; set; }
#endif
        /// <summary>Returns a list of eDiscoverySearch objects associated with this case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EdiscoverySearch>? Searches { get; set; }
#nullable restore
#else
        public List<EdiscoverySearch> Searches { get; set; }
#endif
        /// <summary>Returns a list of eDIscoverySettings objects in the case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EdiscoveryCaseSettings? Settings { get; set; }
#nullable restore
#else
        public EdiscoveryCaseSettings Settings { get; set; }
#endif
        /// <summary>Returns a list of ediscoveryReviewTag objects associated to this case.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EdiscoveryReviewTag>? Tags { get; set; }
#nullable restore
#else
        public List<EdiscoveryReviewTag> Tags { get; set; }
#endif
        /// <summary>
        /// Instantiates a new EdiscoveryCase and sets the default values.
        /// </summary>
        public EdiscoveryCase() : base() {
            OdataType = "#microsoft.graph.security.ediscoveryCase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EdiscoveryCase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EdiscoveryCase();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"closedBy", n => { ClosedBy = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.IdentitySet>(GitHubTodoDemo.MicrosoftGraph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                {"closedDateTime", n => { ClosedDateTime = n.GetDateTimeOffsetValue(); } },
                {"custodians", n => { Custodians = n.GetCollectionOfObjectValues<EdiscoveryCustodian>(EdiscoveryCustodian.CreateFromDiscriminatorValue)?.ToList(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"noncustodialDataSources", n => { NoncustodialDataSources = n.GetCollectionOfObjectValues<EdiscoveryNoncustodialDataSource>(EdiscoveryNoncustodialDataSource.CreateFromDiscriminatorValue)?.ToList(); } },
                {"operations", n => { Operations = n.GetCollectionOfObjectValues<CaseOperation>(CaseOperation.CreateFromDiscriminatorValue)?.ToList(); } },
                {"reviewSets", n => { ReviewSets = n.GetCollectionOfObjectValues<EdiscoveryReviewSet>(EdiscoveryReviewSet.CreateFromDiscriminatorValue)?.ToList(); } },
                {"searches", n => { Searches = n.GetCollectionOfObjectValues<EdiscoverySearch>(EdiscoverySearch.CreateFromDiscriminatorValue)?.ToList(); } },
                {"settings", n => { Settings = n.GetObjectValue<EdiscoveryCaseSettings>(EdiscoveryCaseSettings.CreateFromDiscriminatorValue); } },
                {"tags", n => { Tags = n.GetCollectionOfObjectValues<EdiscoveryReviewTag>(EdiscoveryReviewTag.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.IdentitySet>("closedBy", ClosedBy);
            writer.WriteDateTimeOffsetValue("closedDateTime", ClosedDateTime);
            writer.WriteCollectionOfObjectValues<EdiscoveryCustodian>("custodians", Custodians);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteCollectionOfObjectValues<EdiscoveryNoncustodialDataSource>("noncustodialDataSources", NoncustodialDataSources);
            writer.WriteCollectionOfObjectValues<CaseOperation>("operations", Operations);
            writer.WriteCollectionOfObjectValues<EdiscoveryReviewSet>("reviewSets", ReviewSets);
            writer.WriteCollectionOfObjectValues<EdiscoverySearch>("searches", Searches);
            writer.WriteObjectValue<EdiscoveryCaseSettings>("settings", Settings);
            writer.WriteCollectionOfObjectValues<EdiscoveryReviewTag>("tags", Tags);
        }
    }
}
