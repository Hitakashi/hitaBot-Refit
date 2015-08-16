using System.Runtime.Serialization;

namespace hitaBot.Refit.Model
{
    public class Channel
    {
        /// <summary>
        /// Gets or Sets Followers
        /// </summary>
        [DataMember(Name = "followers", EmitDefaultValue = false)]
        public int Followers { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name = "user_name", EmitDefaultValue = false)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets UserStatus
        /// </summary>
        [DataMember(Name = "user_status", EmitDefaultValue = false)]
        public int UserStatus { get; set; }

        /// <summary>
        /// Gets or Sets UserLogo
        /// </summary>
        [DataMember(Name = "user_logo", EmitDefaultValue = false)]
        public string UserLogo { get; set; }

        /// <summary>
        /// Gets or Sets UserCover
        /// </summary>
        [DataMember(Name = "user_cover", EmitDefaultValue = false)]
        public string UserCover { get; set; }

        /// <summary>
        /// Gets or Sets UserLogoSmall
        /// </summary>
        [DataMember(Name = "user_logo_small", EmitDefaultValue = false)]
        public string UserLogoSmall { get; set; }

        /// <summary>
        /// Gets or Sets UserPartner
        /// </summary>
        [DataMember(Name = "user_partner", EmitDefaultValue = false)]
        public string UserPartner { get; set; }

        /// <summary>
        /// Gets or Sets UserBetaProfile
        /// </summary>
        [DataMember(Name = "user_beta_profile", EmitDefaultValue = false)]
        public int UserBetaProfile { get; set; }

        /// <summary>
        /// Gets or Sets MediaIsLive
        /// </summary>
        [DataMember(Name = "media_is_live", EmitDefaultValue = false)]
        public int MediaIsLive { get; set; }

        /// <summary>
        /// Gets or Sets MediaLiveSince
        /// </summary>
        [DataMember(Name = "media_live_since", EmitDefaultValue = false)]
        public string MediaLiveSince { get; set; }

        /// <summary>
        /// Gets or Sets UserMediaId
        /// </summary>
        [DataMember(Name = "user_media_id", EmitDefaultValue = false)]
        public int UserMediaId { get; set; }

        /// <summary>
        /// Gets or Sets TwitterAccount
        /// </summary>
        [DataMember(Name = "twitter_account", EmitDefaultValue = false)]
        public string TwitterAccount { get; set; }

        /// <summary>
        /// Gets or Sets TwitterEnabled
        /// </summary>
        [DataMember(Name = "twitter_enabled", EmitDefaultValue = false)]
        public int TwitterEnabled { get; set; }

        /// <summary>
        /// Gets or Sets LivestreamCount
        /// </summary>
        [DataMember(Name = "livestream_count", EmitDefaultValue = false)]
        public int LivestreamCount { get; set; }
    }
}