using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class Process : IAdditionalDataHolder, IParsable {
        /// <summary>User account identifier (user account context the process ran under) for example, AccountName, SID, and so on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountName { get; set; }
#nullable restore
#else
        public string AccountName { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The full process invocation commandline including all parameters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CommandLine { get; set; }
#nullable restore
#else
        public string CommandLine { get; set; }
#endif
        /// <summary>Time at which the process was started. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Complex type containing file hashes (cryptographic and location-sensitive).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.FileHash? FileHash { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.FileHash FileHash { get; set; }
#endif
        /// <summary>The integrity level of the process. Possible values are: unknown, untrusted, low, medium, high, system.</summary>
        public ProcessIntegrityLevel? IntegrityLevel { get; set; }
        /// <summary>True if the process is elevated.</summary>
        public bool? IsElevated { get; set; }
        /// <summary>The name of the process&apos; Image file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>DateTime at which the parent process was started. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ParentProcessCreatedDateTime { get; set; }
        /// <summary>The Process ID (PID) of the parent process.</summary>
        public int? ParentProcessId { get; set; }
        /// <summary>The name of the image file of the parent process.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ParentProcessName { get; set; }
#nullable restore
#else
        public string ParentProcessName { get; set; }
#endif
        /// <summary>Full path, including filename.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Path { get; set; }
#nullable restore
#else
        public string Path { get; set; }
#endif
        /// <summary>The Process ID (PID) of the process.</summary>
        public int? ProcessId { get; set; }
        /// <summary>
        /// Instantiates a new process and sets the default values.
        /// </summary>
        public Process() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Process CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Process();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accountName", n => { AccountName = n.GetStringValue(); } },
                {"commandLine", n => { CommandLine = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"fileHash", n => { FileHash = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.FileHash>(GitHubTodoDemo.MicrosoftGraph.Models.FileHash.CreateFromDiscriminatorValue); } },
                {"integrityLevel", n => { IntegrityLevel = n.GetEnumValue<ProcessIntegrityLevel>(); } },
                {"isElevated", n => { IsElevated = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"parentProcessCreatedDateTime", n => { ParentProcessCreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"parentProcessId", n => { ParentProcessId = n.GetIntValue(); } },
                {"parentProcessName", n => { ParentProcessName = n.GetStringValue(); } },
                {"path", n => { Path = n.GetStringValue(); } },
                {"processId", n => { ProcessId = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("accountName", AccountName);
            writer.WriteStringValue("commandLine", CommandLine);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.FileHash>("fileHash", FileHash);
            writer.WriteEnumValue<ProcessIntegrityLevel>("integrityLevel", IntegrityLevel);
            writer.WriteBoolValue("isElevated", IsElevated);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateTimeOffsetValue("parentProcessCreatedDateTime", ParentProcessCreatedDateTime);
            writer.WriteIntValue("parentProcessId", ParentProcessId);
            writer.WriteStringValue("parentProcessName", ParentProcessName);
            writer.WriteStringValue("path", Path);
            writer.WriteIntValue("processId", ProcessId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
