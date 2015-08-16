using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model
{
    /// <summary>
    /// </summary>
    [DataContract]
    public class SubInfo
    {
        /// <summary>
        ///     Gets or Sets Request
        /// </summary>
        [DataMember(Name = "request", EmitDefaultValue = false)]
        public Request Request { get; set; }

        /// <summary>
        ///     Gets or Sets Subscription
        /// </summary>
        [DataMember(Name = "subscription", EmitDefaultValue = false)]
        public SubscriptionObj Subscription { get; set; }

        /// <summary>
        ///     Gets or Sets Recurly
        /// </summary>
        [DataMember(Name = "recurly", EmitDefaultValue = false)]
        public Recurly Recurly { get; set; }

        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubInfo {\n");

            sb.Append("  Request: ").Append(Request).Append("\n");

            sb.Append("  Subscription: ").Append(Subscription).Append("\n");

            sb.Append("  Recurly: ").Append(Recurly).Append("\n");

            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }

    [DataContract]
    public class SubscriptionObj
    {
        [DataMember(Name = "plan")]
        public Plan Plan { get; set; }

        [DataMember(Name = "benefits")]
        public List<Benefit> Benefits { get; set; }
    }

    [DataContract]
    public class Plan
    {
        [DataMember(Name = "user_id")]
        public int UserId { get; set; }

        [DataMember(Name = "group_id")]
        public int GroupId { get; set; }

        [DataMember(Name = "plan_id")]
        public int PlanId { get; set; }

        [DataMember(Name = "date_added")]
        public string DateAdded { get; set; }

        [DataMember(Name = "plan_group_id")]
        public string PlanGroupId { get; set; }

        [DataMember(Name = "plan_name")]
        public string PlanName { get; set; }

        [DataMember(Name = "plan_prefix")]
        public string PlanPrefix { get; set; }

        [DataMember(Name = "plan_charge")]
        public string PlanCharge { get; set; }

        [DataMember(Name = "plan_share")]
        public string PlanShare { get; set; }

        [DataMember(Name = "plan_currency")]
        public string PlanCurrency { get; set; }

        [DataMember(Name = "plan_ads")]
        public int PlanAds { get; set; }

        [DataMember(Name = "plan_hd")]
        public string PlanHd { get; set; }

        [DataMember(Name = "plan_videos")]
        public string PlanVideos { get; set; }

        [DataMember(Name = "plan_recurring")]
        public string PlanRecurring { get; set; }

        [DataMember(Name = "plan_g2a")]
        public int PlanG2a { get; set; }

        [DataMember(Name = "plan_xsolla")]
        public int PlanXsolla { get; set; }
    }

    [DataContract]
    public class Benefit
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "text")]
        public string Text { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }
    }

    [DataContract]
    public class Recurly
    {
        [DataMember(Name = "signature")]
        public string Signature { get; set; }
    }
}