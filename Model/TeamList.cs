using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class TeamList
    {
        /// <summary>
        ///     Gets or Sets Teams
        /// </summary>
        [DataMember(Name = "teams", EmitDefaultValue = false)]
        public List<Team> Teams { get; set; }

        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamList {\n");

            sb.Append("  Teams: ").Append(Teams).Append("\n");

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
        public class Team
        {
            [DataMember(Name = "group_id")]
            public string GroupId { get; set; }

            [DataMember(Name = "group_name")]
            public string GroupName { get; set; }
        }
    }
}