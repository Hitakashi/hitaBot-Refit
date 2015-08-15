using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class CreateTeam {
    
    /// <summary>
    /// Gets or Sets AuthToken
    /// </summary>
    [DataMember(Name="authToken", EmitDefaultValue=false)]
    public string AuthToken { get; set; }

    
    /// <summary>
    /// Gets or Sets GroupUserName
    /// </summary>
    [DataMember(Name="group_user_name", EmitDefaultValue=false)]
    public string GroupUserName { get; set; }

    
    /// <summary>
    /// Gets or Sets GroupName
    /// </summary>
    [DataMember(Name="group_name", EmitDefaultValue=false)]
    public string GroupName { get; set; }

    
    /// <summary>
    /// Gets or Sets GroupTest
    /// </summary>
    [DataMember(Name="group_test", EmitDefaultValue=false)]
    public string GroupTest { get; set; }

    
    /// <summary>
    /// Must match 'group_name' except in casing
    /// </summary>
    /// <value>Must match 'group_name' except in casing</value>
    [DataMember(Name="group_display_name", EmitDefaultValue=false)]
    public string GroupDisplayName { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CreateTeam {\n");
      
      sb.Append("  AuthToken: ").Append(AuthToken).Append("\n");
      
      sb.Append("  GroupUserName: ").Append(GroupUserName).Append("\n");
      
      sb.Append("  GroupName: ").Append(GroupName).Append("\n");
      
      sb.Append("  GroupTest: ").Append(GroupTest).Append("\n");
      
      sb.Append("  GroupDisplayName: ").Append(GroupDisplayName).Append("\n");
      
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
