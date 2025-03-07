using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class TeleconferenceDeviceMediaQuality : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The average inbound stream network jitter.</summary>
        public TimeSpan? AverageInboundJitter { get; set; }
        /// <summary>The average inbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.</summary>
        public double? AverageInboundPacketLossRateInPercentage { get; set; }
        /// <summary>The average inbound stream network round trip delay.</summary>
        public TimeSpan? AverageInboundRoundTripDelay { get; set; }
        /// <summary>The average outbound stream network jitter.</summary>
        public TimeSpan? AverageOutboundJitter { get; set; }
        /// <summary>The average outbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.</summary>
        public double? AverageOutboundPacketLossRateInPercentage { get; set; }
        /// <summary>The average outbound stream network round trip delay.</summary>
        public TimeSpan? AverageOutboundRoundTripDelay { get; set; }
        /// <summary>The channel index of media. Indexing begins with 1.  If a media session contains 3 video modalities, channel indexes will be 1, 2, and 3.</summary>
        public int? ChannelIndex { get; set; }
        /// <summary>The total number of the inbound packets.</summary>
        public long? InboundPackets { get; set; }
        /// <summary>the local IP address for the media session.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocalIPAddress { get; set; }
#nullable restore
#else
        public string LocalIPAddress { get; set; }
