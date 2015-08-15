using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class SubInfo {
    
    /// <summary>
    /// Gets or Sets Request
    /// </summary>
    [DataMember(Name="request", EmitDefaultValue=false)]
    public Object Request { get; set; }

    
    /// <summary>
    /// Gets or Sets Subscription
    /// </summary>
    [DataMember(Name="subscription", EmitDefaultValue=false)]
    public Object Subscription { get; set; }

    
    /// <summary>
    /// Gets or Sets Recurly
    /// </summary>
    [DataMember(Name="recurly", EmitDefaultValue=false)]
    public Object Recurly { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubInfo {\n");
      
      sb.Append("  Request: ").Append(Request).Append("\n");
      
      sb.Append("  Subscription: ").Append(Subscription).Append("\n");
      
      sb.Append("  Recurly: ").Append(Recurly).Append("\n");
      
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
