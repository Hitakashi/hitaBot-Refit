using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class StreamStats {
    
    /// <summary>
    /// Gets or Sets Channel
    /// </summary>
    [DataMember(Name="channel", EmitDefaultValue=false)]
    public string Channel { get; set; }

    
    /// <summary>
    /// Gets or Sets StartTime
    /// </summary>
    [DataMember(Name="startTime", EmitDefaultValue=false)]
    public string StartTime { get; set; }

    
    /// <summary>
    /// Gets or Sets EndTime
    /// </summary>
    [DataMember(Name="endTime", EmitDefaultValue=false)]
    public string EndTime { get; set; }

    
    /// <summary>
    /// Gets or Sets Step
    /// </summary>
    [DataMember(Name="step", EmitDefaultValue=false)]
    public int? Step { get; set; }

    
    /// <summary>
    /// Gets or Sets Maxviewer
    /// </summary>
    [DataMember(Name="maxviewer", EmitDefaultValue=false)]
    public int? Maxviewer { get; set; }

    
    /// <summary>
    /// Gets or Sets Maxfollower
    /// </summary>
    [DataMember(Name="maxfollower", EmitDefaultValue=false)]
    public int? Maxfollower { get; set; }

    
    /// <summary>
    /// Gets or Sets Maxregistered
    /// </summary>
    [DataMember(Name="maxregistered", EmitDefaultValue=false)]
    public int? Maxregistered { get; set; }

    
    /// <summary>
    /// Gets or Sets Maxembed
    /// </summary>
    [DataMember(Name="maxembed", EmitDefaultValue=false)]
    public int? Maxembed { get; set; }

    
    /// <summary>
    /// Gets or Sets Maxsubscriber
    /// </summary>
    [DataMember(Name="maxsubscriber", EmitDefaultValue=false)]
    public int? Maxsubscriber { get; set; }

    
    /// <summary>
    /// Gets or Sets Maxandroid
    /// </summary>
    [DataMember(Name="maxandroid", EmitDefaultValue=false)]
    public int? Maxandroid { get; set; }

    
    /// <summary>
    /// Gets or Sets Maxios
    /// </summary>
    [DataMember(Name="maxios", EmitDefaultValue=false)]
    public int? Maxios { get; set; }

    
    /// <summary>
    /// Gets or Sets Maxchromecast
    /// </summary>
    [DataMember(Name="maxchromecast", EmitDefaultValue=false)]
    public int? Maxchromecast { get; set; }

    
    /// <summary>
    /// Gets or Sets Maxweb
    /// </summary>
    [DataMember(Name="maxweb", EmitDefaultValue=false)]
    public int? Maxweb { get; set; }

    
    /// <summary>
    /// Gets or Sets Totalads
    /// </summary>
    [DataMember(Name="totalads", EmitDefaultValue=false)]
    public int? Totalads { get; set; }

    
    /// <summary>
    /// Gets or Sets Timeline
    /// </summary>
    [DataMember(Name="timeline", EmitDefaultValue=false)]
    public string Timeline { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class StreamStats {\n");
      
      sb.Append("  Channel: ").Append(Channel).Append("\n");
      
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
      
      sb.Append("  EndTime: ").Append(EndTime).Append("\n");
      
      sb.Append("  Step: ").Append(Step).Append("\n");
      
      sb.Append("  Maxviewer: ").Append(Maxviewer).Append("\n");
      
      sb.Append("  Maxfollower: ").Append(Maxfollower).Append("\n");
      
      sb.Append("  Maxregistered: ").Append(Maxregistered).Append("\n");
      
      sb.Append("  Maxembed: ").Append(Maxembed).Append("\n");
      
      sb.Append("  Maxsubscriber: ").Append(Maxsubscriber).Append("\n");
      
      sb.Append("  Maxandroid: ").Append(Maxandroid).Append("\n");
      
      sb.Append("  Maxios: ").Append(Maxios).Append("\n");
      
      sb.Append("  Maxchromecast: ").Append(Maxchromecast).Append("\n");
      
      sb.Append("  Maxweb: ").Append(Maxweb).Append("\n");
      
      sb.Append("  Totalads: ").Append(Totalads).Append("\n");
      
      sb.Append("  Timeline: ").Append(Timeline).Append("\n");
      
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
