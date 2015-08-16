using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class UpdateTeam
    {
        /// <summary>
        ///     Gets or Sets Info
        /// </summary>
        [DataMember(Name = "info", EmitDefaultValue = false)]
        public InfoObj Info { get; set; }

        /// <summary>
        ///     Gets or Sets Invites
        /// </summary>
        [DataMember(Name = "invites", EmitDefaultValue = false)]
        public List<string> Invites { get; set; }

        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTeam {\n");

            sb.Append("  Info: ").Append(Info).Append("\n");

            sb.Append("  Invites: ").Append(Invites).Append("\n");

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

        [DataContract]
        public class InfoObj
        {
            [DataMember(Name = "group_id")]
            public int GroupId { get; set; }

            [DataMember(Name = "founder_name")]
            public string FounderName { get; set; }

            [DataMember(Name = "group_name")]
            public string GroupName { get; set; }

            [DataMember(Name = "group_display_name")]
            public string GroupDisplayName { get; set; }

            [DataMember(Name = "group_text")]
            public string GroupText { get; set; }

            [DataMember(Name = "group_logo_large")]
            public string GroupLogoLarge { get; set; }

            [DataMember(Name = "group_logo_small")]
            public string GroupLogoSmall { get; set; }

            [DataMember(Name = "group_cover")]
            public string GroupCover { get; set; }
        }
    }
}