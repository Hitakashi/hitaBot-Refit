using System.Collections.Generic;
using System.Runtime.Serialization;

namespace hitaBot.Refit.Model
{
    [DataContract]
    public class MediaObj
    {
        /// <summary>
        ///     Gets or Sets MediaUserName
        /// </summary>
        [DataMember(Name = "media_user_name", EmitDefaultValue = false)]
        public string MediaUserName { get; set; }

        /// <summary>
        ///     Gets or Sets MediaId
        /// </summary>
        [DataMember(Name = "media_id", EmitDefaultValue = false)]
        public int MediaId { get; set; }

        /// <summary>
        ///     Gets or Sets MediaTypeId
        /// </summary>
        [DataMember(Name = "media_type_id", EmitDefaultValue = false)]
        public int MediaTypeId { get; set; }

        /// <summary>
        ///     Gets or Sets MediaUserId
        /// </summary>
        [DataMember(Name = "media_user_id", EmitDefaultValue = false)]
        public int MediaUserId { get; set; }

        /// <summary>
        ///     Gets or Sets MediaCategoryId
        /// </summary>
        [DataMember(Name = "media_category_id", EmitDefaultValue = false)]
        public int MediaCategoryId { get; set; }

        /// <summary>
        ///     Gets or Sets MediaFile
        /// </summary>
        [DataMember(Name = "media_file", EmitDefaultValue = false)]
        public string MediaFile { get; set; }

        /// <summary>
        ///     Gets or Sets MediaProfiles
        /// </summary>
        [DataMember(Name = "media_profiles", EmitDefaultValue = false)]
        public string MediaProfiles { get; set; }

        /// <summary>
        ///     Gets or Sets MediaHost
        /// </summary>
        [DataMember(Name = "media_host", EmitDefaultValue = false)]
        public string MediaHost { get; set; }

        /// <summary>
        ///     Gets or Sets MediaRecSession
        /// </summary>
        [DataMember(Name = "media_rec_session", EmitDefaultValue = false)]
        public string MediaRecSession { get; set; }

        /// <summary>
        ///     Gets or Sets MediaIngestHost
        /// </summary>
        [DataMember(Name = "media_ingest_host", EmitDefaultValue = false)]
        public string MediaIngestHost { get; set; }

        /// <summary>
        ///     Gets or Sets MediaIsLive
        /// </summary>
        [DataMember(Name = "media_is_live", EmitDefaultValue = false)]
        public int MediaIsLive { get; set; }

        /// <summary>
        ///     Gets or Sets MediaLiveDelay
        /// </summary>
        [DataMember(Name = "media_live_delay", EmitDefaultValue = false)]
        public string MediaLiveDelay { get; set; }

        /// <summary>
        ///     Gets or Sets MediaFeatured
        /// </summary>
        [DataMember(Name = "media_featured", EmitDefaultValue = false)]
        public string MediaFeatured { get; set; }

        /// <summary>
        ///     Gets or Sets MediaPrivacy
        /// </summary>
        [DataMember(Name = "media_privacy", EmitDefaultValue = false)]
        public string MediaPrivacy { get; set; }

        /// <summary>
        ///     Gets or Sets MediaHidden
        /// </summary>
        [DataMember(Name = "media_hidden", EmitDefaultValue = false)]
        public string MediaHidden { get; set; }

        /// <summary>
        ///     Gets or Sets MediaNotifyUsers
        /// </summary>
        [DataMember(Name = "reqmedia_notify_usersuest", EmitDefaultValue = false)]
        public int MediaNotifyUsers { get; set; }

        /// <summary>
        ///     Gets or Sets MediaDateAdded
        /// </summary>
        [DataMember(Name = "media_date_added", EmitDefaultValue = false)]
        public string MediaDateAdded { get; set; }

        /// <summary>
        ///     Gets or Sets MediaDateUpdated
        /// </summary>
        [DataMember(Name = "media_date_updated", EmitDefaultValue = false)]
        public string MediaDateUpdated { get; set; }

        /// <summary>
        ///     Gets or Sets MediaLiveSince
        /// </summary>
        [DataMember(Name = "media_live_since", EmitDefaultValue = false)]
        public string MediaLiveSince { get; set; }

