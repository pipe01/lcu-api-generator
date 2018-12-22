using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;

namespace GlassLCU.API.Interfaces
{
    public static class PluginManager
    {
        /// <summary>
        /// Write the current plugin stats for the log file.
        /// </summary>
        public static Task GetPluginManagerV1PluginStatsLog()
            => Sender.Request("get", $"/plugin-manager/v1/plugin-stats/log");
        /// <summary>
        /// Get the status of the plugin manager.
        /// </summary>
        public static Task<PluginManagerResource> GetPluginManagerV1Status()
            => Sender.Request<PluginManagerResource>("get", $"/plugin-manager/v1/status");
        /// <summary>
        /// Get all plugin descriptions.
        /// </summary>
        public static Task<PluginDescriptionResource[]> GetPluginManagerV2Descriptions()
            => Sender.Request<PluginDescriptionResource[]>("get", $"/plugin-manager/v2/descriptions");
        /// <summary>
        /// Get a plugin description.
        /// </summary>
        /// <param name="plugin">Plugin name</param>
        public static Task<PluginDescriptionResource> GetPluginManagerV2DescriptionsByPlugin([Parameter("plugin", "path")] string plugin)
            => Sender.Request<PluginDescriptionResource>("get", $"/plugin-manager/v2/descriptions/{plugin}");
        /// <summary>
        /// Get diagnostic information for all plugins.
        /// </summary>
        public static Task<PluginResource[]> GetPluginManagerV2Plugins()
            => Sender.Request<PluginResource[]>("get", $"/plugin-manager/v2/plugins");
        /// <summary>
        /// Get diagnostic information for a single plugin.
        /// </summary>
        /// <param name="plugin">Plugin name</param>
        public static Task<PluginResource> GetPluginManagerV2PluginsByPlugin([Parameter("plugin", "path")] string plugin)
            => Sender.Request<PluginResource>("get", $"/plugin-manager/v2/plugins/{plugin}");
        /// <summary>
        /// Get the plugin manifest.
        /// </summary>
        public static Task<object> GetPluginManagerV3PluginsManifest()
            => Sender.Request<object>("get", $"/plugin-manager/v3/plugins-manifest");
    }
}
