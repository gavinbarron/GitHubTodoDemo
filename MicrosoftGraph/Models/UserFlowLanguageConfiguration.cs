using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class UserFlowLanguageConfiguration : Entity, IParsable {
        /// <summary>Collection of pages with the default content to display in a user flow for a specified language. This collection does not allow any kind of modification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserFlowLanguagePage>? DefaultPages { get; set; }
#nullable restore
#else
        public List<UserFlowLanguagePage> DefaultPages { get; set; }
#endif
        /// <summary>The language name to display. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Indicates whether the language is enabled within the user flow.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>Collection of pages with the overrides messages to display in a user flow for a specified language. This collection only allows to modify the content of the page, any other modification is not allowed (creation or deletion of pages).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserFlowLanguagePage>? OverridesPages { get; set; }
#nullable restore
#else
        public List<UserFlowLanguagePage> OverridesPages { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserFlowLanguageConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserFlowLanguageConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"defaultPages", n => { DefaultPages = n.GetCollectionOfObjectValues<UserFlowLanguagePage>(UserFlowLanguagePage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"overridesPages", n => { OverridesPages = n.GetCollectionOfObjectValues<UserFlowLanguagePage>(UserFlowLanguagePage.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<UserFlowLanguagePage>("defaultPages", DefaultPages);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteCollectionOfObjectValues<UserFlowLanguagePage>("overridesPages", OverridesPages);
        }
    }
}
