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
  public class SubscriberList {
    
    /// <summary>
    /// Gets or Sets Request
    /// </summary>
    [DataMember(Name="request", EmitDefaultValue=false)]
    public Request Request { get; set; }

    
    /// <summary>
    /// Gets or Sets Subscribers
    /// </summary>
    [DataMember(Name="subscribers", EmitDefaultValue=false)]
    public List<SubscribersObj> Subscribers { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubscriberList {\n");
      
      sb.Append("  Request: ").Append(Request).Append("\n");
      
      sb.Append("  Subscribers: ").Append(Subscribers).Append("\n");
      
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

    [DataContract]
    public class SubscribersObj
    {

        [DataMember(Name = "followers")]
        public int Followers { get; set; }

        [DataMember(Name = "user_name")]
        public string UserName { get; set; }

        [DataMember(Name = "user_id")]
        public int UserId { get; set; }

        [DataMember(Name = "user_logo")]
        public string UserLogo { get; set; }

        [DataMember(Name = "user_logo_small")]
        public string UserLogoSmall { get; set; }

        [DataMember(Name = "sub_date_added")]
        public string SubDateAdded { get; set; }

        [DataMember(Name = "sub_date_valid")]
        public string SubDateValid { get; set; }

        [DataMember(Name = "sub_payment_method")]
        public string SubPaymentMethod { get; set; }

        [DataMember(Name = "canceled")]
        public string Canceled { get; set; }
    }
}
