using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class WorkbookWorksheetProtection : Entity, IParsable {
        /// <summary>Sheet protection options. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkbookWorksheetProtectionOptions? Options { get; set; }
#nullable restore
#else
        public WorkbookWorksheetProtectionOptions Options { get; set; }
#endif
        /// <summary>Indicates if the worksheet is protected.  Read-only.</summary>
        public bool? Protected { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WorkbookWorksheetProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookWorksheetProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"options", n => { Options = n.GetObjectValue<WorkbookWorksheetProtectionOptions>(WorkbookWorksheetProtectionOptions.CreateFromDiscriminatorValue); } },
                {"protected", n => { Protected = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<WorkbookWorksheetProtectionOptions>("options", Options);
            writer.WriteBoolValue("protected", Protected);
        }
    }
}
