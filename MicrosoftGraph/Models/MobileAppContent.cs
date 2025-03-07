using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>
    /// Contains content properties for a specific app version. Each mobileAppContent can have multiple mobileAppContentFile.
    /// </summary>
    public class MobileAppContent : Entity, IParsable {
        /// <summary>The collection of contained apps in a MobileLobApp acting as a package.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MobileContainedApp>? ContainedApps { get; set; }
#nullable restore
#else
        public List<MobileContainedApp> ContainedApps { get; set; }
#endif
        /// <summary>The list of files for this app content version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MobileAppContentFile>? Files { get; set; }
#nullable restore
#else
        public List<MobileAppContentFile> Files { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MobileAppContent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileAppContent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"containedApps", n => { ContainedApps = n.GetCollectionOfObjectValues<MobileContainedApp>(MobileContainedApp.CreateFromDiscriminatorValue)?.ToList(); } },
                {"files", n => { Files = n.GetCollectionOfObjectValues<MobileAppContentFile>(MobileAppContentFile.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<MobileContainedApp>("containedApps", ContainedApps);
            writer.WriteCollectionOfObjectValues<MobileAppContentFile>("files", Files);
        }
    }
}
