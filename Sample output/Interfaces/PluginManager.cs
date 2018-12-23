//Auto-generated by https://github.com/pipe01/lcu-api-generator
using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;
using System.Reflection;

namespace GlassLCU.API.Interfaces
{
    public static class PluginManager
    {
        /// <summary>
        /// Write the current plugin stats for the log file.
        /// <para>GET /plugin-manager/v1/plugin-stats/log</para>
        /// </summary>
        [Endpoint("/plugin-manager/v1/plugin-stats/log")]
        public static Task GetPluginManagerV1PluginStatsLog()
            => Sender.Request("get", $"/plugin-manager/v1/plugin-stats/log");
        /// <summary>
        /// Get the status of the plugin manager.
        /// <para>GET /plugin-manager/v1/status</para>
        /// </summary>
        [Endpoint("/plugin-manager/v1/status")]
        public static Task<PluginManagerResource> GetPluginManagerV1Status()
            => Sender.Request<PluginManagerResource>("get", $"/plugin-manager/v1/status");
        /// <summary>
        /// Get all plugin descriptions.
        /// <para>GET /plugin-manager/v2/descriptions</para>
        /// </summary>
        [Endpoint("/plugin-manager/v2/descriptions")]
        public static Task<PluginDescriptionResource[]> GetPluginManagerV2Descriptions()
            => Sender.Request<PluginDescriptionResource[]>("get", $"/plugin-manager/v2/descriptions");
        /// <summary>
        /// Get a plugin description.
        /// <para>GET /plugin-manager/v2/descriptions/{plugin}</para>
        /// </summary>
        /// <param name="plugin">Plugin name</param>
        [Endpoint("/plugin-manager/v2/descriptions/{plugin}")]
        public static Task<PluginDescriptionResource> GetPluginManagerV2DescriptionsByPlugin([Parameter("plugin", "path")] string plugin)
            => Sender.Request<PluginDescriptionResource>("get", $"/plugin-manager/v2/descriptions/{plugin}");
        /// <summary>
        /// Get diagnostic information for all plugins.
        /// <para>GET /plugin-manager/v2/plugins</para>
        /// </summary>
        [Endpoint("/plugin-manager/v2/plugins")]
        public static Task<PluginResource[]> GetPluginManagerV2Plugins()
            => Sender.Request<PluginResource[]>("get", $"/plugin-manager/v2/plugins");
        /// <summary>
        /// Get diagnostic information for a single plugin.
        /// <para>GET /plugin-manager/v2/plugins/{plugin}</para>
        /// </summary>
        /// <param name="plugin">Plugin name</param>
        [Endpoint("/plugin-manager/v2/plugins/{plugin}")]
        public static Task<PluginResource> GetPluginManagerV2PluginsByPlugin([Parameter("plugin", "path")] string plugin)
            => Sender.Request<PluginResource>("get", $"/plugin-manager/v2/plugins/{plugin}");
        /// <summary>
        /// Get the plugin manifest.
        /// <para>GET /plugin-manager/v3/plugins-manifest</para>
        /// </summary>
        [Endpoint("/plugin-manager/v3/plugins-manifest")]
        public static Task<object> GetPluginManagerV3PluginsManifest()
            => Sender.Request<object>("get", $"/plugin-manager/v3/plugins-manifest");

        public static string GetURL(string methodName)
        {
            return typeof(PluginManager).GetMethod(methodName).GetCustomAttribute<EndpointAttribute>().URL;
        }
    }
}
