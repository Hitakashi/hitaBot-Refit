using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class FollowingUser
    {
        /// <summary>
        ///     Gets or Sets Request
        /// </summary>
        [DataMember(Name = "request", EmitDefaultValue = false)]
        public Request Request { get; set; }

        /// <summary>
        ///     Gets or Sets Following
        /// </summary>
        [DataMember(Name = "following", EmitDefaultValue = false)]
        public List<FollowingUserObj> Following { get; set; }

        /// <summary>
        ///     Gets or Sets MaxResults
        /// </summary>
        [DataMember(Name = "max_results", EmitDefaultValue = false)]
        public string MaxResults { get; set; }

        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FollowingUser {\n");

            sb.Append("  Request: ").Append(Request).Append("\n");

            sb.Append("  Following: ").Append(Following).Append("\n");

            sb.Append("  MaxResults: ").Append(MaxResults).Append("\n");

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