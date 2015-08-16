using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class UserAccess
    {
        /// <summary>
        ///     Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        ///     Gets or Sets AccessUserId
        /// </summary>
        [DataMember(Name = "access_user_id", EmitDefaultValue = false)]
        public string AccessUserId { get; set; }

        /// <summary>
        ///     Gets or Sets Settings
        /// </summary>
        [DataMember(Name = "settings", EmitDefaultValue = false)]
        public string Settings { get; set; }

        /// <summary>
        ///     Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        public string Account { get; set; }

        /// <summary>
        ///     Gets or Sets Livestreams
        /// </summary>
        [DataMember(Name = "livestreams", EmitDefaultValue = false)]
        public string Livestreams { get; set; }

        /// <summary>
        ///     Gets or Sets Partner
        /// </summary>
        [DataMember(Name = "partner", EmitDefaultValue = false)]
        public string Partner { get; set; }

        /// <summary>
        ///     Gets or Sets Broadcast
        /// </summary>
        [DataMember(Name = "broadcast", EmitDefaultValue = false)]
        public string Broadcast { get; set; }

        /// <summary>
        ///     Gets or Sets Videos
        /// </summary>
        [DataMember(Name = "videos", EmitDefaultValue = false)]
        public string Videos { get; set; }

        /// <summary>
        ///     Gets or Sets Recordings
        /// </summary>
        [DataMember(Name = "recordings", EmitDefaultValue = false)]
        public string Recordings { get; set; }

        /// <summary>
        ///     Gets or Sets Statistics
        /// </summary>
        [DataMember(Name = "statistics", EmitDefaultValue = false)]
        public string Statistics { get; set; }

        /// <summary>
        ///     Gets or Sets Inbox
        /// </summary>
        [DataMember(Name = "inbox", EmitDefaultValue = false)]
        public string Inbox { get; set; }

        /// <summary>
        ///     Gets or Sets Revenues
        /// </summary>
        [DataMember(Name = "revenues", EmitDefaultValue = false)]
        public string Revenues { get; set; }

        /// <summary>
        ///     Gets or Sets Chat
        /// </summary>
        [DataMember(Name = "chat", EmitDefaultValue = false)]
        public string Chat { get; set; }

        /// <summary>
        ///     Gets or Sets Following
        /// </summary>
        [DataMember(Name = "following", EmitDefaultValue = false)]
        public string Following { get; set; }

        /// <summary>
        ///     Gets or Sets Teams
        /// </summary>
        [DataMember(Name = "teams", EmitDefaultValue = false)]
        public string Teams { get; set; }

        /// <summary>
        ///     Gets or Sets Subscriptions
        /// </summary>
        [DataMember(Name = "subscriptions", EmitDefaultValue = false)]
        public string Subscriptions { get; set; }

        /// <summary>
        ///     Gets or Sets Admin
        /// </summary>
        [DataMember(Name = "admin", EmitDefaultValue = false)]
        public string Admin { get; set; }

        /// <summary>
        ///     Gets or Sets Superadmin
        /// </summary>
        [DataMember(Name = "superadmin", EmitDefaultValue = false)]
        public string Superadmin { get; set; }

        /// <summary>
        ///     Gets or Sets Payments
        /// </summary>
        [DataMember(Name = "payments", EmitDefaultValue = false)]
        public string Payments { get; set; }

        /// <summary>
        ///     Gets or Sets IsSubscriber
        /// </summary>
        [DataMember(Name = "isSubscriber", EmitDefaultValue = false)]
        public bool? IsSubscriber { get; set; }

        /// <summary>
        ///     Gets or Sets IsFollower
        /// </summary>
        [DataMember(Name = "isFollower", EmitDefaultValue = false)]
        public bool? IsFollower { get; set; }

        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserAccess {\n");

            sb.Append("  UserId: ").Append(UserId).Append("\n");

            sb.Append("  AccessUserId: ").Append(AccessUserId).Append("\n");

            sb.Append("  Settings: ").Append(Settings).Append("\n");

            sb.Append("  Account: ").Append(Account).Append("\n");

            sb.Append("  Livestreams: ").Append(Livestreams).Append("\n");

            sb.Append("  Partner: ").Append(Partner).Append("\n");

            sb.Append("  Broadcast: ").Append(Broadcast).Append("\n");

            sb.Append("  Videos: ").Append(Videos).Append("\n");

            sb.Append("  Recordings: ").Append(Recordings).Append("\n");

            sb.Append("  Statistics: ").Append(Statistics).Append("\n");

            sb.Append("  Inbox: ").Append(Inbox).Append("\n");

            sb.Append("  Revenues: ").Append(Revenues).Append("\n");

            sb.Append("  Chat: ").Append(Chat).Append("\n");

            sb.Append("  Following: ").Append(Following).Append("\n");

            sb.Append("  Teams: ").Append(Teams).Append("\n");

            sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");

            sb.Append("  Admin: ").Append(Admin).Append("\n");

            sb.Append("  Superadmin: ").Append(Superadmin).Append("\n");

            sb.Append("  Payments: ").Append(Payments).Append("\n");

            sb.Append("  IsSubscriber: ").Append(IsSubscriber).Append("\n");

            sb.Append("  IsFollower: ").Append(IsFollower).Append("\n");

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