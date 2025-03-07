using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class Windows10SecureAssessmentConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Indicates whether or not to allow the app from printing during the test.</summary>
        public bool? AllowPrinting { get; set; }
        /// <summary>Indicates whether or not to allow screen capture capability during a test.</summary>
        public bool? AllowScreenCapture { get; set; }
        /// <summary>Indicates whether or not to allow text suggestions during the test.</summary>
        public bool? AllowTextSuggestion { get; set; }
        /// <summary>The account used to configure the Windows device for taking the test. The user can be a domain account (domain/user), an AAD account (username@tenant.com) or a local account (username).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConfigurationAccount { get; set; }
#nullable restore
#else
        public string ConfigurationAccount { get; set; }
#endif
        /// <summary>Url link to an assessment that&apos;s automatically loaded when the secure assessment browser is launched. It has to be a valid Url (http[s]://msdn.microsoft.com/).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LaunchUri { get; set; }
#nullable restore
#else
        public string LaunchUri { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Windows10SecureAssessmentConfiguration and sets the default values.
        /// </summary>
        public Windows10SecureAssessmentConfiguration() : base() {
            OdataType = "#microsoft.graph.windows10SecureAssessmentConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Windows10SecureAssessmentConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10SecureAssessmentConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowPrinting", n => { AllowPrinting = n.GetBoolValue(); } },
                {"allowScreenCapture", n => { AllowScreenCapture = n.GetBoolValue(); } },
                {"allowTextSuggestion", n => { AllowTextSuggestion = n.GetBoolValue(); } },
                {"configurationAccount", n => { ConfigurationAccount = n.GetStringValue(); } },
                {"launchUri", n => { LaunchUri = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowPrinting", AllowPrinting);
            writer.WriteBoolValue("allowScreenCapture", AllowScreenCapture);
            writer.WriteBoolValue("allowTextSuggestion", AllowTextSuggestion);
            writer.WriteStringValue("configurationAccount", ConfigurationAccount);
            writer.WriteStringValue("launchUri", LaunchUri);
        }
    }
}
