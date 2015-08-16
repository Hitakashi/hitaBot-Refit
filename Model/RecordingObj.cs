using System.Runtime.Serialization;

namespace hitaBot.Refit.Model
{
    [DataContract]
    public class RecordingObj
    {
        /// <summary>
        /// Gets or Sets RecId
        /// </summary>
        [DataMember(Name = "rec_id", EmitDefaultValue = false)]
        public int RecId { get; set; }
        /// <summary>
        /// Gets or Sets RecMediaId
        /// </summary>
        [DataMember(Name = "rec_media_id", EmitDefaultValue = false)]
        public int RecMediaId { get; set; }
        /// <summary>
        /// Gets or Sets RecSession
        /// </summary>
        [DataMember(Name = "rec_session", EmitDefaultValue = false)]
        public string RecSession { get; set; }
        /// <summary>
        /// Gets or Sets RecTitle
        /// </summary>
        [DataMember(Name = "rec_title", EmitDefaultValue = false)]
        public string RecTitle { get; set; }
        /// <summary>
        /// Gets or Sets RecCategoryId
        /// </summary>
        [DataMember(Name = "rec_category_id", EmitDefaultValue = false)]
        public int RecCategoryId { get; set; }
        /// <summary>
        /// Gets or Sets RecPath
        /// </summary>
        [DataMember(Name = "rec_path", EmitDefaultValue = false)]
        public string RecPath { get; set; }
        /// <summary>
        /// Gets or Sets RecName
        /// </summary>
        [DataMember(Name = "rec_name", EmitDefaultValue = false)]
        public string RecName { get; set; }
        /// <summary>
        /// Gets or Sets RecAddr
        /// </summary>
        [DataMember(Name = "rec_addr", EmitDefaultValue = false)]
        public string RecAddr { get; set; }
        /// <summary>
        /// Gets or Sets RecInfo
        /// </summary>
        [DataMember(Name = "rec_info", EmitDefaultValue = false)]
        public RecInfo RecInfo { get; set; }
        /// <summary>
        /// Gets or Sets RecHeight
        /// </summary>
        [DataMember(Name = "rec_height", EmitDefaultValue = false)]
        public int RecHeight { get; set; }
        /// <summary>
        /// Gets or Sets RecBitrate
        /// </summary>
        [DataMember(Name = "rec_bitrate", EmitDefaultValue = false)]
        public int RecBitrate { get; set; }
        /// <summary>
        /// Gets or Sets RecDuration
        /// </summary>
        [DataMember(Name = "rec_duration", EmitDefaultValue = false)]
        public string RecDuration { get; set; }
        /// <summary>
        /// Gets or Sets RecDateAdded
        /// </summary>
        [DataMember(Name = "rec_date_added", EmitDefaultValue = false)]
        public string RecDateAdded { get; set; }
        /// <summary>
        /// Gets or Sets RecSavedMediaId
        /// </summary>
        [DataMember(Name = "rec_saved_media_id", EmitDefaultValue = false)]
        public int RecSavedMediaId { get; set; }
        /// <summary>
        /// Gets or Sets Thumbnail
        /// </summary>
        [DataMember(Name = "thumbnail", EmitDefaultValue = false)]
        public string Thumbnail { get; set; }
        /// <summary>
        /// Gets or Sets ThumbnailLarge
        /// </summary>
        [DataMember(Name = "thumbnail_large", EmitDefaultValue = false)]
        public string ThumbnailLarge { get; set; }
        /// <summary>
        /// Gets or Sets RecDurationSec
        /// </summary>
        [DataMember(Name = "rec_duration_sec", EmitDefaultValue = false)]
        public string RecDurationSec { get; set; }
        /// <summary>
        /// Gets or Sets RecDownloadLink
        /// </summary>
        [DataMember(Name = "rec_download_link", EmitDefaultValue = false)]
        public string RecDownloadLink { get; set; }
    }

