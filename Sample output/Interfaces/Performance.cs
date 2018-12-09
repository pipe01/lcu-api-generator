using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class Performance
    {
        /// <summary>
        /// Returns process memory status
        /// </summary>
        public static Task<object> GetPerformanceV1Memory()
            => Sender.Request<object>("get", $"/performance/v1/memory");
        /// <summary>
        /// Registers the process and includes it with the performance information.
        /// </summary>
        /// <param name="processId">Id of the process to track performance information.</param>
        public static Task PostPerformanceV1ProcessByProcessId([Parameter("processId", "path")] int processId)
            => Sender.Request("post", $"/performance/v1/process/{processId}");
        /// <summary>
        /// Returns the various performance information for the cef processes
        /// </summary>
        public static Task<object> GetPerformanceV1Report()
            => Sender.Request<object>("get", $"/performance/v1/report");
        /// <summary>
        /// Restarts the CPU timing information and returns the results from PerfReportProcesses
        /// </summary>
        /// <param name="sampleLength">Time in seconds for each CPU timing sample.</param>
        /// <param name="sampleCount">Number of samples to record.</param>
        public static Task<object> PostPerformanceV1ReportRestart([Parameter("sampleLength", "query")] int sampleLength, [Parameter("sampleCount", "query")] int sampleCount)
            => Sender.Request<object>("post", $"/performance/v1/report/restart?sampleLength={System.Net.WebUtility.UrlEncode(sampleLength.ToString())}&sampleCount={System.Net.WebUtility.UrlEncode(sampleCount.ToString())}");
        /// <summary>
        /// Returns hardware and software specs for the machine the client is running on.
        /// </summary>
        /// <param name="full">Returns all available system information</param>
        public static Task<object> GetPerformanceV1SystemInfo([Parameter("full", "query")] int full)
            => Sender.Request<object>("get", $"/performance/v1/system-info?full={System.Net.WebUtility.UrlEncode(full.ToString())}");
    }
}
