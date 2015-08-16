using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class SubBadge {
    
    /// <summary>
    /// Gets or Sets Request
    /// </summary>
    [DataMember(Name="request", EmitDefaultValue=false)]
    public Request Request { get; set; }

    
    /// <summary>
    /// Gets or Sets Badges
    /// </summary>
    [DataMember(Name="badges", EmitDefaultValue=false)]
    public List<Badge> Badges { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubBadge {\n");
      
      sb.Append("  Request: ").Append(Request).Append("\n");
      
      sb.Append("  Badges: ").Append(Badges).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}

    [DataContract]
    public class Badge
    {

        [DataMember(Name = "badge_id")]
        public int BadgeId { get; set; }

        [DataMember(Name = "badge_media_id")]
        public int BadgeMediaId { get; set; }

        [DataMember(Name = "badge_name")]
        public string BadgeName { get; set; }

        [DataMember(Name = "badge_image")]
        public string BadgeImage { get; set; }

        [DataMember(Name = "badge_enabled")]
        public int BadgeEnabled { get; set; }
    }
}
