using System.Runtime.Serialization;

namespace hitaBot.Refit.Model
{
    public class Params
    {
        /// <summary>
        ///     Gets or Sets Channel
        /// </summary>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public string Channel { get; set; }

        /// <summary>
        ///     Gets or Sets Count
        /// </summary>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public string Count { get; set; }

        /// <summary>
        ///     Gets or Sets Delay
        /// </summary>
        [DataMember(Name = "delay", EmitDefaultValue = false)]
        public string Delay { get; set; }

        /// <summary>
        ///     Gets or Sets Token
        /// </summary>
        [DataMember(Name = "token", EmitDefaultValue = false)]
        public string Token { get; set; }

        /// <summary>
        ///     Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        ///     Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public int Timestamp { get; set; }
    }
}