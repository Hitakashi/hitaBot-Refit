using System.Threading.Tasks;
using hitaBot.Refit.Model;
using Refit;

namespace hitaBot.Refit.api
{
    public interface MediaApi
    {
        /**
   * Gets Media Ingests
   * 
   * @return Ingests
   */

        [Get("/ingests/default_list")]
        Task<Ingests> getIngests();

        /**
   * Get List of Media Objects
   * 
   * @param limit Maximum number of objects to fetch. Default and Max. is 100.
   * @param showHidden Show objects that are hidden
   * @param filter Filter objects
   * @param liveonly Show only live channels
   * @param featured Must be list
   * @param followerId Only load followers for the provided User ID
   * @param game Filters objects by Game ID, Game SEO Name, or URL Encoded Game Name
   * @param hiddenOnly Only shows hidden streams
   * @param start Offsets media objects
   * @param publicOnly Only show public streams
   * @param search Filters objects by media_status (Title)
   * @return MediaList
   */

        [Get("/media/live/list")]
        Task<MediaList> getMediaLiveList(
            [AliasAs("limit")] int limit, [AliasAs("showHidden")] bool showHidden, [AliasAs("filter")] string filter,
            [AliasAs("liveonly")] string liveonly, [AliasAs("featured")] string featured,
            [AliasAs("follower_id")] int followerId, [AliasAs("game")] string game,
            [AliasAs("hiddenOnly")] bool hiddenOnly, [AliasAs("start")] int start,
            [AliasAs("publicOnly")] bool publicOnly, [AliasAs("search")] string search
            );

        /**
   * Get Live Media Object
   * Please check the model for values that are authentication only.\n
   * @param channel Channel Name
   * @param authToken Show authenticated values. Editor or Higher Token
   * @param limit Maximum number of objects to fetch. Default and Max. is 100.
   * @param showHidden Show objects that are hidden
   * @param liveonly Show only live channels
   * @return Media
   */

        [Get("/media/live/{channel}")]
        Task<Media> getMediaLive(
            [AliasAs("channel")] string channel, [AliasAs("authToken")] string authToken,
            [AliasAs("limit")] string limit, [AliasAs("showHidden")] bool showHidden,
            [AliasAs("liveonly")] string liveonly
            );

        /**
   * Updates Livestream
   * 
   * @param channel Channel Name
   * @param authToken Editor or Higher Auth Token
   * @param body Stream Data
   * @return UpdateMedia
   */

        [Put("/media/live/{channel}")]
        Task<UpdateMedia> updateMedia(
            [AliasAs("channel")] string channel, [AliasAs("authToken")] string authToken, [Body] UpdateMedia body
            );

        /**
   * Gets Live Status &amp; Viewers
   * 
   * @param channel Channel Name
   * @return Object
   */

        [Get("/media/status/{channel}")]
        Task<MediaStatus> getMediaStatus(
            [AliasAs("channel")] string channel
            );

        /**
   * Create Video from Recording
   * 
   * @param authToken Editor or Higher Auth Token
   * @param body VOD Data
   * @return Object
   */

        [Post("/media/video/list")]
        Task<VideoCreated> createVideo(
            [AliasAs("authToken")] string authToken, [Body] CreateVideo body
            );

        /**
   * Gets Video List
   * 
   * @param channel Channel Name
   * @param authToken Editor or Higher Auth Token
   * @param filter Video Filter
   * @param hiddenOnly Shows only private VODs
   * @param limit Limits amount of VOD objects
   * @param publicOnly Shows only public VODs
   * @param search Search titles of VODs
   * @param showHidden Include Private VODs
   * @param yt Shows VODs pushed to YouTube
   * @return VideoList
   */

        [Get("/media/video/{channel}/list")]
        Task<VideoList> getVideoList(
            [AliasAs("channel")] string channel, [AliasAs("authToken")] string authToken,
            [AliasAs("filter")] string filter, [AliasAs("hiddenOnly")] bool hiddenOnly, [AliasAs("limit")] int limit,
            [AliasAs("publicOnly")] bool publicOnly, [AliasAs("search")] string search,
            [AliasAs("showHidden")] bool showHidden, [AliasAs("yt")] bool yt
            );

        /**
   * Get Video Properties
   * 
   * @param videoID Video ID
   * @param showHidden Show Hidden VOD
   * @return Video
   */

        [Get("/media/video/{videoID}")]
        Task<Video> getVideo(
            [AliasAs("videoID")] int videoID, [AliasAs("showHidden")] bool showHidden
            );

        /**
   * Update Video Properties
   * 
   * @param videoID Video ID to Update
   * @param authToken Editor or Higher Auth Token
   * @param body VOD Data
   * @return UpdateVideo
   */

        [Put("/media/video/{videoID}")]
        Task<UpdateVideo> updateVideo(
            [AliasAs("videoID")] int videoID, [AliasAs("authToken")] string authToken, [Body] UpdateVideo body
            );

        /**
   * Gets Total View Count
   * 
   * @param channel Channel Name
   * @return Object
   */

        [Get("/media/views/{channel}")]
        Task<MediaViews> getMediaViews(
            [AliasAs("channel")] string channel
            );

        /**
   * Get Media Info (Transcoders Only)
   * 
   * @param mediaID Channel Media ID
   * @return MediaInfo
   */

        [Get("/mediainfo/live/{mediaID}")]
        Task<MediaInfo> getMediaInfo(
            [AliasAs("mediaID")] string mediaID
            );

        /**
   * Get Recording List
   * 
   * @param channel Channel Name
   * @param authToken Editor or Higher Auth Token
   * @param limit Limit number of recordings returned.
   * @return Recording
   */

        [Get("/recordings/{channel}")]
        Task<Recording> getRecordings(
            [AliasAs("channel")] string channel, [AliasAs("authToken")] string authToken, [AliasAs("limit")] int limit
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
            [AliasAs("game")] string game, [AliasAs("soe")] bool soe
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
            [AliasAs("q")] string q, [AliasAs("limit")] int limit, [AliasAs("liveonly")] bool liveonly
            );
    }
}