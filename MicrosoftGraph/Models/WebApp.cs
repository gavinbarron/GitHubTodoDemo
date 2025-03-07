using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class WebApp : MobileApp, IParsable {
        /// <summary>The web app URL. This property cannot be PATCHed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppUrl { get; set; }
#nullable restore
#else
        public string AppUrl { get; set; }
#endif
        /// <summary>Whether or not to use managed browser. This property is only applicable for Android and IOS.</summary>
        public bool? UseManagedBrowser { get; set; }
        /// <summary>
        /// Instantiates a new WebApp and sets the default values.
        /// </summary>
        public WebApp() : base() {
            OdataType = "#microsoft.graph.webApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WebApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WebApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appUrl", n => { AppUrl = n.GetStringValue(); } },
                {"useManagedBrowser", n => { UseManagedBrowser = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appUrl", AppUrl);
            writer.WriteBoolValue("useManagedBrowser", UseManagedBrowser);
        }
    }
}
