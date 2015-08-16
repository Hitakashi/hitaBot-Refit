using System.Runtime.Serialization;

namespace hitaBot.Refit.Model
{
    public class FollowerStatsObj
    {
        /// <summary>
        ///     Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public string Date { get; set; }

        /// <summary>
        ///     Gets or Sets Followers
        /// </summary>
        [DataMember(Name = "followers", EmitDefaultValue = false)]
        public int Followers { get; set; }
    }
}