using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class IosVppEBook : ManagedEBook, IParsable {
        /// <summary>The Apple ID associated with Vpp token.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppleId { get; set; }
#nullable restore
#else
        public string AppleId { get; set; }
#endif
        /// <summary>Genres.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Genres { get; set; }
#nullable restore
#else
        public List<string> Genres { get; set; }
#endif
        /// <summary>Language.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Language { get; set; }
#nullable restore
#else
        public string Language { get; set; }
#endif
        /// <summary>Seller.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Seller { get; set; }
#nullable restore
#else
        public string Seller { get; set; }
#endif
        /// <summary>Total license count.</summary>
        public int? TotalLicenseCount { get; set; }
        /// <summary>Used license count.</summary>
        public int? UsedLicenseCount { get; set; }
        /// <summary>The Vpp token&apos;s organization name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VppOrganizationName { get; set; }
#nullable restore
#else
        public string VppOrganizationName { get; set; }
#endif
        /// <summary>The Vpp token ID.</summary>
        public Guid? VppTokenId { get; set; }
        /// <summary>
        /// Instantiates a new IosVppEBook and sets the default values.
        /// </summary>
        public IosVppEBook() : base() {
            OdataType = "#microsoft.graph.iosVppEBook";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IosVppEBook CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosVppEBook();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appleId", n => { AppleId = n.GetStringValue(); } },
                {"genres", n => { Genres = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"language", n => { Language = n.GetStringValue(); } },
                {"seller", n => { Seller = n.GetStringValue(); } },
                {"totalLicenseCount", n => { TotalLicenseCount = n.GetIntValue(); } },
                {"usedLicenseCount", n => { UsedLicenseCount = n.GetIntValue(); } },
                {"vppOrganizationName", n => { VppOrganizationName = n.GetStringValue(); } },
                {"vppTokenId", n => { VppTokenId = n.GetGuidValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appleId", AppleId);
            writer.WriteCollectionOfPrimitiveValues<string>("genres", Genres);
            writer.WriteStringValue("language", Language);
            writer.WriteStringValue("seller", Seller);
            writer.WriteIntValue("totalLicenseCount", TotalLicenseCount);
            writer.WriteIntValue("usedLicenseCount", UsedLicenseCount);
            writer.WriteStringValue("vppOrganizationName", VppOrganizationName);
            writer.WriteGuidValue("vppTokenId", VppTokenId);
        }
    }
}
