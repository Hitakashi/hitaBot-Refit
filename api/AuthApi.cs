using System.Threading.Tasks;
using hitaBot.Refit.Model;
using Refit;

namespace hitaBot.Refit.api
{
    public interface AuthApi
    {
        /**
       * Authenticates user with username and password.
       * This API returns a object containing information about the authenticated user.\n\n\n\n\nYou can optionally pass just an &#39;authToken&#39; value in JSON to return the same valid credentials object\n
       * @param body User object that needs to be authenticated.
       * @return ValidLogin
       */

        [Get("/auth/login")]
        Task<ValidLogin> authUserPass([Body] Login body);

        /**
       * Authenticates user with username and password, only returning an authentication token.
       * 
       * @param body Status values that need to be considered for filter
       * @return ValidLoginToken
       */

        [Post("/auth/token")]
        Task<ValidLoginToken> authToken([Body] Login body);

        /**
       * Verify token to App
       * Verify that the provided token is valid to app
       * @param app App Name to verify token against
       * @param token Auth Token to verify against app.
       * @return ValidAuth
       */

        [Post("/auth/valid/{app}")]
        Task<ValidAuth> verifyAuth([AliasAs("app")] string app, [AliasAs("token")] string token);
    }
}