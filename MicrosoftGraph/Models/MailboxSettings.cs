using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class MailboxSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Folder ID of an archive folder for the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ArchiveFolder { get; set; }
#nullable restore
#else
        public string ArchiveFolder { get; set; }
#endif
        /// <summary>Configuration settings to automatically notify the sender of an incoming email with a message from the signed-in user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.AutomaticRepliesSetting? AutomaticRepliesSetting { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.AutomaticRepliesSetting AutomaticRepliesSetting { get; set; }
#endif
        /// <summary>The date format for the user&apos;s mailbox.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DateFormat { get; set; }
#nullable restore
#else
        public string DateFormat { get; set; }
#endif
        /// <summary>If the user has a calendar delegate, this specifies whether the delegate, mailbox owner, or both receive meeting messages and meeting responses. Possible values are: sendToDelegateAndInformationToPrincipal, sendToDelegateAndPrincipal, sendToDelegateOnly.</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.DelegateMeetingMessageDeliveryOptions? DelegateMeetingMessageDeliveryOptions { get; set; }
        /// <summary>The locale information for the user, including the preferred language and country/region.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public LocaleInfo? Language { get; set; }
#nullable restore
#else
        public LocaleInfo Language { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The time format for the user&apos;s mailbox.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeFormat { get; set; }
#nullable restore
#else
        public string TimeFormat { get; set; }
#endif
        /// <summary>The default time zone for the user&apos;s mailbox.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeZone { get; set; }
#nullable restore
#else
        public string TimeZone { get; set; }
#endif
        /// <summary>The userPurpose property</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.UserPurpose? UserPurpose { get; set; }
        /// <summary>The days of the week and hours in a specific time zone that the user works.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.WorkingHours? WorkingHours { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.WorkingHours WorkingHours { get; set; }
#endif
        /// <summary>
        /// Instantiates a new mailboxSettings and sets the default values.
        /// </summary>
        public MailboxSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MailboxSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MailboxSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"archiveFolder", n => { ArchiveFolder = n.GetStringValue(); } },
                {"automaticRepliesSetting", n => { AutomaticRepliesSetting = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.AutomaticRepliesSetting>(GitHubTodoDemo.MicrosoftGraph.Models.AutomaticRepliesSetting.CreateFromDiscriminatorValue); } },
                {"dateFormat", n => { DateFormat = n.GetStringValue(); } },
                {"delegateMeetingMessageDeliveryOptions", n => { DelegateMeetingMessageDeliveryOptions = n.GetEnumValue<DelegateMeetingMessageDeliveryOptions>(); } },
                {"language", n => { Language = n.GetObjectValue<LocaleInfo>(LocaleInfo.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"timeFormat", n => { TimeFormat = n.GetStringValue(); } },
                {"timeZone", n => { TimeZone = n.GetStringValue(); } },
                {"userPurpose", n => { UserPurpose = n.GetEnumValue<UserPurpose>(); } },
                {"workingHours", n => { WorkingHours = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.WorkingHours>(GitHubTodoDemo.MicrosoftGraph.Models.WorkingHours.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("archiveFolder", ArchiveFolder);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.AutomaticRepliesSetting>("automaticRepliesSetting", AutomaticRepliesSetting);
            writer.WriteStringValue("dateFormat", DateFormat);
            writer.WriteEnumValue<DelegateMeetingMessageDeliveryOptions>("delegateMeetingMessageDeliveryOptions", DelegateMeetingMessageDeliveryOptions);
            writer.WriteObjectValue<LocaleInfo>("language", Language);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("timeFormat", TimeFormat);
            writer.WriteStringValue("timeZone", TimeZone);
            writer.WriteEnumValue<UserPurpose>("userPurpose", UserPurpose);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.WorkingHours>("workingHours", WorkingHours);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
