using System;
using System.Threading.Tasks;
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
        Task<Object> globalMessage();
    }
}