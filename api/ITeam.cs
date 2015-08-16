using System.Threading.Tasks;
using hitaBot.Refit.Model;
using Refit;

namespace hitaBot.Refit.api
{
    public interface ITeam
    {
        /**
   * Create a Team
   * 
   * @param authToken Users Auth
   * @param body Team Data
   * @return Object
   */

        [Post("/team")]
        Task<TeamCreate> createTeam(
            [AliasAs("authToken")] string authToken, [Body] CreateTeam body
            );

        /**
   * Get Team Information
   * 
   * @param teamName Team Name
   * @param filter Filters VODs when &#39;media_type&#39; is video
   * @param limit Limit Live &amp; Video objects
   * @param liveonly Only show Live Streams when &#39;media_type&#39; is live
   * @param media Show Media Object. Used in conjunction with &#39;media_type&#39;
   * @param mediaType Populates the media object with live or video arrays
   * @param offset Offsets Live &amp; Video objects
   * @return Team
   */

        [Get("/team/{teamName}")]
        Task<Team> getTeam(
            [AliasAs("teamName")] string teamName, [AliasAs("filter")] string filter, [AliasAs("limit")] int limit,
            [AliasAs("liveonly")] bool liveonly, [AliasAs("media")] bool media,
            [AliasAs("media_type")] string mediaType, [AliasAs("offset")] int offset
            );

        /**
   * Updates Team Object (Invites)
   * To upload a team icon you must do a [POST /upload/team/{user}/{auth}](/#!/upload/UploadTeam) which will return a logo-&gt;small and logo-&gt;large which then can be put into &#39;group_logo_small&#39; and &#39;group_logo_large&#39; respectively.\n\n\n\n\nTo delete a logo you must set the URL parameter &#39;action&#39; to &#39;delete_logo&#39;\n\n\n\n\nTo upload a team cover you must do a [POST /upload/team/{user}/{auth}](/#!/upload/UploadTeam) which will return a cover-&gt;cover which then can be put into &#39;group_cover&#39;\n\n\n\n\nTo delete a cover you must set the URL paramter &#39;action&#39; to &#39;delete_cover&#39;\n\n\n\n\nDeleting a cover or logo will return &#39;group_logo_small&#39;, &#39;group_logo_large&#39;, &#39;group_cover&#39; as \&quot;\&quot; instead of null like a new team.\n\n\n\n\nTo disband a team you must set the URL paramter &#39;action&#39; to &#39;delete_team&#39; and PUT a valid body.\n
   * @param teamName Team Name
   * @param user User Name
   * @param authToken Founders Auth Token
   * @param body Update Team Data
   * @param action Action to cause on team.
   * @return UpdateTeam
   */

        [Put("/team/{teamName}/{user}")]
        Task<UpdateTeam> updateTeam(
            [AliasAs("teamName")] string teamName, [AliasAs("user")] string user,
            [AliasAs("authToken")] string authToken,
            [Body] UpdateTeam body, [AliasAs("action")] string action
            );

        /**
   * Remove Team Member or Leave a Team
   * 
   * @param teamName Team Name
   * @param user User Name
   * @param authToken Founders Auth Token or Yourself
   * @param groupId Groups ID
   * @return Object
   */

        [Delete("/team/{teamName}/{user}")]
        Task<LeaveTeam> deleteTeam(
            [AliasAs("teamName")] string teamName, [AliasAs("user")] string user,
            [AliasAs("authToken")] string authToken,
            [AliasAs("group_id")] int groupId
            );

        /**
   * Get a list of teams
   * 
   * @param q Keyword to search for.
   * @return TeamList
   */

        [Get("/teamlist")]
        Task<TeamList> getTeamList(
            [AliasAs("q")] string q
            );

        /**
   * Search for teams
   * 
   * @param search Keyword to search for.
   * @return Teams
   */

        [Get("/teams")]
        Task<Teams> searchTeams(
            [AliasAs("search")] string search
            );

        /**
   * Get Teams that User is in.
   * 
   * @param user string
   * @param liveonly Only show Live Streams when &#39;media_type&#39; is live
   * @param media Show Media Object. Used in conjunction with &#39;media_type&#39;
   * @param mediaType Populates the media object with live or video arrays
   * @param partner Only show Teams with Subscription
   * @return TeamsUser
   */

        [Get("/teams/{user}")]
        Task<TeamsUser> getTeamUser(
            [AliasAs("user")] string user, [AliasAs("liveonly")] bool liveonly, [AliasAs("media")] bool media,
            [AliasAs("media_type")] string mediaType, [AliasAs("partner")] bool partner
            );
    }
}