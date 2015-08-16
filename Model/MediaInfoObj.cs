using System.Runtime.Serialization;

namespace hitaBot.Refit.Model
{
    [DataContract]
    public class MediaInfoObj
    {
        /// <summary>
        /// Gets or Sets LogId
        /// </summary>
        [DataMember(Name = "log_id", EmitDefaultValue = false)]
        public int LogId { get; set; }
        /// <summary>
        /// Gets or Sets MediaId
        /// </summary>
        [DataMember(Name = "media_id", EmitDefaultValue = false)]
        public int MediaId { get; set; }
        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public int Width { get; set; }
        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public int Height { get; set; }
        /// <summary>
        /// Gets or Sets Vbitrate
        /// </summary>
        [DataMember(Name = "vbitrate", EmitDefaultValue = false)]
        public int Vbitrate { get; set; }
        /// <summary>
        /// Gets or Sets Abitrate
        /// </summary>
        [DataMember(Name = "abitrate", EmitDefaultValue = false)]
        public int Abitrate { get; set; }
        /// <summary>
        /// Gets or Sets Vcodec
        /// </summary>
        [DataMember(Name = "vcodec", EmitDefaultValue = false)]
        public string Vcodec { get; set; }
        /// <summary>
        /// Gets or Sets Acodec
        /// </summary>
        [DataMember(Name = "acodec", EmitDefaultValue = false)]
        public string Acodec { get; set; }
        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name = "profile", EmitDefaultValue = false)]
        public string Profile { get; set; }
        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name = "level", EmitDefaultValue = false)]
        public int Level { get; set; }
        /// <summary>
        /// Gets or Sets Fps
        /// </summary>
        [DataMember(Name = "fps", EmitDefaultValue = false)]
        public int Fps { get; set; }
        /// <summary>
        /// Gets or Sets Gop
        /// </summary>
        [DataMember(Name = "gop", EmitDefaultValue = false)]
        public string Gop { get; set; }
        /// <summary>
        /// Gets or Sets Hostname
        /// </summary>
        [DataMember(Name = "hostname", EmitDefaultValue = false)]
        public string Hostname { get; set; }
        /// <summary>
        /// Gets or Sets Useragent
        /// </summary>
        [DataMember(Name = "useragent", EmitDefaultValue = false)]
        public string Useragent { get; set; }
        /// <summary>
        /// Gets or Sets LogDate
        /// </summary>
        [DataMember(Name = "log_date", EmitDefaultValue = false)]
        public string LogDate { get; set; }
    }
}