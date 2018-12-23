//Auto-generated by https://github.com/pipe01/lcu-api-generator
using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;
using System.Reflection;

namespace GlassLCU.API.Interfaces
{
    public static class DataStore
    {
        /// <summary>
        /// Gets the current install directory (used internally.)
        /// <para>GET /data-store/v1/install-dir</para>
        /// </summary>
        [Endpoint("/data-store/v1/install-dir")]
        public static Task<string> GetDataStoreV1InstallDir()
            => Sender.Request<string>("get", $"/data-store/v1/install-dir");
        /// <summary>
        /// Get the data for the specified key from the install settings.
        /// <para>GET /data-store/v1/install-settings/{path}</para>
        /// </summary>
        /// <param name="path">The path to the settings key</param>
        [Endpoint("/data-store/v1/install-settings/{path}")]
        public static Task<object> GetDataStoreV1InstallSettingsByPath([Parameter("path", "path")] string path)
            => Sender.Request<object>("get", $"/data-store/v1/install-settings/{path}");
        /// <summary>
        /// Set the data for the specified key from the install settings.
        /// <para>POST /data-store/v1/install-settings/{path}</para>
        /// </summary>
        /// <param name="path">The path to the settings key</param>
        /// <param name="data">The data to assign to the key</param>
        [Endpoint("/data-store/v1/install-settings/{path}")]
        public static Task PostDataStoreV1InstallSettingsByPath([Parameter("path", "path")] string path, [Parameter("data", "body")] object data)
            => Sender.Request("post", $"/data-store/v1/install-settings/{path}", data);
        /// <summary>
        /// Get the setting for the specified key.
        /// <para>GET /data-store/v1/system-settings/{path}</para>
        /// </summary>
        /// <param name="path">The path to the settings key</param>
        [Endpoint("/data-store/v1/system-settings/{path}")]
        public static Task<object> GetDataStoreV1SystemSettingsByPath([Parameter("path", "path")] string path)
            => Sender.Request<object>("get", $"/data-store/v1/system-settings/{path}");

        public static string GetURL(string methodName)
        {
            return typeof(DataStore).GetMethod(methodName).GetCustomAttribute<EndpointAttribute>().URL;
        }
    }
}
