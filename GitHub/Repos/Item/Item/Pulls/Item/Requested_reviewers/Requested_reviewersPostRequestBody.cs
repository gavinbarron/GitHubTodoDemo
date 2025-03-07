using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.GitHub.Repos.Item.Item.Pulls.Item.Requested_reviewers {
    public class Requested_reviewersPostRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>An array of user `login`s that will be requested.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Reviewers { get; set; }
#nullable restore
#else
        public List<string> Reviewers { get; set; }
#endif
        /// <summary>An array of team `slug`s that will be requested.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Team_reviewers { get; set; }
#nullable restore
#else
        public List<string> Team_reviewers { get; set; }
#endif
        /// <summary>
        /// Instantiates a new requested_reviewersPostRequestBody and sets the default values.
        /// </summary>
        public Requested_reviewersPostRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Requested_reviewersPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Requested_reviewersPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"reviewers", n => { Reviewers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"team_reviewers", n => { Team_reviewers = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("reviewers", Reviewers);
            writer.WriteCollectionOfPrimitiveValues<string>("team_reviewers", Team_reviewers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
