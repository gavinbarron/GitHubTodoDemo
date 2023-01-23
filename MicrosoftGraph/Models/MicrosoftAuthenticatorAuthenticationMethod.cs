using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class MicrosoftAuthenticatorAuthenticationMethod : AuthenticationMethod, IParsable {
        /// <summary>The date and time that this app was registered. This property is null if the device is not registered for passwordless Phone Sign-In.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The registered device on which Microsoft Authenticator resides. This property is null if the device is not registered for passwordless Phone Sign-In.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.MicrosoftGraph.Models.Device? Device { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.MicrosoftGraph.Models.Device Device { get; set; }
#endif
        /// <summary>Tags containing app metadata.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceTag { get; set; }
#nullable restore
#else
        public string DeviceTag { get; set; }
#endif
        /// <summary>The name of the device on which this app is registered.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Numerical version of this instance of the Authenticator app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PhoneAppVersion { get; set; }
#nullable restore
#else
        public string PhoneAppVersion { get; set; }
#endif
        /// <summary>
        /// Instantiates a new MicrosoftAuthenticatorAuthenticationMethod and sets the default values.
        /// </summary>
        public MicrosoftAuthenticatorAuthenticationMethod() : base() {
            OdataType = "#microsoft.graph.microsoftAuthenticatorAuthenticationMethod";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MicrosoftAuthenticatorAuthenticationMethod CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MicrosoftAuthenticatorAuthenticationMethod();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"device", n => { Device = n.GetObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Device>(GitHubTodoDemo.MicrosoftGraph.Models.Device.CreateFromDiscriminatorValue); } },
                {"deviceTag", n => { DeviceTag = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"phoneAppVersion", n => { PhoneAppVersion = n.GetStringValue(); } },
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
            writer.WriteObjectValue<GitHubTodoDemo.MicrosoftGraph.Models.Device>("device", Device);
            writer.WriteStringValue("deviceTag", DeviceTag);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("phoneAppVersion", PhoneAppVersion);
        }
    }
}