        /// <summary>
        ///     Gets or Sets MediaLiveNotified
        /// </summary>
        [DataMember(Name = "media_live_notified", EmitDefaultValue = false)]
        public string MediaLiveNotified { get; set; }

        /// <summary>
        ///     Gets or Sets MediaKey
        /// </summary>
        [DataMember(Name = "media_key", EmitDefaultValue = false)]
        public string MediaKey { get; set; }

        /// <summary>
        ///     Gets or Sets MediaChatEnabled
        /// </summary>
        [DataMember(Name = "media_chat_enabled", EmitDefaultValue = false)]
        public int MediaChatEnabled { get; set; }

        /// <summary>
        ///     Gets or Sets MediaDeleted
        /// </summary>
        [DataMember(Name = "media_deleted", EmitDefaultValue = false)]
        public string MediaDeleted { get; set; }

        /// <summary>
        ///     Gets or Sets MediaPlaying
        /// </summary>
        [DataMember(Name = "media_playing", EmitDefaultValue = false)]
        public int MediaPlaying { get; set; }

        /// <summary>
        ///     Gets or Sets MediaTranscoding
        /// </summary>
        [DataMember(Name = "media_transcoding", EmitDefaultValue = false)]
        public int? MediaTranscoding { get; set; }

        /// <summary>
        ///     Gets or Sets MediaRepairSource
        /// </summary>
        [DataMember(Name = "media_repair_source", EmitDefaultValue = false)]
        public string MediaRepairSource { get; set; }

        /// <summary>
        ///     Gets or Sets MediaRecording
        /// </summary>
        [DataMember(Name = "media_recording", EmitDefaultValue = false)]
        public string MediaRecording { get; set; }

        /// <summary>
        ///     Gets or Sets MediaDvr
        /// </summary>
        [DataMember(Name = "media_dvr", EmitDefaultValue = false)]
        public int MediaDvr { get; set; }

        /// <summary>
        ///     Gets or Sets MediaCountries
        /// </summary>
        [DataMember(Name = "media_countries", EmitDefaultValue = false)]
        public List<string> MediaCountries { get; set; }

        /// <summary>
        ///     Gets or Sets MediaInfo
        /// </summary>
        [DataMember(Name = "media_info", EmitDefaultValue = false)]
        public string MediaInfo { get; set; }

        /// <summary>
        ///     Gets or Sets MediaRelay
        /// </summary>
        [DataMember(Name = "media_relay", EmitDefaultValue = false)]
        public string MediaRelay { get; set; }

        /// <summary>
        ///     Gets or Sets MediaPasswordProtected
        /// </summary>
        [DataMember(Name = "media_password_protected", EmitDefaultValue = false)]
        public string MediaPasswordProtected { get; set; }

        /// <summary>
        ///     Gets or Sets MediaYtUpload
        /// </summary>
        [DataMember(Name = "media_yt_upload", EmitDefaultValue = false)]
        public string MediaYtUpload { get; set; }

        /// <summary>
        ///     Gets or Sets MediaYtUploadStatus
        /// </summary>
        [DataMember(Name = "media_yt_upload_status", EmitDefaultValue = false)]
        public string MediaYtUploadStatus { get; set; }

        /// <summary>
        ///     Gets or Sets MediaProcessing
        /// </summary>
        [DataMember(Name = "media_processing", EmitDefaultValue = false)]
        public string MediaProcessing { get; set; }

        /// <summary>
        ///     Gets or Sets MediaTotalViews
        /// </summary>
        [DataMember(Name = "media_total_views", EmitDefaultValue = false)]
        public int MediaTotalViews { get; set; }

        /// <summary>
        ///     Gets or Sets MediaMonthlyViews
        /// </summary>
        [DataMember(Name = "media_monthly_views", EmitDefaultValue = false)]
        public string MediaMonthlyViews { get; set; }

        /// <summary>
        ///     Gets or Sets MediaWeeklyViews
        /// </summary>
        [DataMember(Name = "media_weekly_views", EmitDefaultValue = false)]
        public string MediaWeeklyViews { get; set; }

