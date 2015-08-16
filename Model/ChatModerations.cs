using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class ChatModerations
    {
        /// <summary>
        ///     Gets or Sets Request
        /// </summary>
        [DataMember(Name = "request", EmitDefaultValue = false)]
        public Request Request { get; set; }

        /// <summary>
        ///     Gets or Sets Moderations
        /// </summary>
        [DataMember(Name = "moderations", EmitDefaultValue = false)]
        public List<Moderator> Moderations { get; set; }

        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChatModerations {\n");

            sb.Append("  Request: ").Append(Request).Append("\n");

            sb.Append("  Moderations: ").Append(Moderations).Append("\n");

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