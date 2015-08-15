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
  public class Team {
    
    /// <summary>
    /// Gets or Sets Info
    /// </summary>
    [DataMember(Name="info", EmitDefaultValue=false)]
    public Object Info { get; set; }

    
    /// <summary>
    /// Gets or Sets Media
    /// </summary>
    [DataMember(Name="media", EmitDefaultValue=false)]
    public Object Media { get; set; }

    
    /// <summary>
    /// Gets or Sets Members
    /// </summary>
    [DataMember(Name="members", EmitDefaultValue=false)]
    public List<Object> Members { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Team {\n");
      
      sb.Append("  Info: ").Append(Info).Append("\n");
      
      sb.Append("  Media: ").Append(Media).Append("\n");
      
      sb.Append("  Members: ").Append(Members).Append("\n");
      
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
