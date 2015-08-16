using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace hitaBot.Refit.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class ValidLogin {
    
    /// <summary>
    /// Gets or Sets UserId
    /// </summary>
    [DataMember(Name="user_id", EmitDefaultValue=false)]
    public string UserId { get; set; }

    
    /// <summary>
    /// Gets or Sets UserName
    /// </summary>
    [DataMember(Name="user_name", EmitDefaultValue=false)]
    public string UserName { get; set; }

    
    /// <summary>
    /// Gets or Sets UserLogo
    /// </summary>
    [DataMember(Name="user_logo", EmitDefaultValue=false)]
    public string UserLogo { get; set; }

    
    /// <summary>
    /// Gets or Sets UserLogoSmall
    /// </summary>
    [DataMember(Name="user_logo_small", EmitDefaultValue=false)]
    public string UserLogoSmall { get; set; }

    
    /// <summary>
    /// Gets or Sets UserBanned
    /// </summary>
    [DataMember(Name="user_banned", EmitDefaultValue=false)]
    public string UserBanned { get; set; }

    
    /// <summary>
    /// Gets or Sets UserBannedChannel
    /// </summary>
    [DataMember(Name="user_banned_channel", EmitDefaultValue=false)]
    public string UserBannedChannel { get; set; }

    
    /// <summary>
    /// Gets or Sets Superadmin
    /// </summary>
    [DataMember(Name="superadmin", EmitDefaultValue=false)]
    public string Superadmin { get; set; }

    
    /// <summary>
    /// Gets or Sets LivestreamCount
    /// </summary>
    [DataMember(Name="livestream_count", EmitDefaultValue=false)]
    public string LivestreamCount { get; set; }

    
    /// <summary>
    /// Gets or Sets Followers
    /// </summary>
    [DataMember(Name="followers", EmitDefaultValue=false)]
    public string Followers { get; set; }

    
    /// <summary>
    /// Gets or Sets AuthToken
    /// </summary>
    [DataMember(Name="authToken", EmitDefaultValue=false)]
    public string AuthToken { get; set; }

    
    /// <summary>
    /// Gets or Sets Login
    /// </summary>
    [DataMember(Name="login", EmitDefaultValue=false)]
    public string Login { get; set; }

    
    /// <summary>
    /// Gets or Sets Data
    /// </summary>
    [DataMember(Name="data", EmitDefaultValue=false)]
    public DataObj Data { get; set; }

    
    /// <summary>
    /// Gets or Sets Access
    /// </summary>
    [DataMember(Name="access", EmitDefaultValue=false)]
    public string Access { get; set; }

    
    /// <summary>
    /// Gets or Sets App
    /// </summary>
    [DataMember(Name="app", EmitDefaultValue=false)]
    public string App { get; set; }

    

    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ValidLogin {\n");
      
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      
      sb.Append("  UserName: ").Append(UserName).Append("\n");
      
      sb.Append("  UserLogo: ").Append(UserLogo).Append("\n");
      
      sb.Append("  UserLogoSmall: ").Append(UserLogoSmall).Append("\n");
      
      sb.Append("  UserBanned: ").Append(UserBanned).Append("\n");
      
      sb.Append("  UserBannedChannel: ").Append(UserBannedChannel).Append("\n");
      
      sb.Append("  Superadmin: ").Append(Superadmin).Append("\n");
      
      sb.Append("  LivestreamCount: ").Append(LivestreamCount).Append("\n");
      
      sb.Append("  Followers: ").Append(Followers).Append("\n");
      
      sb.Append("  AuthToken: ").Append(AuthToken).Append("\n");
      
      sb.Append("  Login: ").Append(Login).Append("\n");
      
      sb.Append("  Data: ").Append(Data).Append("\n");
      
      sb.Append("  Access: ").Append(Access).Append("\n");
      
      sb.Append("  App: ").Append(App).Append("\n");
      
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
        [DataContract]
        public class DataObj
        {

            [DataMember(Name = "app")]
            public string App { get; set; }

            [DataMember(Name = "user_id")]
            public string UserId { get; set; }

            [DataMember(Name = "user_name")]
            public string UserName { get; set; }

            [DataMember(Name = "user_logo")]
            public string UserLogo { get; set; }

            [DataMember(Name = "user_logo_small")]
            public string UserLogoSmall { get; set; }

            [DataMember(Name = "user_banned")]
            public string UserBanned { get; set; }

            [DataMember(Name = "superadmin")]
            public string Superadmin { get; set; }

            [DataMember(Name = "livestream_count")]
            public string LivestreamCount { get; set; }

            [DataMember(Name = "followers")]
            public string Followers { get; set; }

            [DataMember(Name = "authToken")]
            public string AuthToken { get; set; }

            [DataMember(Name = "login")]
            public bool Login { get; set; }
        }
    }
}
