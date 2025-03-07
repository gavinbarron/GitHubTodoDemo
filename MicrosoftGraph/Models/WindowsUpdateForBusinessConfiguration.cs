using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class WindowsUpdateForBusinessConfiguration : DeviceConfiguration, IParsable {
        /// <summary>When TRUE, allows eligible Windows 10 devices to upgrade to Windows 11. When FALSE, implies the device stays on the existing operating system. Returned by default. Query parameters are not supported.</summary>
        public bool? AllowWindows11Upgrade { get; set; }
        /// <summary>Possible values for automatic update mode.</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.AutomaticUpdateMode? AutomaticUpdateMode { get; set; }
        /// <summary>Auto restart required notification dismissal method</summary>
        public AutoRestartNotificationDismissalMethod? AutoRestartNotificationDismissal { get; set; }
        /// <summary>Which branch devices will receive their updates from</summary>
        public WindowsUpdateType? BusinessReadyUpdatesOnly { get; set; }
        /// <summary>Number of days before feature updates are installed automatically with valid range from 0 to 30 days. Returned by default. Query parameters are not supported.</summary>
        public int? DeadlineForFeatureUpdatesInDays { get; set; }
        /// <summary>Number of days before quality updates are installed automatically with valid range from 0 to 30 days. Returned by default. Query parameters are not supported.</summary>
        public int? DeadlineForQualityUpdatesInDays { get; set; }
        /// <summary>Number of days after deadline until restarts occur automatically with valid range from 0 to 7 days. Returned by default. Query parameters are not supported.</summary>
        public int? DeadlineGracePeriodInDays { get; set; }
        /// <summary>Delivery optimization mode for peer distribution</summary>
        public WindowsDeliveryOptimizationMode? DeliveryOptimizationMode { get; set; }
        /// <summary>When TRUE, excludes Windows update Drivers. When FALSE, does not exclude Windows update Drivers. Returned by default. Query parameters are not supported.</summary>
        public bool? DriversExcluded { get; set; }
        /// <summary>Deadline in days before automatically scheduling and executing a pending restart outside of active hours, with valid range from 2 to 30 days. Returned by default. Query parameters are not supported.</summary>
        public int? EngagedRestartDeadlineInDays { get; set; }
        /// <summary>Number of days a user can snooze Engaged Restart reminder notifications with valid range from 1 to 3 days. Returned by default. Query parameters are not supported.</summary>
        public int? EngagedRestartSnoozeScheduleInDays { get; set; }
        /// <summary>Number of days before transitioning from Auto Restarts scheduled outside of active hours to Engaged Restart, which requires the user to schedule, with valid range from 0 to 30 days. Returned by default. Query parameters are not supported.</summary>
        public int? EngagedRestartTransitionScheduleInDays { get; set; }
        /// <summary>Defer Feature Updates by these many days with valid range from 0 to 30 days. Returned by default. Query parameters are not supported.</summary>
        public int? FeatureUpdatesDeferralPeriodInDays { get; set; }
        /// <summary>When TRUE, assigned devices are paused from receiving feature updates for up to 35 days from the time you pause the ring. When FALSE, does not pause Feature Updates. Returned by default. Query parameters are not supported.s</summary>
        public bool? FeatureUpdatesPaused { get; set; }
        /// <summary>The Feature Updates Pause Expiry datetime. This value is 35 days from the time admin paused or extended the pause for the ring. Returned by default. Query parameters are not supported.</summary>
        public DateTimeOffset? FeatureUpdatesPauseExpiryDateTime { get; set; }
        /// <summary>The Feature Updates Pause start date. This value is the time when the admin paused or extended the pause for the ring. Returned by default. Query parameters are not supported. This property is read-only.</summary>
        public Date? FeatureUpdatesPauseStartDate { get; private set; }
        /// <summary>The Feature Updates Rollback Start datetime.This value is the time when the admin rolled back the Feature update for the ring.Returned by default.Query parameters are not supported.</summary>
        public DateTimeOffset? FeatureUpdatesRollbackStartDateTime { get; set; }
        /// <summary>The number of days after a Feature Update for which a rollback is valid with valid range from 2 to 60 days. Returned by default. Query parameters are not supported.</summary>
        public int? FeatureUpdatesRollbackWindowInDays { get; set; }
        /// <summary>When TRUE, rollback Feature Updates on the next device check in. When FALSE, do not rollback Feature Updates on the next device check in. Returned by default.Query parameters are not supported.</summary>
        public bool? FeatureUpdatesWillBeRolledBack { get; set; }
        /// <summary>The Installation Schedule. Possible values are: ActiveHoursStart, ActiveHoursEnd, ScheduledInstallDay, ScheduledInstallTime. Returned by default. Query parameters are not supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WindowsUpdateInstallScheduleType? InstallationSchedule { get; set; }
#nullable restore
#else
        public WindowsUpdateInstallScheduleType InstallationSchedule { get; set; }
#endif
        /// <summary>When TRUE, allows Microsoft Update Service. When FALSE, does not allow Microsoft Update Service. Returned by default. Query parameters are not supported.</summary>
        public bool? MicrosoftUpdateServiceAllowed { get; set; }
        /// <summary>When TRUE the device should wait until deadline for rebooting outside of active hours. When FALSE the device should not wait until deadline for rebooting outside of active hours. Returned by default. Query parameters are not supported.</summary>
        public bool? PostponeRebootUntilAfterDeadline { get; set; }
        /// <summary>Possible values for pre-release features.</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.PrereleaseFeatures? PrereleaseFeatures { get; set; }
        /// <summary>Defer Quality Updates by these many days with valid range from 0 to 30 days. Returned by default. Query parameters are not supported.</summary>
        public int? QualityUpdatesDeferralPeriodInDays { get; set; }
        /// <summary>When TRUE, assigned devices are paused from receiving quality updates for up to 35 days from the time you pause the ring. When FALSE, does not pause Quality Updates. Returned by default. Query parameters are not supported.</summary>
        public bool? QualityUpdatesPaused { get; set; }
        /// <summary>The Quality Updates Pause Expiry datetime. This value is 35 days from the time admin paused or extended the pause for the ring. Returned by default. Query parameters are not supported.</summary>
        public DateTimeOffset? QualityUpdatesPauseExpiryDateTime { get; set; }
        /// <summary>The Quality Updates Pause start date. This value is the time when the admin paused or extended the pause for the ring. Returned by default. Query parameters are not supported. This property is read-only.</summary>
        public Date? QualityUpdatesPauseStartDate { get; private set; }
        /// <summary>The Quality Updates Rollback Start datetime. This value is the time when the admin rolled back the Quality update for the ring. Returned by default. Query parameters are not supported.</summary>
        public DateTimeOffset? QualityUpdatesRollbackStartDateTime { get; set; }
        /// <summary>When TRUE, rollback Quality Updates on the next device check in. When FALSE, do not rollback Quality Updates on the next device check in. Returned by default. Query parameters are not supported.</summary>
        public bool? QualityUpdatesWillBeRolledBack { get; set; }
        /// <summary>Specify the period for auto-restart imminent warning notifications. Supported values: 15, 30 or 60 (minutes). Returned by default. Query parameters are not supported.</summary>
        public int? ScheduleImminentRestartWarningInMinutes { get; set; }
        /// <summary>Specify the period for auto-restart warning reminder notifications. Supported values: 2, 4, 8, 12 or 24 (hours). Returned by default. Query parameters are not supported.</summary>
        public int? ScheduleRestartWarningInHours { get; set; }
        /// <summary>When TRUE, skips all checks before restart: Battery level = 40%, User presence, Display Needed, Presentation mode, Full screen mode, phone call state, game mode etc. When FALSE, does not skip all checks before restart. Returned by default. Query parameters are not supported.</summary>
        public bool? SkipChecksBeforeRestart { get; set; }
        /// <summary>Windows Update Notification Display Options</summary>
        public WindowsUpdateNotificationDisplayOption? UpdateNotificationLevel { get; set; }
        /// <summary>Schedule the update installation on the weeks of the month. Possible values are: UserDefined, FirstWeek, SecondWeek, ThirdWeek, FourthWeek, EveryWeek. Returned by default. Query parameters are not supported. Possible values are: userDefined, firstWeek, secondWeek, thirdWeek, fourthWeek, everyWeek, unknownFutureValue.</summary>
        public WindowsUpdateForBusinessUpdateWeeks? UpdateWeeks { get; set; }
        /// <summary>Possible values of a property</summary>
        public Enablement? UserPauseAccess { get; set; }
        /// <summary>Possible values of a property</summary>
        public Enablement? UserWindowsUpdateScanAccess { get; set; }
        /// <summary>
        /// Instantiates a new WindowsUpdateForBusinessConfiguration and sets the default values.
        /// </summary>
        public WindowsUpdateForBusinessConfiguration() : base() {
            OdataType = "#microsoft.graph.windowsUpdateForBusinessConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsUpdateForBusinessConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsUpdateForBusinessConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowWindows11Upgrade", n => { AllowWindows11Upgrade = n.GetBoolValue(); } },
                {"automaticUpdateMode", n => { AutomaticUpdateMode = n.GetEnumValue<AutomaticUpdateMode>(); } },
                {"autoRestartNotificationDismissal", n => { AutoRestartNotificationDismissal = n.GetEnumValue<AutoRestartNotificationDismissalMethod>(); } },
                {"businessReadyUpdatesOnly", n => { BusinessReadyUpdatesOnly = n.GetEnumValue<WindowsUpdateType>(); } },
                {"deadlineForFeatureUpdatesInDays", n => { DeadlineForFeatureUpdatesInDays = n.GetIntValue(); } },
                {"deadlineForQualityUpdatesInDays", n => { DeadlineForQualityUpdatesInDays = n.GetIntValue(); } },
                {"deadlineGracePeriodInDays", n => { DeadlineGracePeriodInDays = n.GetIntValue(); } },
                {"deliveryOptimizationMode", n => { DeliveryOptimizationMode = n.GetEnumValue<WindowsDeliveryOptimizationMode>(); } },
                {"driversExcluded", n => { DriversExcluded = n.GetBoolValue(); } },
                {"engagedRestartDeadlineInDays", n => { EngagedRestartDeadlineInDays = n.GetIntValue(); } },
                {"engagedRestartSnoozeScheduleInDays", n => { EngagedRestartSnoozeScheduleInDays = n.GetIntValue(); } },
                {"engagedRestartTransitionScheduleInDays", n => { EngagedRestartTransitionScheduleInDays = n.GetIntValue(); } },
                {"featureUpdatesDeferralPeriodInDays", n => { FeatureUpdatesDeferralPeriodInDays = n.GetIntValue(); } },
                {"featureUpdatesPaused", n => { FeatureUpdatesPaused = n.GetBoolValue(); } },
                {"featureUpdatesPauseExpiryDateTime", n => { FeatureUpdatesPauseExpiryDateTime = n.GetDateTimeOffsetValue(); } },
                {"featureUpdatesPauseStartDate", n => { FeatureUpdatesPauseStartDate = n.GetDateValue(); } },
                {"featureUpdatesRollbackStartDateTime", n => { FeatureUpdatesRollbackStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"featureUpdatesRollbackWindowInDays", n => { FeatureUpdatesRollbackWindowInDays = n.GetIntValue(); } },
                {"featureUpdatesWillBeRolledBack", n => { FeatureUpdatesWillBeRolledBack = n.GetBoolValue(); } },
                {"installationSchedule", n => { InstallationSchedule = n.GetObjectValue<WindowsUpdateInstallScheduleType>(WindowsUpdateInstallScheduleType.CreateFromDiscriminatorValue); } },
                {"microsoftUpdateServiceAllowed", n => { MicrosoftUpdateServiceAllowed = n.GetBoolValue(); } },
                {"postponeRebootUntilAfterDeadline", n => { PostponeRebootUntilAfterDeadline = n.GetBoolValue(); } },
                {"prereleaseFeatures", n => { PrereleaseFeatures = n.GetEnumValue<PrereleaseFeatures>(); } },
                {"qualityUpdatesDeferralPeriodInDays", n => { QualityUpdatesDeferralPeriodInDays = n.GetIntValue(); } },
                {"qualityUpdatesPaused", n => { QualityUpdatesPaused = n.GetBoolValue(); } },
                {"qualityUpdatesPauseExpiryDateTime", n => { QualityUpdatesPauseExpiryDateTime = n.GetDateTimeOffsetValue(); } },
                {"qualityUpdatesPauseStartDate", n => { QualityUpdatesPauseStartDate = n.GetDateValue(); } },
                {"qualityUpdatesRollbackStartDateTime", n => { QualityUpdatesRollbackStartDateTime = n.GetDateTimeOffsetValue(); } },
                {"qualityUpdatesWillBeRolledBack", n => { QualityUpdatesWillBeRolledBack = n.GetBoolValue(); } },
                {"scheduleImminentRestartWarningInMinutes", n => { ScheduleImminentRestartWarningInMinutes = n.GetIntValue(); } },
                {"scheduleRestartWarningInHours", n => { ScheduleRestartWarningInHours = n.GetIntValue(); } },
                {"skipChecksBeforeRestart", n => { SkipChecksBeforeRestart = n.GetBoolValue(); } },
                {"updateNotificationLevel", n => { UpdateNotificationLevel = n.GetEnumValue<WindowsUpdateNotificationDisplayOption>(); } },
                {"updateWeeks", n => { UpdateWeeks = n.GetEnumValue<WindowsUpdateForBusinessUpdateWeeks>(); } },
                {"userPauseAccess", n => { UserPauseAccess = n.GetEnumValue<Enablement>(); } },
                {"userWindowsUpdateScanAccess", n => { UserWindowsUpdateScanAccess = n.GetEnumValue<Enablement>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowWindows11Upgrade", AllowWindows11Upgrade);
            writer.WriteEnumValue<AutomaticUpdateMode>("automaticUpdateMode", AutomaticUpdateMode);
            writer.WriteEnumValue<AutoRestartNotificationDismissalMethod>("autoRestartNotificationDismissal", AutoRestartNotificationDismissal);
            writer.WriteEnumValue<WindowsUpdateType>("businessReadyUpdatesOnly", BusinessReadyUpdatesOnly);
            writer.WriteIntValue("deadlineForFeatureUpdatesInDays", DeadlineForFeatureUpdatesInDays);
            writer.WriteIntValue("deadlineForQualityUpdatesInDays", DeadlineForQualityUpdatesInDays);
            writer.WriteIntValue("deadlineGracePeriodInDays", DeadlineGracePeriodInDays);
            writer.WriteEnumValue<WindowsDeliveryOptimizationMode>("deliveryOptimizationMode", DeliveryOptimizationMode);
            writer.WriteBoolValue("driversExcluded", DriversExcluded);
            writer.WriteIntValue("engagedRestartDeadlineInDays", EngagedRestartDeadlineInDays);
            writer.WriteIntValue("engagedRestartSnoozeScheduleInDays", EngagedRestartSnoozeScheduleInDays);
            writer.WriteIntValue("engagedRestartTransitionScheduleInDays", EngagedRestartTransitionScheduleInDays);
            writer.WriteIntValue("featureUpdatesDeferralPeriodInDays", FeatureUpdatesDeferralPeriodInDays);
            writer.WriteBoolValue("featureUpdatesPaused", FeatureUpdatesPaused);
            writer.WriteDateTimeOffsetValue("featureUpdatesPauseExpiryDateTime", FeatureUpdatesPauseExpiryDateTime);
            writer.WriteDateTimeOffsetValue("featureUpdatesRollbackStartDateTime", FeatureUpdatesRollbackStartDateTime);
            writer.WriteIntValue("featureUpdatesRollbackWindowInDays", FeatureUpdatesRollbackWindowInDays);
            writer.WriteBoolValue("featureUpdatesWillBeRolledBack", FeatureUpdatesWillBeRolledBack);
            writer.WriteObjectValue<WindowsUpdateInstallScheduleType>("installationSchedule", InstallationSchedule);
            writer.WriteBoolValue("microsoftUpdateServiceAllowed", MicrosoftUpdateServiceAllowed);
            writer.WriteBoolValue("postponeRebootUntilAfterDeadline", PostponeRebootUntilAfterDeadline);
            writer.WriteEnumValue<PrereleaseFeatures>("prereleaseFeatures", PrereleaseFeatures);
            writer.WriteIntValue("qualityUpdatesDeferralPeriodInDays", QualityUpdatesDeferralPeriodInDays);
            writer.WriteBoolValue("qualityUpdatesPaused", QualityUpdatesPaused);
            writer.WriteDateTimeOffsetValue("qualityUpdatesPauseExpiryDateTime", QualityUpdatesPauseExpiryDateTime);
            writer.WriteDateTimeOffsetValue("qualityUpdatesRollbackStartDateTime", QualityUpdatesRollbackStartDateTime);
            writer.WriteBoolValue("qualityUpdatesWillBeRolledBack", QualityUpdatesWillBeRolledBack);
            writer.WriteIntValue("scheduleImminentRestartWarningInMinutes", ScheduleImminentRestartWarningInMinutes);
            writer.WriteIntValue("scheduleRestartWarningInHours", ScheduleRestartWarningInHours);
            writer.WriteBoolValue("skipChecksBeforeRestart", SkipChecksBeforeRestart);
            writer.WriteEnumValue<WindowsUpdateNotificationDisplayOption>("updateNotificationLevel", UpdateNotificationLevel);
            writer.WriteEnumValue<WindowsUpdateForBusinessUpdateWeeks>("updateWeeks", UpdateWeeks);
            writer.WriteEnumValue<Enablement>("userPauseAccess", UserPauseAccess);
            writer.WriteEnumValue<Enablement>("userWindowsUpdateScanAccess", UserWindowsUpdateScanAccess);
        }
    }
}
