using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class MediaStatus
    {
        /// <summary>
        ///     Gets or Sets MediaIsLive
        /// </summary>
        [DataMember(Name = "media_is_live", EmitDefaultValue = false)]
        public string MediaIsLive { get; set; }

        /// <summary>
        ///     Gets or Sets MediaViews
        /// </summary>
        [DataMember(Name = "media_views", EmitDefaultValue = false)]
        public string MediaViews { get; set; }

        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaStatus {\n");

            sb.Append("  MediaIsLive: ").Append(MediaIsLive).Append("\n");

            sb.Append("  MediaViews: ").Append(MediaViews).Append("\n");

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