using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class TemporaryAccessPassAuthenticationMethod : AuthenticationMethod, IParsable {
        /// <summary>The date and time when the Temporary Access Pass was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The state of the authentication method that indicates whether it&apos;s currently usable by the user.</summary>
        public bool? IsUsable { get; set; }
        /// <summary>Determines whether the pass is limited to a one-time use. If true, the pass can be used once; if false, the pass can be used multiple times within the Temporary Access Pass lifetime.</summary>
        public bool? IsUsableOnce { get; set; }
        /// <summary>The lifetime of the Temporary Access Pass in minutes starting at startDateTime. Must be between 10 and 43200 inclusive (equivalent to 30 days).</summary>
        public int? LifetimeInMinutes { get; set; }
        /// <summary>Details about the usability state (isUsable). Reasons can include: EnabledByPolicy, DisabledByPolicy, Expired, NotYetValid, OneTimeUsed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MethodUsabilityReason { get; set; }
#nullable restore
#else
        public string MethodUsabilityReason { get; set; }
#endif
        /// <summary>The date and time when the Temporary Access Pass becomes available to use and when isUsable is true is enforced.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>The Temporary Access Pass used to authenticate. Returned only on creation of a new temporaryAccessPassAuthenticationMethod object; Hidden in subsequent read operations and returned as null with GET.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TemporaryAccessPass { get; set; }
#nullable restore
#else
        public string TemporaryAccessPass { get; set; }
#endif
        /// <summary>
        /// Instantiates a new TemporaryAccessPassAuthenticationMethod and sets the default values.
        /// </summary>
        public TemporaryAccessPassAuthenticationMethod() : base() {
            OdataType = "#microsoft.graph.temporaryAccessPassAuthenticationMethod";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TemporaryAccessPassAuthenticationMethod CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TemporaryAccessPassAuthenticationMethod();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"isUsable", n => { IsUsable = n.GetBoolValue(); } },
                {"isUsableOnce", n => { IsUsableOnce = n.GetBoolValue(); } },
                {"lifetimeInMinutes", n => { LifetimeInMinutes = n.GetIntValue(); } },
                {"methodUsabilityReason", n => { MethodUsabilityReason = n.GetStringValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"temporaryAccessPass", n => { TemporaryAccessPass = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteBoolValue("isUsable", IsUsable);
            writer.WriteBoolValue("isUsableOnce", IsUsableOnce);
            writer.WriteIntValue("lifetimeInMinutes", LifetimeInMinutes);
            writer.WriteStringValue("methodUsabilityReason", MethodUsabilityReason);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("temporaryAccessPass", TemporaryAccessPass);
        }
    }
}
