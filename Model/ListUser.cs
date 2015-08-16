using System.Runtime.Serialization;

namespace hitaBot.Refit.Model
{
    public class ListUser
    {
        /// <summary>
        ///     Gets or Sets UserName
        /// </summary>
        [DataMember(Name = "user_name", EmitDefaultValue = false)]
        public string UserName { get; set; }

        /// <summary>
        ///     Gets or Sets UserStatus
        /// </summary>
        [DataMember(Name = "user_status", EmitDefaultValue = false)]
        public int UserStatus { get; set; }

        /// <summary>
        ///     Gets or Sets UserLogo
        /// </summary>
        [DataMember(Name = "user_logo", EmitDefaultValue = false)]
        public string UserLogo { get; set; }

        /// <summary>
        ///     Gets or Sets UserLogoSmall
        /// </summary>
        [DataMember(Name = "user_logo_small", EmitDefaultValue = false)]
        public string UserLogoSmall { get; set; }
    }
}