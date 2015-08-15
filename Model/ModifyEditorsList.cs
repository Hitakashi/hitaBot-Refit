using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ModifyEditorsList {
    
    /// <summary>
    /// Gets or Sets AuthToken
    /// </summary>
    [DataMember(Name="authToken", EmitDefaultValue=false)]
    public string AuthToken { get; set; }

    
    /// <summary>
    /// Gets or Sets Editor
    /// </summary>
    [DataMember(Name="editor", EmitDefaultValue=false)]
    public string Editor { get; set; }

    
    /// <summary>
    /// Gets or Sets Remove
    /// </summary>
    [DataMember(Name="remove", EmitDefaultValue=false)]
    public bool? Remove { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ModifyEditorsList {\n");
      
      sb.Append("  AuthToken: ").Append(AuthToken).Append("\n");
      
      sb.Append("  Editor: ").Append(Editor).Append("\n");
      
      sb.Append("  Remove: ").Append(Remove).Append("\n");
      
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
