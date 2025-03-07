using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class UserTrainingEventInfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Display name of the training.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Latest status of the training assigned to the user. Possible values are: unknown, assigned, inProgress, completed, overdue, unknownFutureValue.</summary>
        public TrainingStatus? LatestTrainingStatus { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Event details of the training when it was assigned to the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserTrainingContentEventInfo? TrainingAssignedProperties { get; set; }
#nullable restore
#else
        public UserTrainingContentEventInfo TrainingAssignedProperties { get; set; }
#endif
        /// <summary>Event details of the training when it was completed by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserTrainingContentEventInfo? TrainingCompletedProperties { get; set; }
#nullable restore
#else
        public UserTrainingContentEventInfo TrainingCompletedProperties { get; set; }
#endif
        /// <summary>Event details of the training when it was updated/in-progress by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public UserTrainingContentEventInfo? TrainingUpdatedProperties { get; set; }
#nullable restore
#else
        public UserTrainingContentEventInfo TrainingUpdatedProperties { get; set; }
#endif
        /// <summary>
        /// Instantiates a new userTrainingEventInfo and sets the default values.
        /// </summary>
        public UserTrainingEventInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserTrainingEventInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserTrainingEventInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"latestTrainingStatus", n => { LatestTrainingStatus = n.GetEnumValue<TrainingStatus>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"trainingAssignedProperties", n => { TrainingAssignedProperties = n.GetObjectValue<UserTrainingContentEventInfo>(UserTrainingContentEventInfo.CreateFromDiscriminatorValue); } },
                {"trainingCompletedProperties", n => { TrainingCompletedProperties = n.GetObjectValue<UserTrainingContentEventInfo>(UserTrainingContentEventInfo.CreateFromDiscriminatorValue); } },
                {"trainingUpdatedProperties", n => { TrainingUpdatedProperties = n.GetObjectValue<UserTrainingContentEventInfo>(UserTrainingContentEventInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<TrainingStatus>("latestTrainingStatus", LatestTrainingStatus);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<UserTrainingContentEventInfo>("trainingAssignedProperties", TrainingAssignedProperties);
            writer.WriteObjectValue<UserTrainingContentEventInfo>("trainingCompletedProperties", TrainingCompletedProperties);
            writer.WriteObjectValue<UserTrainingContentEventInfo>("trainingUpdatedProperties", TrainingUpdatedProperties);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
