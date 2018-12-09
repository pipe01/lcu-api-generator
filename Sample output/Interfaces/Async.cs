using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class Async
    {
        /// <summary>
        /// Retrieves the result of a completed asynchronous operation.
        /// </summary>
        /// <param name="asyncToken">ID of the asynchronous operation to check</param>
        public static Task<object> HttpAsyncResult([Parameter("asyncToken", "path")] int asyncToken)
            => Sender.Request<object>("get", $"/async/v1/result/{asyncToken}");
        /// <summary>
        /// Cancels the asynchronous operation or removes its completion status.
        /// </summary>
        /// <param name="asyncToken">ID of the asynchronous operation to remove</param>
        public static Task<object> HttpAsyncDelete([Parameter("asyncToken", "path")] int asyncToken)
            => Sender.Request<object>("delete", $"/async/v1/status/{asyncToken}");
        /// <summary>
        /// Retrieves details on the current state of an asynchronous operation.
        /// </summary>
        /// <param name="asyncToken">ID of the asynchronous operation to check</param>
        public static Task<object> Http2AsyncStatus([Parameter("asyncToken", "path")] int asyncToken)
            => Sender.Request<object>("get", $"/async/v1/status/{asyncToken}");
    }
}
