using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class Login
    {
        /// <summary>
        ///     Gets or Sets Login
        /// </summary>
        [DataMember(Name = "login", EmitDefaultValue = false)]
        public string LoginVar { get; set; }

        /// <summary>
        ///     Gets or Sets Pass
        /// </summary>
        [DataMember(Name = "pass", EmitDefaultValue = false)]
        public string Pass { get; set; }

        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Login {\n");

            sb.Append("  Login: ").Append(LoginVar).Append("\n");

            sb.Append("  Pass: ").Append(Pass).Append("\n");

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