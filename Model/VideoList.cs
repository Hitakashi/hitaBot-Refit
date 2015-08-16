using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class VideoList {
    
    /// <summary>
    /// Gets or Sets Request
    /// </summary>
    [DataMember(Name="request", EmitDefaultValue=false)]
    public Request Request { get; set; }

    
    /// <summary>
    /// Gets or Sets MediaType
    /// </summary>
    [DataMember(Name="media_type", EmitDefaultValue=false)]
    public string MediaType { get; set; }

    
    /// <summary>
    /// Authenticated
    /// </summary>
    /// <value>Authenticated</value>
    [DataMember(Name="authToken", EmitDefaultValue=false)]
    public string AuthToken { get; set; }

    
    /// <summary>
    /// Gets or Sets Video
    /// </summary>
    [DataMember(Name="video", EmitDefaultValue=false)]
    public List<VideoObj> Video { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VideoList {\n");
      
      sb.Append("  Request: ").Append(Request).Append("\n");
      
      sb.Append("  MediaType: ").Append(MediaType).Append("\n");
      
      sb.Append("  AuthToken: ").Append(AuthToken).Append("\n");
      
      sb.Append("  Video: ").Append(Video).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }
        [DataContract]
        public class Channel
        {

            [DataMember(Name = "followers")]
            public int Followers { get; set; }

            [DataMember(Name = "user_id")]
            public int UserId { get; set; }

            [DataMember(Name = "user_name")]
            public string UserName { get; set; }

            [DataMember(Name = "user_status")]
            public int UserStatus { get; set; }

            [DataMember(Name = "user_logo")]
            public string UserLogo { get; set; }

            [DataMember(Name = "user_cover")]
            public string UserCover { get; set; }

            [DataMember(Name = "user_logo_small")]
            public string UserLogoSmall { get; set; }

            [DataMember(Name = "user_partner")]
            public string UserPartner { get; set; }

            [DataMember(Name = "user_beta_profile")]
            public int UserBetaProfile { get; set; }

            [DataMember(Name = "media_is_live")]
            public int MediaIsLive { get; set; }

            [DataMember(Name = "media_live_since")]
            public string MediaLiveSince { get; set; }

            [DataMember(Name = "user_media_id")]
            public int UserMediaId { get; set; }

            [DataMember(Name = "twitter_account")]
            public string TwitterAccount { get; set; }

            [DataMember(Name = "twitter_enabled")]
            public int TwitterEnabled { get; set; }

            [DataMember(Name = "livestream_count")]
            public int LivestreamCount { get; set; }
        }

        [DataContract]
        public class VideoObj
        {

            [DataMember(Name = "media_user_name")]
            public string MediaUserName { get; set; }

            [DataMember(Name = "media_id")]
            public int MediaId { get; set; }

            [DataMember(Name = "media_type_id")]
            public int MediaTypeId { get; set; }

            [DataMember(Name = "media_user_id")]
            public int MediaUserId { get; set; }

            [DataMember(Name = "media_category_id")]
            public string MediaCategoryId { get; set; }

            [DataMember(Name = "media_file")]
            public string MediaFile { get; set; }

            [DataMember(Name = "media_profiles")]
            public string MediaProfiles { get; set; }

            [DataMember(Name = "media_host")]
            public string MediaHost { get; set; }

            [DataMember(Name = "media_rec_session")]
            public string MediaRecSession { get; set; }

            [DataMember(Name = "media_ingest_host")]
            public string MediaIngestHost { get; set; }

            [DataMember(Name = "media_is_live")]
            public int MediaIsLive { get; set; }

            [DataMember(Name = "media_live_delay")]
            public string MediaLiveDelay { get; set; }

            [DataMember(Name = "media_featured")]
            public string MediaFeatured { get; set; }

            [DataMember(Name = "media_privacy")]
            public string MediaPrivacy { get; set; }

            [DataMember(Name = "media_hidden")]
            public string MediaHidden { get; set; }

            [DataMember(Name = "media_notify_users")]
            public int MediaNotifyUsers { get; set; }

            [DataMember(Name = "media_date_added")]
            public string MediaDateAdded { get; set; }

            [DataMember(Name = "media_date_updated")]
            public string MediaDateUpdated { get; set; }

            [DataMember(Name = "media_live_since")]
            public string MediaLiveSince { get; set; }

            [DataMember(Name = "media_live_notified")]
            public string MediaLiveNotified { get; set; }

            [DataMember(Name = "media_key")]
            public string MediaKey { get; set; }

            [DataMember(Name = "media_chat_enabled")]
            public int MediaChatEnabled { get; set; }

            [DataMember(Name = "media_deleted")]
            public string MediaDeleted { get; set; }

            [DataMember(Name = "media_playing")]
            public int MediaPlaying { get; set; }

            [DataMember(Name = "media_transcoding")]
            public string MediaTranscoding { get; set; }

            [DataMember(Name = "media_repair_source")]
            public string MediaRepairSource { get; set; }

            [DataMember(Name = "media_recording")]
            public string MediaRecording { get; set; }

            [DataMember(Name = "media_dvr")]
            public int MediaDvr { get; set; }

            [DataMember(Name = "media_countries")]
            public string MediaCountries { get; set; }

            [DataMember(Name = "media_info")]
            public string MediaInfo { get; set; }

            [DataMember(Name = "media_relay")]
            public string MediaRelay { get; set; }

            [DataMember(Name = "media_password_protected")]
            public string MediaPasswordProtected { get; set; }

            [DataMember(Name = "media_yt_upload")]
            public string MediaYtUpload { get; set; }

            [DataMember(Name = "media_yt_upload_status")]
            public string MediaYtUploadStatus { get; set; }

            [DataMember(Name = "media_processing")]
            public string MediaProcessing { get; set; }

            [DataMember(Name = "media_total_views")]
            public string MediaTotalViews { get; set; }

            [DataMember(Name = "media_monthly_views")]
            public string MediaMonthlyViews { get; set; }

            [DataMember(Name = "media_weekly_views")]
            public string MediaWeeklyViews { get; set; }

            [DataMember(Name = "media_daily_views")]
            public string MediaDailyViews { get; set; }

            [DataMember(Name = "media_hosted_id")]
            public string MediaHostedId { get; set; }

            [DataMember(Name = "media_mature")]
            public string MediaMature { get; set; }

            [DataMember(Name = "media_uploaded")]
            public int MediaUploaded { get; set; }

            [DataMember(Name = "media_offline_id")]
            public string MediaOfflineId { get; set; }

            [DataMember(Name = "media_featured_weight")]
            public string MediaFeaturedWeight { get; set; }

            [DataMember(Name = "media_featured_forced")]
            public string MediaFeaturedForced { get; set; }

            [DataMember(Name = "media_featured_countries")]
            public string MediaFeaturedCountries { get; set; }

            [DataMember(Name = "user_banned")]
            public string UserBanned { get; set; }

            [DataMember(Name = "media_name")]
            public string MediaName { get; set; }

            [DataMember(Name = "media_display_name")]
            public string MediaDisplayName { get; set; }

            [DataMember(Name = "media_status")]
            public string MediaStatus { get; set; }

            [DataMember(Name = "media_title")]
            public string MediaTitle { get; set; }

            [DataMember(Name = "media_tags")]
            public string MediaTags { get; set; }

            [DataMember(Name = "media_duration")]
            public string MediaDuration { get; set; }

            [DataMember(Name = "media_bg_image")]
            public string MediaBgImage { get; set; }

            [DataMember(Name = "media_views")]
            public int MediaViews { get; set; }

            [DataMember(Name = "media_views_daily")]
            public int MediaViewsDaily { get; set; }

            [DataMember(Name = "media_views_weekly")]
            public int MediaViewsWeekly { get; set; }

            [DataMember(Name = "media_views_monthly")]
            public int MediaViewsMonthly { get; set; }

            [DataMember(Name = "category_id")]
            public string CategoryId { get; set; }

            [DataMember(Name = "category_name")]
            public string CategoryName { get; set; }

            [DataMember(Name = "category_name_short")]
            public string CategoryNameShort { get; set; }

            [DataMember(Name = "category_seo_key")]
            public string CategorySeoKey { get; set; }

            [DataMember(Name = "category_viewers")]
            public string CategoryViewers { get; set; }

            [DataMember(Name = "category_media_count")]
            public string CategoryMediaCount { get; set; }

            [DataMember(Name = "category_channels")]
            public string CategoryChannels { get; set; }

            [DataMember(Name = "category_logo_small")]
            public string CategoryLogoSmall { get; set; }

            [DataMember(Name = "category_logo_large")]
            public string CategoryLogoLarge { get; set; }

            [DataMember(Name = "category_updated")]
            public string CategoryUpdated { get; set; }

            [DataMember(Name = "team_name")]
            public string TeamName { get; set; }

            [DataMember(Name = "media_start_in_sec")]
            public int MediaStartInSec { get; set; }

            [DataMember(Name = "media_download_link")]
            public string MediaDownloadLink { get; set; }

            [DataMember(Name = "media_duration_format")]
            public string MediaDurationFormat { get; set; }

            [DataMember(Name = "media_thumbnail")]
            public string MediaThumbnail { get; set; }

            [DataMember(Name = "media_thumbnail_large")]
            public string MediaThumbnailLarge { get; set; }

            [DataMember(Name = "channel")]
            public Channel Channel { get; set; }
        }
    }
}
