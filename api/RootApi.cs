using System.Threading.Tasks;
using hitaBot.Refit.Model;
using Refit;

namespace hitaBot.Refit.api
{
    public interface RootApi
    {
        /**
   * Get Global Message
   * 
   * @return Object
   */

        [Get("/globalmessage")]
        Task<GlobalMessage> globalMessage();
    }
}