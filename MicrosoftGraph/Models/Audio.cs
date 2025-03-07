using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace GitHubTodoDemo.MicrosoftGraph.Models {
    public class Audio : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The title of the album for this audio file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Album { get; set; }
#nullable restore
#else
        public string Album { get; set; }
#endif
        /// <summary>The artist named on the album for the audio file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlbumArtist { get; set; }
#nullable restore
#else
        public string AlbumArtist { get; set; }
#endif
        /// <summary>The performing artist for the audio file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Artist { get; set; }
#nullable restore
#else
        public string Artist { get; set; }
#endif
        /// <summary>Bitrate expressed in kbps.</summary>
        public long? Bitrate { get; set; }
        /// <summary>The name of the composer of the audio file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Composers { get; set; }
#nullable restore
#else
        public string Composers { get; set; }
#endif
        /// <summary>Copyright information for the audio file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Copyright { get; set; }
#nullable restore
#else
        public string Copyright { get; set; }
#endif
        /// <summary>The number of the disc this audio file came from.</summary>
        public int? Disc { get; set; }
        /// <summary>The total number of discs in this album.</summary>
        public int? DiscCount { get; set; }
        /// <summary>Duration of the audio file, expressed in milliseconds</summary>
        public long? Duration { get; set; }
        /// <summary>The genre of this audio file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Genre { get; set; }
#nullable restore
#else
        public string Genre { get; set; }
#endif
        /// <summary>Indicates if the file is protected with digital rights management.</summary>
        public bool? HasDrm { get; set; }
        /// <summary>Indicates if the file is encoded with a variable bitrate.</summary>
        public bool? IsVariableBitrate { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The title of the audio file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>The number of the track on the original disc for this audio file.</summary>
        public int? Track { get; set; }
        /// <summary>The total number of tracks on the original disc for this audio file.</summary>
        public int? TrackCount { get; set; }
        /// <summary>The year the audio file was recorded.</summary>
        public int? Year { get; set; }
        /// <summary>
        /// Instantiates a new audio and sets the default values.
        /// </summary>
        public Audio() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Audio CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Audio();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"album", n => { Album = n.GetStringValue(); } },
                {"albumArtist", n => { AlbumArtist = n.GetStringValue(); } },
                {"artist", n => { Artist = n.GetStringValue(); } },
                {"bitrate", n => { Bitrate = n.GetLongValue(); } },
                {"composers", n => { Composers = n.GetStringValue(); } },
                {"copyright", n => { Copyright = n.GetStringValue(); } },
                {"disc", n => { Disc = n.GetIntValue(); } },
                {"discCount", n => { DiscCount = n.GetIntValue(); } },
                {"duration", n => { Duration = n.GetLongValue(); } },
                {"genre", n => { Genre = n.GetStringValue(); } },
                {"hasDrm", n => { HasDrm = n.GetBoolValue(); } },
                {"isVariableBitrate", n => { IsVariableBitrate = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"track", n => { Track = n.GetIntValue(); } },
                {"trackCount", n => { TrackCount = n.GetIntValue(); } },
                {"year", n => { Year = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("album", Album);
            writer.WriteStringValue("albumArtist", AlbumArtist);
            writer.WriteStringValue("artist", Artist);
            writer.WriteLongValue("bitrate", Bitrate);
            writer.WriteStringValue("composers", Composers);
            writer.WriteStringValue("copyright", Copyright);
            writer.WriteIntValue("disc", Disc);
            writer.WriteIntValue("discCount", DiscCount);
            writer.WriteLongValue("duration", Duration);
            writer.WriteStringValue("genre", Genre);
            writer.WriteBoolValue("hasDrm", HasDrm);
            writer.WriteBoolValue("isVariableBitrate", IsVariableBitrate);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("title", Title);
            writer.WriteIntValue("track", Track);
            writer.WriteIntValue("trackCount", TrackCount);
            writer.WriteIntValue("year", Year);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
