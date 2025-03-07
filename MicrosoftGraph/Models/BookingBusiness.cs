using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class BookingBusiness : Entity, IParsable {
        /// <summary>The street address of the business. The address property, together with phone and webSiteUrl, appear in the footer of a business scheduling page. The attribute type of physicalAddress is not supported in v1.0. Internally we map the addresses to the type others.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PhysicalAddress? Address { get; set; }
#nullable restore
#else
        public PhysicalAddress Address { get; set; }
#endif
        /// <summary>All the appointments of this business. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BookingAppointment>? Appointments { get; set; }
#nullable restore
#else
        public List<BookingAppointment> Appointments { get; set; }
#endif
        /// <summary>The hours of operation for the business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BookingWorkHours>? BusinessHours { get; set; }
#nullable restore
#else
        public List<BookingWorkHours> BusinessHours { get; set; }
#endif
        /// <summary>The type of business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessType { get; set; }
#nullable restore
#else
        public string BusinessType { get; set; }
#endif
        /// <summary>The set of appointments of this business in a specified date range. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BookingAppointment>? CalendarView { get; set; }
#nullable restore
#else
        public List<BookingAppointment> CalendarView { get; set; }
#endif
        /// <summary>All the customers of this business. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BookingCustomerBase>? Customers { get; set; }
#nullable restore
#else
        public List<BookingCustomerBase> Customers { get; set; }
#endif
        /// <summary>All the custom questions of this business. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BookingCustomQuestion>? CustomQuestions { get; set; }
#nullable restore
#else
        public List<BookingCustomQuestion> CustomQuestions { get; set; }
#endif
        /// <summary>The code for the currency that the business operates in on Microsoft Bookings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultCurrencyIso { get; set; }
#nullable restore
#else
        public string DefaultCurrencyIso { get; set; }
#endif
        /// <summary>The name of the business, which interfaces with customers. This name appears at the top of the business scheduling page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The email address for the business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email { get; set; }
#nullable restore
#else
        public string Email { get; set; }
#endif
        /// <summary>The scheduling page has been made available to external customers. Use the publish and unpublish actions to set this property. Read-only.</summary>
        public bool? IsPublished { get; private set; }
        /// <summary>The language of the self-service booking page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LanguageTag { get; set; }
#nullable restore
#else
        public string LanguageTag { get; set; }
#endif
        /// <summary>The telephone number for the business. The phone property, together with address and webSiteUrl, appear in the footer of a business scheduling page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Phone { get; set; }
#nullable restore
#else
        public string Phone { get; set; }
#endif
        /// <summary>The URL for the scheduling page, which is set after you publish or unpublish the page. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublicUrl { get; private set; }
#nullable restore
#else
        public string PublicUrl { get; private set; }
#endif
        /// <summary>Specifies how bookings can be created for this business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BookingSchedulingPolicy? SchedulingPolicy { get; set; }
#nullable restore
#else
        public BookingSchedulingPolicy SchedulingPolicy { get; set; }
#endif
        /// <summary>All the services offered by this business. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BookingService>? Services { get; set; }
#nullable restore
#else
        public List<BookingService> Services { get; set; }
#endif
        /// <summary>All the staff members that provide services in this business. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BookingStaffMemberBase>? StaffMembers { get; set; }
#nullable restore
#else
        public List<BookingStaffMemberBase> StaffMembers { get; set; }
#endif
        /// <summary>The URL of the business web site. The webSiteUrl property, together with address, phone, appear in the footer of a business scheduling page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebSiteUrl { get; set; }
#nullable restore
#else
        public string WebSiteUrl { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new BookingBusiness CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BookingBusiness();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"address", n => { Address = n.GetObjectValue<PhysicalAddress>(PhysicalAddress.CreateFromDiscriminatorValue); } },
                {"appointments", n => { Appointments = n.GetCollectionOfObjectValues<BookingAppointment>(BookingAppointment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"businessHours", n => { BusinessHours = n.GetCollectionOfObjectValues<BookingWorkHours>(BookingWorkHours.CreateFromDiscriminatorValue)?.ToList(); } },
                {"businessType", n => { BusinessType = n.GetStringValue(); } },
                {"calendarView", n => { CalendarView = n.GetCollectionOfObjectValues<BookingAppointment>(BookingAppointment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"customers", n => { Customers = n.GetCollectionOfObjectValues<BookingCustomerBase>(BookingCustomerBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"customQuestions", n => { CustomQuestions = n.GetCollectionOfObjectValues<BookingCustomQuestion>(BookingCustomQuestion.CreateFromDiscriminatorValue)?.ToList(); } },
                {"defaultCurrencyIso", n => { DefaultCurrencyIso = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"isPublished", n => { IsPublished = n.GetBoolValue(); } },
                {"languageTag", n => { LanguageTag = n.GetStringValue(); } },
                {"phone", n => { Phone = n.GetStringValue(); } },
                {"publicUrl", n => { PublicUrl = n.GetStringValue(); } },
                {"schedulingPolicy", n => { SchedulingPolicy = n.GetObjectValue<BookingSchedulingPolicy>(BookingSchedulingPolicy.CreateFromDiscriminatorValue); } },
                {"services", n => { Services = n.GetCollectionOfObjectValues<BookingService>(BookingService.CreateFromDiscriminatorValue)?.ToList(); } },
                {"staffMembers", n => { StaffMembers = n.GetCollectionOfObjectValues<BookingStaffMemberBase>(BookingStaffMemberBase.CreateFromDiscriminatorValue)?.ToList(); } },
                {"webSiteUrl", n => { WebSiteUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PhysicalAddress>("address", Address);
            writer.WriteCollectionOfObjectValues<BookingAppointment>("appointments", Appointments);
            writer.WriteCollectionOfObjectValues<BookingWorkHours>("businessHours", BusinessHours);
            writer.WriteStringValue("businessType", BusinessType);
            writer.WriteCollectionOfObjectValues<BookingAppointment>("calendarView", CalendarView);
            writer.WriteCollectionOfObjectValues<BookingCustomerBase>("customers", Customers);
            writer.WriteCollectionOfObjectValues<BookingCustomQuestion>("customQuestions", CustomQuestions);
            writer.WriteStringValue("defaultCurrencyIso", DefaultCurrencyIso);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("languageTag", LanguageTag);
            writer.WriteStringValue("phone", Phone);
            writer.WriteObjectValue<BookingSchedulingPolicy>("schedulingPolicy", SchedulingPolicy);
            writer.WriteCollectionOfObjectValues<BookingService>("services", Services);
            writer.WriteCollectionOfObjectValues<BookingStaffMemberBase>("staffMembers", StaffMembers);
            writer.WriteStringValue("webSiteUrl", WebSiteUrl);
        }
    }
}
