using System.Runtime.Serialization;

namespace hitaBot.Refit.Model
{
    public class Request
    {    /// <summary>
         /// Gets or Sets this
         /// </summary>
        [DataMember(Name = "this", EmitDefaultValue = false)]
        public string This { get; set; }
    }
}