using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.GitHub.Models {
    public class PullRequestSimple_head : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The label property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Label { get; set; }
#nullable restore
#else
        public string Label { get; set; }
#endif
        /// <summary>The ref property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ref { get; set; }
#nullable restore
#else
        public string Ref { get; set; }
#endif
        /// <summary>A git repository</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Repository? Repo { get; set; }
#nullable restore
#else
        public Repository Repo { get; set; }
#endif
        /// <summary>The sha property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sha { get; set; }
#nullable restore
#else
        public string Sha { get; set; }
#endif
        /// <summary>The user property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimpleUser? User { get; set; }
#nullable restore
#else
        public SimpleUser User { get; set; }
#endif
        /// <summary>
        /// Instantiates a new PullRequestSimple_head and sets the default values.
        /// </summary>
        public PullRequestSimple_head() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PullRequestSimple_head CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PullRequestSimple_head();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"label", n => { Label = n.GetStringValue(); } },
                {"ref", n => { Ref = n.GetStringValue(); } },
                {"repo", n => { Repo = n.GetObjectValue<Repository>(Repository.CreateFromDiscriminatorValue); } },
                {"sha", n => { Sha = n.GetStringValue(); } },
                {"user", n => { User = n.GetObjectValue<SimpleUser>(SimpleUser.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("label", Label);
            writer.WriteStringValue("ref", Ref);
            writer.WriteObjectValue<Repository>("repo", Repo);
            writer.WriteStringValue("sha", Sha);
            writer.WriteObjectValue<SimpleUser>("user", User);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
