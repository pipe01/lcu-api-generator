using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class Riotclient
    {
        /// <summary>
        /// Adds or Updates a Metric
        /// </summary>
        /// <param name="group">Name of metric group</param>
        /// <param name="@object">Name of metric object</param>
        /// <param name="name">Name of metric item</param>
        /// <param name="value">Value to store</param>
        public static Task PostRiotclientAddorupdatemetric([Parameter("group", "query")] string group, [Parameter("object", "query")] string @object, [Parameter("name", "query")] string name, [Parameter("value", "query")] long value)
            => Sender.Request("post", $"/riotclient/addorupdatemetric?group={System.Net.WebUtility.UrlEncode(group.ToString())}&object={System.Net.WebUtility.UrlEncode(@object.ToString())}&name={System.Net.WebUtility.UrlEncode(name.ToString())}&value={System.Net.WebUtility.UrlEncode(value.ToString())}");
        /// <summary>
        /// Deletes the current runtime affinity of the application.
        /// </summary>
        public static Task DeleteRiotclientAffinity()
            => Sender.Request("delete", $"/riotclient/affinity");
        /// <summary>
        /// Get the current runtime affinity of the application.
        /// </summary>
        public static Task<object> GetRiotclientAffinity()
            => Sender.Request<object>("get", $"/riotclient/affinity");
        /// <summary>
        /// Sets the current runtime affinity of the application.
        /// </summary>
        /// <param name="newAffinity">The new affinity to use.</param>
        public static Task PostRiotclientAffinity([Parameter("newAffinity", "query")] string newAffinity)
            => Sender.Request("post", $"/riotclient/affinity?newAffinity={System.Net.WebUtility.UrlEncode(newAffinity.ToString())}");
        /// <summary>
        /// Application name without file extension
        /// </summary>
        public static Task<string> GetRiotclientAppName()
            => Sender.Request<string>("get", $"/riotclient/app-name");
        /// <summary>
        /// Get the TCP port number that the remoting server is listening on.
        /// </summary>
        public static Task<int> GetRiotclientAppPort()
            => Sender.Request<int>("get", $"/riotclient/app-port");
        /// <summary>
        /// Return the auth token used by the remoting server
        /// </summary>
        public static Task<string> GetRiotclientAuthToken()
            => Sender.Request<string>("get", $"/riotclient/auth-token");
        /// <summary>
        /// Get the command line parameters for the application
        /// </summary>
        public static Task<string[]> GetRiotclientCommandLineArgs()
            => Sender.Request<string[]>("get", $"/riotclient/command-line-args");
        /// <summary>
        /// Get the current region and locale.
        /// </summary>
        public static Task<RegionLocale> GetRiotclientGetRegionLocale()
            => Sender.Request<RegionLocale>("get", $"/riotclient/get_region_locale");
        /// <summary>
        /// Kills the ux process and restarts it. Used only when the ux process crashes.
        /// </summary>
        public static Task PostRiotclientKillAndRestartUx()
            => Sender.Request("post", $"/riotclient/kill-and-restart-ux");
        /// <summary>
        /// Kills the ux process.
        /// </summary>
        public static Task PostRiotclientKillUx()
            => Sender.Request("post", $"/riotclient/kill-ux");
        /// <summary>
        /// Launches the ux process.
        /// </summary>
        public static Task PostRiotclientLaunchUx()
            => Sender.Request("post", $"/riotclient/launch-ux");
        /// <summary>
        /// Base64 encoded uuid identifying the user's machine
        /// </summary>
        public static Task<string> GetRiotclientMachineId()
            => Sender.Request<string>("get", $"/riotclient/machine-id");
        /// <summary>
        /// Endpoint for passing in new data.
        /// </summary>
        /// <param name="args">Vector of new command line arguments</param>
        public static Task PostRiotclientNewArgs([Parameter("args", "formData")] string[] args)
            => Sender.Request("post", $"/riotclient/new-args");
        /// <summary>
        /// Get the current region and locale.
        /// </summary>
        public static Task<RegionLocale> GetRiotclientRegionLocale()
            => Sender.Request<RegionLocale>("get", $"/riotclient/region-locale");
        /// <summary>
        /// Update the region and locale.
        /// </summary>
        /// <param name="data">Region and locale resource.</param>
        public static Task PutRiotclientRegionLocale([Parameter("data", "body")] RegionLocale data)
            => Sender.Request("put", $"/riotclient/region-locale", data);
        /// <summary>
        /// Ux acknowledges the update to the region and locale.
        /// </summary>
        /// <param name="requestId">The region and locale change requestId that is being acknowledged.</param>
        public static Task PutRiotclientRegionLocaleAck([Parameter("requestId", "body")] int requestId)
            => Sender.Request("put", $"/riotclient/region-locale/ack", requestId);
        /// <summary>
        /// Update the region and locale.
        /// </summary>
        /// <param name="region">Name of the region.</param>
        /// <param name="locale">Name of the locale.</param>
        public static Task PostRiotclientSetRegionLocale([Parameter("region", "query")] string region, [Parameter("locale", "query")] string locale)
            => Sender.Request("post", $"/riotclient/set_region_locale?region={System.Net.WebUtility.UrlEncode(region.ToString())}&locale={System.Net.WebUtility.UrlEncode(locale.ToString())}");
        /// <summary>
        /// Open swagger in the default browser.
        /// </summary>
        public static Task PostRiotclientShowSwagger()
            => Sender.Request("post", $"/riotclient/show-swagger");
        /// <summary>
        /// Hide the splash screen.
        /// </summary>
        public static Task DeleteRiotclientSplash()
            => Sender.Request("delete", $"/riotclient/splash");
        /// <summary>
        /// Show the splash screen.
        /// </summary>
        public static Task PutRiotclientSplash()
            => Sender.Request("put", $"/riotclient/splash");
        /// <summary>
        /// Get basic system information: OS, memory, processor speed, and number of physical cores
        /// </summary>
        public static Task<basicSystemInfo> GetRiotclientSystemInfoV1BasicInfo()
            => Sender.Request<basicSystemInfo>("get", $"/riotclient/system-info/v1/basic-info");
        /// <summary>
        /// Retrieves a completed scheduler trace.
        /// </summary>
        public static Task<object> GetRiotclientTrace()
            => Sender.Request<object>("get", $"/riotclient/trace");
        /// <summary>
        /// Unloads the UX process
        /// </summary>
        public static Task PostRiotclientUnload()
            => Sender.Request("post", $"/riotclient/unload");
        /// <summary>
        /// Returns whether the ux has crashed or not
        /// </summary>
        public static Task<int> GetRiotclientUxCrashCount()
            => Sender.Request<int>("get", $"/riotclient/ux-crash-count");
        /// <summary>
        /// Flash the ux process' main window and the taskbar/dock icon, if they exist.
        /// </summary>
        public static Task PostRiotclientUxFlash()
            => Sender.Request("post", $"/riotclient/ux-flash");
        /// <summary>
        /// Ux notification that it has completed loading the main window.
        /// </summary>
        public static Task PutRiotclientUxLoadComplete()
            => Sender.Request("put", $"/riotclient/ux-load-complete");
        /// <summary>
        /// Minimize the ux process and all its windows if it exists. This does not kill the ux.
        /// </summary>
        public static Task PostRiotclientUxMinimize()
            => Sender.Request("post", $"/riotclient/ux-minimize");
        /// <summary>
        /// Shows the ux process if it exists; create and show if it does not.
        /// </summary>
        public static Task PostRiotclientUxShow()
            => Sender.Request("post", $"/riotclient/ux-show");
        /// <summary>
        /// Get the current Ux state.
        /// </summary>
        public static Task<string> GetRiotclientUxState()
            => Sender.Request<string>("get", $"/riotclient/ux-state");
        /// <summary>
        /// Ux acknowledges the update to the Ux state.
        /// </summary>
        /// <param name="requestId">The ux change requestId that is being acknowledged.</param>
        public static Task PutRiotclientUxStateAck([Parameter("requestId", "body")] int requestId)
            => Sender.Request("put", $"/riotclient/ux-state/ack", requestId);
        /// <summary>
        /// Unregister an existing auth token.
        /// </summary>
        public static Task<object> DeleteRiotclientV1AuthTokensByAuthToken([Parameter("authToken", "path")] string authToken)
            => Sender.Request<object>("delete", $"/riotclient/v1/auth-tokens/{authToken}");
        /// <summary>
        /// Register an auth token.  This is any alpha-numeric string that will be used as a password with the `riot` user when making requests.
        /// </summary>
        /// <param name="authToken">Authentication token to add.</param>
        public static Task<object> PutRiotclientV1AuthTokensByAuthToken([Parameter("authToken", "path")] string authToken)
            => Sender.Request<object>("put", $"/riotclient/v1/auth-tokens/{authToken}");
        /// <summary>
        /// Adds the enclosed log to the app's bugsplat report.
        /// </summary>
        /// <param name="logFilePath">Full path to the log file.</param>
        public static Task PostRiotclientV1BugsplatLogs([Parameter("logFilePath", "body")] string logFilePath)
            => Sender.Request("post", $"/riotclient/v1/bugsplat/logs", logFilePath);
        /// <summary>
        /// Get the bugsplat platform id.
        /// </summary>
        public static Task<string> GetRiotclientV1BugsplatPlatformId()
            => Sender.Request<string>("get", $"/riotclient/v1/bugsplat/platform-id");
        /// <summary>
        /// Tags the bugsplat with a platform id so it can be filtered more easily.
        /// </summary>
        /// <param name="platformId">The platform id that should be reported to bugsplat.</param>
        public static Task PutRiotclientV1BugsplatPlatformId([Parameter("platformId", "body")] string platformId)
            => Sender.Request("put", $"/riotclient/v1/bugsplat/platform-id", platformId);
        /// <summary>
        /// Gets the last known posted zoom-scale value.
        /// </summary>
        public static Task<float> GetRiotclientZoomScale()
            => Sender.Request<float>("get", $"/riotclient/zoom-scale");
        /// <summary>
        /// Handles changing the zoom scale value.
        /// </summary>
        /// <param name="newZoomScale">The new value of the zoom scale.</param>
        public static Task PostRiotclientZoomScale([Parameter("newZoomScale", "query")] float newZoomScale)
            => Sender.Request("post", $"/riotclient/zoom-scale?newZoomScale={System.Net.WebUtility.UrlEncode(newZoomScale.ToString())}");
    }
}
