using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class Windows81GeneralConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Indicates whether or not to Block the user from adding email accounts to the device that are not associated with a Microsoft account.</summary>
        public bool? AccountsBlockAddingNonMicrosoftAccountEmail { get; set; }
        /// <summary>Value indicating whether this policy only applies to Windows 8.1. This property is read-only.</summary>
        public bool? ApplyOnlyToWindows81 { get; private set; }
        /// <summary>Indicates whether or not to block auto fill.</summary>
        public bool? BrowserBlockAutofill { get; set; }
        /// <summary>Indicates whether or not to block automatic detection of Intranet sites.</summary>
        public bool? BrowserBlockAutomaticDetectionOfIntranetSites { get; set; }
        /// <summary>Indicates whether or not to block enterprise mode access.</summary>
        public bool? BrowserBlockEnterpriseModeAccess { get; set; }
        /// <summary>Indicates whether or not to Block the user from using JavaScript.</summary>
        public bool? BrowserBlockJavaScript { get; set; }
        /// <summary>Indicates whether or not to block plug-ins.</summary>
        public bool? BrowserBlockPlugins { get; set; }
        /// <summary>Indicates whether or not to block popups.</summary>
        public bool? BrowserBlockPopups { get; set; }
        /// <summary>Indicates whether or not to Block the user from sending the do not track header.</summary>
        public bool? BrowserBlockSendingDoNotTrackHeader { get; set; }
        /// <summary>Indicates whether or not to block a single word entry on Intranet sites.</summary>
        public bool? BrowserBlockSingleWordEntryOnIntranetSites { get; set; }
        /// <summary>The enterprise mode site list location. Could be a local file, local network or http location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BrowserEnterpriseModeSiteListLocation { get; set; }
#nullable restore
#else
        public string BrowserEnterpriseModeSiteListLocation { get; set; }
#endif
        /// <summary>Possible values for internet site security level.</summary>
        public InternetSiteSecurityLevel? BrowserInternetSecurityLevel { get; set; }
        /// <summary>Possible values for site security level.</summary>
        public SiteSecurityLevel? BrowserIntranetSecurityLevel { get; set; }
        /// <summary>The logging report location.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BrowserLoggingReportLocation { get; set; }
#nullable restore
#else
        public string BrowserLoggingReportLocation { get; set; }
#endif
        /// <summary>Indicates whether or not to require a firewall.</summary>
        public bool? BrowserRequireFirewall { get; set; }
        /// <summary>Indicates whether or not to require fraud warning.</summary>
        public bool? BrowserRequireFraudWarning { get; set; }
        /// <summary>Indicates whether or not to require high security for restricted sites.</summary>
        public bool? BrowserRequireHighSecurityForRestrictedSites { get; set; }
        /// <summary>Indicates whether or not to require the user to use the smart screen filter.</summary>
        public bool? BrowserRequireSmartScreen { get; set; }
        /// <summary>Possible values for site security level.</summary>
        public SiteSecurityLevel? BrowserTrustedSitesSecurityLevel { get; set; }
        /// <summary>Indicates whether or not to block data roaming.</summary>
        public bool? CellularBlockDataRoaming { get; set; }
        /// <summary>Indicates whether or not to block diagnostic data submission.</summary>
        public bool? DiagnosticsBlockDataSubmission { get; set; }
        /// <summary>Indicates whether or not to Block the user from using a pictures password and pin.</summary>
        public bool? PasswordBlockPicturePasswordAndPin { get; set; }
        /// <summary>Password expiration in days.</summary>
        public int? PasswordExpirationDays { get; set; }
        /// <summary>The number of character sets required in the password.</summary>
        public int? PasswordMinimumCharacterSetCount { get; set; }
        /// <summary>The minimum password length.</summary>
        public int? PasswordMinimumLength { get; set; }
        /// <summary>The minutes of inactivity before the screen times out.</summary>
        public int? PasswordMinutesOfInactivityBeforeScreenTimeout { get; set; }
        /// <summary>The number of previous passwords to prevent re-use of. Valid values 0 to 24</summary>
        public int? PasswordPreviousPasswordBlockCount { get; set; }
        /// <summary>Possible values of required passwords.</summary>
        public RequiredPasswordType? PasswordRequiredType { get; set; }
        /// <summary>The number of sign in failures before factory reset.</summary>
        public int? PasswordSignInFailureCountBeforeFactoryReset { get; set; }
        /// <summary>Indicates whether or not to require encryption on a mobile device.</summary>
        public bool? StorageRequireDeviceEncryption { get; set; }
        /// <summary>Indicates whether or not to require automatic updates.</summary>
        public bool? UpdatesRequireAutomaticUpdates { get; set; }
        /// <summary>Possible values for Windows user account control settings.</summary>
        public WindowsUserAccountControlSettings? UserAccountControlSettings { get; set; }
        /// <summary>The work folders url.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WorkFoldersUrl { get; set; }
