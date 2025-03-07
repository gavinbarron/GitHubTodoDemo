using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class EducationFeedbackOutcome : EducationOutcome, IParsable {
        /// <summary>Teacher&apos;s written feedback to the student.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationFeedback? Feedback { get; set; }
#nullable restore
#else
        public EducationFeedback Feedback { get; set; }
#endif
        /// <summary>A copy of the feedback property that is made when the grade is released to the student.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public EducationFeedback? PublishedFeedback { get; set; }
#nullable restore
#else
        public EducationFeedback PublishedFeedback { get; set; }
#endif
        /// <summary>
        /// Instantiates a new EducationFeedbackOutcome and sets the default values.
        /// </summary>
        public EducationFeedbackOutcome() : base() {
            OdataType = "#microsoft.graph.educationFeedbackOutcome";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EducationFeedbackOutcome CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationFeedbackOutcome();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"feedback", n => { Feedback = n.GetObjectValue<EducationFeedback>(EducationFeedback.CreateFromDiscriminatorValue); } },
                {"publishedFeedback", n => { PublishedFeedback = n.GetObjectValue<EducationFeedback>(EducationFeedback.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<EducationFeedback>("feedback", Feedback);
            writer.WriteObjectValue<EducationFeedback>("publishedFeedback", PublishedFeedback);
        }
    }
}
