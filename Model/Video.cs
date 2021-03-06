using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class Video
    {
        /// <summary>
        ///     Gets or Sets Request
        /// </summary>
        [DataMember(Name = "request", EmitDefaultValue = false)]
        public Request Request { get; set; }

        /// <summary>
        ///     Gets or Sets MediaType
        /// </summary>
        [DataMember(Name = "media_type", EmitDefaultValue = false)]
        public string MediaType { get; set; }

        /// <summary>
        ///     Gets or Sets Video
        /// </summary>
        [DataMember(Name = "video", EmitDefaultValue = false)]
        public List<VideoObj> VideoVar { get; set; }

        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Video {\n");

            sb.Append("  Request: ").Append(Request).Append("\n");

            sb.Append("  MediaType: ").Append(MediaType).Append("\n");

            sb.Append("  Video: ").Append(VideoVar).Append("\n");

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