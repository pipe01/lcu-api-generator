using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class ProcessControl
    {
        /// <summary>
        /// Returns information about the process-control.
        /// </summary>
        public static Task<ProcessControlProcess> GetProcessControlV1Process()
            => Sender.Request<ProcessControlProcess>("get", $"/process-control/v1/process");
        /// <summary>
        /// Quits the application.
        /// </summary>
        public static Task PostProcessControlV1ProcessQuit()
            => Sender.Request("post", $"/process-control/v1/process/quit");
        /// <summary>
        /// Restarts the application.  Does nothing if there is already a waiting delayed restart.  Optionally accepts specific version to restart.
        /// </summary>
        public static Task PostProcessControlV1ProcessRestart([Parameter("delaySeconds", "query")] int delaySeconds, [Parameter("restartVersion", "query")] int restartVersion = default)
            => Sender.Request("post", $"/process-control/v1/process/restart?delaySeconds={System.Net.WebUtility.UrlEncode(delaySeconds.ToString())}&{(restartVersion != default ? $"restartVersion={System.Net.WebUtility.UrlEncode(restartVersion.ToString())}" : null)}");
        /// <summary>
        /// Restarts the application in order to perform a full repair (including self repair).
        /// </summary>
        public static Task PostProcessControlV1ProcessRestartToRepair()
            => Sender.Request("post", $"/process-control/v1/process/restart-to-repair");
        /// <summary>
        /// Restarts the application in order to perform a self-update.
        /// </summary>
        public static Task PostProcessControlV1ProcessRestartToUpdate([Parameter("delaySeconds", "query")] int delaySeconds, [Parameter("selfUpdateUrl", "query")] string selfUpdateUrl)
            => Sender.Request("post", $"/process-control/v1/process/restart-to-update?delaySeconds={System.Net.WebUtility.UrlEncode(delaySeconds.ToString())}&selfUpdateUrl={System.Net.WebUtility.UrlEncode(selfUpdateUrl.ToString())}");
    }
}
