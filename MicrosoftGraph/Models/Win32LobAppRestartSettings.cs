using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>
    /// Contains properties describing restart coordination following an app installation.
    /// </summary>
    public class Win32LobAppRestartSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The number of minutes before the restart time to display the countdown dialog for pending restarts.</summary>
        public int? CountdownDisplayBeforeRestartInMinutes { get; set; }
        /// <summary>The number of minutes to wait before restarting the device after an app installation.</summary>
        public int? GracePeriodInMinutes { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The number of minutes to snooze the restart notification dialog when the snooze button is selected.</summary>
        public int? RestartNotificationSnoozeDurationInMinutes { get; set; }
        /// <summary>
        /// Instantiates a new win32LobAppRestartSettings and sets the default values.
        /// </summary>
        public Win32LobAppRestartSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Win32LobAppRestartSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Win32LobAppRestartSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"countdownDisplayBeforeRestartInMinutes", n => { CountdownDisplayBeforeRestartInMinutes = n.GetIntValue(); } },
                {"gracePeriodInMinutes", n => { GracePeriodInMinutes = n.GetIntValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"restartNotificationSnoozeDurationInMinutes", n => { RestartNotificationSnoozeDurationInMinutes = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("countdownDisplayBeforeRestartInMinutes", CountdownDisplayBeforeRestartInMinutes);
            writer.WriteIntValue("gracePeriodInMinutes", GracePeriodInMinutes);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("restartNotificationSnoozeDurationInMinutes", RestartNotificationSnoozeDurationInMinutes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
