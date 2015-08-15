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
  public class UpdateTeam {
    
    /// <summary>
    /// Gets or Sets Info
    /// </summary>
    [DataMember(Name="info", EmitDefaultValue=false)]
    public Object Info { get; set; }

    
    /// <summary>
    /// Gets or Sets Invites
    /// </summary>
    [DataMember(Name="invites", EmitDefaultValue=false)]
    public List<string> Invites { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UpdateTeam {\n");
      
      sb.Append("  Info: ").Append(Info).Append("\n");
      
      sb.Append("  Invites: ").Append(Invites).Append("\n");
      
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
