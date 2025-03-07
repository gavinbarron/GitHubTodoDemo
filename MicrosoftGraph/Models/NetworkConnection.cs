using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class NetworkConnection : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name of the application managing the network connection (for example, Facebook or SMTP).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApplicationName { get; set; }
#nullable restore
#else
        public string ApplicationName { get; set; }
#endif
        /// <summary>Destination IP address (of the network connection).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationAddress { get; set; }
#nullable restore
#else
        public string DestinationAddress { get; set; }
#endif
        /// <summary>Destination domain portion of the destination URL. (for example &apos;www.contoso.com&apos;).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationDomain { get; set; }
#nullable restore
#else
        public string DestinationDomain { get; set; }
#endif
        /// <summary>Location (by IP address mapping) associated with the destination of a network connection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationLocation { get; set; }
#nullable restore
#else
        public string DestinationLocation { get; set; }
#endif
        /// <summary>Destination port (of the network connection).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationPort { get; set; }
#nullable restore
#else
        public string DestinationPort { get; set; }
#endif
        /// <summary>Network connection URL/URI string - excluding parameters. (for example &apos;www.contoso.com/products/default.html&apos;)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DestinationUrl { get; set; }
#nullable restore
#else
        public string DestinationUrl { get; set; }
#endif
        /// <summary>Network connection direction. Possible values are: unknown, inbound, outbound.</summary>
        public ConnectionDirection? Direction { get; set; }
        /// <summary>Date when the destination domain was registered. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? DomainRegisteredDateTime { get; set; }
        /// <summary>The local DNS name resolution as it appears in the host&apos;s local DNS cache (for example, in case the &apos;hosts&apos; file was tampered with).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocalDnsName { get; set; }
#nullable restore
#else
        public string LocalDnsName { get; set; }
#endif
        /// <summary>Network Address Translation destination IP address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NatDestinationAddress { get; set; }
#nullable restore
#else
        public string NatDestinationAddress { get; set; }
#endif
        /// <summary>Network Address Translation destination port.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NatDestinationPort { get; set; }
#nullable restore
#else
        public string NatDestinationPort { get; set; }
#endif
        /// <summary>Network Address Translation source IP address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NatSourceAddress { get; set; }
#nullable restore
#else
        public string NatSourceAddress { get; set; }
#endif
        /// <summary>Network Address Translation source port.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NatSourcePort { get; set; }
#nullable restore
#else
        public string NatSourcePort { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Network protocol. Possible values are: unknown, ip, icmp, igmp, ggp, ipv4, tcp, pup, udp, idp, ipv6, ipv6RoutingHeader, ipv6FragmentHeader, ipSecEncapsulatingSecurityPayload, ipSecAuthenticationHeader, icmpV6, ipv6NoNextHeader, ipv6DestinationOptions, nd, raw, ipx, spx, spxII.</summary>
        public SecurityNetworkProtocol? Protocol { get; set; }
        /// <summary>Provider generated/calculated risk score of the network connection. Recommended value range of 0-1, which equates to a percentage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RiskScore { get; set; }
#nullable restore
#else
        public string RiskScore { get; set; }
#endif
        /// <summary>Source (i.e. origin) IP address (of the network connection).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceAddress { get; set; }
#nullable restore
#else
        public string SourceAddress { get; set; }
#endif
        /// <summary>Location (by IP address mapping) associated with the source of a network connection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceLocation { get; set; }
#nullable restore
#else
        public string SourceLocation { get; set; }
#endif
        /// <summary>Source (i.e. origin) IP port (of the network connection).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourcePort { get; set; }
#nullable restore
#else
        public string SourcePort { get; set; }
#endif
        /// <summary>Network connection status. Possible values are: unknown, attempted, succeeded, blocked, failed.</summary>
        public ConnectionStatus? Status { get; set; }
        /// <summary>Parameters (suffix) of the destination URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UrlParameters { get; set; }
#nullable restore
#else
        public string UrlParameters { get; set; }
#endif
        /// <summary>
        /// Instantiates a new networkConnection and sets the default values.
        /// </summary>
        public NetworkConnection() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static NetworkConnection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new NetworkConnection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"applicationName", n => { ApplicationName = n.GetStringValue(); } },
                {"destinationAddress", n => { DestinationAddress = n.GetStringValue(); } },
                {"destinationDomain", n => { DestinationDomain = n.GetStringValue(); } },
                {"destinationLocation", n => { DestinationLocation = n.GetStringValue(); } },
                {"destinationPort", n => { DestinationPort = n.GetStringValue(); } },
                {"destinationUrl", n => { DestinationUrl = n.GetStringValue(); } },
                {"direction", n => { Direction = n.GetEnumValue<ConnectionDirection>(); } },
                {"domainRegisteredDateTime", n => { DomainRegisteredDateTime = n.GetDateTimeOffsetValue(); } },
                {"localDnsName", n => { LocalDnsName = n.GetStringValue(); } },
                {"natDestinationAddress", n => { NatDestinationAddress = n.GetStringValue(); } },
                {"natDestinationPort", n => { NatDestinationPort = n.GetStringValue(); } },
                {"natSourceAddress", n => { NatSourceAddress = n.GetStringValue(); } },
                {"natSourcePort", n => { NatSourcePort = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"protocol", n => { Protocol = n.GetEnumValue<SecurityNetworkProtocol>(); } },
                {"riskScore", n => { RiskScore = n.GetStringValue(); } },
                {"sourceAddress", n => { SourceAddress = n.GetStringValue(); } },
                {"sourceLocation", n => { SourceLocation = n.GetStringValue(); } },
                {"sourcePort", n => { SourcePort = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<ConnectionStatus>(); } },
                {"urlParameters", n => { UrlParameters = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("applicationName", ApplicationName);
            writer.WriteStringValue("destinationAddress", DestinationAddress);
            writer.WriteStringValue("destinationDomain", DestinationDomain);
            writer.WriteStringValue("destinationLocation", DestinationLocation);
            writer.WriteStringValue("destinationPort", DestinationPort);
            writer.WriteStringValue("destinationUrl", DestinationUrl);
            writer.WriteEnumValue<ConnectionDirection>("direction", Direction);
            writer.WriteDateTimeOffsetValue("domainRegisteredDateTime", DomainRegisteredDateTime);
            writer.WriteStringValue("localDnsName", LocalDnsName);
            writer.WriteStringValue("natDestinationAddress", NatDestinationAddress);
            writer.WriteStringValue("natDestinationPort", NatDestinationPort);
            writer.WriteStringValue("natSourceAddress", NatSourceAddress);
            writer.WriteStringValue("natSourcePort", NatSourcePort);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<SecurityNetworkProtocol>("protocol", Protocol);
            writer.WriteStringValue("riskScore", RiskScore);
            writer.WriteStringValue("sourceAddress", SourceAddress);
            writer.WriteStringValue("sourceLocation", SourceLocation);
            writer.WriteStringValue("sourcePort", SourcePort);
            writer.WriteEnumValue<ConnectionStatus>("status", Status);
            writer.WriteStringValue("urlParameters", UrlParameters);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
