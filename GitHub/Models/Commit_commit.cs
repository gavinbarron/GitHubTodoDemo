using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.GitHub.Models {
    public class Commit_commit : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The author property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitUser? Author { get; set; }
#nullable restore
#else
        public GitUser Author { get; set; }
#endif
        /// <summary>The comment_count property</summary>
        public int? Comment_count { get; set; }
        /// <summary>The committer property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitUser? Committer { get; set; }
#nullable restore
#else
        public GitUser Committer { get; set; }
#endif
        /// <summary>The message property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message { get; set; }
#nullable restore
#else
        public string Message { get; set; }
#endif
        /// <summary>The tree property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Commit_commit_tree? Tree { get; set; }
#nullable restore
#else
        public Commit_commit_tree Tree { get; set; }
#endif
        /// <summary>The url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>The verification property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public GitHubTodoDemo.GitHub.Models.Verification? Verification { get; set; }
#nullable restore
#else
        public GitHubTodoDemo.GitHub.Models.Verification Verification { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Commit_commit and sets the default values.
        /// </summary>
        public Commit_commit() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Commit_commit CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Commit_commit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"author", n => { Author = n.GetObjectValue<GitUser>(GitUser.CreateFromDiscriminatorValue); } },
                {"comment_count", n => { Comment_count = n.GetIntValue(); } },
                {"committer", n => { Committer = n.GetObjectValue<GitUser>(GitUser.CreateFromDiscriminatorValue); } },
                {"message", n => { Message = n.GetStringValue(); } },
                {"tree", n => { Tree = n.GetObjectValue<Commit_commit_tree>(Commit_commit_tree.CreateFromDiscriminatorValue); } },
                {"url", n => { Url = n.GetStringValue(); } },
                {"verification", n => { Verification = n.GetObjectValue<GitHubTodoDemo.GitHub.Models.Verification>(GitHubTodoDemo.GitHub.Models.Verification.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<GitUser>("author", Author);
            writer.WriteIntValue("comment_count", Comment_count);
            writer.WriteObjectValue<GitUser>("committer", Committer);
            writer.WriteStringValue("message", Message);
            writer.WriteObjectValue<Commit_commit_tree>("tree", Tree);
            writer.WriteStringValue("url", Url);
            writer.WriteObjectValue<GitHubTodoDemo.GitHub.Models.Verification>("verification", Verification);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
