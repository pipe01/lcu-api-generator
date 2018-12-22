using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class BuiltIn
    {
        /// <summary>
        /// Cancels the asynchronous operation or removes its completion status.
        /// </summary>
        /// <param name="asyncToken">ID of the asynchronous operation to remove</param>
        public static Task<object> AsyncDelete([Parameter("asyncToken", "query")] int asyncToken)
            => Sender.Request<object>("post", $"/AsyncDelete?asyncToken={System.Net.WebUtility.UrlEncode(asyncToken.ToString())}");
        /// <summary>
        /// Retrieves the result of a completed asynchronous operation.
        /// </summary>
        /// <param name="asyncToken">ID of the asynchronous operation to check</param>
        public static Task<object> AsyncResult([Parameter("asyncToken", "query")] int asyncToken)
            => Sender.Request<object>("post", $"/AsyncResult?asyncToken={System.Net.WebUtility.UrlEncode(asyncToken.ToString())}");
        /// <summary>
        /// Retrieves details on the current state of an asynchronous operation.
        /// </summary>
        /// <param name="asyncToken">ID of the asynchronous operation to check</param>
        public static Task<object> AsyncStatus([Parameter("asyncToken", "query")] int asyncToken)
            => Sender.Request<object>("post", $"/AsyncStatus?asyncToken={System.Net.WebUtility.UrlEncode(asyncToken.ToString())}");
        /// <summary>
        /// Attempts to cancel an asynchronous operation
        /// </summary>
        /// <param name="asyncToken">Operation to cancel</param>
        public static Task<object> Cancel([Parameter("asyncToken", "query")] int asyncToken)
            => Sender.Request<object>("post", $"/Cancel?asyncToken={System.Net.WebUtility.UrlEncode(asyncToken.ToString())}");
        /// <summary>
        /// Closes the connection.
        /// </summary>
        public static Task<object> Exit()
            => Sender.Request<object>("post", $"/Exit");
        /// <summary>
        /// Returns information on available functions and types
        /// </summary>
        /// <param name="target">Name of the function or type to describe</param>
        /// <param name="format">Format for returned information</param>
        public static Task<object> Help([Parameter("target", "query")] string target = default, [Parameter("format", "query")] string format = default)
            => Sender.Request<object>("post", $"/Help?{(target != default ? $"target={System.Net.WebUtility.UrlEncode(target.ToString())}" : null)}&{(format != default ? $"format={System.Net.WebUtility.UrlEncode(format.ToString())}" : null)}");
        /// <summary>
        /// Gets all buffered log entries since the last call.
        /// </summary>
        public static Task<LogEvent[]> LoggingGetEntries()
            => Sender.Request<LogEvent[]>("post", $"/LoggingGetEntries");
        /// <summary>
        /// Returns all metrics
        /// </summary>
        public static Task<object> LoggingMetrics()
            => Sender.Request<object>("post", $"/LoggingMetrics");
        /// <summary>
        /// Returns metadata for all metrics
        /// </summary>
        public static Task<object> LoggingMetricsMetadata()
            => Sender.Request<object>("post", $"/LoggingMetricsMetadata");
        /// <summary>
        /// Initializes the logging system.
        /// </summary>
        /// <param name="buffered">Specifies whether logs will be buffered for LoggingGetEntries to work</param>
        /// <param name="severity">Minimum severity level to fire a log event</param>
        public static Task LoggingStart([Parameter("buffered", "query")] bool buffered = default, [Parameter("severity", "query")] string severity = default)
            => Sender.Request("post", $"/LoggingStart?{(buffered != default ? $"buffered={System.Net.WebUtility.UrlEncode(buffered.ToString())}" : null)}&{(severity != default ? $"severity={System.Net.WebUtility.UrlEncode(severity.ToString())}" : null)}");
        /// <summary>
        /// Finalizes the logging system.
        /// </summary>
        public static Task LoggingStop()
            => Sender.Request("post", $"/LoggingStop");
        /// <summary>
        /// Memory filter prints to the log when memory is allocated or freed that matches the filter parameters set in MemoryFilterSet
        /// </summary>
        /// <param name="enable">Enable/disable the memory filter</param>
        public static Task MemoryFilterEnable([Parameter("enable", "query")] int enable = default)
            => Sender.Request("post", $"/MemoryFilterEnable?{(enable != default ? $"enable={System.Net.WebUtility.UrlEncode(enable.ToString())}" : null)}");
        /// <summary>
        /// Sets the filter parameters for when to print to the log. Use MemoryFilterEnable to start/stop the print outs
        /// </summary>
        /// <param name="minSize">Optional filter for minimum size to output</param>
        /// <param name="maxSize">Optional filter for maximum size to output</param>
        /// <param name="minAddress">Optional filter for minimum address in hex to output</param>
        /// <param name="maxAddress">Optional filter for maximum address in hex to output</param>
        public static Task MemoryFilterSet([Parameter("minSize", "query")] int minSize = default, [Parameter("maxSize", "query")] int maxSize = default, [Parameter("minAddress", "query")] string minAddress = default, [Parameter("maxAddress", "query")] string maxAddress = default)
            => Sender.Request("post", $"/MemoryFilterSet?{(minSize != default ? $"minSize={System.Net.WebUtility.UrlEncode(minSize.ToString())}" : null)}&{(maxSize != default ? $"maxSize={System.Net.WebUtility.UrlEncode(maxSize.ToString())}" : null)}&{(minAddress != default ? $"minAddress={System.Net.WebUtility.UrlEncode(minAddress.ToString())}" : null)}&{(maxAddress != default ? $"maxAddress={System.Net.WebUtility.UrlEncode(maxAddress.ToString())}" : null)}");
        /// <summary>
        /// Returns current pool usage
        /// </summary>
        /// <param name="contextName">Name of the context to find (optional)</param>
        public static Task<object> MemoryPools([Parameter("contextName", "query")] string contextName = default)
            => Sender.Request<object>("post", $"/MemoryPools?{(contextName != default ? $"contextName={System.Net.WebUtility.UrlEncode(contextName.ToString())}" : null)}");
        /// <summary>
        /// Returns aggregate information about memory usage
        /// </summary>
        public static Task<object> MemoryStats()
            => Sender.Request<object>("post", $"/MemoryStats");
        /// <summary>
        /// Returns current memory usage by callstack site
        /// </summary>
        /// <param name="minSize">Minimum size of total allocations at call site in order to print (optional: MEMORYUSAGE_MINSIZE default)</param>
        /// <param name="minCount">Minimum count of total allocations at call site in order to print (optional: MEMORYUSAGE_MINCOUNT default)</param>
        public static Task<object> MemoryUsage([Parameter("minSize", "query")] int minSize = default, [Parameter("minCount", "query")] int minCount = default)
            => Sender.Request<object>("post", $"/MemoryUsage?{(minSize != default ? $"minSize={System.Net.WebUtility.UrlEncode(minSize.ToString())}" : null)}&{(minCount != default ? $"minCount={System.Net.WebUtility.UrlEncode(minCount.ToString())}" : null)}");
        /// <summary>
        /// Subscribes to a given event
        /// </summary>
        /// <param name="eventName">Name of the event to subscribe to</param>
        /// <param name="format">Desired format to receive events in. If unspecified, events will be sent in the active result format at the time.</param>
        public static Task<object> Subscribe([Parameter("eventName", "query")] string eventName, [Parameter("format", "query")] string format = default)
            => Sender.Request<object>("post", $"/Subscribe?eventName={System.Net.WebUtility.UrlEncode(eventName.ToString())}&{(format != default ? $"format={System.Net.WebUtility.UrlEncode(format.ToString())}" : null)}");
        /// <summary>
        /// Unsubscribes from a given event
        /// </summary>
        /// <param name="eventName">Name of the event to unsubscribe from</param>
        public static Task<object> Unsubscribe([Parameter("eventName", "query")] string eventName)
            => Sender.Request<object>("post", $"/Unsubscribe?eventName={System.Net.WebUtility.UrlEncode(eventName.ToString())}");
        /// <summary>
        /// Controls the console output format
        /// </summary>
        /// <param name="format">Output format to switch to</param>
        public static Task<object> WebSocketFormat([Parameter("format", "query")] string format = default)
            => Sender.Request<object>("post", $"/WebSocketFormat?{(format != default ? $"format={System.Net.WebUtility.UrlEncode(format.ToString())}" : null)}");
        /// <summary>
        /// Download a backend asset
        /// </summary>
        /// <param name="plugin">Plugin name to serve from</param>
        /// <param name="path">Path to the asset to serve</param>
        /// <param name="ifNoneMatch">optional ETag of the asset that the caller has cached</param>
        public static Task<object> GetByPluginAssetsByPath([Parameter("plugin", "path")] string plugin, [Parameter("path", "path")] string path, [Parameter("if-none-match", "header")] string ifNoneMatch = default)
            => Sender.Request<object>("get", $"/{plugin}/assets/{path}");
        /// <summary>
        /// Download the header for a backend asset
        /// </summary>
        /// <param name="plugin">Plugin name to serve from</param>
        /// <param name="path">Path to the asset to serve</param>
        /// <param name="ifNoneMatch">optional ETag of the asset that the caller has cached</param>
        public static Task<object> HeadByPluginAssetsByPath([Parameter("plugin", "path")] string plugin, [Parameter("path", "path")] string path, [Parameter("if-none-match", "header")] string ifNoneMatch = default)
            => Sender.Request<object>("head", $"/{plugin}/assets/{path}");
    }
}
