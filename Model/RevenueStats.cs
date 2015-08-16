using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class RevenueStats {
    
    /// <summary>
    /// Gets or Sets Request
    /// </summary>
    [DataMember(Name="request", EmitDefaultValue=false)]
    public RequestRevenue Request { get; set; }

    
    /// <summary>
    /// Gets or Sets Revenues
    /// </summary>
    [DataMember(Name="revenues", EmitDefaultValue=false)]
    public string Revenues { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RevenueStats {\n");
      
      sb.Append("  Request: ").Append(Request).Append("\n");
      
      sb.Append("  Revenues: ").Append(Revenues).Append("\n");
      
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

    public class RequestRevenue
    {
        [DataMember(Name = "this")]
        public string This { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "user")]
        public string User { get; set; }
    }
}
