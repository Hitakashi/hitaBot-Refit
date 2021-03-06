using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class Teams
    {
        /// <summary>
        ///     Gets or Sets Teams
        /// </summary>
        [DataMember(Name = "teams", EmitDefaultValue = false)]
        public List<Team> TeamsVar { get; set; }

        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Teams {\n");

            sb.Append("  Teams: ").Append(TeamsVar).Append("\n");

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
        public class Info
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

            [DataMember(Name = "group_logo_small")]
            public string GroupLogoSmall { get; set; }

            [DataMember(Name = "group_logo_large")]
            public string GroupLogoLarge { get; set; }

            [DataMember(Name = "group_cover")]
            public string GroupCover { get; set; }

            [DataMember(Name = "members_total")]
            public int MembersTotal { get; set; }

            [DataMember(Name = "group_default")]
            public int GroupDefault { get; set; }
        }

        [DataContract]
        public class Member
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

            [DataMember(Name = "admin")]
            public int Admin { get; set; }

            [DataMember(Name = "enabled")]
            public int Enabled { get; set; }

            [DataMember(Name = "is_default")]
            public int IsDefault { get; set; }

            [DataMember(Name = "revenues_enabled")]
            public string RevenuesEnabled { get; set; }

            [DataMember(Name = "group_role")]
            public string GroupRole { get; set; }

            [DataMember(Name = "group_accepted")]
            public bool GroupAccepted { get; set; }
        }

        [DataContract]
        public class Team
        {
            [DataMember(Name = "info")]
            public Info Info { get; set; }

            [DataMember(Name = "members")]
            public IList<Member> Members { get; set; }
        }
    }
}