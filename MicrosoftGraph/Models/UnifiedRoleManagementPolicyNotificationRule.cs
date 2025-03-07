using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class UnifiedRoleManagementPolicyNotificationRule : UnifiedRoleManagementPolicyRule, IParsable {
        /// <summary>Indicates whether a default recipient will receive the notification email.</summary>
        public bool? IsDefaultRecipientsEnabled { get; set; }
        /// <summary>The level of notification. The possible values are None, Critical, All.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NotificationLevel { get; set; }
#nullable restore
#else
        public string NotificationLevel { get; set; }
#endif
        /// <summary>The list of recipients of the email notifications.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? NotificationRecipients { get; set; }
#nullable restore
#else
        public List<string> NotificationRecipients { get; set; }
#endif
        /// <summary>The type of notification. Only Email is supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NotificationType { get; set; }
#nullable restore
#else
        public string NotificationType { get; set; }
#endif
        /// <summary>The type of recipient of the notification. The possible values are Requestor, Approver, Admin.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecipientType { get; set; }
#nullable restore
#else
        public string RecipientType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new UnifiedRoleManagementPolicyNotificationRule and sets the default values.
        /// </summary>
        public UnifiedRoleManagementPolicyNotificationRule() : base() {
            OdataType = "#microsoft.graph.unifiedRoleManagementPolicyNotificationRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UnifiedRoleManagementPolicyNotificationRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRoleManagementPolicyNotificationRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"isDefaultRecipientsEnabled", n => { IsDefaultRecipientsEnabled = n.GetBoolValue(); } },
                {"notificationLevel", n => { NotificationLevel = n.GetStringValue(); } },
                {"notificationRecipients", n => { NotificationRecipients = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"notificationType", n => { NotificationType = n.GetStringValue(); } },
                {"recipientType", n => { RecipientType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isDefaultRecipientsEnabled", IsDefaultRecipientsEnabled);
            writer.WriteStringValue("notificationLevel", NotificationLevel);
            writer.WriteCollectionOfPrimitiveValues<string>("notificationRecipients", NotificationRecipients);
            writer.WriteStringValue("notificationType", NotificationType);
            writer.WriteStringValue("recipientType", RecipientType);
        }
    }
}
