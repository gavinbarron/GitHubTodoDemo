using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class UserExperienceAnalyticsDevicePerformance : Entity, IParsable {
        /// <summary>Average (mean) number of Blue Screens per device in the last 30 days. Valid values 0 to 9999999</summary>
        public double? AverageBlueScreens { get; set; }
        /// <summary>Average (mean) number of Restarts per device in the last 30 days. Valid values 0 to 9999999</summary>
        public double? AverageRestarts { get; set; }
        /// <summary>Number of Blue Screens in the last 30 days. Valid values 0 to 9999999</summary>
        public int? BlueScreenCount { get; set; }
        /// <summary>The user experience analytics device boot score.</summary>
        public int? BootScore { get; set; }
        /// <summary>The user experience analytics device core boot time in milliseconds.</summary>
        public int? CoreBootTimeInMs { get; set; }
        /// <summary>The user experience analytics device core login time in milliseconds.</summary>
        public int? CoreLoginTimeInMs { get; set; }
        /// <summary>User experience analytics summarized device count.</summary>
        public long? DeviceCount { get; set; }
        /// <summary>The user experience analytics device name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName { get; set; }
#nullable restore
#else
        public string DeviceName { get; set; }
#endif
        /// <summary>The diskType property</summary>
        public GitHubTodoDemo.MicrosoftGraph.Models.DiskType? DiskType { get; set; }
        /// <summary>The user experience analytics device group policy boot time in milliseconds.</summary>
        public int? GroupPolicyBootTimeInMs { get; set; }
        /// <summary>The user experience analytics device group policy login time in milliseconds.</summary>
        public int? GroupPolicyLoginTimeInMs { get; set; }
        /// <summary>The healthStatus property</summary>
        public UserExperienceAnalyticsHealthState? HealthStatus { get; set; }
        /// <summary>The user experience analytics device login score.</summary>
        public int? LoginScore { get; set; }
        /// <summary>The user experience analytics device manufacturer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Manufacturer { get; set; }
#nullable restore
#else
        public string Manufacturer { get; set; }
#endif
        /// <summary>The user experience analytics device model.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Model { get; set; }
#nullable restore
#else
        public string Model { get; set; }
#endif
        /// <summary>The user experience analytics model level startup performance score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? ModelStartupPerformanceScore { get; set; }
        /// <summary>The user experience analytics device Operating System version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperatingSystemVersion { get; set; }
#nullable restore
#else
        public string OperatingSystemVersion { get; set; }
#endif
        /// <summary>The user experience analytics responsive desktop time in milliseconds.</summary>
        public int? ResponsiveDesktopTimeInMs { get; set; }
        /// <summary>Number of Restarts in the last 30 days. Valid values 0 to 9999999</summary>
        public int? RestartCount { get; set; }
        /// <summary>The user experience analytics device startup performance score. Valid values -1.79769313486232E+308 to 1.79769313486232E+308</summary>
        public double? StartupPerformanceScore { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserExperienceAnalyticsDevicePerformance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserExperienceAnalyticsDevicePerformance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"averageBlueScreens", n => { AverageBlueScreens = n.GetDoubleValue(); } },
                {"averageRestarts", n => { AverageRestarts = n.GetDoubleValue(); } },
                {"blueScreenCount", n => { BlueScreenCount = n.GetIntValue(); } },
                {"bootScore", n => { BootScore = n.GetIntValue(); } },
                {"coreBootTimeInMs", n => { CoreBootTimeInMs = n.GetIntValue(); } },
                {"coreLoginTimeInMs", n => { CoreLoginTimeInMs = n.GetIntValue(); } },
                {"deviceCount", n => { DeviceCount = n.GetLongValue(); } },
                {"deviceName", n => { DeviceName = n.GetStringValue(); } },
                {"diskType", n => { DiskType = n.GetEnumValue<DiskType>(); } },
                {"groupPolicyBootTimeInMs", n => { GroupPolicyBootTimeInMs = n.GetIntValue(); } },
                {"groupPolicyLoginTimeInMs", n => { GroupPolicyLoginTimeInMs = n.GetIntValue(); } },
                {"healthStatus", n => { HealthStatus = n.GetEnumValue<UserExperienceAnalyticsHealthState>(); } },
                {"loginScore", n => { LoginScore = n.GetIntValue(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"modelStartupPerformanceScore", n => { ModelStartupPerformanceScore = n.GetDoubleValue(); } },
                {"operatingSystemVersion", n => { OperatingSystemVersion = n.GetStringValue(); } },
                {"responsiveDesktopTimeInMs", n => { ResponsiveDesktopTimeInMs = n.GetIntValue(); } },
                {"restartCount", n => { RestartCount = n.GetIntValue(); } },
                {"startupPerformanceScore", n => { StartupPerformanceScore = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDoubleValue("averageBlueScreens", AverageBlueScreens);
            writer.WriteDoubleValue("averageRestarts", AverageRestarts);
            writer.WriteIntValue("blueScreenCount", BlueScreenCount);
            writer.WriteIntValue("bootScore", BootScore);
            writer.WriteIntValue("coreBootTimeInMs", CoreBootTimeInMs);
            writer.WriteIntValue("coreLoginTimeInMs", CoreLoginTimeInMs);
            writer.WriteLongValue("deviceCount", DeviceCount);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteEnumValue<DiskType>("diskType", DiskType);
            writer.WriteIntValue("groupPolicyBootTimeInMs", GroupPolicyBootTimeInMs);
            writer.WriteIntValue("groupPolicyLoginTimeInMs", GroupPolicyLoginTimeInMs);
            writer.WriteEnumValue<UserExperienceAnalyticsHealthState>("healthStatus", HealthStatus);
            writer.WriteIntValue("loginScore", LoginScore);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteDoubleValue("modelStartupPerformanceScore", ModelStartupPerformanceScore);
            writer.WriteStringValue("operatingSystemVersion", OperatingSystemVersion);
            writer.WriteIntValue("responsiveDesktopTimeInMs", ResponsiveDesktopTimeInMs);
            writer.WriteIntValue("restartCount", RestartCount);
            writer.WriteDoubleValue("startupPerformanceScore", StartupPerformanceScore);
        }
    }
}
