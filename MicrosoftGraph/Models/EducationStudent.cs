using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class EducationStudent : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Birth date of the student.</summary>
        public Date? BirthDate { get; set; }
        /// <summary>ID of the student in the source system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId { get; set; }
#nullable restore
#else
        public string ExternalId { get; set; }
#endif
        /// <summary>The possible values are: female, male, other, unknownFutureValue.</summary>
        public EducationGender? Gender { get; set; }
        /// <summary>Current grade level of the student.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Grade { get; set; }
#nullable restore
#else
        public string Grade { get; set; }
#endif
        /// <summary>Year the student is graduating from the school.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GraduationYear { get; set; }
#nullable restore
#else
        public string GraduationYear { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Student Number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StudentNumber { get; set; }
#nullable restore
#else
        public string StudentNumber { get; set; }
#endif
        /// <summary>
        /// Instantiates a new educationStudent and sets the default values.
        /// </summary>
        public EducationStudent() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EducationStudent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationStudent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"birthDate", n => { BirthDate = n.GetDateValue(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"gender", n => { Gender = n.GetEnumValue<EducationGender>(); } },
                {"grade", n => { Grade = n.GetStringValue(); } },
                {"graduationYear", n => { GraduationYear = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"studentNumber", n => { StudentNumber = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateValue("birthDate", BirthDate);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteEnumValue<EducationGender>("gender", Gender);
            writer.WriteStringValue("grade", Grade);
            writer.WriteStringValue("graduationYear", GraduationYear);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("studentNumber", StudentNumber);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
