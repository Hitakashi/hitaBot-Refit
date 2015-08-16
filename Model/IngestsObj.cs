using System.Runtime.Serialization;

namespace hitaBot.Refit.Model
{
    [DataContract]
    public class IngestsObj
    {
        /// <summary>
        /// Gets or Sets IngestLocation
        /// </summary>
        [DataMember(Name = "ingest_location", EmitDefaultValue = false)]
        public string IngestLocation { get; set; }
        /// <summary>
        /// Gets or Sets IngestUrl
        /// </summary>
        [DataMember(Name = "ingest_url", EmitDefaultValue = false)]
        public string IngestUrl { get; set; }
    }
}