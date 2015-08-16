using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class CreateVideo
    {
        /// <summary>
        ///     Gets or Sets UserName
        /// </summary>
        [DataMember(Name = "user_name", EmitDefaultValue = false)]
        public string UserName { get; set; }

        /// <summary>
        ///     Gets or Sets AuthToken
        /// </summary>
        [DataMember(Name = "authToken", EmitDefaultValue = false)]
        public string AuthToken { get; set; }

        /// <summary>
        ///     Gets or Sets MediaType
        /// </summary>
        [DataMember(Name = "media_type", EmitDefaultValue = false)]
        public string MediaType { get; set; }

        /// <summary>
        ///     Gets or Sets MediaTitle
        /// </summary>
        [DataMember(Name = "media_title", EmitDefaultValue = false)]
        public string MediaTitle { get; set; }

        /// <summary>
        ///     Gets or Sets MediaStatus
        /// </summary>
        [DataMember(Name = "media_status", EmitDefaultValue = false)]
        public string MediaStatus { get; set; }

        /// <summary>
        ///     Gets or Sets MediaName
        /// </summary>
        [DataMember(Name = "media_name", EmitDefaultValue = false)]
        public string MediaName { get; set; }

        /// <summary>
        ///     Gets or Sets MediaHidden
        /// </summary>
        [DataMember(Name = "media_hidden", EmitDefaultValue = false)]
        public int? MediaHidden { get; set; }

        /// <summary>
        ///     Gets or Sets MediaCategoryId
        /// </summary>
        [DataMember(Name = "media_category_id", EmitDefaultValue = false)]
        public MediaCategoryId MediaCategoryId { get; set; }

        /// <summary>
        ///     Gets or Sets ClipDuration
        /// </summary>
        [DataMember(Name = "clip_duration", EmitDefaultValue = false)]
        public double? ClipDuration { get; set; }

        /// <summary>
        ///     Gets or Sets ClipStart
        /// </summary>
        [DataMember(Name = "clip_start", EmitDefaultValue = false)]
        public double? ClipStart { get; set; }

        /// <summary>
        ///     Gets or Sets RecSession
        /// </summary>
        [DataMember(Name = "rec_session", EmitDefaultValue = false)]
        public string RecSession { get; set; }

        /// <summary>
        ///     Gets or Sets Original
        /// </summary>
        [DataMember(Name = "original", EmitDefaultValue = false)]
        public bool? Original { get; set; }

        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateVideo {\n");

            sb.Append("  UserName: ").Append(UserName).Append("\n");

            sb.Append("  AuthToken: ").Append(AuthToken).Append("\n");

            sb.Append("  MediaType: ").Append(MediaType).Append("\n");

            sb.Append("  MediaTitle: ").Append(MediaTitle).Append("\n");

            sb.Append("  MediaStatus: ").Append(MediaStatus).Append("\n");

            sb.Append("  MediaName: ").Append(MediaName).Append("\n");

            sb.Append("  MediaHidden: ").Append(MediaHidden).Append("\n");

            sb.Append("  MediaCategoryId: ").Append(MediaCategoryId).Append("\n");

            sb.Append("  ClipDuration: ").Append(ClipDuration).Append("\n");

            sb.Append("  ClipStart: ").Append(ClipStart).Append("\n");

            sb.Append("  RecSession: ").Append(RecSession).Append("\n");

            sb.Append("  Original: ").Append(Original).Append("\n");

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

    [DataContract]
    public class MediaCategoryId
    {
        [DataMember(Name = "category_id")]
        public int CategoryId { get; set; }

        [DataMember(Name = "category_name")]
        public string CategoryName { get; set; }

        [DataMember(Name = "category_name_short")]
        public string CategoryNameShort { get; set; }

        [DataMember(Name = "category_seo_key")]
        public string CategorySeoKey { get; set; }

        [DataMember(Name = "category_viewers")]
        public int CategoryViewers { get; set; }

        [DataMember(Name = "category_media_count")]
        public int CategoryMediaCount { get; set; }

        [DataMember(Name = "category_channels")]
        public string CategoryChannels { get; set; }

        [DataMember(Name = "category_logo_small")]
        public string CategoryLogoSmall { get; set; }

        [DataMember(Name = "category_logo_large")]
        public string CategoryLogoLarge { get; set; }

        [DataMember(Name = "category_updated")]
        public string CategoryUpdated { get; set; }
    }
}