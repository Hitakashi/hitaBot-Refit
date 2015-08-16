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
  public class SubscriptionList {
    
    /// <summary>
    /// Gets or Sets Request
    /// </summary>
    [DataMember(Name="request", EmitDefaultValue=false)]
    public Request Request { get; set; }

    
    /// <summary>
    /// Gets or Sets Subscriptions
    /// </summary>
    [DataMember(Name="subscriptions", EmitDefaultValue=false)]
    public List<Subscription> Subscriptions { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SubscriptionList {\n");
      
      sb.Append("  Request: ").Append(Request).Append("\n");
      
      sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");
      
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
    public class Subscription
    {

        [DataMember(Name = "followers")]
        public int Followers { get; set; }

        [DataMember(Name = "sub_id")]
        public int SubId { get; set; }

        [DataMember(Name = "sub_date_added")]
        public string SubDateAdded { get; set; }

        [DataMember(Name = "sub_date_valid")]
        public string SubDateValid { get; set; }

        [DataMember(Name = "sub_payment_method")]
        public string SubPaymentMethod { get; set; }

        [DataMember(Name = "canceled")]
        public string Canceled { get; set; }

        [DataMember(Name = "plan_charge")]
        public string PlanCharge { get; set; }

        [DataMember(Name = "plan_currency")]
        public string PlanCurrency { get; set; }

        [DataMember(Name = "plan_recurring")]
        public int PlanRecurring { get; set; }

        [DataMember(Name = "plan_id")]
        public int PlanId { get; set; }

        [DataMember(Name = "user_name")]
        public string UserName { get; set; }

        [DataMember(Name = "user_id")]
        public int UserId { get; set; }

        [DataMember(Name = "user_logo")]
        public string UserLogo { get; set; }

        [DataMember(Name = "user_logo_small")]
        public string UserLogoSmall { get; set; }

        [DataMember(Name = "user_cover")]
        public string UserCover { get; set; }

        [DataMember(Name = "benefits")]
        public List<SubscriptionBenefit> Benefits { get; set; }
    }


    [DataContract]
    public class SubscriptionBenefit
    {

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "text")]
        public string Text { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "media")]
        public string Media { get; set; }
    }
}
