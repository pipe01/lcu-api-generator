using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class SSystem
    {
        /// <summary>
        /// Information about the current artifacts that make up this build
        /// </summary>
        public static Task<BuildInfo> GetSystemV1Builds()
            => Sender.Request<BuildInfo>("get", $"/system/v1/builds");
    }
}
