using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    /// <summary>
    /// intuneBrand contains data which is used in customizing the appearance of the Company Portal applications as well as the end user web portal.
    /// </summary>
    public class IntuneBrand : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Email address of the person/organization responsible for IT support.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContactITEmailAddress { get; set; }
#nullable restore
#else
        public string ContactITEmailAddress { get; set; }
#endif
        /// <summary>Name of the person/organization responsible for IT support.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContactITName { get; set; }
#nullable restore
#else
        public string ContactITName { get; set; }
#endif
        /// <summary>Text comments regarding the person/organization responsible for IT support.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContactITNotes { get; set; }
#nullable restore
#else
        public string ContactITNotes { get; set; }
#endif
        /// <summary>Phone number of the person/organization responsible for IT support.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContactITPhoneNumber { get; set; }
#nullable restore
#else
        public string ContactITPhoneNumber { get; set; }
#endif
        /// <summary>Logo image displayed in Company Portal apps which have a dark background behind the logo.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MimeContent? DarkBackgroundLogo { get; set; }
#nullable restore
#else
        public MimeContent DarkBackgroundLogo { get; set; }
#endif
        /// <summary>Company/organization name that is displayed to end users.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Logo image displayed in Company Portal apps which have a light background behind the logo.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MimeContent? LightBackgroundLogo { get; set; }
#nullable restore
#else
        public MimeContent LightBackgroundLogo { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Display name of the company/organization’s IT helpdesk site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnlineSupportSiteName { get; set; }
#nullable restore
#else
        public string OnlineSupportSiteName { get; set; }
#endif
        /// <summary>URL to the company/organization’s IT helpdesk site.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnlineSupportSiteUrl { get; set; }
#nullable restore
#else
        public string OnlineSupportSiteUrl { get; set; }
#endif
        /// <summary>URL to the company/organization’s privacy policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrivacyUrl { get; set; }
#nullable restore
#else
        public string PrivacyUrl { get; set; }
#endif
        /// <summary>Boolean that represents whether the administrator-supplied display name will be shown next to the logo image.</summary>
        public bool? ShowDisplayNameNextToLogo { get; set; }
        /// <summary>Boolean that represents whether the administrator-supplied logo images are shown or not shown.</summary>
        public bool? ShowLogo { get; set; }
        /// <summary>Boolean that represents whether the administrator-supplied display name will be shown next to the logo image.</summary>
        public bool? ShowNameNextToLogo { get; set; }
        /// <summary>Primary theme color used in the Company Portal applications and web portal.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RgbColor? ThemeColor { get; set; }
#nullable restore
#else
        public RgbColor ThemeColor { get; set; }
#endif
        /// <summary>
        /// Instantiates a new intuneBrand and sets the default values.
        /// </summary>
        public IntuneBrand() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IntuneBrand CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IntuneBrand();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"contactITEmailAddress", n => { ContactITEmailAddress = n.GetStringValue(); } },
                {"contactITName", n => { ContactITName = n.GetStringValue(); } },
                {"contactITNotes", n => { ContactITNotes = n.GetStringValue(); } },
                {"contactITPhoneNumber", n => { ContactITPhoneNumber = n.GetStringValue(); } },
                {"darkBackgroundLogo", n => { DarkBackgroundLogo = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lightBackgroundLogo", n => { LightBackgroundLogo = n.GetObjectValue<MimeContent>(MimeContent.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"onlineSupportSiteName", n => { OnlineSupportSiteName = n.GetStringValue(); } },
                {"onlineSupportSiteUrl", n => { OnlineSupportSiteUrl = n.GetStringValue(); } },
                {"privacyUrl", n => { PrivacyUrl = n.GetStringValue(); } },
                {"showDisplayNameNextToLogo", n => { ShowDisplayNameNextToLogo = n.GetBoolValue(); } },
                {"showLogo", n => { ShowLogo = n.GetBoolValue(); } },
                {"showNameNextToLogo", n => { ShowNameNextToLogo = n.GetBoolValue(); } },
                {"themeColor", n => { ThemeColor = n.GetObjectValue<RgbColor>(RgbColor.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("contactITEmailAddress", ContactITEmailAddress);
            writer.WriteStringValue("contactITName", ContactITName);
            writer.WriteStringValue("contactITNotes", ContactITNotes);
            writer.WriteStringValue("contactITPhoneNumber", ContactITPhoneNumber);
            writer.WriteObjectValue<MimeContent>("darkBackgroundLogo", DarkBackgroundLogo);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<MimeContent>("lightBackgroundLogo", LightBackgroundLogo);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("onlineSupportSiteName", OnlineSupportSiteName);
            writer.WriteStringValue("onlineSupportSiteUrl", OnlineSupportSiteUrl);
            writer.WriteStringValue("privacyUrl", PrivacyUrl);
            writer.WriteBoolValue("showDisplayNameNextToLogo", ShowDisplayNameNextToLogo);
            writer.WriteBoolValue("showLogo", ShowLogo);
            writer.WriteBoolValue("showNameNextToLogo", ShowNameNextToLogo);
            writer.WriteObjectValue<RgbColor>("themeColor", ThemeColor);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
