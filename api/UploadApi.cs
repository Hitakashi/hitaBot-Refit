using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using hitaBot.Refit.Model;
using Refit;

namespace hitaBot.Refit.api
{
    public interface UploadApi
    {
        /**
   * Changes User Avatar or Channel Cover
   * 
   * @param user User Name
   * @param authToken Auth Token
   * @param file Only include if you want to change User Avatar
   * @param cover Only include if you want to change Channel Banner
   * @return Object
   */

        [Multipart]
        [Post("/upload/account/{user}/{authToken}")]
        Task<Cover> uploadUserAvatarCover(
            [AliasAs("user")] string user, [AliasAs("authToken")] string authToken,
            [AttachmentName("file")] Stream file = null, [AttachmentName("cover")] Stream cover = null
            );

        /**
   * Gets images from old description system
   * 
   * @param channel User Name
   * @param authToken Auth Token
   * @return List<Object>
   */

        [Get("/upload/description/{channel}/{authToken}")]
        Task<List<GetUploadDesc>> getDescImages(
            [AliasAs("channel")] string channel, [AliasAs("authToken")] string authToken
            );

        /**
   * Upload Image for the old description system.
   * 
   * @param channel User Name
   * @param authToken Auth Token
   * @param file Description Image to upload
   * @return String
   */

        [Multipart]
        [Post("/upload/description/{channel}/{authToken}")]
        Task<string> uploadDescImage(
            [AliasAs("channel")] string channel, [AliasAs("authToken")] string authToken,
            [AttachmentName("file")] Stream file
            );

        /**
   * Deletes Description Image
   * 
   * @param channel User Name
   * @param authToken Auth Token
   * @param imageId Image ID to Delete
   * @return String
   */

        [Delete("/upload/description/{channel}/{authToken}")]
        Task<SuccessOnlyString> removeDescImages(
            [AliasAs("channel")] string channel, [AliasAs("authToken")] string authToken,
            [AliasAs("image_id")] string imageId
            );

        /**
   * Uploads Team Logo or Cover
   * If you upload &#39;file&#39;, the cover object will be &#39;null&#39;\n\nIf you upload &#39;cover&#39;, the logo object will be &#39;null&#39;\n
   * @param user User Name
   * @param authToken Auth Token
   * @param file file = Team Logo. cover = Team Cover
   * @return TeamUplaod
   */

        [Multipart]
        [Post("/upload/team/{user}/{authToken}")]
        Task<TeamUplaod> uploadTeamImage(
            [AliasAs("user")] string user, [AliasAs("authToken")] string authToken, [AttachmentName("file")] Stream file
            );
    }
}