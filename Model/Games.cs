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
  public class Games {
    
    /// <summary>
    /// Gets or Sets Request
    /// </summary>
    [DataMember(Name="request", EmitDefaultValue=false)]
    public Request Request { get; set; }

    
    /// <summary>
    /// Gets or Sets Categories
    /// </summary>
    [DataMember(Name="categories", EmitDefaultValue=false)]
    public List<GameObj> Categories { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Games {\n");
      
      sb.Append("  Request: ").Append(Request).Append("\n");
      
      sb.Append("  Categories: ").Append(Categories).Append("\n");
      
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
