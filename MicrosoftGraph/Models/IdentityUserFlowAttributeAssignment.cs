using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class IdentityUserFlowAttributeAssignment : Entity, IParsable {
        /// <summary>The display name of the identityUserFlowAttribute within a user flow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Determines whether the identityUserFlowAttribute is optional. true means the user doesn&apos;t have to provide a value. false means the user cannot complete sign-up without providing a value.</summary>
        public bool? IsOptional { get; set; }
        /// <summary>Determines whether the identityUserFlowAttribute requires verification. This is only used for verifying the user&apos;s phone number or email address.</summary>
        public bool? RequiresVerification { get; set; }
        /// <summary>The user attribute that you want to add to your user flow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentityUserFlowAttribute? UserAttribute { get; set; }
#nullable restore
#else
        public IdentityUserFlowAttribute UserAttribute { get; set; }
#endif
        /// <summary>The input options for the user flow attribute. Only applicable when the userInputType is radioSingleSelect, dropdownSingleSelect, or checkboxMultiSelect.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserAttributeValuesItem>? UserAttributeValues { get; set; }
#nullable restore
#else
        public List<UserAttributeValuesItem> UserAttributeValues { get; set; }
#endif
        /// <summary>The userInputType property</summary>
        public IdentityUserFlowAttributeInputType? UserInputType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IdentityUserFlowAttributeAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IdentityUserFlowAttributeAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isOptional", n => { IsOptional = n.GetBoolValue(); } },
                {"requiresVerification", n => { RequiresVerification = n.GetBoolValue(); } },
                {"userAttribute", n => { UserAttribute = n.GetObjectValue<IdentityUserFlowAttribute>(IdentityUserFlowAttribute.CreateFromDiscriminatorValue); } },
                {"userAttributeValues", n => { UserAttributeValues = n.GetCollectionOfObjectValues<UserAttributeValuesItem>(UserAttributeValuesItem.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userInputType", n => { UserInputType = n.GetEnumValue<IdentityUserFlowAttributeInputType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isOptional", IsOptional);
            writer.WriteBoolValue("requiresVerification", RequiresVerification);
            writer.WriteObjectValue<IdentityUserFlowAttribute>("userAttribute", UserAttribute);
            writer.WriteCollectionOfObjectValues<UserAttributeValuesItem>("userAttributeValues", UserAttributeValues);
            writer.WriteEnumValue<IdentityUserFlowAttributeInputType>("userInputType", UserInputType);
        }
    }
}