        /// <summary>
        ///     Gets or Sets MediaDailyViews
        /// </summary>
        [DataMember(Name = "media_daily_views", EmitDefaultValue = false)]
        public string MediaDailyViews { get; set; }

        /// <summary>
        ///     Gets or Sets MediaHostedId
        /// </summary>
        [DataMember(Name = "media_hosted_id", EmitDefaultValue = false)]
        public string MediaHostedId { get; set; }

        /// <summary>
        ///     Gets or Sets MediaMature
        /// </summary>
        [DataMember(Name = "media_mature", EmitDefaultValue = false)]
        public string MediaMature { get; set; }

        /// <summary>
        ///     Gets or Sets MediaUploaded
        /// </summary>
        [DataMember(Name = "media_uploaded", EmitDefaultValue = false)]
        public string MediaUploaded { get; set; }

        /// <summary>
        ///     Gets or Sets MediaOfflineId
        /// </summary>
        [DataMember(Name = "media_offline_id", EmitDefaultValue = false)]
        public string MediaOfflineId { get; set; }

        /// <summary>
        ///     Gets or Sets MediaFeaturedWeight
        /// </summary>
        [DataMember(Name = "media_featured_weight", EmitDefaultValue = false)]
        public string MediaFeaturedWeight { get; set; }

        /// <summary>
        ///     Gets or Sets MediaFeaturedForced
        /// </summary>
        [DataMember(Name = "media_featured_forced", EmitDefaultValue = false)]
        public string MediaFeaturedForced { get; set; }

        /// <summary>
        ///     Gets or Sets MediaFeaturedCountries
        /// </summary>
        [DataMember(Name = "media_featured_countries", EmitDefaultValue = false)]
        public string MediaFeaturedCountries { get; set; }

        /// <summary>
        ///     Gets or Sets UserBanned
        /// </summary>
        [DataMember(Name = "user_banned", EmitDefaultValue = false)]
        public string UserBanned { get; set; }

        /// <summary>
        ///     Gets or Sets MediaName
        /// </summary>
        [DataMember(Name = "media_name", EmitDefaultValue = false)]
        public string MediaName { get; set; }

        /// <summary>
        ///     Gets or Sets MediaDisplayName
        /// </summary>
        [DataMember(Name = "media_display_name", EmitDefaultValue = false)]
        public string MediaDisplayName { get; set; }

        /// <summary>
        ///     Gets or Sets MediaStatus
        /// </summary>
        [DataMember(Name = "media_status", EmitDefaultValue = false)]
        public string MediaStatus { get; set; }

        /// <summary>
        ///     Gets or Sets MediaTitle
        /// </summary>
        [DataMember(Name = "media_title", EmitDefaultValue = false)]
        public string MediaTitle { get; set; }

        /// <summary>
        ///     Gets or Sets MediaDescription
        /// </summary>
        [DataMember(Name = "media_description", EmitDefaultValue = false)]
        public string MediaDescription { get; set; }

        /// <summary>
        ///     Gets or Sets MediaDescriptionMd
        /// </summary>
        [DataMember(Name = "media_description_md", EmitDefaultValue = false)]
        public string MediaDescriptionMd { get; set; }

        /// <summary>
        ///     Gets or Sets MediaTags
        /// </summary>
        [DataMember(Name = "media_tags", EmitDefaultValue = false)]
        public string MediaTags { get; set; }

        /// <summary>
        ///     Gets or Sets MediaDuration
        /// </summary>
        [DataMember(Name = "media_duration", EmitDefaultValue = false)]
        public string MediaDuration { get; set; }

        /// <summary>
        ///     Gets or Sets MediaBgImage
        /// </summary>
        [DataMember(Name = "media_bg_image", EmitDefaultValue = false)]
        public string MediaBgImage { get; set; }

        /// <summary>
        ///     Gets or Sets MediaViews
        /// </summary>
        [DataMember(Name = "media_views", EmitDefaultValue = false)]
        public int MediaViews { get; set; }

