using System.Runtime.Serialization;

namespace hitaBot.Refit.Model
{
    public class ChatIconInfoObj
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
        ///     Gets or Sets IconDateAdded
        /// </summary>
        [DataMember(Name = "icon_date_added", EmitDefaultValue = false)]
        public string IconDateAdded { get; set; }

        /// <summary>
        ///     Gets or Sets IconPremiumOnly
        /// </summary>
        [DataMember(Name = "icon_premium_only", EmitDefaultValue = false)]
        public int IconPremiumOnly { get; set; }

        /// <summary>
        ///     Gets or Sets IconEnabled
        /// </summary>
        [DataMember(Name = "icon_enabled", EmitDefaultValue = false)]
        public int IconEnabled { get; set; }

        /// <summary>
        ///     Gets or Sets IconComment
        /// </summary>
        [DataMember(Name = "icon_comment", EmitDefaultValue = false)]
        public string IconComment { get; set; }
    }
}