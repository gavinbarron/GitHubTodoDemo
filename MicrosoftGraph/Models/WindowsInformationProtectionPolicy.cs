using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class WindowsInformationProtectionPolicy : WindowsInformationProtection, IParsable {
        /// <summary>Offline interval before app data is wiped (days)</summary>
        public int? DaysWithoutContactBeforeUnenroll { get; set; }
        /// <summary>Enrollment url for the MDM</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MdmEnrollmentUrl { get; set; }
#nullable restore
#else
        public string MdmEnrollmentUrl { get; set; }
#endif
        /// <summary>Specifies the maximum amount of time (in minutes) allowed after the device is idle that will cause the device to become PIN or password locked.   Range is an integer X where 0 &lt;= X &lt;= 999.</summary>
        public int? MinutesOfInactivityBeforeDeviceLock { get; set; }
        /// <summary>Integer value that specifies the number of past PINs that can be associated to a user account that can&apos;t be reused. The largest number you can configure for this policy setting is 50. The lowest number you can configure for this policy setting is 0. If this policy is set to 0, then storage of previous PINs is not required. This node was added in Windows 10, version 1511. Default is 0.</summary>
        public int? NumberOfPastPinsRemembered { get; set; }
        /// <summary>The number of authentication failures allowed before the device will be wiped. A value of 0 disables device wipe functionality. Range is an integer X where 4 &lt;= X &lt;= 16 for desktop and 0 &lt;= X &lt;= 999 for mobile devices.</summary>
        public int? PasswordMaximumAttemptCount { get; set; }
        /// <summary>Integer value specifies the period of time (in days) that a PIN can be used before the system requires the user to change it. The largest number you can configure for this policy setting is 730. The lowest number you can configure for this policy setting is 0. If this policy is set to 0, then the user&apos;s PIN will never expire. This node was added in Windows 10, version 1511. Default is 0.</summary>
        public int? PinExpirationDays { get; set; }
        /// <summary>Pin Character Requirements</summary>
        public WindowsInformationProtectionPinCharacterRequirements? PinLowercaseLetters { get; set; }
        /// <summary>Integer value that sets the minimum number of characters required for the PIN. Default value is 4. The lowest number you can configure for this policy setting is 4. The largest number you can configure must be less than the number configured in the Maximum PIN length policy setting or the number 127, whichever is the lowest.</summary>
        public int? PinMinimumLength { get; set; }
        /// <summary>Pin Character Requirements</summary>
        public WindowsInformationProtectionPinCharacterRequirements? PinSpecialCharacters { get; set; }
        /// <summary>Pin Character Requirements</summary>
        public WindowsInformationProtectionPinCharacterRequirements? PinUppercaseLetters { get; set; }
        /// <summary>New property in RS2, pending documentation</summary>
        public bool? RevokeOnMdmHandoffDisabled { get; set; }
        /// <summary>Boolean value that sets Windows Hello for Business as a method for signing into Windows.</summary>
        public bool? WindowsHelloForBusinessBlocked { get; set; }
        /// <summary>
        /// Instantiates a new WindowsInformationProtectionPolicy and sets the default values.
        /// </summary>
        public WindowsInformationProtectionPolicy() : base() {
            OdataType = "#microsoft.graph.windowsInformationProtectionPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsInformationProtectionPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsInformationProtectionPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"daysWithoutContactBeforeUnenroll", n => { DaysWithoutContactBeforeUnenroll = n.GetIntValue(); } },
                {"mdmEnrollmentUrl", n => { MdmEnrollmentUrl = n.GetStringValue(); } },
                {"minutesOfInactivityBeforeDeviceLock", n => { MinutesOfInactivityBeforeDeviceLock = n.GetIntValue(); } },
                {"numberOfPastPinsRemembered", n => { NumberOfPastPinsRemembered = n.GetIntValue(); } },
                {"passwordMaximumAttemptCount", n => { PasswordMaximumAttemptCount = n.GetIntValue(); } },
                {"pinExpirationDays", n => { PinExpirationDays = n.GetIntValue(); } },
                {"pinLowercaseLetters", n => { PinLowercaseLetters = n.GetEnumValue<WindowsInformationProtectionPinCharacterRequirements>(); } },
                {"pinMinimumLength", n => { PinMinimumLength = n.GetIntValue(); } },
                {"pinSpecialCharacters", n => { PinSpecialCharacters = n.GetEnumValue<WindowsInformationProtectionPinCharacterRequirements>(); } },
                {"pinUppercaseLetters", n => { PinUppercaseLetters = n.GetEnumValue<WindowsInformationProtectionPinCharacterRequirements>(); } },
                {"revokeOnMdmHandoffDisabled", n => { RevokeOnMdmHandoffDisabled = n.GetBoolValue(); } },
                {"windowsHelloForBusinessBlocked", n => { WindowsHelloForBusinessBlocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("daysWithoutContactBeforeUnenroll", DaysWithoutContactBeforeUnenroll);
            writer.WriteStringValue("mdmEnrollmentUrl", MdmEnrollmentUrl);
            writer.WriteIntValue("minutesOfInactivityBeforeDeviceLock", MinutesOfInactivityBeforeDeviceLock);
            writer.WriteIntValue("numberOfPastPinsRemembered", NumberOfPastPinsRemembered);
            writer.WriteIntValue("passwordMaximumAttemptCount", PasswordMaximumAttemptCount);
            writer.WriteIntValue("pinExpirationDays", PinExpirationDays);
            writer.WriteEnumValue<WindowsInformationProtectionPinCharacterRequirements>("pinLowercaseLetters", PinLowercaseLetters);
            writer.WriteIntValue("pinMinimumLength", PinMinimumLength);
            writer.WriteEnumValue<WindowsInformationProtectionPinCharacterRequirements>("pinSpecialCharacters", PinSpecialCharacters);
            writer.WriteEnumValue<WindowsInformationProtectionPinCharacterRequirements>("pinUppercaseLetters", PinUppercaseLetters);
            writer.WriteBoolValue("revokeOnMdmHandoffDisabled", RevokeOnMdmHandoffDisabled);
            writer.WriteBoolValue("windowsHelloForBusinessBlocked", WindowsHelloForBusinessBlocked);
        }
    }
}