        /// <summary>
        ///     Gets or Sets MediaViewsDaily
        /// </summary>
        [DataMember(Name = "media_views_daily", EmitDefaultValue = false)]
        public int MediaViewsDaily { get; set; }

        /// <summary>
        ///     Gets or Sets MediaViewsWeekly
        /// </summary>
        [DataMember(Name = "media_views_weekly", EmitDefaultValue = false)]
        public int MediaViewsWeekly { get; set; }

        /// <summary>
        ///     Gets or Sets MediaViewsMonthly
        /// </summary>
        [DataMember(Name = "media_views_monthly", EmitDefaultValue = false)]
        public int MediaViewsMonthly { get; set; }

        /// <summary>
        ///     Gets or Sets CategoryId
        /// </summary>
        [DataMember(Name = "category_id", EmitDefaultValue = false)]
        public int CategoryId { get; set; }

        /// <summary>
        ///     Gets or Sets CategoryName
        /// </summary>
        [DataMember(Name = "category_name", EmitDefaultValue = false)]
        public string CategoryName { get; set; }

        /// <summary>
        ///     Gets or Sets CategoryNameShort
        /// </summary>
        [DataMember(Name = "category_name_short", EmitDefaultValue = false)]
        public string CategoryNameShort { get; set; }

        /// <summary>
        ///     Gets or Sets CategorySeoKey
        /// </summary>
        [DataMember(Name = "category_seo_key", EmitDefaultValue = false)]
        public string CategorySeoKey { get; set; }

        /// <summary>
        ///     Gets or Sets CategoryViewers
        /// </summary>
        [DataMember(Name = "category_viewers", EmitDefaultValue = false)]
        public int CategoryViewers { get; set; }

        /// <summary>
        ///     Gets or Sets CategoryMediaCount
        /// </summary>
        [DataMember(Name = "category_media_count", EmitDefaultValue = false)]
        public int CategoryMediaCount { get; set; }

        /// <summary>
        ///     Gets or Sets CategoryChannels
        /// </summary>
        [DataMember(Name = "category_channels", EmitDefaultValue = false)]
        public string CategoryChannels { get; set; }

        /// <summary>
        ///     Gets or Sets CategoryLogoSmall
        /// </summary>
        [DataMember(Name = "category_logo_small", EmitDefaultValue = false)]
        public string CategoryLogoSmall { get; set; }

        /// <summary>
        ///     Gets or Sets CategoryLogoLarge
        /// </summary>
        [DataMember(Name = "category_logo_large", EmitDefaultValue = false)]
        public string CategoryLogoLarge { get; set; }

        /// <summary>
        ///     Gets or Sets CategoryUpdated
        /// </summary>
        [DataMember(Name = "category_updated", EmitDefaultValue = false)]
        public string CategoryUpdated { get; set; }

        /// <summary>
        ///     Gets or Sets TeamName
        /// </summary>
        [DataMember(Name = "team_name", EmitDefaultValue = false)]
        public string TeamName { get; set; }

        /// <summary>
        ///     Gets or Sets MediaStartInSec
        /// </summary>
        [DataMember(Name = "media_start_in_sec", EmitDefaultValue = false)]
        public int MediaStartInSec { get; set; }

        /// <summary>
        ///     Gets or Sets MediaDownloadLink
        /// </summary>
        [DataMember(Name = "media_download_link", EmitDefaultValue = false)]
        public string MediaDownloadLink { get; set; }

        /// <summary>
        ///     Gets or Sets MediaDurationFormat
        /// </summary>
        [DataMember(Name = "media_duration_format", EmitDefaultValue = false)]
        public string MediaDurationFormat { get; set; }

        /// <summary>
        ///     Gets or Sets MediaThumbnail
        /// </summary>
        [DataMember(Name = "media_thumbnail", EmitDefaultValue = false)]
        public string MediaThumbnail { get; set; }

        /// <summary>
        ///     Gets or Sets MediaThumbnailLarge
        /// </summary>
        [DataMember(Name = "media_thumbnail_large", EmitDefaultValue = false)]
        public string MediaThumbnailLarge { get; set; }

        /// <summary>
        ///     Gets or Sets Channel
        /// </summary>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public Channel Channel { get; set; }
    }
}