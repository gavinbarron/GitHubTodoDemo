using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class WorkbookTableSort : Entity, IParsable {
        /// <summary>Represents the current conditions used to last sort the table. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkbookSortField>? Fields { get; set; }
#nullable restore
#else
        public List<WorkbookSortField> Fields { get; set; }
#endif
        /// <summary>Represents whether the casing impacted the last sort of the table. Read-only.</summary>
        public bool? MatchCase { get; set; }
        /// <summary>Represents Chinese character ordering method last used to sort the table. The possible values are: PinYin, StrokeCount. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Method { get; set; }
#nullable restore
#else
        public string Method { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WorkbookTableSort CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkbookTableSort();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"fields", n => { Fields = n.GetCollectionOfObjectValues<WorkbookSortField>(WorkbookSortField.CreateFromDiscriminatorValue)?.ToList(); } },
                {"matchCase", n => { MatchCase = n.GetBoolValue(); } },
                {"method", n => { Method = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<WorkbookSortField>("fields", Fields);
            writer.WriteBoolValue("matchCase", MatchCase);
            writer.WriteStringValue("method", Method);
        }
    }
}
