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
  public class UpdateVideo {
    
    /// <summary>
    /// Gets or Sets Video
    /// </summary>
    [DataMember(Name="video", EmitDefaultValue=false)]
    public List<VideoObj> Video { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UpdateVideo {\n");
      
      sb.Append("  Video: ").Append(Video).Append("\n");
      
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
        [DataContract]
        public class VideoObj
        {

            [DataMember(Name = "media_user_name")]
            public string MediaUserName { get; set; }

            [DataMember(Name = "media_id")]
            public int MediaId { get; set; }

            [DataMember(Name = "media_category_id")]
            public int MediaCategoryId { get; set; }

            [DataMember(Name = "media_hidden")]
            public int MediaHidden { get; set; }

            [DataMember(Name = "media_status")]
            public string MediaStatus { get; set; }

            [DataMember(Name = "media_description")]
            public string MediaDescription { get; set; }
        }

    }
}
