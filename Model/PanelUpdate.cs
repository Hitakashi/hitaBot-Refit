using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PanelUpdate {
    
    /// <summary>
    /// Gets or Sets UserName
    /// </summary>
    [DataMember(Name="user_name", EmitDefaultValue=false)]
    public string UserName { get; set; }

    
    /// <summary>
    /// Gets or Sets AuthToken
    /// </summary>
    [DataMember(Name="authToken", EmitDefaultValue=false)]
    public string AuthToken { get; set; }

    
    /// <summary>
    /// Gets or Sets Profile
    /// </summary>
    [DataMember(Name="profile", EmitDefaultValue=false)]
    public Object Profile { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PanelUpdate {\n");
      
      sb.Append("  UserName: ").Append(UserName).Append("\n");
      
      sb.Append("  AuthToken: ").Append(AuthToken).Append("\n");
      
      sb.Append("  Profile: ").Append(Profile).Append("\n");
      
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
