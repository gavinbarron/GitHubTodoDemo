using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class EducationRubricOutcome : EducationOutcome, IParsable {
        /// <summary>A copy of the rubricQualityFeedback property that is made when the grade is released to the student.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RubricQualityFeedbackModel>? PublishedRubricQualityFeedback { get; set; }
#nullable restore
#else
        public List<RubricQualityFeedbackModel> PublishedRubricQualityFeedback { get; set; }
#endif
        /// <summary>A copy of the rubricQualitySelectedLevels property that is made when the grade is released to the student.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RubricQualitySelectedColumnModel>? PublishedRubricQualitySelectedLevels { get; set; }
#nullable restore
#else
        public List<RubricQualitySelectedColumnModel> PublishedRubricQualitySelectedLevels { get; set; }
#endif
        /// <summary>A collection of specific feedback for each quality of this rubric.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RubricQualityFeedbackModel>? RubricQualityFeedback { get; set; }
#nullable restore
#else
        public List<RubricQualityFeedbackModel> RubricQualityFeedback { get; set; }
#endif
        /// <summary>The level that the teacher has selected for each quality while grading this assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<RubricQualitySelectedColumnModel>? RubricQualitySelectedLevels { get; set; }
#nullable restore
#else
        public List<RubricQualitySelectedColumnModel> RubricQualitySelectedLevels { get; set; }
#endif
        /// <summary>
        /// Instantiates a new EducationRubricOutcome and sets the default values.
        /// </summary>
        public EducationRubricOutcome() : base() {
            OdataType = "#microsoft.graph.educationRubricOutcome";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EducationRubricOutcome CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EducationRubricOutcome();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"publishedRubricQualityFeedback", n => { PublishedRubricQualityFeedback = n.GetCollectionOfObjectValues<RubricQualityFeedbackModel>(RubricQualityFeedbackModel.CreateFromDiscriminatorValue)?.ToList(); } },
                {"publishedRubricQualitySelectedLevels", n => { PublishedRubricQualitySelectedLevels = n.GetCollectionOfObjectValues<RubricQualitySelectedColumnModel>(RubricQualitySelectedColumnModel.CreateFromDiscriminatorValue)?.ToList(); } },
                {"rubricQualityFeedback", n => { RubricQualityFeedback = n.GetCollectionOfObjectValues<RubricQualityFeedbackModel>(RubricQualityFeedbackModel.CreateFromDiscriminatorValue)?.ToList(); } },
                {"rubricQualitySelectedLevels", n => { RubricQualitySelectedLevels = n.GetCollectionOfObjectValues<RubricQualitySelectedColumnModel>(RubricQualitySelectedColumnModel.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<RubricQualityFeedbackModel>("publishedRubricQualityFeedback", PublishedRubricQualityFeedback);
            writer.WriteCollectionOfObjectValues<RubricQualitySelectedColumnModel>("publishedRubricQualitySelectedLevels", PublishedRubricQualitySelectedLevels);
            writer.WriteCollectionOfObjectValues<RubricQualityFeedbackModel>("rubricQualityFeedback", RubricQualityFeedback);
            writer.WriteCollectionOfObjectValues<RubricQualitySelectedColumnModel>("rubricQualitySelectedLevels", RubricQualitySelectedLevels);
        }
    }
}
