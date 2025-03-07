using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class Windows10EndpointProtectionConfiguration : DeviceConfiguration, IParsable {
        /// <summary>Allow persisting user generated data inside the App Guard Containter (favorites, cookies, web passwords, etc.)</summary>
        public bool? ApplicationGuardAllowPersistence { get; set; }
        /// <summary>Allow printing to Local Printers from Container</summary>
        public bool? ApplicationGuardAllowPrintToLocalPrinters { get; set; }
        /// <summary>Allow printing to Network Printers from Container</summary>
        public bool? ApplicationGuardAllowPrintToNetworkPrinters { get; set; }
        /// <summary>Allow printing to PDF from Container</summary>
        public bool? ApplicationGuardAllowPrintToPDF { get; set; }
        /// <summary>Allow printing to XPS from Container</summary>
        public bool? ApplicationGuardAllowPrintToXPS { get; set; }
        /// <summary>Possible values for applicationGuardBlockClipboardSharingType</summary>
        public ApplicationGuardBlockClipboardSharingType? ApplicationGuardBlockClipboardSharing { get; set; }
        /// <summary>Possible values for applicationGuardBlockFileTransfer</summary>
        public ApplicationGuardBlockFileTransferType? ApplicationGuardBlockFileTransfer { get; set; }
        /// <summary>Block enterprise sites to load non-enterprise content, such as third party plug-ins</summary>
        public bool? ApplicationGuardBlockNonEnterpriseContent { get; set; }
        /// <summary>Enable Windows Defender Application Guard</summary>
        public bool? ApplicationGuardEnabled { get; set; }
        /// <summary>Force auditing will persist Windows logs and events to meet security/compliance criteria (sample events are user login-logoff, use of privilege rights, software installation, system changes, etc.)</summary>
        public bool? ApplicationGuardForceAuditing { get; set; }
        /// <summary>Possible values of AppLocker Application Control Types</summary>
        public AppLockerApplicationControlType? AppLockerApplicationControl { get; set; }
        /// <summary>Allows the Admin to disable the warning prompt for other disk encryption on the user machines.</summary>
        public bool? BitLockerDisableWarningForOtherDiskEncryption { get; set; }
        /// <summary>Allows the admin to require encryption to be turned on using BitLocker. This policy is valid only for a mobile SKU.</summary>
        public bool? BitLockerEnableStorageCardEncryptionOnMobile { get; set; }
        /// <summary>Allows the admin to require encryption to be turned on using BitLocker.</summary>
        public bool? BitLockerEncryptDevice { get; set; }
        /// <summary>BitLocker Removable Drive Policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.BitLockerRemovableDrivePolicy? BitLockerRemovableDrivePolicy { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.BitLockerRemovableDrivePolicy BitLockerRemovableDrivePolicy { get; set; }
#endif
        /// <summary>List of folder paths to be added to the list of protected folders</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DefenderAdditionalGuardedFolders { get; set; }
#nullable restore
#else
        public List<string> DefenderAdditionalGuardedFolders { get; set; }
#endif
        /// <summary>List of exe files and folders to be excluded from attack surface reduction rules</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DefenderAttackSurfaceReductionExcludedPaths { get; set; }
#nullable restore
#else
        public List<string> DefenderAttackSurfaceReductionExcludedPaths { get; set; }
#endif
        /// <summary>Xml content containing information regarding exploit protection details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? DefenderExploitProtectionXml { get; set; }
#nullable restore
#else
        public byte[] DefenderExploitProtectionXml { get; set; }
#endif
        /// <summary>Name of the file from which DefenderExploitProtectionXml was obtained.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefenderExploitProtectionXmlFileName { get; set; }
#nullable restore
#else
        public string DefenderExploitProtectionXmlFileName { get; set; }
#endif
        /// <summary>List of paths to exe that are allowed to access protected folders</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DefenderGuardedFoldersAllowedAppPaths { get; set; }
#nullable restore
#else
        public List<string> DefenderGuardedFoldersAllowedAppPaths { get; set; }
#endif
        /// <summary>Indicates whether or not to block user from overriding Exploit Protection settings.</summary>
        public bool? DefenderSecurityCenterBlockExploitProtectionOverride { get; set; }
        /// <summary>Blocks stateful FTP connections to the device</summary>
        public bool? FirewallBlockStatefulFTP { get; set; }
        /// <summary>Possible values for firewallCertificateRevocationListCheckMethod</summary>
        public FirewallCertificateRevocationListCheckMethodType? FirewallCertificateRevocationListCheckMethod { get; set; }
        /// <summary>Configures the idle timeout for security associations, in seconds, from 300 to 3600 inclusive. This is the period after which security associations will expire and be deleted. Valid values 300 to 3600</summary>
        public int? FirewallIdleTimeoutForSecurityAssociationInSeconds { get; set; }
        /// <summary>Configures IPSec exemptions to allow both IPv4 and IPv6 DHCP traffic</summary>
        public bool? FirewallIPSecExemptionsAllowDHCP { get; set; }
        /// <summary>Configures IPSec exemptions to allow ICMP</summary>
        public bool? FirewallIPSecExemptionsAllowICMP { get; set; }
        /// <summary>Configures IPSec exemptions to allow neighbor discovery IPv6 ICMP type-codes</summary>
        public bool? FirewallIPSecExemptionsAllowNeighborDiscovery { get; set; }
        /// <summary>Configures IPSec exemptions to allow router discovery IPv6 ICMP type-codes</summary>
        public bool? FirewallIPSecExemptionsAllowRouterDiscovery { get; set; }
        /// <summary>If an authentication set is not fully supported by a keying module, direct the module to ignore only unsupported authentication suites rather than the entire set</summary>
        public bool? FirewallMergeKeyingModuleSettings { get; set; }
        /// <summary>Possible values for firewallPacketQueueingMethod</summary>
        public FirewallPacketQueueingMethodType? FirewallPacketQueueingMethod { get; set; }
        /// <summary>Possible values for firewallPreSharedKeyEncodingMethod</summary>
        public FirewallPreSharedKeyEncodingMethodType? FirewallPreSharedKeyEncodingMethod { get; set; }
        /// <summary>Configures the firewall profile settings for domain networks</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WindowsFirewallNetworkProfile? FirewallProfileDomain { get; set; }
#nullable restore
#else
        public WindowsFirewallNetworkProfile FirewallProfileDomain { get; set; }
#endif
        /// <summary>Configures the firewall profile settings for private networks</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WindowsFirewallNetworkProfile? FirewallProfilePrivate { get; set; }
#nullable restore
#else
        public WindowsFirewallNetworkProfile FirewallProfilePrivate { get; set; }
#endif
        /// <summary>Configures the firewall profile settings for public networks</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WindowsFirewallNetworkProfile? FirewallProfilePublic { get; set; }
#nullable restore
#else
        public WindowsFirewallNetworkProfile FirewallProfilePublic { get; set; }
#endif
        /// <summary>Allows IT Admins to control whether users can can ignore SmartScreen warnings and run malicious files.</summary>
        public bool? SmartScreenBlockOverrideForFiles { get; set; }
        /// <summary>Allows IT Admins to configure SmartScreen for Windows.</summary>
        public bool? SmartScreenEnableInShell { get; set; }
        /// <summary>
        /// Instantiates a new Windows10EndpointProtectionConfiguration and sets the default values.
        /// </summary>
        public Windows10EndpointProtectionConfiguration() : base() {
            OdataType = "#microsoft.graph.windows10EndpointProtectionConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Windows10EndpointProtectionConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Windows10EndpointProtectionConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicationGuardAllowPersistence", n => { ApplicationGuardAllowPersistence = n.GetBoolValue(); } },
                {"applicationGuardAllowPrintToLocalPrinters", n => { ApplicationGuardAllowPrintToLocalPrinters = n.GetBoolValue(); } },
                {"applicationGuardAllowPrintToNetworkPrinters", n => { ApplicationGuardAllowPrintToNetworkPrinters = n.GetBoolValue(); } },
                {"applicationGuardAllowPrintToPDF", n => { ApplicationGuardAllowPrintToPDF = n.GetBoolValue(); } },
                {"applicationGuardAllowPrintToXPS", n => { ApplicationGuardAllowPrintToXPS = n.GetBoolValue(); } },
                {"applicationGuardBlockClipboardSharing", n => { ApplicationGuardBlockClipboardSharing = n.GetEnumValue<ApplicationGuardBlockClipboardSharingType>(); } },
                {"applicationGuardBlockFileTransfer", n => { ApplicationGuardBlockFileTransfer = n.GetEnumValue<ApplicationGuardBlockFileTransferType>(); } },
                {"applicationGuardBlockNonEnterpriseContent", n => { ApplicationGuardBlockNonEnterpriseContent = n.GetBoolValue(); } },
                {"applicationGuardEnabled", n => { ApplicationGuardEnabled = n.GetBoolValue(); } },
                {"applicationGuardForceAuditing", n => { ApplicationGuardForceAuditing = n.GetBoolValue(); } },
                {"appLockerApplicationControl", n => { AppLockerApplicationControl = n.GetEnumValue<AppLockerApplicationControlType>(); } },
                {"bitLockerDisableWarningForOtherDiskEncryption", n => { BitLockerDisableWarningForOtherDiskEncryption = n.GetBoolValue(); } },
                {"bitLockerEnableStorageCardEncryptionOnMobile", n => { BitLockerEnableStorageCardEncryptionOnMobile = n.GetBoolValue(); } },
                {"bitLockerEncryptDevice", n => { BitLockerEncryptDevice = n.GetBoolValue(); } },
                {"bitLockerRemovableDrivePolicy", n => { BitLockerRemovableDrivePolicy = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.BitLockerRemovableDrivePolicy>(GitHubTodoDemo.MicrosoftGraph.Models.BitLockerRemovableDrivePolicy.CreateFromDiscriminatorValue); } },
                {"defenderAdditionalGuardedFolders", n => { DefenderAdditionalGuardedFolders = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"defenderAttackSurfaceReductionExcludedPaths", n => { DefenderAttackSurfaceReductionExcludedPaths = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"defenderExploitProtectionXml", n => { DefenderExploitProtectionXml = n.GetByteArrayValue(); } },
                {"defenderExploitProtectionXmlFileName", n => { DefenderExploitProtectionXmlFileName = n.GetStringValue(); } },
                {"defenderGuardedFoldersAllowedAppPaths", n => { DefenderGuardedFoldersAllowedAppPaths = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"defenderSecurityCenterBlockExploitProtectionOverride", n => { DefenderSecurityCenterBlockExploitProtectionOverride = n.GetBoolValue(); } },
                {"firewallBlockStatefulFTP", n => { FirewallBlockStatefulFTP = n.GetBoolValue(); } },
                {"firewallCertificateRevocationListCheckMethod", n => { FirewallCertificateRevocationListCheckMethod = n.GetEnumValue<FirewallCertificateRevocationListCheckMethodType>(); } },
                {"firewallIdleTimeoutForSecurityAssociationInSeconds", n => { FirewallIdleTimeoutForSecurityAssociationInSeconds = n.GetIntValue(); } },
                {"firewallIPSecExemptionsAllowDHCP", n => { FirewallIPSecExemptionsAllowDHCP = n.GetBoolValue(); } },
                {"firewallIPSecExemptionsAllowICMP", n => { FirewallIPSecExemptionsAllowICMP = n.GetBoolValue(); } },
                {"firewallIPSecExemptionsAllowNeighborDiscovery", n => { FirewallIPSecExemptionsAllowNeighborDiscovery = n.GetBoolValue(); } },
                {"firewallIPSecExemptionsAllowRouterDiscovery", n => { FirewallIPSecExemptionsAllowRouterDiscovery = n.GetBoolValue(); } },
                {"firewallMergeKeyingModuleSettings", n => { FirewallMergeKeyingModuleSettings = n.GetBoolValue(); } },
                {"firewallPacketQueueingMethod", n => { FirewallPacketQueueingMethod = n.GetEnumValue<FirewallPacketQueueingMethodType>(); } },
                {"firewallPreSharedKeyEncodingMethod", n => { FirewallPreSharedKeyEncodingMethod = n.GetEnumValue<FirewallPreSharedKeyEncodingMethodType>(); } },
                {"firewallProfileDomain", n => { FirewallProfileDomain = n.GetObjectValue<WindowsFirewallNetworkProfile>(WindowsFirewallNetworkProfile.CreateFromDiscriminatorValue); } },
                {"firewallProfilePrivate", n => { FirewallProfilePrivate = n.GetObjectValue<WindowsFirewallNetworkProfile>(WindowsFirewallNetworkProfile.CreateFromDiscriminatorValue); } },
                {"firewallProfilePublic", n => { FirewallProfilePublic = n.GetObjectValue<WindowsFirewallNetworkProfile>(WindowsFirewallNetworkProfile.CreateFromDiscriminatorValue); } },
                {"smartScreenBlockOverrideForFiles", n => { SmartScreenBlockOverrideForFiles = n.GetBoolValue(); } },
                {"smartScreenEnableInShell", n => { SmartScreenEnableInShell = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("applicationGuardAllowPersistence", ApplicationGuardAllowPersistence);
            writer.WriteBoolValue("applicationGuardAllowPrintToLocalPrinters", ApplicationGuardAllowPrintToLocalPrinters);
            writer.WriteBoolValue("applicationGuardAllowPrintToNetworkPrinters", ApplicationGuardAllowPrintToNetworkPrinters);
            writer.WriteBoolValue("applicationGuardAllowPrintToPDF", ApplicationGuardAllowPrintToPDF);
            writer.WriteBoolValue("applicationGuardAllowPrintToXPS", ApplicationGuardAllowPrintToXPS);
            writer.WriteEnumValue<ApplicationGuardBlockClipboardSharingType>("applicationGuardBlockClipboardSharing", ApplicationGuardBlockClipboardSharing);
            writer.WriteEnumValue<ApplicationGuardBlockFileTransferType>("applicationGuardBlockFileTransfer", ApplicationGuardBlockFileTransfer);
            writer.WriteBoolValue("applicationGuardBlockNonEnterpriseContent", ApplicationGuardBlockNonEnterpriseContent);
            writer.WriteBoolValue("applicationGuardEnabled", ApplicationGuardEnabled);
            writer.WriteBoolValue("applicationGuardForceAuditing", ApplicationGuardForceAuditing);
            writer.WriteEnumValue<AppLockerApplicationControlType>("appLockerApplicationControl", AppLockerApplicationControl);
            writer.WriteBoolValue("bitLockerDisableWarningForOtherDiskEncryption", BitLockerDisableWarningForOtherDiskEncryption);
            writer.WriteBoolValue("bitLockerEnableStorageCardEncryptionOnMobile", BitLockerEnableStorageCardEncryptionOnMobile);
            writer.WriteBoolValue("bitLockerEncryptDevice", BitLockerEncryptDevice);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.BitLockerRemovableDrivePolicy>("bitLockerRemovableDrivePolicy", BitLockerRemovableDrivePolicy);
            writer.WriteCollectionOfPrimitiveValues<string>("defenderAdditionalGuardedFolders", DefenderAdditionalGuardedFolders);
            writer.WriteCollectionOfPrimitiveValues<string>("defenderAttackSurfaceReductionExcludedPaths", DefenderAttackSurfaceReductionExcludedPaths);
            writer.WriteByteArrayValue("defenderExploitProtectionXml", DefenderExploitProtectionXml);
            writer.WriteStringValue("defenderExploitProtectionXmlFileName", DefenderExploitProtectionXmlFileName);
            writer.WriteCollectionOfPrimitiveValues<string>("defenderGuardedFoldersAllowedAppPaths", DefenderGuardedFoldersAllowedAppPaths);
            writer.WriteBoolValue("defenderSecurityCenterBlockExploitProtectionOverride", DefenderSecurityCenterBlockExploitProtectionOverride);
            writer.WriteBoolValue("firewallBlockStatefulFTP", FirewallBlockStatefulFTP);
            writer.WriteEnumValue<FirewallCertificateRevocationListCheckMethodType>("firewallCertificateRevocationListCheckMethod", FirewallCertificateRevocationListCheckMethod);
            writer.WriteIntValue("firewallIdleTimeoutForSecurityAssociationInSeconds", FirewallIdleTimeoutForSecurityAssociationInSeconds);
            writer.WriteBoolValue("firewallIPSecExemptionsAllowDHCP", FirewallIPSecExemptionsAllowDHCP);
            writer.WriteBoolValue("firewallIPSecExemptionsAllowICMP", FirewallIPSecExemptionsAllowICMP);
            writer.WriteBoolValue("firewallIPSecExemptionsAllowNeighborDiscovery", FirewallIPSecExemptionsAllowNeighborDiscovery);
            writer.WriteBoolValue("firewallIPSecExemptionsAllowRouterDiscovery", FirewallIPSecExemptionsAllowRouterDiscovery);
            writer.WriteBoolValue("firewallMergeKeyingModuleSettings", FirewallMergeKeyingModuleSettings);
            writer.WriteEnumValue<FirewallPacketQueueingMethodType>("firewallPacketQueueingMethod", FirewallPacketQueueingMethod);
            writer.WriteEnumValue<FirewallPreSharedKeyEncodingMethodType>("firewallPreSharedKeyEncodingMethod", FirewallPreSharedKeyEncodingMethod);
            writer.WriteObjectValue<WindowsFirewallNetworkProfile>("firewallProfileDomain", FirewallProfileDomain);
            writer.WriteObjectValue<WindowsFirewallNetworkProfile>("firewallProfilePrivate", FirewallProfilePrivate);
            writer.WriteObjectValue<WindowsFirewallNetworkProfile>("firewallProfilePublic", FirewallProfilePublic);
            writer.WriteBoolValue("smartScreenBlockOverrideForFiles", SmartScreenBlockOverrideForFiles);
            writer.WriteBoolValue("smartScreenEnableInShell", SmartScreenEnableInShell);
        }
    }
}
