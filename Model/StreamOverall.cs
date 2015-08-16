using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class StreamOverall
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
        ///     Gets or Sets TotalUniques
        /// </summary>
        [DataMember(Name = "totalUniques", EmitDefaultValue = false)]
        public int? TotalUniques { get; set; }

        /// <summary>
        ///     Gets or Sets TotalViewtime
        /// </summary>
        [DataMember(Name = "totalViewtime", EmitDefaultValue = false)]
        public int? TotalViewtime { get; set; }

        /// <summary>
        ///     Gets or Sets TotalViews
        /// </summary>
        [DataMember(Name = "totalViews", EmitDefaultValue = false)]
        public int? TotalViews { get; set; }

        /// <summary>
        ///     Gets or Sets TotalCountries
        /// </summary>
        [DataMember(Name = "totalCountries", EmitDefaultValue = false)]
        public int? TotalCountries { get; set; }

        /// <summary>
        ///     Gets or Sets Countries
        /// </summary>
        [DataMember(Name = "countries", EmitDefaultValue = false)]
        public string Countries { get; set; }

        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StreamOverall {\n");

            sb.Append("  Channel: ").Append(Channel).Append("\n");

            sb.Append("  StartTime: ").Append(StartTime).Append("\n");

            sb.Append("  EndTime: ").Append(EndTime).Append("\n");

            sb.Append("  TotalUniques: ").Append(TotalUniques).Append("\n");

            sb.Append("  TotalViewtime: ").Append(TotalViewtime).Append("\n");

            sb.Append("  TotalViews: ").Append(TotalViews).Append("\n");

            sb.Append("  TotalCountries: ").Append(TotalCountries).Append("\n");

            sb.Append("  Countries: ").Append(Countries).Append("\n");

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