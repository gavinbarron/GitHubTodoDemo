using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models.CallRecords {
    public class DeviceInfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name of the capture device driver used by the media endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CaptureDeviceDriver { get; set; }
#nullable restore
#else
        public string CaptureDeviceDriver { get; set; }
#endif
        /// <summary>Name of the capture device used by the media endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CaptureDeviceName { get; set; }
#nullable restore
#else
        public string CaptureDeviceName { get; set; }
#endif
        /// <summary>Fraction of the call that the media endpoint detected the capture device was not working properly.</summary>
        public float? CaptureNotFunctioningEventRatio { get; set; }
        /// <summary>Fraction of the call that the media endpoint detected the CPU resources available were insufficient and caused poor quality of the audio sent and received.</summary>
        public float? CpuInsufficentEventRatio { get; set; }
        /// <summary>Fraction of the call that the media endpoint detected clipping in the captured audio that caused poor quality of the audio being sent.</summary>
        public float? DeviceClippingEventRatio { get; set; }
        /// <summary>Fraction of the call that the media endpoint detected glitches or gaps in the audio played or captured that caused poor quality of the audio being sent or received.</summary>
        public float? DeviceGlitchEventRatio { get; set; }
        /// <summary>Number of times during the call that the media endpoint detected howling or screeching audio.</summary>
        public int? HowlingEventCount { get; set; }
        /// <summary>The root mean square (RMS) of the incoming signal of up to the first 30 seconds of the call.</summary>
        public float? InitialSignalLevelRootMeanSquare { get; set; }
        /// <summary>Fraction of the call that the media endpoint detected low speech level that caused poor quality of the audio being sent.</summary>
        public float? LowSpeechLevelEventRatio { get; set; }
        /// <summary>Fraction of the call that the media endpoint detected low speech to noise level that caused poor quality of the audio being sent.</summary>
        public float? LowSpeechToNoiseEventRatio { get; set; }
        /// <summary>Glitches per 5 minute interval for the media endpoint&apos;s microphone.</summary>
        public float? MicGlitchRate { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Average energy level of received audio for audio classified as mono noise or left channel of stereo noise by the media endpoint.</summary>
        public int? ReceivedNoiseLevel { get; set; }
        /// <summary>Average energy level of received audio for audio classified as mono speech, or left channel of stereo speech by the media endpoint.</summary>
        public int? ReceivedSignalLevel { get; set; }
        /// <summary>Name of the render device driver used by the media endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RenderDeviceDriver { get; set; }
#nullable restore
#else
        public string RenderDeviceDriver { get; set; }
#endif
        /// <summary>Name of the render device used by the media endpoint.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RenderDeviceName { get; set; }
#nullable restore
#else
        public string RenderDeviceName { get; set; }
#endif
        /// <summary>Fraction of the call that media endpoint detected device render is muted.</summary>
        public float? RenderMuteEventRatio { get; set; }
        /// <summary>Fraction of the call that the media endpoint detected the render device was not working properly.</summary>
        public float? RenderNotFunctioningEventRatio { get; set; }
        /// <summary>Fraction of the call that media endpoint detected device render volume is set to 0.</summary>
        public float? RenderZeroVolumeEventRatio { get; set; }
        /// <summary>Average energy level of sent audio for audio classified as mono noise or left channel of stereo noise by the media endpoint.</summary>
        public int? SentNoiseLevel { get; set; }
        /// <summary>Average energy level of sent audio for audio classified as mono speech, or left channel of stereo speech by the media endpoint.</summary>
        public int? SentSignalLevel { get; set; }
        /// <summary>Glitches per 5 minute internal for the media endpoint&apos;s loudspeaker.</summary>
        public float? SpeakerGlitchRate { get; set; }
        /// <summary>
        /// Instantiates a new deviceInfo and sets the default values.
        /// </summary>
        public DeviceInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"captureDeviceDriver", n => { CaptureDeviceDriver = n.GetStringValue(); } },
                {"captureDeviceName", n => { CaptureDeviceName = n.GetStringValue(); } },
                {"captureNotFunctioningEventRatio", n => { CaptureNotFunctioningEventRatio = n.GetFloatValue(); } },
                {"cpuInsufficentEventRatio", n => { CpuInsufficentEventRatio = n.GetFloatValue(); } },
                {"deviceClippingEventRatio", n => { DeviceClippingEventRatio = n.GetFloatValue(); } },
                {"deviceGlitchEventRatio", n => { DeviceGlitchEventRatio = n.GetFloatValue(); } },
                {"howlingEventCount", n => { HowlingEventCount = n.GetIntValue(); } },
                {"initialSignalLevelRootMeanSquare", n => { InitialSignalLevelRootMeanSquare = n.GetFloatValue(); } },
                {"lowSpeechLevelEventRatio", n => { LowSpeechLevelEventRatio = n.GetFloatValue(); } },
                {"lowSpeechToNoiseEventRatio", n => { LowSpeechToNoiseEventRatio = n.GetFloatValue(); } },
                {"micGlitchRate", n => { MicGlitchRate = n.GetFloatValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"receivedNoiseLevel", n => { ReceivedNoiseLevel = n.GetIntValue(); } },
                {"receivedSignalLevel", n => { ReceivedSignalLevel = n.GetIntValue(); } },
                {"renderDeviceDriver", n => { RenderDeviceDriver = n.GetStringValue(); } },
                {"renderDeviceName", n => { RenderDeviceName = n.GetStringValue(); } },
                {"renderMuteEventRatio", n => { RenderMuteEventRatio = n.GetFloatValue(); } },
                {"renderNotFunctioningEventRatio", n => { RenderNotFunctioningEventRatio = n.GetFloatValue(); } },
                {"renderZeroVolumeEventRatio", n => { RenderZeroVolumeEventRatio = n.GetFloatValue(); } },
                {"sentNoiseLevel", n => { SentNoiseLevel = n.GetIntValue(); } },
                {"sentSignalLevel", n => { SentSignalLevel = n.GetIntValue(); } },
                {"speakerGlitchRate", n => { SpeakerGlitchRate = n.GetFloatValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("captureDeviceDriver", CaptureDeviceDriver);
            writer.WriteStringValue("captureDeviceName", CaptureDeviceName);
            writer.WriteFloatValue("captureNotFunctioningEventRatio", CaptureNotFunctioningEventRatio);
            writer.WriteFloatValue("cpuInsufficentEventRatio", CpuInsufficentEventRatio);
            writer.WriteFloatValue("deviceClippingEventRatio", DeviceClippingEventRatio);
            writer.WriteFloatValue("deviceGlitchEventRatio", DeviceGlitchEventRatio);
            writer.WriteIntValue("howlingEventCount", HowlingEventCount);
            writer.WriteFloatValue("initialSignalLevelRootMeanSquare", InitialSignalLevelRootMeanSquare);
            writer.WriteFloatValue("lowSpeechLevelEventRatio", LowSpeechLevelEventRatio);
            writer.WriteFloatValue("lowSpeechToNoiseEventRatio", LowSpeechToNoiseEventRatio);
            writer.WriteFloatValue("micGlitchRate", MicGlitchRate);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("receivedNoiseLevel", ReceivedNoiseLevel);
            writer.WriteIntValue("receivedSignalLevel", ReceivedSignalLevel);
            writer.WriteStringValue("renderDeviceDriver", RenderDeviceDriver);
            writer.WriteStringValue("renderDeviceName", RenderDeviceName);
            writer.WriteFloatValue("renderMuteEventRatio", RenderMuteEventRatio);
            writer.WriteFloatValue("renderNotFunctioningEventRatio", RenderNotFunctioningEventRatio);
            writer.WriteFloatValue("renderZeroVolumeEventRatio", RenderZeroVolumeEventRatio);
            writer.WriteIntValue("sentNoiseLevel", SentNoiseLevel);
            writer.WriteIntValue("sentSignalLevel", SentSignalLevel);
            writer.WriteFloatValue("speakerGlitchRate", SpeakerGlitchRate);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
