using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
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
