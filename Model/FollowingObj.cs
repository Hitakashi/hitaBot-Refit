using System.Runtime.Serialization;

namespace hitaBot.Refit.Model
{
    [DataContract]
    public class FollowingUserObj
    {
        /// <summary>
        ///     Gets or Sets Followers
        /// </summary>
        [DataMember(Name = "followers", EmitDefaultValue = false)]
        public int Followers { get; set; }

        /// <summary>
        ///     Gets or Sets UserName
        /// </summary>
        [DataMember(Name = "user_name", EmitDefaultValue = false)]
        public string UserName { get; set; }

        /// <summary>
        ///     Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public int UserId { get; set; }

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

        /// <summary>
        ///     Gets or Sets FollowId
        /// </summary>
        [DataMember(Name = "follow_id", EmitDefaultValue = false)]
        public int FollowId { get; set; }

        /// <summary>
        ///     Gets or Sets FollowerUserId
        /// </summary>
        [DataMember(Name = "follower_user_id", EmitDefaultValue = false)]
        public int FollowerUserId { get; set; }

        /// <summary>
        ///     Gets or Sets FollowerNotify
        /// </summary>
        [DataMember(Name = "follower_notify", EmitDefaultValue = false)]
        public int FollowerNotify { get; set; }

        /// <summary>
        ///     Gets or Sets DateAdded
        /// </summary>
        [DataMember(Name = "date_added", EmitDefaultValue = false)]
        public string DateAdded { get; set; }
    }
}