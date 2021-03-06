//Auto-generated by https://github.com/pipe01/lcu-api-generator
using GlassLCU.API.Models;
using System.Threading.Tasks;
using static GlassLCU.API.GenerationUtils;
using System.Reflection;

namespace GlassLCU.API.Interfaces
{
    public static class LolPlayerPreferences
    {
        /// <summary>
        /// <para>POST /lol-player-preferences/v1/hash</para>
        /// </summary>
        [Endpoint("/lol-player-preferences/v1/hash")]
        public static Task<string> PostLolPlayerPreferencesV1Hash([Parameter("preferences", "body")] string preferences)
            => Sender.Request<string>("post", $"/lol-player-preferences/v1/hash", preferences);
        /// <summary>
        /// <para>POST /lol-player-preferences/v1/player-preferences-endpoint-override</para>
        /// </summary>
        [Endpoint("/lol-player-preferences/v1/player-preferences-endpoint-override")]
        public static Task<object> PostLolPlayerPreferencesV1PlayerPreferencesEndpointOverride([Parameter("preferences", "body")] LolPlayerPreferencesPlayerPreferencesEndpoint preferences)
            => Sender.Request<object>("post", $"/lol-player-preferences/v1/player-preferences-endpoint-override", preferences);
        /// <summary>
        /// <para>GET /lol-player-preferences/v1/player-preferences-ready</para>
        /// </summary>
        [Endpoint("/lol-player-preferences/v1/player-preferences-ready")]
        public static Task<bool> GetLolPlayerPreferencesV1PlayerPreferencesReady()
            => Sender.Request<bool>("get", $"/lol-player-preferences/v1/player-preferences-ready");
        /// <summary>
        /// <para>PUT /lol-player-preferences/v1/preference</para>
        /// </summary>
        [Endpoint("/lol-player-preferences/v1/preference")]
        public static Task<object> PutLolPlayerPreferencesV1Preference([Parameter("preferences", "body")] LolPlayerPreferencesPlayerPreferences preferences)
            => Sender.Request<object>("put", $"/lol-player-preferences/v1/preference", preferences);
        /// <summary>
        /// <para>GET /lol-player-preferences/v1/preference/{type}</para>
        /// </summary>
        [Endpoint("/lol-player-preferences/v1/preference/{type}")]
        public static Task<object> GetLolPlayerPreferencesV1PreferenceByType([Parameter("type", "path")] string type, [Parameter("hash", "query")] string hash = default)
            => Sender.Request<object>("get", $"/lol-player-preferences/v1/preference/{type}?{(hash != default ? $"hash={System.Net.WebUtility.UrlEncode(hash.ToString())}" : null)}");

        public static string GetURL(string methodName)
        {
            return typeof(LolPlayerPreferences).GetMethod(methodName).GetCustomAttribute<EndpointAttribute>().URL;
        }
    }
}
