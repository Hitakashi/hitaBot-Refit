using System.Runtime.Serialization;

namespace hitaBot.Refit.Model
{
    [DataContract]
    public class GameObj
    {
        /// <summary>
        /// Gets or Sets CategoryId
        /// </summary>
        [DataMember(Name = "category_id", EmitDefaultValue = false)]
        public int CategoryId { get; set; }
        /// <summary>
        /// Gets or Sets CategoryName
        /// </summary>
        [DataMember(Name = "category_name", EmitDefaultValue = false)]
        public string CategoryName { get; set; }
        /// <summary>
        /// Gets or Sets CategoryNameShort
        /// </summary>
        [DataMember(Name = "category_name_short", EmitDefaultValue = false)]
        public string CategoryNameShort { get; set; }
        /// <summary>
        /// Gets or Sets CategorySeoKey
        /// </summary>
        [DataMember(Name = "category_seo_key", EmitDefaultValue = false)]
        public string CategorySeoKey { get; set; }
        /// <summary>
        /// Gets or Sets CategoryViewers
        /// </summary>
        [DataMember(Name = "category_viewers", EmitDefaultValue = false)]
        public string CategoryViewers { get; set; }
        /// <summary>
        /// Gets or Sets CategoryMediaCount
        /// </summary>
        [DataMember(Name = "category_media_count", EmitDefaultValue = false)]
        public string CategoryMediaCount { get; set; }
        /// <summary>
        /// Gets or Sets CategoryChannels
        /// </summary>
        [DataMember(Name = "category_channels", EmitDefaultValue = false)]
        public string CategoryChannels { get; set; }
        /// <summary>
        /// Gets or Sets CategoryLogoSmall
        /// </summary>
        [DataMember(Name = "category_logo_small", EmitDefaultValue = false)]
        public string CategoryLogoSmall { get; set; }
        /// <summary>
        /// Gets or Sets CategoryLogoLarge
        /// </summary>
        [DataMember(Name = "category_logo_large", EmitDefaultValue = false)]
        public string CategoryLogoLarge { get; set; }
        /// <summary>
        /// Gets or Sets CategoryUpdated
        /// </summary>
        [DataMember(Name = "category_updated", EmitDefaultValue = false)]
        public string CategoryUpdated { get; set; }
    }
}