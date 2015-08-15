using System;
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
            [AliasAs("channel")] String channel
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
        Task<String> updateChatBlacklist(
            [AliasAs("channel")] String channel, [AliasAs("authToken")] String authToken,
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
            [AliasAs("user")] String user, [AliasAs("authToken")] String authToken
            );

        /**
   * Get Emoji Properties
   * 
   * @param iconName Emoji Name.
   * @return ChatIconInfo
   */

        [Get("/chat/icon/{iconName}")]
        Task<ChatIconInfo> getChatIconInfo(
            [AliasAs("iconName")] String iconName
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
            [AliasAs("channel")] String channel, [AliasAs("premiumOnly")] String premiumOnly
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
            [AliasAs("user")] String user, [AliasAs("authToken")] String authToken
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
            [AliasAs("channel")] String channel, [AliasAs("authToken")] String authToken
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
            [AliasAs("channel")] String channel, [Body] AddChatModerators body
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
            [AliasAs("channel")] String channel, [AliasAs("authToken")] String authToken
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
            [AliasAs("channel")] String channel, [AliasAs("authToken")] String authToken, [Body] ChatSettings body
            );

        /**
   * Get Game Properties
   * You can use either a game ID or game name. For a game name you must use the soe query.
   * @param game Game ID or Game Name
   * @param soe Use for Game Names
   * @return Game
   */

        [Get("/game/{game}")]
        Task<Game> getGame(
            [AliasAs("game")] String game, [AliasAs("soe")] Boolean soe
            );

        /**
   * Get Games
   * Searches for games by keywords
   * @param q Search keyword for &#39;category_name&#39;
   * @param limit Maximum number of games objects
   * @param liveonly Only show games with live channels
   * @return Games
   */

        [Get("/games")]
        Task<Games> getGames(
            [AliasAs("q")] String q, [AliasAs("limit")] int limit, [AliasAs("liveonly")] Boolean liveonly
            );
    }
}