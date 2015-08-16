using System;
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
            [AliasAs("limit")] int limit, [AliasAs("showHidden")] Boolean showHidden, [AliasAs("filter")] String filter,
            [AliasAs("liveonly")] String liveonly, [AliasAs("featured")] String featured,
            [AliasAs("follower_id")] int followerId, [AliasAs("game")] String game,
            [AliasAs("hiddenOnly")] Boolean hiddenOnly, [AliasAs("start")] int start,
            [AliasAs("publicOnly")] Boolean publicOnly, [AliasAs("search")] String search
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
            [AliasAs("channel")] String channel, [AliasAs("authToken")] String authToken,
            [AliasAs("limit")] String limit, [AliasAs("showHidden")] Boolean showHidden,
            [AliasAs("liveonly")] String liveonly
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
            [AliasAs("channel")] String channel, [AliasAs("authToken")] String authToken, [Body] UpdateMedia body
            );

        /**
   * Gets Live Status &amp; Viewers
   * 
   * @param channel Channel Name
   * @return Object
   */

        [Get("/media/status/{channel}")]
        Task<MediaStatus> getMediaStatus(
            [AliasAs("channel")] String channel
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
            [AliasAs("authToken")] String authToken, [Body] CreateVideo body
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
            [AliasAs("channel")] String channel, [AliasAs("authToken")] String authToken,
            [AliasAs("filter")] String filter, [AliasAs("hiddenOnly")] Boolean hiddenOnly, [AliasAs("limit")] int limit,
            [AliasAs("publicOnly")] Boolean publicOnly, [AliasAs("search")] String search,
            [AliasAs("showHidden")] Boolean showHidden, [AliasAs("yt")] Boolean yt
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
            [AliasAs("videoID")] int videoID, [AliasAs("showHidden")] Boolean showHidden
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
            [AliasAs("videoID")] int videoID, [AliasAs("authToken")] String authToken, [Body] UpdateVideo body
            );

        /**
   * Gets Total View Count
   * 
   * @param channel Channel Name
   * @return Object
   */

        [Get("/media/views/{channel}")]
        Task<MediaViews> getMediaViews(
            [AliasAs("channel")] String channel
            );

        /**
   * Get Media Info (Transcoders Only)
   * 
   * @param mediaID Channel Media ID
   * @return MediaInfo
   */

        [Get("/mediainfo/live/{mediaID}")]
        Task<MediaInfo> getMediaInfo(
            [AliasAs("mediaID")] String mediaID
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
            [AliasAs("channel")] String channel, [AliasAs("authToken")] String authToken, [AliasAs("limit")] int limit
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