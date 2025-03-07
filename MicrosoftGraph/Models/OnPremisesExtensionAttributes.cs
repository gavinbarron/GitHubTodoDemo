using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class OnPremisesExtensionAttributes : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>First customizable extension attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute1 { get; set; }
#nullable restore
#else
        public string ExtensionAttribute1 { get; set; }
#endif
        /// <summary>Tenth customizable extension attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute10 { get; set; }
#nullable restore
#else
        public string ExtensionAttribute10 { get; set; }
#endif
        /// <summary>Eleventh customizable extension attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute11 { get; set; }
#nullable restore
#else
        public string ExtensionAttribute11 { get; set; }
#endif
        /// <summary>Twelfth customizable extension attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute12 { get; set; }
#nullable restore
#else
        public string ExtensionAttribute12 { get; set; }
#endif
        /// <summary>Thirteenth customizable extension attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute13 { get; set; }
#nullable restore
#else
        public string ExtensionAttribute13 { get; set; }
#endif
        /// <summary>Fourteenth customizable extension attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute14 { get; set; }
#nullable restore
#else
        public string ExtensionAttribute14 { get; set; }
#endif
        /// <summary>Fifteenth customizable extension attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute15 { get; set; }
#nullable restore
#else
        public string ExtensionAttribute15 { get; set; }
#endif
        /// <summary>Second customizable extension attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute2 { get; set; }
#nullable restore
#else
        public string ExtensionAttribute2 { get; set; }
#endif
        /// <summary>Third customizable extension attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute3 { get; set; }
#nullable restore
#else
        public string ExtensionAttribute3 { get; set; }
#endif
        /// <summary>Fourth customizable extension attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute4 { get; set; }
#nullable restore
#else
        public string ExtensionAttribute4 { get; set; }
#endif
        /// <summary>Fifth customizable extension attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute5 { get; set; }
#nullable restore
#else
        public string ExtensionAttribute5 { get; set; }
#endif
        /// <summary>Sixth customizable extension attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute6 { get; set; }
#nullable restore
#else
        public string ExtensionAttribute6 { get; set; }
#endif
        /// <summary>Seventh customizable extension attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute7 { get; set; }
#nullable restore
#else
        public string ExtensionAttribute7 { get; set; }
#endif
        /// <summary>Eighth customizable extension attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute8 { get; set; }
#nullable restore
#else
        public string ExtensionAttribute8 { get; set; }
#endif
        /// <summary>Ninth customizable extension attribute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExtensionAttribute9 { get; set; }
#nullable restore
#else
        public string ExtensionAttribute9 { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new onPremisesExtensionAttributes and sets the default values.
        /// </summary>
        public OnPremisesExtensionAttributes() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OnPremisesExtensionAttributes CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnPremisesExtensionAttributes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"extensionAttribute1", n => { ExtensionAttribute1 = n.GetStringValue(); } },
                {"extensionAttribute10", n => { ExtensionAttribute10 = n.GetStringValue(); } },
                {"extensionAttribute11", n => { ExtensionAttribute11 = n.GetStringValue(); } },
                {"extensionAttribute12", n => { ExtensionAttribute12 = n.GetStringValue(); } },
                {"extensionAttribute13", n => { ExtensionAttribute13 = n.GetStringValue(); } },
                {"extensionAttribute14", n => { ExtensionAttribute14 = n.GetStringValue(); } },
                {"extensionAttribute15", n => { ExtensionAttribute15 = n.GetStringValue(); } },
                {"extensionAttribute2", n => { ExtensionAttribute2 = n.GetStringValue(); } },
                {"extensionAttribute3", n => { ExtensionAttribute3 = n.GetStringValue(); } },
                {"extensionAttribute4", n => { ExtensionAttribute4 = n.GetStringValue(); } },
                {"extensionAttribute5", n => { ExtensionAttribute5 = n.GetStringValue(); } },
                {"extensionAttribute6", n => { ExtensionAttribute6 = n.GetStringValue(); } },
                {"extensionAttribute7", n => { ExtensionAttribute7 = n.GetStringValue(); } },
                {"extensionAttribute8", n => { ExtensionAttribute8 = n.GetStringValue(); } },
                {"extensionAttribute9", n => { ExtensionAttribute9 = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("extensionAttribute1", ExtensionAttribute1);
            writer.WriteStringValue("extensionAttribute10", ExtensionAttribute10);
            writer.WriteStringValue("extensionAttribute11", ExtensionAttribute11);
            writer.WriteStringValue("extensionAttribute12", ExtensionAttribute12);
            writer.WriteStringValue("extensionAttribute13", ExtensionAttribute13);
            writer.WriteStringValue("extensionAttribute14", ExtensionAttribute14);
            writer.WriteStringValue("extensionAttribute15", ExtensionAttribute15);
            writer.WriteStringValue("extensionAttribute2", ExtensionAttribute2);
            writer.WriteStringValue("extensionAttribute3", ExtensionAttribute3);
            writer.WriteStringValue("extensionAttribute4", ExtensionAttribute4);
            writer.WriteStringValue("extensionAttribute5", ExtensionAttribute5);
            writer.WriteStringValue("extensionAttribute6", ExtensionAttribute6);
            writer.WriteStringValue("extensionAttribute7", ExtensionAttribute7);
            writer.WriteStringValue("extensionAttribute8", ExtensionAttribute8);
            writer.WriteStringValue("extensionAttribute9", ExtensionAttribute9);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
