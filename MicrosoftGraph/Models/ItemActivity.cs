using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class ItemActivity : Entity, IParsable {
        /// <summary>An item was accessed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccessAction? Access { get; set; }
#nullable restore
#else
        public AccessAction Access { get; set; }
#endif
        /// <summary>Details about when the activity took place. Read-only.</summary>
        public DateTimeOffset? ActivityDateTime { get; set; }
        /// <summary>Identity of who performed the action. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? Actor { get; set; }
#nullable restore
#else
        public IdentitySet Actor { get; set; }
#endif
        /// <summary>Exposes the driveItem that was the target of this activity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.DriveItem? DriveItem { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.DriveItem DriveItem { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ItemActivity CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ItemActivity();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"access", n => { Access = n.GetObjectValue<AccessAction>(AccessAction.CreateFromDiscriminatorValue); } },
                {"activityDateTime", n => { ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"actor", n => { Actor = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"driveItem", n => { DriveItem = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.DriveItem>(GitHubTodoDemo.MicrosoftGraph.Models.DriveItem.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<AccessAction>("access", Access);
            writer.WriteDateTimeOffsetValue("activityDateTime", ActivityDateTime);
            writer.WriteObjectValue<IdentitySet>("actor", Actor);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.DriveItem>("driveItem", DriveItem);
        }
    }
}
