using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class TemporaryAccessPassAuthenticationMethodConfiguration : AuthenticationMethodConfiguration, IParsable {
        /// <summary>Default length in characters of a Temporary Access Pass object. Must be between 8 and 48 characters.</summary>
        public int? DefaultLength { get; set; }
        /// <summary>Default lifetime in minutes for a Temporary Access Pass. Value can be any integer between the minimumLifetimeInMinutes and maximumLifetimeInMinutes.</summary>
        public int? DefaultLifetimeInMinutes { get; set; }
        /// <summary>A collection of groups that are enabled to use the authentication method.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AuthenticationMethodTarget>? IncludeTargets { get; set; }
#nullable restore
#else
        public List<AuthenticationMethodTarget> IncludeTargets { get; set; }
#endif
        /// <summary>If true, all the passes in the tenant will be restricted to one-time use. If false, passes in the tenant can be created to be either one-time use or reusable.</summary>
        public bool? IsUsableOnce { get; set; }
        /// <summary>Maximum lifetime in minutes for any Temporary Access Pass created in the tenant. Value can be between 10 and 43200 minutes (equivalent to 30 days).</summary>
        public int? MaximumLifetimeInMinutes { get; set; }
        /// <summary>Minimum lifetime in minutes for any Temporary Access Pass created in the tenant. Value can be between 10 and 43200 minutes (equivalent to 30 days).</summary>
        public int? MinimumLifetimeInMinutes { get; set; }
        /// <summary>
        /// Instantiates a new TemporaryAccessPassAuthenticationMethodConfiguration and sets the default values.
        /// </summary>
        public TemporaryAccessPassAuthenticationMethodConfiguration() : base() {
            OdataType = "#microsoft.graph.temporaryAccessPassAuthenticationMethodConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TemporaryAccessPassAuthenticationMethodConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TemporaryAccessPassAuthenticationMethodConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"defaultLength", n => { DefaultLength = n.GetIntValue(); } },
                {"defaultLifetimeInMinutes", n => { DefaultLifetimeInMinutes = n.GetIntValue(); } },
                {"includeTargets", n => { IncludeTargets = n.GetCollectionOfObjectValues<AuthenticationMethodTarget>(AuthenticationMethodTarget.CreateFromDiscriminatorValue)?.ToList(); } },
                {"isUsableOnce", n => { IsUsableOnce = n.GetBoolValue(); } },
                {"maximumLifetimeInMinutes", n => { MaximumLifetimeInMinutes = n.GetIntValue(); } },
                {"minimumLifetimeInMinutes", n => { MinimumLifetimeInMinutes = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("defaultLength", DefaultLength);
            writer.WriteIntValue("defaultLifetimeInMinutes", DefaultLifetimeInMinutes);
            writer.WriteCollectionOfObjectValues<AuthenticationMethodTarget>("includeTargets", IncludeTargets);
            writer.WriteBoolValue("isUsableOnce", IsUsableOnce);
            writer.WriteIntValue("maximumLifetimeInMinutes", MaximumLifetimeInMinutes);
            writer.WriteIntValue("minimumLifetimeInMinutes", MinimumLifetimeInMinutes);
        }
    }
}
