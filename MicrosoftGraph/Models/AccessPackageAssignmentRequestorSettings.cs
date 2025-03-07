using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class AccessPackageAssignmentRequestorSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>If false, the requestor is not permitted to include a schedule in their request.</summary>
        public bool? AllowCustomAssignmentSchedule { get; set; }
        /// <summary>If true, allows on-behalf-of requestors to create a request to add access for another principal.</summary>
        public bool? EnableOnBehalfRequestorsToAddAccess { get; set; }
        /// <summary>If true, allows on-behalf-of requestors to create a request to remove access for another principal.</summary>
        public bool? EnableOnBehalfRequestorsToRemoveAccess { get; set; }
        /// <summary>If true, allows on-behalf-of requestors to create a request to update access for another principal.</summary>
        public bool? EnableOnBehalfRequestorsToUpdateAccess { get; set; }
        /// <summary>If true, allows requestors to create a request to add access for themselves.</summary>
        public bool? EnableTargetsToSelfAddAccess { get; set; }
        /// <summary>If true, allows requestors to create a request to remove their access.</summary>
        public bool? EnableTargetsToSelfRemoveAccess { get; set; }
        /// <summary>If true, allows requestors to create a request to update their access.</summary>
        public bool? EnableTargetsToSelfUpdateAccess { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The principals who can request on-behalf-of others.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SubjectSet>? OnBehalfRequestors { get; set; }
#nullable restore
#else
        public List<SubjectSet> OnBehalfRequestors { get; set; }
#endif
        /// <summary>
        /// Instantiates a new accessPackageAssignmentRequestorSettings and sets the default values.
        /// </summary>
        public AccessPackageAssignmentRequestorSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AccessPackageAssignmentRequestorSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignmentRequestorSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowCustomAssignmentSchedule", n => { AllowCustomAssignmentSchedule = n.GetBoolValue(); } },
                {"enableOnBehalfRequestorsToAddAccess", n => { EnableOnBehalfRequestorsToAddAccess = n.GetBoolValue(); } },
                {"enableOnBehalfRequestorsToRemoveAccess", n => { EnableOnBehalfRequestorsToRemoveAccess = n.GetBoolValue(); } },
                {"enableOnBehalfRequestorsToUpdateAccess", n => { EnableOnBehalfRequestorsToUpdateAccess = n.GetBoolValue(); } },
                {"enableTargetsToSelfAddAccess", n => { EnableTargetsToSelfAddAccess = n.GetBoolValue(); } },
                {"enableTargetsToSelfRemoveAccess", n => { EnableTargetsToSelfRemoveAccess = n.GetBoolValue(); } },
                {"enableTargetsToSelfUpdateAccess", n => { EnableTargetsToSelfUpdateAccess = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"onBehalfRequestors", n => { OnBehalfRequestors = n.GetCollectionOfObjectValues<SubjectSet>(SubjectSet.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowCustomAssignmentSchedule", AllowCustomAssignmentSchedule);
            writer.WriteBoolValue("enableOnBehalfRequestorsToAddAccess", EnableOnBehalfRequestorsToAddAccess);
            writer.WriteBoolValue("enableOnBehalfRequestorsToRemoveAccess", EnableOnBehalfRequestorsToRemoveAccess);
            writer.WriteBoolValue("enableOnBehalfRequestorsToUpdateAccess", EnableOnBehalfRequestorsToUpdateAccess);
            writer.WriteBoolValue("enableTargetsToSelfAddAccess", EnableTargetsToSelfAddAccess);
            writer.WriteBoolValue("enableTargetsToSelfRemoveAccess", EnableTargetsToSelfRemoveAccess);
            writer.WriteBoolValue("enableTargetsToSelfUpdateAccess", EnableTargetsToSelfUpdateAccess);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<SubjectSet>("onBehalfRequestors", OnBehalfRequestors);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
