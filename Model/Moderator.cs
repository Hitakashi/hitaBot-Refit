using System.Runtime.Serialization;

namespace hitaBot.Refit.Model
{
    public class Moderator
    {
        /// <summary>
        ///     Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public int UserId { get; set; }

        /// <summary>
        ///     Gets or Sets UserName
        /// </summary>
        [DataMember(Name = "user_name", EmitDefaultValue = false)]
        public string UserName { get; set; }

        /// <summary>
        ///     Gets or Sets UserLogo
        /// </summary>
        [DataMember(Name = "user_logo", EmitDefaultValue = false)]
        public string UserLogo { get; set; }
    }
}