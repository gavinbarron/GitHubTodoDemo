using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class WindowsMicrosoftEdgeApp : MobileApp, IParsable {
        /// <summary>The enum to specify the channels for Microsoft Edge apps.</summary>
        public MicrosoftEdgeChannel? Channel { get; set; }
        /// <summary>The language locale to use when the Edge app displays text to the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayLanguageLocale { get; set; }
#nullable restore
#else
        public string DisplayLanguageLocale { get; set; }
#endif
        /// <summary>
        /// Instantiates a new WindowsMicrosoftEdgeApp and sets the default values.
        /// </summary>
        public WindowsMicrosoftEdgeApp() : base() {
            OdataType = "#microsoft.graph.windowsMicrosoftEdgeApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsMicrosoftEdgeApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsMicrosoftEdgeApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"channel", n => { Channel = n.GetEnumValue<MicrosoftEdgeChannel>(); } },
                {"displayLanguageLocale", n => { DisplayLanguageLocale = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<MicrosoftEdgeChannel>("channel", Channel);
            writer.WriteStringValue("displayLanguageLocale", DisplayLanguageLocale);
        }
    }
}
