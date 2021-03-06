using System.Threading.Tasks;
using hitaBot.Refit.Model;
using Refit;

namespace hitaBot.Refit.api
{
    public interface IChannel
    {
        /**
         * Gets channel editors
         * 
         * @param authToken authToken of channel owner
         * @param channel Channel Name
         * @return EditorsList
         */

        [Get("/editors/{channel}")]
        Task<EditorsList> getEditors(
            [AliasAs("authToken")] string authToken, [AliasAs("channel")] string channel
            );

        /**
         * Modify channel editor list.
         * 
         * @param channel Channel Name
         * @param body 
         * @return Success
         */

        [Post("/editors/{channel}")]
        Task<Success> modifyEditors(
            [AliasAs("channel")] string channel, [Body] ModifyEditorsList body
            );

        /**
         * Gets users that follow a channel.
         * 
         * @param channel Channel Name
         * @param reverse Reverse Sort
         * @param sort Sort Objects
         * @param limit Limit number of objects
         * @param offset Number to offset objects by.
         * @return FollowersList
         */

        [Get("/followers/user/{channel}")]
        Task<FollowersList> getFollowers(
            [AliasAs("channel")] string channel,
            [AliasAs("reverse")] string reverse = null,
            [AliasAs("sort")] string sort = null,
            [AliasAs("limit")] int? limit = null,
            [AliasAs("offset")] int? offset = null
            );

        /**
         * Get Follower Stats
         * 
         * @param channel Channel Name
         * @param authToken Owners Auth Token
         * @return FollowerStats
         */

        [Get("/followerstats/{channel}")]
        Task<FollowerStats> getFollowerStats(
            [AliasAs("channel")] string channel, [AliasAs("authToken")] string authToken
            );

        /**
         * Get channels that host &#39;channel&#39;
         * 
         * @param channel Channel Name
         * @param authToken Editor or higher Auth Token
         * @return HostersList
         */

        [Get("/hosters/{channel}")]
        Task<HostersList> getHosters(
            [AliasAs("channel")] string channel, [AliasAs("authToken")] string authToken
            );

        /**
         * Get Sub Badge
         * 
         * @param channel Channel Name
         * @return SubBadge
         */

        [Get("/mediabadges/{channel}")]
        Task<SubBadge> getSubBadge(
            [AliasAs("channel")] string channel
            );

        /**
         * Get Stream key for channel
         * 
         * @param channel Channel Name
         * @param authToken Editor or Higher Auth Token
         * @return MediaKey
         */

        [Get("/mediakey/{channel}")]
        Task<MediaKey> getStreamKey(
            [AliasAs("channel")] string channel, [AliasAs("authToken")] string authToken
            );

        /**
         * Reset Stream Key for channel
         * 
         * @param channel Channel Name
         * @param authToken Editor or Higher Auth Token
         * @return MediaKey
         */

        [Put("/mediakey/{channel}")]
        Task<MediaKey> resetStreamKey(
            [AliasAs("channel")] string channel, [AliasAs("authToken")] string authToken
            );

        /**
         * Gets panel data
         * 
         * @param channel Channel Name
         * @return PanelProfile
         */

        [Get("/profile/{channel}")]
        Task<PanelProfile> getPanels(
            [AliasAs("channel")] string channel
            );

        /**
         * Updates Panel Data
         * 
         * @param channel Channel Name
         * @param body Post Data
         * @return ErrorOnly
         */

        [Post("/profile/{channel}")]
        Task<ErrorOnly> updatePanels(
            [AliasAs("channel")] string channel, [Body] PanelUpdate body
            );

        /**
         * Toggles panel layout on descriptions
         * All \&quot;null\&quot; values are just null values.
         * @param channel Channel Name
         * @param body Post Data
         * @return SuccessOnly
         */

        [Post("/profileenable/{channel}")]
        Task<SuccessOnly> toggleProfile(
            [AliasAs("channel")] string channel, [Body] ProfileEnable body
            );

        /**
         * Get Revenue Stats
         * Arrays have been truncated to one item each
         * @param channel Channel Name
         * @param authToken Owners Auth Token
         * @param startDate Start Date in YYYY-MM-DD
         * @param endDate End Date in YYYY-MM-DD
         * @return RevenueStats
         */

        [Get("/revenues/channel/{channel}")]
        Task<RevenueStats> getRevenueStats(
            [AliasAs("channel")] string channel,
            [AliasAs("authToken")] string authToken,
            [AliasAs("startDate")] string startDate,
            [AliasAs("endDate")] string endDate
            );

        /**
         * Get Streamed Seconds
         * 
         * @param channel Channel Name
         * @param startEpoch Start Date in Epoch
         * @param endEpoch End Date in Epoch
         * @param authToken Owners Auth Token
         * @return StreamedSeconds
         */

        [Get("/streamedseconds/{channel}/{startEpoch}/{endEpoch}")]
        Task<StreamedSeconds> getStreamedSeconds(
            [AliasAs("channel")] string channel, [AliasAs("startEpoch")] string startEpoch,
            [AliasAs("endEpoch")] string endEpoch, [AliasAs("authToken")] string authToken
            );

        /**
         * Get Overall Stats
         * 
         * @param channel Channel Name
         * @param startEpoch Start Time/Date in Epoch
         * @param endEpoch End Time/Date in Epoch
         * @param authToken Owners Auth Token
         * @return StreamOverall
         */

        [Get("/streamoverallstats/{channel}/{startEpoch}/{endEpoch}")]
        Task<StreamOverall> getOverallStats(
            [AliasAs("channel")] string channel, [AliasAs("startEpoch")] string startEpoch,
            [AliasAs("endEpoch")] string endEpoch, [AliasAs("authToken")] string authToken
            );

        /**
         * Get Stream Stats
         * Arrays have been truncated to one item each
         * @param channel Channel Name
         * @param startEpoch Start Date in Epoch
         * @param endEpoch End Date in Epoch
         * @param authToken Owners Auth Token
         * @return StreamStats
         */

        [Get("/streamstats/{channel}/{startEpoch}/{endEpoch}")]
        Task<StreamStats> getStreamStats(
            [AliasAs("channel")] string channel, [AliasAs("startEpoch")] string startEpoch,
            [AliasAs("endEpoch")] string endEpoch, [AliasAs("authToken")] string authToken
            );

        /**
         * Get Subscription Info
         * 
         * @param channel Channel Name
         * @return SubInfo
         */

        [Get("/subscription/info/channel/{channel}")]
        Task<SubInfo> getSubInfo(
            [AliasAs("channel")] string channel
            );

        /**
         * Runs a commercial
         * 
         * @param channel Name of channel to run ad on.
         * @param count Number of commercials to run.
         * @param body authToken that has access to channel.
         * @return ComBreak
         */

        [Post("/ws/combreak/{channel}/{count}")]
        Task<ComBreak> runCom(
            [AliasAs("channel")] string channel, [AliasAs("count")] string count, [Body] AuthToken body
            );
    }
}