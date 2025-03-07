using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>
    /// Devices that are managed or pre-enrolled through Intune
    /// </summary>
    public class ManagedDevice : Entity, IParsable {
        /// <summary>The code that allows the Activation Lock on managed device to be bypassed. Default, is Null (Non-Default property) for this property when returned as part of managedDevice entity in LIST call. Individual GET call with select query options is needed to retrieve actual values. Supports: $select. $Search is not supported. Read-only. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ActivationLockBypassCode { get; private set; }
#nullable restore
#else
        public string ActivationLockBypassCode { get; private set; }
#endif
        /// <summary>Android security patch level. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AndroidSecurityPatchLevel { get; private set; }
#nullable restore
#else
        public string AndroidSecurityPatchLevel { get; private set; }
#endif
        /// <summary>The unique identifier for the Azure Active Directory device. Read only. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AzureADDeviceId { get; private set; }
#nullable restore
#else
        public string AzureADDeviceId { get; private set; }
#endif
        /// <summary>Whether the device is Azure Active Directory registered. This property is read-only.</summary>
        public bool? AzureADRegistered { get; private set; }
        /// <summary>The DateTime when device compliance grace period expires. This property is read-only.</summary>
        public DateTimeOffset? ComplianceGracePeriodExpirationDateTime { get; private set; }
        /// <summary>Compliance state.</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.ComplianceState? ComplianceState { get; set; }
        /// <summary>ConfigrMgr client enabled features. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.ConfigurationManagerClientEnabledFeatures? ConfigurationManagerClientEnabledFeatures { get; private set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.ConfigurationManagerClientEnabledFeatures ConfigurationManagerClientEnabledFeatures { get; private set; }
#endif
        /// <summary>List of ComplexType deviceActionResult objects. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceActionResult>? DeviceActionResults { get; private set; }
#nullable restore
#else
        public List<DeviceActionResult> DeviceActionResults { get; private set; }
#endif
        /// <summary>Device category</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.DeviceCategory? DeviceCategory { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.DeviceCategory DeviceCategory { get; set; }
#endif
        /// <summary>Device category display name. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceCategoryDisplayName { get; private set; }
#nullable restore
#else
        public string DeviceCategoryDisplayName { get; private set; }
#endif
        /// <summary>Device compliance policy states for this device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceCompliancePolicyState>? DeviceCompliancePolicyStates { get; set; }
#nullable restore
#else
        public List<DeviceCompliancePolicyState> DeviceCompliancePolicyStates { get; set; }
#endif
        /// <summary>Device configuration states for this device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DeviceConfigurationState>? DeviceConfigurationStates { get; set; }
#nullable restore
#else
        public List<DeviceConfigurationState> DeviceConfigurationStates { get; set; }
#endif
        /// <summary>Possible ways of adding a mobile device to management.</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.DeviceEnrollmentType? DeviceEnrollmentType { get; set; }
        /// <summary>The device health attestation state. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.DeviceHealthAttestationState? DeviceHealthAttestationState { get; private set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.DeviceHealthAttestationState DeviceHealthAttestationState { get; private set; }
#endif
        /// <summary>Name of the device. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName { get; private set; }
#nullable restore
#else
        public string DeviceName { get; private set; }
#endif
        /// <summary>Device registration status.</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.DeviceRegistrationState? DeviceRegistrationState { get; set; }
        /// <summary>Whether the device is Exchange ActiveSync activated. This property is read-only.</summary>
        public bool? EasActivated { get; private set; }
        /// <summary>Exchange ActivationSync activation time of the device. This property is read-only.</summary>
        public DateTimeOffset? EasActivationDateTime { get; private set; }
        /// <summary>Exchange ActiveSync Id of the device. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EasDeviceId { get; private set; }
#nullable restore
#else
        public string EasDeviceId { get; private set; }
#endif
        /// <summary>Email(s) for the user associated with the device. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailAddress { get; private set; }
#nullable restore
#else
        public string EmailAddress { get; private set; }
#endif
        /// <summary>Enrollment time of the device. This property is read-only.</summary>
        public DateTimeOffset? EnrolledDateTime { get; private set; }
        /// <summary>Ethernet MAC. Default, is Null (Non-Default property) for this property when returned as part of managedDevice entity. Individual get call with select query options is needed to retrieve actual values. Example: deviceManagement/managedDevices({managedDeviceId})?$select=ethernetMacAddress Supports: $select. $Search is not supported. Read-only. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EthernetMacAddress { get; private set; }
#nullable restore
#else
        public string EthernetMacAddress { get; private set; }
#endif
        /// <summary>Device Exchange Access State.</summary>
        public DeviceManagementExchangeAccessState? ExchangeAccessState { get; set; }
        /// <summary>Device Exchange Access State Reason.</summary>
        public DeviceManagementExchangeAccessStateReason? ExchangeAccessStateReason { get; set; }
        /// <summary>Last time the device contacted Exchange. This property is read-only.</summary>
        public DateTimeOffset? ExchangeLastSuccessfulSyncDateTime { get; private set; }
        /// <summary>Free Storage in Bytes. Default value is 0. Read-only. This property is read-only.</summary>
        public long? FreeStorageSpaceInBytes { get; private set; }
        /// <summary>Integrated Circuit Card Identifier, it is A SIM card&apos;s unique identification number. Return default value null in LIST managedDevices. Real value only returned in singel device GET call with device id and included in select parameter. Supports: $select. $Search is not supported. Read-only. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Iccid { get; private set; }
#nullable restore
#else
        public string Iccid { get; private set; }
#endif
        /// <summary>IMEI. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Imei { get; private set; }
#nullable restore
#else
        public string Imei { get; private set; }
#endif
        /// <summary>Device encryption status. This property is read-only.</summary>
        public bool? IsEncrypted { get; private set; }
        /// <summary>Device supervised status. This property is read-only.</summary>
        public bool? IsSupervised { get; private set; }
        /// <summary>whether the device is jail broken or rooted. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JailBroken { get; private set; }
#nullable restore
#else
        public string JailBroken { get; private set; }
#endif
        /// <summary>The date and time that the device last completed a successful sync with Intune. This property is read-only.</summary>
        public DateTimeOffset? LastSyncDateTime { get; private set; }
        /// <summary>Automatically generated name to identify a device. Can be overwritten to a user friendly name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagedDeviceName { get; set; }
#nullable restore
#else
        public string ManagedDeviceName { get; set; }
#endif
        /// <summary>Owner type of device.</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.ManagedDeviceOwnerType? ManagedDeviceOwnerType { get; set; }
        /// <summary>The managementAgent property</summary>
        public ManagementAgentType? ManagementAgent { get; set; }
        /// <summary>Reports device management certificate expiration date. This property is read-only.</summary>
        public DateTimeOffset? ManagementCertificateExpirationDate { get; private set; }
        /// <summary>Manufacturer of the device. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer { get; private set; }
#nullable restore
#else
        public string Manufacturer { get; private set; }
#endif
        /// <summary>MEID. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Meid { get; private set; }
#nullable restore
#else
        public string Meid { get; private set; }
#endif
        /// <summary>Model of the device. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model { get; private set; }
#nullable restore
#else
        public string Model { get; private set; }
#endif
        /// <summary>Notes on the device created by IT Admin. Return default value null in LIST managedDevices. Real value only returned in singel device GET call with device id and included in select parameter. Supports: $select.  $Search is not supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Notes { get; set; }
#nullable restore
#else
        public string Notes { get; set; }
#endif
        /// <summary>Operating system of the device. Windows, iOS, etc. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperatingSystem { get; private set; }
#nullable restore
#else
        public string OperatingSystem { get; private set; }
#endif
        /// <summary>Operating system version of the device. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsVersion { get; private set; }
#nullable restore
#else
        public string OsVersion { get; private set; }
#endif
        /// <summary>Available health states for the Device Health API</summary>
        public ManagedDevicePartnerReportedHealthState? PartnerReportedThreatState { get; set; }
        /// <summary>Phone number of the device. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneNumber { get; private set; }
#nullable restore
#else
        public string PhoneNumber { get; private set; }
#endif
        /// <summary>Total Memory in Bytes. Return default value 0 in LIST managedDevices. Real value only returned in singel device GET call with device id and included in select parameter. Supports: $select. Default value is 0. Read-only. This property is read-only.</summary>
        public long? PhysicalMemoryInBytes { get; private set; }
        /// <summary>An error string that identifies issues when creating Remote Assistance session objects. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemoteAssistanceSessionErrorDetails { get; private set; }
#nullable restore
#else
        public string RemoteAssistanceSessionErrorDetails { get; private set; }
#endif
        /// <summary>Url that allows a Remote Assistance session to be established with the device. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemoteAssistanceSessionUrl { get; private set; }
#nullable restore
#else
        public string RemoteAssistanceSessionUrl { get; private set; }
#endif
        /// <summary>Reports if the managed iOS device is user approval enrollment. This property is read-only.</summary>
        public bool? RequireUserEnrollmentApproval { get; private set; }
        /// <summary>SerialNumber. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SerialNumber { get; private set; }
#nullable restore
#else
        public string SerialNumber { get; private set; }
#endif
        /// <summary>Subscriber Carrier. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SubscriberCarrier { get; private set; }
#nullable restore
#else
        public string SubscriberCarrier { get; private set; }
#endif
        /// <summary>Total Storage in Bytes. This property is read-only.</summary>
        public long? TotalStorageSpaceInBytes { get; private set; }
        /// <summary>Unique Device Identifier for iOS and macOS devices. Return default value null in LIST managedDevices. Real value only returned in singel device GET call with device id and included in select parameter. Supports: $select. $Search is not supported. Read-only. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Udid { get; private set; }
#nullable restore
#else
        public string Udid { get; private set; }
#endif
        /// <summary>User display name. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserDisplayName { get; private set; }
#nullable restore
#else
        public string UserDisplayName { get; private set; }
#endif
        /// <summary>Unique Identifier for the user associated with the device. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; private set; }
#nullable restore
#else
        public string UserId { get; private set; }
#endif
        /// <summary>Device user principal name. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName { get; private set; }
#nullable restore
#else
        public string UserPrincipalName { get; private set; }
#endif
        /// <summary>The primary users associated with the managed device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<User>? Users { get; set; }
#nullable restore
#else
        public List<User> Users { get; set; }
#endif
        /// <summary>Wi-Fi MAC. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WiFiMacAddress { get; private set; }
#nullable restore
#else
        public string WiFiMacAddress { get; private set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ManagedDevice CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedDevice();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activationLockBypassCode", n => { ActivationLockBypassCode = n.GetStringValue(); } },
                {"androidSecurityPatchLevel", n => { AndroidSecurityPatchLevel = n.GetStringValue(); } },
                {"azureADDeviceId", n => { AzureADDeviceId = n.GetStringValue(); } },
                {"azureADRegistered", n => { AzureADRegistered = n.GetBoolValue(); } },
                {"complianceGracePeriodExpirationDateTime", n => { ComplianceGracePeriodExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"complianceState", n => { ComplianceState = n.GetEnumValue<ComplianceState>(); } },
                {"configurationManagerClientEnabledFeatures", n => { ConfigurationManagerClientEnabledFeatures = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.ConfigurationManagerClientEnabledFeatures>(GitHubTodoDemo.MicrosoftGraph.Models.ConfigurationManagerClientEnabledFeatures.CreateFromDiscriminatorValue); } },
                {"deviceActionResults", n => { DeviceActionResults = n.GetCollectionOfObjectValues<DeviceActionResult>(DeviceActionResult.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceCategory", n => { DeviceCategory = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.DeviceCategory>(GitHubTodoDemo.MicrosoftGraph.Models.DeviceCategory.CreateFromDiscriminatorValue); } },
                {"deviceCategoryDisplayName", n => { DeviceCategoryDisplayName = n.GetStringValue(); } },
                {"deviceCompliancePolicyStates", n => { DeviceCompliancePolicyStates = n.GetCollectionOfObjectValues<DeviceCompliancePolicyState>(DeviceCompliancePolicyState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceConfigurationStates", n => { DeviceConfigurationStates = n.GetCollectionOfObjectValues<DeviceConfigurationState>(DeviceConfigurationState.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceEnrollmentType", n => { DeviceEnrollmentType = n.GetEnumValue<DeviceEnrollmentType>(); } },
                {"deviceHealthAttestationState", n => { DeviceHealthAttestationState = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.DeviceHealthAttestationState>(GitHubTodoDemo.MicrosoftGraph.Models.DeviceHealthAttestationState.CreateFromDiscriminatorValue); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"deviceRegistrationState", n => { DeviceRegistrationState = n.GetEnumValue<DeviceRegistrationState>(); } },
                {"easActivated", n => { EasActivated = n.GetBoolValue(); } },
                {"easActivationDateTime", n => { EasActivationDateTime = n.GetDateTimeOffsetValue(); } },
                {"easDeviceId", n => { EasDeviceId = n.GetStringValue(); } },
                {"emailAddress", n => { EmailAddress = n.GetStringValue(); } },
                {"enrolledDateTime", n => { EnrolledDateTime = n.GetDateTimeOffsetValue(); } },
                {"ethernetMacAddress", n => { EthernetMacAddress = n.GetStringValue(); } },
                {"exchangeAccessState", n => { ExchangeAccessState = n.GetEnumValue<DeviceManagementExchangeAccessState>(); } },
                {"exchangeAccessStateReason", n => { ExchangeAccessStateReason = n.GetEnumValue<DeviceManagementExchangeAccessStateReason>(); } },
                {"exchangeLastSuccessfulSyncDateTime", n => { ExchangeLastSuccessfulSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"freeStorageSpaceInBytes", n => { FreeStorageSpaceInBytes = n.GetLongValue(); } },
                {"iccid", n => { Iccid = n.GetStringValue(); } },
                {"imei", n => { Imei = n.GetStringValue(); } },
                {"isEncrypted", n => { IsEncrypted = n.GetBoolValue(); } },
                {"isSupervised", n => { IsSupervised = n.GetBoolValue(); } },
                {"jailBroken", n => { JailBroken = n.GetStringValue(); } },
                {"lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDeviceName", n => { ManagedDeviceName = n.GetStringValue(); } },
                {"managedDeviceOwnerType", n => { ManagedDeviceOwnerType = n.GetEnumValue<ManagedDeviceOwnerType>(); } },
                {"managementAgent", n => { ManagementAgent = n.GetEnumValue<ManagementAgentType>(); } },
                {"managementCertificateExpirationDate", n => { ManagementCertificateExpirationDate = n.GetDateTimeOffsetValue(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"meid", n => { Meid = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"notes", n => { Notes = n.GetStringValue(); } },
                {"operatingSystem", n => { OperatingSystem = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"partnerReportedThreatState", n => { PartnerReportedThreatState = n.GetEnumValue<ManagedDevicePartnerReportedHealthState>(); } },
                {"phoneNumber", n => { PhoneNumber = n.GetStringValue(); } },
                {"physicalMemoryInBytes", n => { PhysicalMemoryInBytes = n.GetLongValue(); } },
                {"remoteAssistanceSessionErrorDetails", n => { RemoteAssistanceSessionErrorDetails = n.GetStringValue(); } },
                {"remoteAssistanceSessionUrl", n => { RemoteAssistanceSessionUrl = n.GetStringValue(); } },
                {"requireUserEnrollmentApproval", n => { RequireUserEnrollmentApproval = n.GetBoolValue(); } },
                {"serialNumber", n => { SerialNumber = n.GetStringValue(); } },
                {"subscriberCarrier", n => { SubscriberCarrier = n.GetStringValue(); } },
                {"totalStorageSpaceInBytes", n => { TotalStorageSpaceInBytes = n.GetLongValue(); } },
                {"udid", n => { Udid = n.GetStringValue(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"users", n => { Users = n.GetCollectionOfObjectValues<User>(User.CreateFromDiscriminatorValue)?.ToList(); } },
                {"wiFiMacAddress", n => { WiFiMacAddress = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<ComplianceState>("complianceState", ComplianceState);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.DeviceCategory>("deviceCategory", DeviceCategory);
            writer.WriteCollectionOfObjectValues<DeviceCompliancePolicyState>("deviceCompliancePolicyStates", DeviceCompliancePolicyStates);
            writer.WriteCollectionOfObjectValues<DeviceConfigurationState>("deviceConfigurationStates", DeviceConfigurationStates);
            writer.WriteEnumValue<DeviceEnrollmentType>("deviceEnrollmentType", DeviceEnrollmentType);
            writer.WriteEnumValue<DeviceRegistrationState>("deviceRegistrationState", DeviceRegistrationState);
            writer.WriteEnumValue<DeviceManagementExchangeAccessState>("exchangeAccessState", ExchangeAccessState);
            writer.WriteEnumValue<DeviceManagementExchangeAccessStateReason>("exchangeAccessStateReason", ExchangeAccessStateReason);
            writer.WriteStringValue("managedDeviceName", ManagedDeviceName);
            writer.WriteEnumValue<ManagedDeviceOwnerType>("managedDeviceOwnerType", ManagedDeviceOwnerType);
            writer.WriteEnumValue<ManagementAgentType>("managementAgent", ManagementAgent);
            writer.WriteStringValue("notes", Notes);
            writer.WriteEnumValue<ManagedDevicePartnerReportedHealthState>("partnerReportedThreatState", PartnerReportedThreatState);
            writer.WriteCollectionOfObjectValues<User>("users", Users);
        }
    }
}
