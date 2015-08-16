using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class User
    {
        /// <summary>
        ///     Gets or Sets Followers
        /// </summary>
        [DataMember(Name = "followers", EmitDefaultValue = false)]
        public string Followers { get; set; }

        /// <summary>
        ///     Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        ///     Gets or Sets UserName
        /// </summary>
        [DataMember(Name = "user_name", EmitDefaultValue = false)]
        public string UserName { get; set; }

        /// <summary>
        ///     Gets or Sets UserStatus
        /// </summary>
        [DataMember(Name = "user_status", EmitDefaultValue = false)]
        public string UserStatus { get; set; }

        /// <summary>
        ///     Gets or Sets UserLogo
        /// </summary>
        [DataMember(Name = "user_logo", EmitDefaultValue = false)]
        public string UserLogo { get; set; }

        /// <summary>
        ///     Gets or Sets UserCover
        /// </summary>
        [DataMember(Name = "user_cover", EmitDefaultValue = false)]
        public string UserCover { get; set; }

        /// <summary>
        ///     Gets or Sets UserLogoSmall
        /// </summary>
        [DataMember(Name = "user_logo_small", EmitDefaultValue = false)]
        public string UserLogoSmall { get; set; }

        /// <summary>
        ///     Gets or Sets UserEmail
        /// </summary>
        [DataMember(Name = "user_email", EmitDefaultValue = false)]
        public string UserEmail { get; set; }

        /// <summary>
        ///     null = No Partner. 0 = Team Partner. 1 = Partner
        /// </summary>
        /// <value>null = No Partner. 0 = Team Partner. 1 = Partner</value>
        [DataMember(Name = "user_partner", EmitDefaultValue = false)]
        public string UserPartner { get; set; }

        /// <summary>
        ///     Gets or Sets UserBetaProfile
        /// </summary>
        [DataMember(Name = "user_beta_profile", EmitDefaultValue = false)]
        public string UserBetaProfile { get; set; }

        /// <summary>
        ///     Gets or Sets MediaIsLive
        /// </summary>
        [DataMember(Name = "media_is_live", EmitDefaultValue = false)]
        public string MediaIsLive { get; set; }

        /// <summary>
        ///     Gets or Sets MediaLiveSince
        /// </summary>
        [DataMember(Name = "media_live_since", EmitDefaultValue = false)]
        public string MediaLiveSince { get; set; }

        /// <summary>
        ///     Gets or Sets UserMediaId
        /// </summary>
        [DataMember(Name = "user_media_id", EmitDefaultValue = false)]
        public string UserMediaId { get; set; }

        /// <summary>
        ///     Gets or Sets TwitterAccount
        /// </summary>
        [DataMember(Name = "twitter_account", EmitDefaultValue = false)]
        public string TwitterAccount { get; set; }

        /// <summary>
        ///     Gets or Sets TwitterEnabled
        /// </summary>
        [DataMember(Name = "twitter_enabled", EmitDefaultValue = false)]
        public string TwitterEnabled { get; set; }

        /// <summary>
        ///     Gets or Sets LivestreamCount
        /// </summary>
        [DataMember(Name = "livestream_count", EmitDefaultValue = false)]
        public string LivestreamCount { get; set; }

        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");

            sb.Append("  Followers: ").Append(Followers).Append("\n");

            sb.Append("  UserId: ").Append(UserId).Append("\n");

            sb.Append("  UserName: ").Append(UserName).Append("\n");

            sb.Append("  UserStatus: ").Append(UserStatus).Append("\n");

            sb.Append("  UserLogo: ").Append(UserLogo).Append("\n");

            sb.Append("  UserCover: ").Append(UserCover).Append("\n");

            sb.Append("  UserLogoSmall: ").Append(UserLogoSmall).Append("\n");

            sb.Append("  UserEmail: ").Append(UserEmail).Append("\n");

            sb.Append("  UserPartner: ").Append(UserPartner).Append("\n");

            sb.Append("  UserBetaProfile: ").Append(UserBetaProfile).Append("\n");

            sb.Append("  MediaIsLive: ").Append(MediaIsLive).Append("\n");

            sb.Append("  MediaLiveSince: ").Append(MediaLiveSince).Append("\n");

            sb.Append("  UserMediaId: ").Append(UserMediaId).Append("\n");

            sb.Append("  TwitterAccount: ").Append(TwitterAccount).Append("\n");

            sb.Append("  TwitterEnabled: ").Append(TwitterEnabled).Append("\n");

            sb.Append("  LivestreamCount: ").Append(LivestreamCount).Append("\n");

            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}