#nullable restore
#else
        public string WorkFoldersUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Windows81GeneralConfiguration and sets the default values.
        /// </summary>
        public Windows81GeneralConfiguration() : base() {
            OdataType = "#microsoft.graph.windows81GeneralConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Windows81GeneralConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows81GeneralConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accountsBlockAddingNonMicrosoftAccountEmail", n => { AccountsBlockAddingNonMicrosoftAccountEmail = n.GetBoolValue(); } },
                {"applyOnlyToWindows81", n => { ApplyOnlyToWindows81 = n.GetBoolValue(); } },
                {"browserBlockAutofill", n => { BrowserBlockAutofill = n.GetBoolValue(); } },
                {"browserBlockAutomaticDetectionOfIntranetSites", n => { BrowserBlockAutomaticDetectionOfIntranetSites = n.GetBoolValue(); } },
                {"browserBlockEnterpriseModeAccess", n => { BrowserBlockEnterpriseModeAccess = n.GetBoolValue(); } },
                {"browserBlockJavaScript", n => { BrowserBlockJavaScript = n.GetBoolValue(); } },
                {"browserBlockPlugins", n => { BrowserBlockPlugins = n.GetBoolValue(); } },
                {"browserBlockPopups", n => { BrowserBlockPopups = n.GetBoolValue(); } },
                {"browserBlockSendingDoNotTrackHeader", n => { BrowserBlockSendingDoNotTrackHeader = n.GetBoolValue(); } },
                {"browserBlockSingleWordEntryOnIntranetSites", n => { BrowserBlockSingleWordEntryOnIntranetSites = n.GetBoolValue(); } },
                {"browserEnterpriseModeSiteListLocation", n => { BrowserEnterpriseModeSiteListLocation = n.GetStringValue(); } },
                {"browserInternetSecurityLevel", n => { BrowserInternetSecurityLevel = n.GetEnumValue<InternetSiteSecurityLevel>(); } },
                {"browserIntranetSecurityLevel", n => { BrowserIntranetSecurityLevel = n.GetEnumValue<SiteSecurityLevel>(); } },
                {"browserLoggingReportLocation", n => { BrowserLoggingReportLocation = n.GetStringValue(); } },
                {"browserRequireFirewall", n => { BrowserRequireFirewall = n.GetBoolValue(); } },
                {"browserRequireFraudWarning", n => { BrowserRequireFraudWarning = n.GetBoolValue(); } },
                {"browserRequireHighSecurityForRestrictedSites", n => { BrowserRequireHighSecurityForRestrictedSites = n.GetBoolValue(); } },
                {"browserRequireSmartScreen", n => { BrowserRequireSmartScreen = n.GetBoolValue(); } },
                {"browserTrustedSitesSecurityLevel", n => { BrowserTrustedSitesSecurityLevel = n.GetEnumValue<SiteSecurityLevel>(); } },
                {"cellularBlockDataRoaming", n => { CellularBlockDataRoaming = n.GetBoolValue(); } },
                {"diagnosticsBlockDataSubmission", n => { DiagnosticsBlockDataSubmission = n.GetBoolValue(); } },
                {"passwordBlockPicturePasswordAndPin", n => { PasswordBlockPicturePasswordAndPin = n.GetBoolValue(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordMinimumCharacterSetCount", n => { PasswordMinimumCharacterSetCount = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordMinutesOfInactivityBeforeScreenTimeout", n => { PasswordMinutesOfInactivityBeforeScreenTimeout = n.GetIntValue(); } },
                {"passwordPreviousPasswordBlockCount", n => { PasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                {"passwordRequiredType", n => { PasswordRequiredType = n.GetEnumValue<RequiredPasswordType>(); } },
                {"passwordSignInFailureCountBeforeFactoryReset", n => { PasswordSignInFailureCountBeforeFactoryReset = n.GetIntValue(); } },
                {"storageRequireDeviceEncryption", n => { StorageRequireDeviceEncryption = n.GetBoolValue(); } },
                {"updatesRequireAutomaticUpdates", n => { UpdatesRequireAutomaticUpdates = n.GetBoolValue(); } },
                {"userAccountControlSettings", n => { UserAccountControlSettings = n.GetEnumValue<WindowsUserAccountControlSettings>(); } },
                {"workFoldersUrl", n => { WorkFoldersUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("accountsBlockAddingNonMicrosoftAccountEmail", AccountsBlockAddingNonMicrosoftAccountEmail);
            writer.WriteBoolValue("browserBlockAutofill", BrowserBlockAutofill);
            writer.WriteBoolValue("browserBlockAutomaticDetectionOfIntranetSites", BrowserBlockAutomaticDetectionOfIntranetSites);
            writer.WriteBoolValue("browserBlockEnterpriseModeAccess", BrowserBlockEnterpriseModeAccess);
            writer.WriteBoolValue("browserBlockJavaScript", BrowserBlockJavaScript);
            writer.WriteBoolValue("browserBlockPlugins", BrowserBlockPlugins);
            writer.WriteBoolValue("browserBlockPopups", BrowserBlockPopups);
            writer.WriteBoolValue("browserBlockSendingDoNotTrackHeader", BrowserBlockSendingDoNotTrackHeader);
            writer.WriteBoolValue("browserBlockSingleWordEntryOnIntranetSites", BrowserBlockSingleWordEntryOnIntranetSites);
            writer.WriteStringValue("browserEnterpriseModeSiteListLocation", BrowserEnterpriseModeSiteListLocation);
            writer.WriteEnumValue<InternetSiteSecurityLevel>("browserInternetSecurityLevel", BrowserInternetSecurityLevel);
            writer.WriteEnumValue<SiteSecurityLevel>("browserIntranetSecurityLevel", BrowserIntranetSecurityLevel);
            writer.WriteStringValue("browserLoggingReportLocation", BrowserLoggingReportLocation);
            writer.WriteBoolValue("browserRequireFirewall", BrowserRequireFirewall);
            writer.WriteBoolValue("browserRequireFraudWarning", BrowserRequireFraudWarning);
            writer.WriteBoolValue("browserRequireHighSecurityForRestrictedSites", BrowserRequireHighSecurityForRestrictedSites);
            writer.WriteBoolValue("browserRequireSmartScreen", BrowserRequireSmartScreen);
            writer.WriteEnumValue<SiteSecurityLevel>("browserTrustedSitesSecurityLevel", BrowserTrustedSitesSecurityLevel);
            writer.WriteBoolValue("cellularBlockDataRoaming", CellularBlockDataRoaming);
            writer.WriteBoolValue("diagnosticsBlockDataSubmission", DiagnosticsBlockDataSubmission);
            writer.WriteBoolValue("passwordBlockPicturePasswordAndPin", PasswordBlockPicturePasswordAndPin);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordMinimumCharacterSetCount", PasswordMinimumCharacterSetCount);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordMinutesOfInactivityBeforeScreenTimeout", PasswordMinutesOfInactivityBeforeScreenTimeout);
            writer.WriteIntValue("passwordPreviousPasswordBlockCount", PasswordPreviousPasswordBlockCount);
            writer.WriteEnumValue<RequiredPasswordType>("passwordRequiredType", PasswordRequiredType);
            writer.WriteIntValue("passwordSignInFailureCountBeforeFactoryReset", PasswordSignInFailureCountBeforeFactoryReset);
            writer.WriteBoolValue("storageRequireDeviceEncryption", StorageRequireDeviceEncryption);
            writer.WriteBoolValue("updatesRequireAutomaticUpdates", UpdatesRequireAutomaticUpdates);
            writer.WriteEnumValue<WindowsUserAccountControlSettings>("userAccountControlSettings", UserAccountControlSettings);
            writer.WriteStringValue("workFoldersUrl", WorkFoldersUrl);
        }
    }
}
