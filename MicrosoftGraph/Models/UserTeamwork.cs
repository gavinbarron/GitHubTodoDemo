using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class UserTeamwork : Entity, IParsable {
        /// <summary>The list of associatedTeamInfo objects that a user is associated with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AssociatedTeamInfo>? AssociatedTeams { get; set; }
#nullable restore
#else
        public List<AssociatedTeamInfo> AssociatedTeams { get; set; }
#endif
        /// <summary>The apps installed in the personal scope of this user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserScopeTeamsAppInstallation>? InstalledApps { get; set; }
#nullable restore
#else
        public List<UserScopeTeamsAppInstallation> InstalledApps { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserTeamwork CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserTeamwork();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"associatedTeams", n => { AssociatedTeams = n.GetCollectionOfObjectValues<AssociatedTeamInfo>(AssociatedTeamInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                {"installedApps", n => { InstalledApps = n.GetCollectionOfObjectValues<UserScopeTeamsAppInstallation>(UserScopeTeamsAppInstallation.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AssociatedTeamInfo>("associatedTeams", AssociatedTeams);
            writer.WriteCollectionOfObjectValues<UserScopeTeamsAppInstallation>("installedApps", InstalledApps);
        }
    }
}
