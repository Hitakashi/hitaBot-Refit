using System.Threading.Tasks;
using hitaBot.Refit.Model;
using Refit;

namespace hitaBot.Refit.api
{
    public interface ChatApi
    {
        /**
   * Get Chat Blacklist
   * 
   * @param channel Channel Name
   * @return ChatBlacklist
   */

        [Get("/chat/blacklist/{channel}")]
        Task<ChatBlacklist> getChatBlacklist(
            [AliasAs("channel")] string channel
            );

        /**
   * Update Chat Blacklist
   * Must include all previous blacklist words to prevent resetting the blacklist.
   * @param channel Channel Name
   * @param authToken Moderator or Higher Auth Token
   * @param body Array of words to overwrite current blacklist
   * @return String
   */

        [Post("/chat/blacklist/{channel}")]
        Task<SuccessOnlyString> updateChatBlacklist(
            [AliasAs("channel")] string channel, [AliasAs("authToken")] string authToken,
            [Body] UpdateChatBlacklist body
            );

        /**
   * Get Detailed Emoji List
   * 
   * @param user Gets Emoji for user
   * @param authToken Includes subscription Emoji for user
   * @return ChatEmotes
   */

        [Get("/chat/emotes/{user}")]
        Task<ChatEmotes> getChatEmotes(
            [AliasAs("user")] string user, [AliasAs("authToken")] string authToken
            );

        /**
   * Get Emoji Properties
   * 
   * @param iconName Emoji Name.
   * @return ChatIconInfo
   */

        [Get("/chat/icon/{iconName}")]
        Task<ChatIconInfo> getChatIconInfo(
            [AliasAs("iconName")] string iconName
            );

        /**
   * Gets Global Icons or Channels Subscription Emoji&#39;s
   * 
   * @param channel Channel Name
   * @param premiumOnly Only show channels subscription emoji&#39;s
   * @return ChatIcons
   */

        [Get("/chat/icons/{channel}")]
        Task<ChatIcons> getChatIcons(
            [AliasAs("channel")] string channel, [AliasAs("premiumOnly")] string premiumOnly
            );

        /**
   * Get Channels &#39;user&#39; has moderator access
   * 
   * @param user Username
   * @param authToken User&#39;s Auth Token
   * @return ChatModerations
   */

        [Get("/chat/moderations/{user}")]
        Task<ChatModerations> getModerations(
            [AliasAs("user")] string user, [AliasAs("authToken")] string authToken
            );

        /**
   * Get Channel Moderators
   * 
   * @param channel Channel Name
   * @param authToken Editor or Higher Auth Token
   * @return ChatModerators
   */

        [Get("/chat/moderators/{channel}")]
        Task<ChatModerators> getChatMods(
            [AliasAs("channel")] string channel, [AliasAs("authToken")] string authToken
            );

        /**
   * Add or Remove Channel Moderator
   * 
   * @param channel Channel Name
   * @param body 
   * @return Success
   */

        [Post("/chat/moderators/{channel}")]
        Task<Success> modifyChatMods(
            [AliasAs("channel")] string channel, [Body] AddChatModerators body
            );

        /**
   * Get Chat Servers
   * 
   * @return WSServers
   */

        [Get("/chat/servers")]
        Task<WSServers> getChatServers();

        /**
   * Get Chat Settings
   * 
   * @param channel Channel Name
   * @param authToken Editor or Higher Auth Token
   * @return ChatSettings
   */

        [Get("/chat/settings/{channel}")]
        Task<ChatSettings> getChatSettings(
            [AliasAs("channel")] string channel, [AliasAs("authToken")] string authToken
            );

        /**
   * Updates Chat Settings
   * Editors cannot update whisper settings
   * @param channel Channel Name
   * @param authToken Editor or Higher Auth Token
   * @param body 
   * @return Success
   */

        [Post("/chat/settings/{channel}")]
        Task<Success> updateChatSettings(
            [AliasAs("channel")] string channel, [AliasAs("authToken")] string authToken, [Body] ChatSettings body
            );
    }
}