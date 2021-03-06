using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class SetNotifications
    {
        /// <summary>
        ///     Gets or Sets UserName
        /// </summary>
        [DataMember(Name = "user_name", EmitDefaultValue = false)]
        public string UserName { get; set; }

        /// <summary>
        ///     Gets or Sets AuthToken
        /// </summary>
        [DataMember(Name = "authToken", EmitDefaultValue = false)]
        public string AuthToken { get; set; }

        /// <summary>
        ///     Gets or Sets NotifyEmail
        /// </summary>
        [DataMember(Name = "notify_email", EmitDefaultValue = false)]
        public int? NotifyEmail { get; set; }

        /// <summary>
        ///     Gets or Sets NotifyFacebook
        /// </summary>
        [DataMember(Name = "notify_facebook", EmitDefaultValue = false)]
        public int? NotifyFacebook { get; set; }

        /// <summary>
        ///     Gets or Sets PushFacebook
        /// </summary>
        [DataMember(Name = "push_facebook", EmitDefaultValue = false)]
        public int? PushFacebook { get; set; }

        /// <summary>
        ///     Gets or Sets PushTwitter
        /// </summary>
        [DataMember(Name = "push_twitter", EmitDefaultValue = false)]
        public int? PushTwitter { get; set; }

        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetNotifications {\n");

            sb.Append("  UserName: ").Append(UserName).Append("\n");

            sb.Append("  AuthToken: ").Append(AuthToken).Append("\n");

            sb.Append("  NotifyEmail: ").Append(NotifyEmail).Append("\n");

            sb.Append("  NotifyFacebook: ").Append(NotifyFacebook).Append("\n");

            sb.Append("  PushFacebook: ").Append(PushFacebook).Append("\n");

            sb.Append("  PushTwitter: ").Append(PushTwitter).Append("\n");

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