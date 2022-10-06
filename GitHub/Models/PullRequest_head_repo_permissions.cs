using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GithubTodoDemo.GitHub.Models {
    public class PullRequest_head_repo_permissions : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The admin property</summary>
        public bool? Admin { get; set; }
        /// <summary>The maintain property</summary>
        public bool? Maintain { get; set; }
        /// <summary>The pull property</summary>
        public bool? Pull { get; set; }
        /// <summary>The push property</summary>
        public bool? Push { get; set; }
        /// <summary>The triage property</summary>
        public bool? Triage { get; set; }
        /// <summary>
        /// Instantiates a new PullRequest_head_repo_permissions and sets the default values.
        /// </summary>
        public PullRequest_head_repo_permissions() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PullRequest_head_repo_permissions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PullRequest_head_repo_permissions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"admin", n => { Admin = n.GetBoolValue(); } },
                {"maintain", n => { Maintain = n.GetBoolValue(); } },
                {"pull", n => { Pull = n.GetBoolValue(); } },
                {"push", n => { Push = n.GetBoolValue(); } },
                {"triage", n => { Triage = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("admin", Admin);
            writer.WriteBoolValue("maintain", Maintain);
            writer.WriteBoolValue("pull", Pull);
            writer.WriteBoolValue("push", Push);
            writer.WriteBoolValue("triage", Triage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