#endif
        /// <summary>The local media port.</summary>
        public int? LocalPort { get; set; }
        /// <summary>The maximum inbound stream network jitter.</summary>
        public TimeSpan? MaximumInboundJitter { get; set; }
        /// <summary>The maximum inbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.</summary>
        public double? MaximumInboundPacketLossRateInPercentage { get; set; }
        /// <summary>The maximum inbound stream network round trip delay.</summary>
        public TimeSpan? MaximumInboundRoundTripDelay { get; set; }
        /// <summary>The maximum outbound stream network jitter.</summary>
        public TimeSpan? MaximumOutboundJitter { get; set; }
        /// <summary>The maximum outbound stream packet loss rate in percentage (0-100). For example, 0.01 means 0.01%.</summary>
        public double? MaximumOutboundPacketLossRateInPercentage { get; set; }
        /// <summary>The maximum outbound stream network round trip delay.</summary>
        public TimeSpan? MaximumOutboundRoundTripDelay { get; set; }
        /// <summary>The total modality duration. If the media enabled and disabled multiple times, MediaDuration will the summation of all of the durations.</summary>
        public TimeSpan? MediaDuration { get; set; }
        /// <summary>The network link speed in bytes</summary>
        public long? NetworkLinkSpeedInBytes { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The total number of the outbound packets.</summary>
        public long? OutboundPackets { get; set; }
        /// <summary>The remote IP address for the media session.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemoteIPAddress { get; set; }
#nullable restore
#else
        public string RemoteIPAddress { get; set; }
#endif
        /// <summary>The remote media port.</summary>
        public int? RemotePort { get; set; }
        /// <summary>
        /// Instantiates a new teleconferenceDeviceMediaQuality and sets the default values.
        /// </summary>
        public TeleconferenceDeviceMediaQuality() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TeleconferenceDeviceMediaQuality CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.teleconferenceDeviceAudioQuality" => new TeleconferenceDeviceAudioQuality(),
                "#microsoft.graph.teleconferenceDeviceScreenSharingQuality" => new TeleconferenceDeviceScreenSharingQuality(),
                "#microsoft.graph.teleconferenceDeviceVideoQuality" => new TeleconferenceDeviceVideoQuality(),
                _ => new TeleconferenceDeviceMediaQuality(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"averageInboundJitter", n => { AverageInboundJitter = n.GetTimeSpanValue(); } },
                {"averageInboundPacketLossRateInPercentage", n => { AverageInboundPacketLossRateInPercentage = n.GetDoubleValue(); } },
                {"averageInboundRoundTripDelay", n => { AverageInboundRoundTripDelay = n.GetTimeSpanValue(); } },
                {"averageOutboundJitter", n => { AverageOutboundJitter = n.GetTimeSpanValue(); } },
                {"averageOutboundPacketLossRateInPercentage", n => { AverageOutboundPacketLossRateInPercentage = n.GetDoubleValue(); } },
                {"averageOutboundRoundTripDelay", n => { AverageOutboundRoundTripDelay = n.GetTimeSpanValue(); } },
                {"channelIndex", n => { ChannelIndex = n.GetIntValue(); } },
                {"inboundPackets", n => { InboundPackets = n.GetLongValue(); } },
                {"localIPAddress", n => { LocalIPAddress = n.GetStringValue(); } },
                {"localPort", n => { LocalPort = n.GetIntValue(); } },
                {"maximumInboundJitter", n => { MaximumInboundJitter = n.GetTimeSpanValue(); } },
                {"maximumInboundPacketLossRateInPercentage", n => { MaximumInboundPacketLossRateInPercentage = n.GetDoubleValue(); } },
                {"maximumInboundRoundTripDelay", n => { MaximumInboundRoundTripDelay = n.GetTimeSpanValue(); } },
                {"maximumOutboundJitter", n => { MaximumOutboundJitter = n.GetTimeSpanValue(); } },
                {"maximumOutboundPacketLossRateInPercentage", n => { MaximumOutboundPacketLossRateInPercentage = n.GetDoubleValue(); } },
                {"maximumOutboundRoundTripDelay", n => { MaximumOutboundRoundTripDelay = n.GetTimeSpanValue(); } },
                {"mediaDuration", n => { MediaDuration = n.GetTimeSpanValue(); } },
                {"networkLinkSpeedInBytes", n => { NetworkLinkSpeedInBytes = n.GetLongValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"outboundPackets", n => { OutboundPackets = n.GetLongValue(); } },
                {"remoteIPAddress", n => { RemoteIPAddress = n.GetStringValue(); } },
                {"remotePort", n => { RemotePort = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteTimeSpanValue("averageInboundJitter", AverageInboundJitter);
            writer.WriteDoubleValue("averageInboundPacketLossRateInPercentage", AverageInboundPacketLossRateInPercentage);
            writer.WriteTimeSpanValue("averageInboundRoundTripDelay", AverageInboundRoundTripDelay);
            writer.WriteTimeSpanValue("averageOutboundJitter", AverageOutboundJitter);
            writer.WriteDoubleValue("averageOutboundPacketLossRateInPercentage", AverageOutboundPacketLossRateInPercentage);
            writer.WriteTimeSpanValue("averageOutboundRoundTripDelay", AverageOutboundRoundTripDelay);
            writer.WriteIntValue("channelIndex", ChannelIndex);
            writer.WriteLongValue("inboundPackets", InboundPackets);
            writer.WriteStringValue("localIPAddress", LocalIPAddress);
            writer.WriteIntValue("localPort", LocalPort);
            writer.WriteTimeSpanValue("maximumInboundJitter", MaximumInboundJitter);
            writer.WriteDoubleValue("maximumInboundPacketLossRateInPercentage", MaximumInboundPacketLossRateInPercentage);
            writer.WriteTimeSpanValue("maximumInboundRoundTripDelay", MaximumInboundRoundTripDelay);
            writer.WriteTimeSpanValue("maximumOutboundJitter", MaximumOutboundJitter);
            writer.WriteDoubleValue("maximumOutboundPacketLossRateInPercentage", MaximumOutboundPacketLossRateInPercentage);
            writer.WriteTimeSpanValue("maximumOutboundRoundTripDelay", MaximumOutboundRoundTripDelay);
            writer.WriteTimeSpanValue("mediaDuration", MediaDuration);
            writer.WriteLongValue("networkLinkSpeedInBytes", NetworkLinkSpeedInBytes);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteLongValue("outboundPackets", OutboundPackets);
            writer.WriteStringValue("remoteIPAddress", RemoteIPAddress);
            writer.WriteIntValue("remotePort", RemotePort);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
