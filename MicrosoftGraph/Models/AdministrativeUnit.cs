using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class AdministrativeUnit : DirectoryObject, IParsable {
        /// <summary>An optional description for the administrative unit. Supports $filter (eq, ne, in, startsWith), $search.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Display name for the administrative unit. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The collection of open extensions defined for this administrative unit. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Extension>? Extensions { get; set; }
#nullable restore
#else
        public List<Extension> Extensions { get; set; }
#endif
        /// <summary>Users and groups that are members of this administrative unit. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DirectoryObject>? Members { get; set; }
#nullable restore
#else
        public List<DirectoryObject> Members { get; set; }
#endif
        /// <summary>Scoped-role members of this administrative unit.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ScopedRoleMembership>? ScopedRoleMembers { get; set; }
#nullable restore
#else
        public List<ScopedRoleMembership> ScopedRoleMembers { get; set; }
#endif
        /// <summary>Controls whether the administrative unit and its members are hidden or public. Can be set to HiddenMembership. If not set (value is null), the default behavior is public. When set to HiddenMembership, only members of the administrative unit can list other members of the administrative unit.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Visibility { get; set; }
#nullable restore
#else
        public string Visibility { get; set; }
#endif
        /// <summary>
        /// Instantiates a new AdministrativeUnit and sets the default values.
        /// </summary>
        public AdministrativeUnit() : base() {
            OdataType = "#microsoft.graph.administrativeUnit";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AdministrativeUnit CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AdministrativeUnit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"extensions", n => { Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue)?.ToList(); } },
                {"members", n => { Members = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                {"scopedRoleMembers", n => { ScopedRoleMembers = n.GetCollectionOfObjectValues<ScopedRoleMembership>(ScopedRoleMembership.CreateFromDiscriminatorValue)?.ToList(); } },
                {"visibility", n => { Visibility = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("members", Members);
            writer.WriteCollectionOfObjectValues<ScopedRoleMembership>("scopedRoleMembers", ScopedRoleMembers);
            writer.WriteStringValue("visibility", Visibility);
        }
    }
}
