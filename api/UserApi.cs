using System;
using System.Threading.Tasks;
using hitaBot.Refit.Model;
using Refit;

namespace hitaBot.Refit.api
{
    public interface UserApi
    {
        /**
   * Posts to enabled Facebook walls.
   * 
   * @param authToken Editor or Higher Auth Token
   * @param userName Hitbox User to try posting to.
   * @return Object
   */

        [Post("/facebook/post")]
        Task<SocialPost> postFacebook(
            [AliasAs("authToken")] String authToken, [AliasAs("user_name")] String userName
            );

        /**
   * Follows a channel
   * 
   * @param authToken User&#39;s Auth Token
   * @param body POST data
   * @return SuccessFollow
   */

        [Post("/follow")]
        Task<SuccessFollow> followChannel(
            [AliasAs("authToken")] String authToken, [Body] Object body
            );

        /**
   * Unfollow a user
   * 
   * @param authToken Users Auth Token
   * @param followId Follower to unfollow User ID
   * @param type 
   * @return Object
   */

        [Delete("/follow")]
        Task<UnfollowUser> unfollowUser(
            [AliasAs("authToken")] String authToken, [AliasAs("follow_id")] String followId,
            [AliasAs("type")] String type
            );

        /**
   * List of channels a user is following.
   * 
   * @param userName User Name To Check
   * @param sort Sort Followers
   * @param offset Offset Results
   * @param limit Limit Results
   * @param reverse Reverses Results
   * @return FollowingUser
   */

        [Get("/following/user")]
        Task<FollowingUser> getFollowing(
            [AliasAs("user_name")] String userName, [AliasAs("sort")] String sort, [AliasAs("offset")] int offset,
            [AliasAs("limit")] int limit, [AliasAs("reverse")] Boolean reverse
            );

        /**
   * Following Releationship
   * Following relationship between &#39;channel&#39; and &#39;user_name&#39;
   * @param channel Channel Name
   * @param userName User Name
   * @return FollowingUserChannel
   */

        [Get("/following/user/{channel}")]
        Task<FollowingUserChannel> getFollowingUser(
            [AliasAs("channel")] String channel, [AliasAs("user_name")] String userName
            );

        /**
   * Gets Notification Settings
   * 
   * @param authToken Auth Token
   * @param userName User Name
   * @return Notifications
   */

        [Get("/notifications")]
        Task<Notifications> getNotifications(
            [AliasAs("authToken")] String authToken, [AliasAs("user_name")] String userName
            );

        /**
   * Sets Notification Settings
   * 
   * @param authToken Auth Token
   * @param userName User Name
   * @param body PUT Data
   * @return String
   */

        [Put("/notifications")]
        Task<SuccessOnlyString> setNotifications(
            [AliasAs("authToken")] String authToken, [AliasAs("user_name")] String userName,
            [Body] SetNotifications body
            );

        /**
   * Get Subscriber List
   * 
   * @param user User Name
   * @param authToken User&#39;s Auth Token
   * @return SubscriberList
   */

        [Get("/subscriberlist/{user}")]
        Task<SubscriberList> getSubscriberList(
            [AliasAs("user")] String user, [AliasAs("authToken")] String authToken
            );

        /**
   * Get Subscription List
   * 
   * @param user User Name
   * @param authToken Auth Token
   * @return SubscriptionList
   */

        [Get("/subscriptionlist/{user}")]
        Task<SubscriptionList> getSubscriptionList(
            [AliasAs("user")] String user, [AliasAs("authToken")] String authToken
            );

        /**
   * Posts to Twitter
   * 
   * @param authToken Editor or Higher Auth Token
   * @param userName User to try posting to.
   * @return Object
   */

        [Post("/twitter/post")]
        Task<SocialPost> postTwitter(
            [AliasAs("authToken")] String authToken, [AliasAs("user_name")] String userName
            );

        /**
   * Get Access Levels
   * Only returns &#39;isSubscriber&#39; and &#39;isFollower&#39; if the user never had higher access.
   * @param channel Channel to check access in
   * @param authToken Auth Token to check
   * @return UserAccess
   */

        [Get("/user/access/{channel}/{authToken}")]
        Task<UserAccess> getAccessLevel(
            [AliasAs("channel")] String channel, [AliasAs("authToken")] String authToken
            );

        /**
   * Get User List
   * 
   * @param q Search Query
   * @return UserList
   */

        [Get("/user/list")]
        Task<UserList> getUserList(
            [AliasAs("q")] String q
            );

        /**
   * Check Subscription for Auth
   * 
   * @param channel Channel to check subscription in.
   * @param authToken Auth Token to check.
   * @return Object
   */

        [Get("/user/subscription/{channel}/{authToken}")]
        Task<IsSubscriber> getSubStatus(
            [AliasAs("channel")] String channel, [AliasAs("authToken")] String authToken
            );

        /**
   * Get User Properties
   * 
   * @param user User Name
   * @param authToken Users Auth Token
   * @return User
   */

        [Get("/user/{user}")]
        Task<User> getUser(
            [AliasAs("user")] String user, [AliasAs("authToken")] String authToken
            );

        /**
   * Update User
   * 
   * @param authToken Users Auth Token
   * @param user User To Update
   * @param body User Data
   * @return Object
   */

        [Put("/user/{user}")]
        Task<UserUpdated> updateUser(
            [AliasAs("authToken")] String authToken, [AliasAs("user")] String user, [Body] UserUpdate body
            );

        /**
   * Sets Default Team
   * 
   * @param authToken Auth Token
   * @param body Post Data
   * @return Successful
   */

        [Post("/user/{user}/team/default")]
        Task<Successful> setDefaultTeam(
            [AliasAs("authToken")] String authToken, [Body] Object body
            );
    }
}