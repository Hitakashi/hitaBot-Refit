using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class GetUploadDesc : List<GetUploadDesc.Image> {
    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetUploadDesc {\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public  new string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }
        [DataContract]
        public class Image
        {

            [DataMember(Name = "image_id")]
            public int ImageId { get; set; }

            [DataMember(Name = "image_path")]
            public string ImagePath { get; set; }

            [DataMember(Name = "image_date_added")]
            public string ImageDateAdded { get; set; }
        }
    }
}
