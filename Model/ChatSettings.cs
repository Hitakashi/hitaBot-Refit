using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ChatSettings {
    
    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    public string UserId { get; set; }

    
    /// <summary>
    /// Gets or Sets SubImages
    /// </summary>
    [DataMember(Name="sub_images", EmitDefaultValue=false)]
    public bool? SubImages { get; set; }

    
    /// <summary>
    /// Gets or Sets ExternEmotes
    /// </summary>
    [DataMember(Name="extern_emotes", EmitDefaultValue=false)]
    public bool? ExternEmotes { get; set; }

    
    /// <summary>
    /// Gets or Sets Whisper
    /// </summary>
    [DataMember(Name="whisper", EmitDefaultValue=false)]
    public bool? Whisper { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ChatSettings {\n");
      
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      
      sb.Append("  SubImages: ").Append(SubImages).Append("\n");
      
      sb.Append("  ExternEmotes: ").Append(ExternEmotes).Append("\n");
      
      sb.Append("  Whisper: ").Append(Whisper).Append("\n");
      
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
}
