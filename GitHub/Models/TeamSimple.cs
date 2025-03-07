using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.GitHub.Models {
    /// <summary>
    /// Groups of organization members that gives permissions on specified repositories.
    /// </summary>
    public class TeamSimple : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Description of the team</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The html_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Html_url { get; set; }
#nullable restore
#else
        public string Html_url { get; set; }
#endif
        /// <summary>Unique identifier of the team</summary>
        public int? Id { get; set; }
        /// <summary>Distinguished Name (DN) that team maps to within LDAP environment</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Ldap_dn { get; set; }
#nullable restore
#else
        public string Ldap_dn { get; set; }
#endif
        /// <summary>The members_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Members_url { get; set; }
#nullable restore
#else
        public string Members_url { get; set; }
#endif
        /// <summary>Name of the team</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The node_id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Node_id { get; set; }
#nullable restore
#else
        public string Node_id { get; set; }
#endif
        /// <summary>Permission that the team will have for its repositories</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Permission { get; set; }
#nullable restore
#else
        public string Permission { get; set; }
#endif
        /// <summary>The level of privacy this team should have</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Privacy { get; set; }
#nullable restore
#else
        public string Privacy { get; set; }
#endif
        /// <summary>The repositories_url property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Repositories_url { get; set; }
#nullable restore
#else
        public string Repositories_url { get; set; }
#endif
        /// <summary>The slug property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Slug { get; set; }
#nullable restore
#else
        public string Slug { get; set; }
#endif
        /// <summary>URL for the team</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; set; }
#nullable restore
#else
        public string Url { get; set; }
#endif
        /// <summary>
        /// Instantiates a new teamSimple and sets the default values.
        /// </summary>
        public TeamSimple() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeamSimple CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamSimple();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"html_url", n => { Html_url = n.GetStringValue(); } },
                {"id", n => { Id = n.GetIntValue(); } },
                {"ldap_dn", n => { Ldap_dn = n.GetStringValue(); } },
                {"members_url", n => { Members_url = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"node_id", n => { Node_id = n.GetStringValue(); } },
                {"permission", n => { Permission = n.GetStringValue(); } },
                {"privacy", n => { Privacy = n.GetStringValue(); } },
                {"repositories_url", n => { Repositories_url = n.GetStringValue(); } },
                {"slug", n => { Slug = n.GetStringValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("html_url", Html_url);
            writer.WriteIntValue("id", Id);
            writer.WriteStringValue("ldap_dn", Ldap_dn);
            writer.WriteStringValue("members_url", Members_url);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("node_id", Node_id);
            writer.WriteStringValue("permission", Permission);
            writer.WriteStringValue("privacy", Privacy);
            writer.WriteStringValue("repositories_url", Repositories_url);
            writer.WriteStringValue("slug", Slug);
            writer.WriteStringValue("url", Url);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
