using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class AndroidWorkProfileGeneralDeviceConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Indicates whether or not to block fingerprint unlock.</summary>
        public bool? PasswordBlockFingerprintUnlock { get; set; }
        /// <summary>Indicates whether or not to block Smart Lock and other trust agents.</summary>
        public bool? PasswordBlockTrustAgents { get; set; }
        /// <summary>Number of days before the password expires. Valid values 1 to 365</summary>
        public int? PasswordExpirationDays { get; set; }
        /// <summary>Minimum length of passwords. Valid values 4 to 16</summary>
        public int? PasswordMinimumLength { get; set; }
        /// <summary>Minutes of inactivity before the screen times out.</summary>
        public int? PasswordMinutesOfInactivityBeforeScreenTimeout { get; set; }
        /// <summary>Number of previous passwords to block. Valid values 0 to 24</summary>
        public int? PasswordPreviousPasswordBlockCount { get; set; }
        /// <summary>Android Work Profile required password type.</summary>
        public AndroidWorkProfileRequiredPasswordType? PasswordRequiredType { get; set; }
        /// <summary>Number of sign in failures allowed before factory reset. Valid values 1 to 16</summary>
        public int? PasswordSignInFailureCountBeforeFactoryReset { get; set; }
        /// <summary>Require the Android Verify apps feature is turned on.</summary>
        public bool? SecurityRequireVerifyApps { get; set; }
        /// <summary>Block users from adding/removing accounts in work profile.</summary>
        public bool? WorkProfileBlockAddingAccounts { get; set; }
        /// <summary>Block work profile camera.</summary>
        public bool? WorkProfileBlockCamera { get; set; }
        /// <summary>Block display work profile caller ID in personal profile.</summary>
        public bool? WorkProfileBlockCrossProfileCallerId { get; set; }
        /// <summary>Block work profile contacts availability in personal profile.</summary>
        public bool? WorkProfileBlockCrossProfileContactsSearch { get; set; }
        /// <summary>Boolean that indicates if the setting disallow cross profile copy/paste is enabled.</summary>
        public bool? WorkProfileBlockCrossProfileCopyPaste { get; set; }
        /// <summary>Indicates whether or not to block notifications while device locked.</summary>
        public bool? WorkProfileBlockNotificationsWhileDeviceLocked { get; set; }
        /// <summary>Block screen capture in work profile.</summary>
        public bool? WorkProfileBlockScreenCapture { get; set; }
        /// <summary>Allow bluetooth devices to access enterprise contacts.</summary>
        public bool? WorkProfileBluetoothEnableContactSharing { get; set; }
        /// <summary>Android Work Profile cross profile data sharing type.</summary>
        public AndroidWorkProfileCrossProfileDataSharingType? WorkProfileDataSharingType { get; set; }
        /// <summary>Android Work Profile default app permission policy type.</summary>
        public AndroidWorkProfileDefaultAppPermissionPolicyType? WorkProfileDefaultAppPermissionPolicy { get; set; }
        /// <summary>Indicates whether or not to block fingerprint unlock for work profile.</summary>
        public bool? WorkProfilePasswordBlockFingerprintUnlock { get; set; }
        /// <summary>Indicates whether or not to block Smart Lock and other trust agents for work profile.</summary>
        public bool? WorkProfilePasswordBlockTrustAgents { get; set; }
        /// <summary>Number of days before the work profile password expires. Valid values 1 to 365</summary>
        public int? WorkProfilePasswordExpirationDays { get; set; }
        /// <summary>Minimum length of work profile password. Valid values 4 to 16</summary>
        public int? WorkProfilePasswordMinimumLength { get; set; }
        /// <summary>Minimum # of letter characters required in work profile password. Valid values 1 to 10</summary>
        public int? WorkProfilePasswordMinLetterCharacters { get; set; }
        /// <summary>Minimum # of lower-case characters required in work profile password. Valid values 1 to 10</summary>
        public int? WorkProfilePasswordMinLowerCaseCharacters { get; set; }
        /// <summary>Minimum # of non-letter characters required in work profile password. Valid values 1 to 10</summary>
        public int? WorkProfilePasswordMinNonLetterCharacters { get; set; }
        /// <summary>Minimum # of numeric characters required in work profile password. Valid values 1 to 10</summary>
        public int? WorkProfilePasswordMinNumericCharacters { get; set; }
        /// <summary>Minimum # of symbols required in work profile password. Valid values 1 to 10</summary>
        public int? WorkProfilePasswordMinSymbolCharacters { get; set; }
        /// <summary>Minimum # of upper-case characters required in work profile password. Valid values 1 to 10</summary>
        public int? WorkProfilePasswordMinUpperCaseCharacters { get; set; }
        /// <summary>Minutes of inactivity before the screen times out.</summary>
        public int? WorkProfilePasswordMinutesOfInactivityBeforeScreenTimeout { get; set; }
        /// <summary>Number of previous work profile passwords to block. Valid values 0 to 24</summary>
        public int? WorkProfilePasswordPreviousPasswordBlockCount { get; set; }
        /// <summary>Android Work Profile required password type.</summary>
        public AndroidWorkProfileRequiredPasswordType? WorkProfilePasswordRequiredType { get; set; }
        /// <summary>Number of sign in failures allowed before work profile is removed and all corporate data deleted. Valid values 1 to 16</summary>
        public int? WorkProfilePasswordSignInFailureCountBeforeFactoryReset { get; set; }
        /// <summary>Password is required or not for work profile</summary>
        public bool? WorkProfileRequirePassword { get; set; }
        /// <summary>
        /// Instantiates a new AndroidWorkProfileGeneralDeviceConfiguration and sets the default values.
        /// </summary>
        public AndroidWorkProfileGeneralDeviceConfiguration() : base() {
            OdataType = "#microsoft.graph.androidWorkProfileGeneralDeviceConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AndroidWorkProfileGeneralDeviceConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AndroidWorkProfileGeneralDeviceConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"passwordBlockFingerprintUnlock", n => { PasswordBlockFingerprintUnlock = n.GetBoolValue(); } },
                {"passwordBlockTrustAgents", n => { PasswordBlockTrustAgents = n.GetBoolValue(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeScreenTimeout", n => { PasswordMinutesOfInactivityBeforeScreenTimeout = n.GetIntValue(); } },
                {"passwordPreviousPasswordBlockCount", n => { PasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<AndroidWorkProfileRequiredPasswordType>(); } },
                {"passwordSignInFailureCountBeforeFactoryReset", n => { PasswordSignInFailureCountBeforeFactoryReset = n.GetIntValue(); } },
                {"securityRequireVerifyApps", n => { SecurityRequireVerifyApps = n.GetBoolValue(); } },
                {"workProfileBlockAddingAccounts", n => { WorkProfileBlockAddingAccounts = n.GetBoolValue(); } },
                {"workProfileBlockCamera", n => { WorkProfileBlockCamera = n.GetBoolValue(); } },
                {"workProfileBlockCrossProfileCallerId", n => { WorkProfileBlockCrossProfileCallerId = n.GetBoolValue(); } },
                {"workProfileBlockCrossProfileContactsSearch", n => { WorkProfileBlockCrossProfileContactsSearch = n.GetBoolValue(); } },
                {"workProfileBlockCrossProfileCopyPaste", n => { WorkProfileBlockCrossProfileCopyPaste = n.GetBoolValue(); } },
                {"workProfileBlockNotificationsWhileDeviceLocked", n => { WorkProfileBlockNotificationsWhileDeviceLocked = n.GetBoolValue(); } },
                {"workProfileBlockScreenCapture", n => { WorkProfileBlockScreenCapture = n.GetBoolValue(); } },
                {"workProfileBluetoothEnableContactSharing", n => { WorkProfileBluetoothEnableContactSharing = n.GetBoolValue(); } },
                {"workProfileDataSharingType", n => { WorkProfileDataSharingType = n.GetEnumValue<AndroidWorkProfileCrossProfileDataSharingType>(); } },
                {"workProfileDefaultAppPermissionPolicy", n => { WorkProfileDefaultAppPermissionPolicy = n.GetEnumValue<AndroidWorkProfileDefaultAppPermissionPolicyType>(); } },
                {"workProfilePasswordBlockFingerprintUnlock", n => { WorkProfilePasswordBlockFingerprintUnlock = n.GetBoolValue(); } },
                {"workProfilePasswordBlockTrustAgents", n => { WorkProfilePasswordBlockTrustAgents = n.GetBoolValue(); } },
                {"workProfilePasswordExpirationDays", n => { WorkProfilePasswordExpirationDays = n.GetIntValue(); } },
                {"workProfilePasswordMinimumLength", n => { WorkProfilePasswordMinimumLength = n.GetIntValue(); } },
                {"workProfilePasswordMinLetterCharacters", n => { WorkProfilePasswordMinLetterCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinLowerCaseCharacters", n => { WorkProfilePasswordMinLowerCaseCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinNonLetterCharacters", n => { WorkProfilePasswordMinNonLetterCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinNumericCharacters", n => { WorkProfilePasswordMinNumericCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinSymbolCharacters", n => { WorkProfilePasswordMinSymbolCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinUpperCaseCharacters", n => { WorkProfilePasswordMinUpperCaseCharacters = n.GetIntValue(); } },
                {"workProfilePasswordMinutesOfInactivityBeforeScreenTimeout", n => { WorkProfilePasswordMinutesOfInactivityBeforeScreenTimeout = n.GetIntValue(); } },
                {"workProfilePasswordPreviousPasswordBlockCount", n => { WorkProfilePasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                {"workProfilePasswordRequiredType", n => { WorkProfilePasswordRequiredType = n.GetEnumValue<AndroidWorkProfileRequiredPasswordType>(); } },
                {"workProfilePasswordSignInFailureCountBeforeFactoryReset", n => { WorkProfilePasswordSignInFailureCountBeforeFactoryReset = n.GetIntValue(); } },
                {"workProfileRequirePassword", n => { WorkProfileRequirePassword = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("passwordBlockFingerprintUnlock", PasswordBlockFingerprintUnlock);
            writer.WriteBoolValue("passwordBlockTrustAgents", PasswordBlockTrustAgents);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeScreenTimeout", PasswordMinutesOfInactivityBeforeScreenTimeout);
            writer.WriteIntValue("passwordPreviousPasswordBlockCount", PasswordPreviousPasswordBlockCount);
            writer.WriteEnumValue<AndroidWorkProfileRequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteIntValue("passwordSignInFailureCountBeforeFactoryReset", PasswordSignInFailureCountBeforeFactoryReset);
            writer.WriteBoolValue("securityRequireVerifyApps", SecurityRequireVerifyApps);
            writer.WriteBoolValue("workProfileBlockAddingAccounts", WorkProfileBlockAddingAccounts);
            writer.WriteBoolValue("workProfileBlockCamera", WorkProfileBlockCamera);
            writer.WriteBoolValue("workProfileBlockCrossProfileCallerId", WorkProfileBlockCrossProfileCallerId);
            writer.WriteBoolValue("workProfileBlockCrossProfileContactsSearch", WorkProfileBlockCrossProfileContactsSearch);
            writer.WriteBoolValue("workProfileBlockCrossProfileCopyPaste", WorkProfileBlockCrossProfileCopyPaste);
            writer.WriteBoolValue("workProfileBlockNotificationsWhileDeviceLocked", WorkProfileBlockNotificationsWhileDeviceLocked);
            writer.WriteBoolValue("workProfileBlockScreenCapture", WorkProfileBlockScreenCapture);
            writer.WriteBoolValue("workProfileBluetoothEnableContactSharing", WorkProfileBluetoothEnableContactSharing);
            writer.WriteEnumValue<AndroidWorkProfileCrossProfileDataSharingType>("workProfileDataSharingType", WorkProfileDataSharingType);
            writer.WriteEnumValue<AndroidWorkProfileDefaultAppPermissionPolicyType>("workProfileDefaultAppPermissionPolicy", WorkProfileDefaultAppPermissionPolicy);
            writer.WriteBoolValue("workProfilePasswordBlockFingerprintUnlock", WorkProfilePasswordBlockFingerprintUnlock);
            writer.WriteBoolValue("workProfilePasswordBlockTrustAgents", WorkProfilePasswordBlockTrustAgents);
            writer.WriteIntValue("workProfilePasswordExpirationDays", WorkProfilePasswordExpirationDays);
            writer.WriteIntValue("workProfilePasswordMinimumLength", WorkProfilePasswordMinimumLength);
            writer.WriteIntValue("workProfilePasswordMinLetterCharacters", WorkProfilePasswordMinLetterCharacters);
            writer.WriteIntValue("workProfilePasswordMinLowerCaseCharacters", WorkProfilePasswordMinLowerCaseCharacters);
            writer.WriteIntValue("workProfilePasswordMinNonLetterCharacters", WorkProfilePasswordMinNonLetterCharacters);
            writer.WriteIntValue("workProfilePasswordMinNumericCharacters", WorkProfilePasswordMinNumericCharacters);
            writer.WriteIntValue("workProfilePasswordMinSymbolCharacters", WorkProfilePasswordMinSymbolCharacters);
            writer.WriteIntValue("workProfilePasswordMinUpperCaseCharacters", WorkProfilePasswordMinUpperCaseCharacters);
            writer.WriteIntValue("workProfilePasswordMinutesOfInactivityBeforeScreenTimeout", WorkProfilePasswordMinutesOfInactivityBeforeScreenTimeout);
            writer.WriteIntValue("workProfilePasswordPreviousPasswordBlockCount", WorkProfilePasswordPreviousPasswordBlockCount);
            writer.WriteEnumValue<AndroidWorkProfileRequiredPasswordType>("workProfilePasswordRequiredType", WorkProfilePasswordRequiredType);
            writer.WriteIntValue("workProfilePasswordSignInFailureCountBeforeFactoryReset", WorkProfilePasswordSignInFailureCountBeforeFactoryReset);
            writer.WriteBoolValue("workProfileRequirePassword", WorkProfileRequirePassword);
        }
    }
}
