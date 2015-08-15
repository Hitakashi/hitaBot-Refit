using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class UserUpdate {
    
    /// <summary>
    /// Gets or Sets UserName
    /// </summary>
    [DataMember(Name="user_name", EmitDefaultValue=false)]
    public string UserName { get; set; }

    
    /// <summary>
    /// Gets or Sets UserDisplayName
    /// </summary>
    [DataMember(Name="user_display_name", EmitDefaultValue=false)]
    public string UserDisplayName { get; set; }

    
    /// <summary>
    /// Gets or Sets TwitterAccount
    /// </summary>
    [DataMember(Name="twitter_account", EmitDefaultValue=false)]
    public string TwitterAccount { get; set; }

    
    /// <summary>
    /// Gets or Sets TwitterEnabled
    /// </summary>
    [DataMember(Name="twitter_enabled", EmitDefaultValue=false)]
    public bool? TwitterEnabled { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UserUpdate {\n");
      
      sb.Append("  UserName: ").Append(UserName).Append("\n");
      
      sb.Append("  UserDisplayName: ").Append(UserDisplayName).Append("\n");
      
      sb.Append("  TwitterAccount: ").Append(TwitterAccount).Append("\n");
      
      sb.Append("  TwitterEnabled: ").Append(TwitterEnabled).Append("\n");
      
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
