using System.Threading.Tasks;
using static LCU_API_Generator.GenerationUtils;

namespace LCU_API_Generator
{
    public static class LolPlayerPreferences
    {
        public static Task<string> PostLolPlayerPreferencesV1Hash([Parameter("preferences", "body")] string preferences)
            => Sender.Request<string>("post", $"/lol-player-preferences/v1/hash", preferences);
        public static Task<object> PostLolPlayerPreferencesV1PlayerPreferencesEndpointOverride([Parameter("preferences", "body")] LolPlayerPreferencesPlayerPreferencesEndpoint preferences)
            => Sender.Request<object>("post", $"/lol-player-preferences/v1/player-preferences-endpoint-override", preferences);
        public static Task<bool> GetLolPlayerPreferencesV1PlayerPreferencesReady()
            => Sender.Request<bool>("get", $"/lol-player-preferences/v1/player-preferences-ready");
        public static Task<object> PutLolPlayerPreferencesV1Preference([Parameter("preferences", "body")] LolPlayerPreferencesPlayerPreferences preferences)
            => Sender.Request<object>("put", $"/lol-player-preferences/v1/preference", preferences);
        public static Task<object> GetLolPlayerPreferencesV1PreferenceByType([Parameter("type", "path")] string type, [Parameter("hash", "query")] string hash)
            => Sender.Request<object>("get", $"/lol-player-preferences/v1/preference/{type}?hash={System.Net.WebUtility.UrlEncode(hash.ToString())}");
    }
}