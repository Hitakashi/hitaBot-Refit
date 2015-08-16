using System.Runtime.Serialization;

namespace hitaBot.Refit.Model
{
    [DataContract]
    public class FollowingUserChannelObj
    {
        /// <summary>
        /// Gets or Sets FollowId
        /// </summary>
        [DataMember(Name = "follow_id", EmitDefaultValue = false)]
        public int FollowId { get; set; }
        /// <summary>
        /// Gets or Sets FollowerUserId
        /// </summary>
        [DataMember(Name = "follower_user_id", EmitDefaultValue = false)]
        public int FollowerUserId { get; set; }
        /// <summary>
        /// Gets or Sets FollowerNotify
        /// </summary>
        [DataMember(Name = "follower_notify", EmitDefaultValue = false)]
        public int FollowerNotify { get; set; }
    }
}