using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class StreamedSeconds
    {
        /// <summary>
        ///     Gets or Sets Channel
        /// </summary>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public string Channel { get; set; }

        /// <summary>
        ///     Gets or Sets StartTime
        /// </summary>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public int? StartTime { get; set; }

        /// <summary>
        ///     Gets or Sets EndTime
        /// </summary>
        [DataMember(Name = "endTime", EmitDefaultValue = false)]
        public int? EndTime { get; set; }

        /// <summary>
        ///     Gets or Sets StreamedSeconds
        /// </summary>
        [DataMember(Name = "streamed_seconds", EmitDefaultValue = false)]
        public int? StreamedSecondsVar { get; set; }

        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StreamedSeconds {\n");

            sb.Append("  Channel: ").Append(Channel).Append("\n");

            sb.Append("  StartTime: ").Append(StartTime).Append("\n");

            sb.Append("  EndTime: ").Append(EndTime).Append("\n");

            sb.Append("  StreamedSeconds: ").Append(StreamedSecondsVar).Append("\n");

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