    [DataContract]
    public class RecInfo
    {
        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name = "index", EmitDefaultValue = false)]
        public int Index { get; set; }
        /// <summary>
        /// Gets or Sets CodecName
        /// </summary>
        [DataMember(Name = "codec_name", EmitDefaultValue = false)]
        public string CodecName { get; set; }
        /// <summary>
        /// Gets or Sets CodecLongName
        /// </summary>
        [DataMember(Name = "codec_long_name", EmitDefaultValue = false)]
        public string CodecLongName { get; set; }
        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name = "profile", EmitDefaultValue = false)]
        public string Profile { get; set; }
        /// <summary>
        /// Gets or Sets CodecType
        /// </summary>
        [DataMember(Name = "autcodec_typehToken", EmitDefaultValue = false)]
        public string CodecType { get; set; }
        /// <summary>
        /// Gets or Sets CodecTimeBase
        /// </summary>
        [DataMember(Name = "codec_time_base", EmitDefaultValue = false)]
        public string CodecTimeBase { get; set; }
        /// <summary>
        /// Gets or Sets CodecTagString
        /// </summary>
        [DataMember(Name = "codec_tag_string", EmitDefaultValue = false)]
        public string CodecTagString { get; set; }
        /// <summary>
        /// Gets or Sets CodecTag
        /// </summary>
        [DataMember(Name = "codec_tag", EmitDefaultValue = false)]
        public int CodecTag { get; set; }
        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public int Width { get; set; }
        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public int Height { get; set; }
        /// <summary>
        /// Gets or Sets HasBFrames
        /// </summary>
        [DataMember(Name = "has_b_frames", EmitDefaultValue = false)]
        public int HasBFrames { get; set; }
        /// <summary>
        /// Gets or Sets SampleAspectRatio
        /// </summary>
        [DataMember(Name = "sample_aspect_ratio", EmitDefaultValue = false)]
        public string SampleAspectRatio { get; set; }
        /// <summary>
        /// Gets or Sets DisplayAspectRatio
        /// </summary>
        [DataMember(Name = "display_aspect_ratio", EmitDefaultValue = false)]
        public string DisplayAspectRatio { get; set; }
        /// <summary>
        /// Gets or Sets PixFmt
        /// </summary>
        [DataMember(Name = "pix_fmt", EmitDefaultValue = false)]
        public string PixFmt { get; set; }
        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name = "level", EmitDefaultValue = false)]
        public int Level { get; set; }
        /// <summary>
        /// Gets or Sets RFrameRate
        /// </summary>
        [DataMember(Name = "r_frame_rate", EmitDefaultValue = false)]
        public string RFrameRate { get; set; }
        /// <summary>
        /// Gets or Sets AvgFrameRate
        /// </summary>
        [DataMember(Name = "avg_frame_rate", EmitDefaultValue = false)]
        public string AvgFrameRate { get; set; }
        /// <summary>
        /// Gets or Sets TimeBase
        /// </summary>
        [DataMember(Name = "time_base", EmitDefaultValue = false)]
        public string TimeBase { get; set; }
        /// <summary>
        /// Gets or Sets StartPts
        /// </summary>
        [DataMember(Name = "start_pts", EmitDefaultValue = false)]
        public int StartPts { get; set; }
        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name = "start_time", EmitDefaultValue = false)]
        public string StartTime { get; set; }
        /// <summary>
        /// Gets or Sets Disposition
        /// </summary>
        [DataMember(Name = "disposition", EmitDefaultValue = false)]
        public Disposition Disposition { get; set; }
    }

    [DataContract]
    public class Disposition
    {
        /// <summary>
        /// Gets or Sets Default
        /// </summary>
        [DataMember(Name = "default", EmitDefaultValue = false)]
        public int Default { get; set; }
        /// <summary>
        /// Gets or Sets Dub
        /// </summary>
        [DataMember(Name = "dub", EmitDefaultValue = false)]
        public int Dub { get; set; }
        /// <summary>
        /// Gets or Sets Original
        /// </summary>
        [DataMember(Name = "original", EmitDefaultValue = false)]
        public int Original { get; set; }
        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public int Comment { get; set; }
        /// <summary>
        /// Gets or Sets Lyrics
        /// </summary>
        [DataMember(Name = "lyrics", EmitDefaultValue = false)]
        public int Lyrics { get; set; }
        /// <summary>
        /// Gets or Sets Karaoke
        /// </summary>
        [DataMember(Name = "karaoke", EmitDefaultValue = false)]
        public int Karaoke { get; set; }
        /// <summary>
        /// Gets or Sets Forced
        /// </summary>
        [DataMember(Name = "forced", EmitDefaultValue = false)]
        public int Forced { get; set; }
        /// <summary>
        /// Gets or Sets HearingImpaired
        /// </summary>
        [DataMember(Name = "hearing_impaired", EmitDefaultValue = false)]
        public int HearingImpaired { get; set; }
        /// <summary>
        /// Gets or Sets VisualImpaired
        /// </summary>
        [DataMember(Name = "visual_impaired", EmitDefaultValue = false)]
        public int VisualImpaired { get; set; }
        /// <summary>
        /// Gets or Sets CleanEffects
        /// </summary>
        [DataMember(Name = "clean_effects", EmitDefaultValue = false)]
        public int CleanEffects { get; set; }
        /// <summary>
        /// Gets or Sets AttachedPic
        /// </summary>
        [DataMember(Name = "attached_pic", EmitDefaultValue = false)]
        public int AttachedPic { get; set; }
    }
}