using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class TeamUplaod {
    
    /// <summary>
    /// Gets or Sets Logo
    /// </summary>
    [DataMember(Name="logo", EmitDefaultValue=false)]
    public LogoObj Logo { get; set; }

    
    /// <summary>
    /// Gets or Sets Cover
    /// </summary>
    [DataMember(Name="cover", EmitDefaultValue=false)]
    public CoverObj Cover { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TeamUplaod {\n");
      
      sb.Append("  Logo: ").Append(Logo).Append("\n");
      
      sb.Append("  Cover: ").Append(Cover).Append("\n");
      
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
        public class LogoObj
        {

            [DataMember(Name = "small")]
            public string Small { get; set; }

            [DataMember(Name = "large")]
            public string Large { get; set; }
        }

        [DataContract]
        public class CoverObj
        {

            [DataMember(Name = "cover")]
            public string Cover { get; set; }
        }
    }
}
