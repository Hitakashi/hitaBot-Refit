using System.Runtime.Serialization;

namespace hitaBot.Refit.Model
{
    public class ChatEmotesObj
    {
        /// <summary>
        ///     Gets or Sets IconId
        /// </summary>
        [DataMember(Name = "icon_id", EmitDefaultValue = false)]
        public int IconId { get; set; }

        /// <summary>
        ///     Gets or Sets IconName
        /// </summary>
        [DataMember(Name = "icon_name", EmitDefaultValue = false)]
        public string IconName { get; set; }

        /// <summary>
        ///     Gets or Sets IconShort
        /// </summary>
        [DataMember(Name = "icon_short", EmitDefaultValue = false)]
        public string IconShort { get; set; }

        /// <summary>
        ///     Gets or Sets IconShortAlt
        /// </summary>
        [DataMember(Name = "icon_short_alt", EmitDefaultValue = false)]
        public string IconShortAlt { get; set; }

        /// <summary>
        ///     Gets or Sets IconPath
        /// </summary>
        [DataMember(Name = "icon_path", EmitDefaultValue = false)]
        public string IconPath { get; set; }

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
        ///     Gets or Sets CategoryLogo
        /// </summary>
        [DataMember(Name = "category_logo", EmitDefaultValue = false)]
        public string CategoryLogo { get; set; }

        /// <summary>
        ///     Gets or Sets IconPremiumOnly
        /// </summary>
        [DataMember(Name = "icon_premium_only", EmitDefaultValue = false)]
        public int IconPremiumOnly { get; set; }
    }
}