using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class SubNotFound
    {
        /// <summary>
        ///     Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public bool? Error { get; set; }

        /// <summary>
        ///     Gets or Sets ErrorMsg
        /// </summary>
        [DataMember(Name = "error_msg", EmitDefaultValue = false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubNotFound {\n");

            sb.Append("  Error: ").Append(Error).Append("\n");

            sb.Append("  ErrorMsg: ").Append(ErrorMsg).Append("\n");

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