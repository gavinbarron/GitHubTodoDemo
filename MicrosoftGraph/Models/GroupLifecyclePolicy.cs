using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class GroupLifecyclePolicy : Entity, IParsable {
        /// <summary>List of email address to send notifications for groups without owners. Multiple email address can be defined by separating email address with a semicolon.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlternateNotificationEmails { get; set; }
#nullable restore
#else
        public string AlternateNotificationEmails { get; set; }
#endif
        /// <summary>Number of days before a group expires and needs to be renewed. Once renewed, the group expiration is extended by the number of days defined.</summary>
        public int? GroupLifetimeInDays { get; set; }
        /// <summary>The group type for which the expiration policy applies. Possible values are All, Selected or None.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedGroupTypes { get; set; }
#nullable restore
#else
        public string ManagedGroupTypes { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GroupLifecyclePolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupLifecyclePolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alternateNotificationEmails", n => { AlternateNotificationEmails = n.GetStringValue(); } },
                {"groupLifetimeInDays", n => { GroupLifetimeInDays = n.GetIntValue(); } },
                {"managedGroupTypes", n => { ManagedGroupTypes = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("alternateNotificationEmails", AlternateNotificationEmails);
            writer.WriteIntValue("groupLifetimeInDays", GroupLifetimeInDays);
            writer.WriteStringValue("managedGroupTypes", ManagedGroupTypes);
        }
    }
}
