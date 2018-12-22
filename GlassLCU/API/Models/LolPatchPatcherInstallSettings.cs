using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPatchPatcherInstallSettings
    {
        [JsonProperty("client_patch_url")]
        public string Client_patch_url { get; set; }
        [JsonProperty("client_patcher")]
        public string Client_patcher { get; set; }
        [JsonProperty("client_patcher_available")]
        public bool Client_patcher_available { get; set; }
        [JsonProperty("game_patch_url")]
        public string Game_patch_url { get; set; }
        [JsonProperty("game_patcher")]
        public string Game_patcher { get; set; }
        [JsonProperty("game_patcher_available")]
        public bool Game_patcher_available { get; set; }
        [JsonProperty("locales")]
        public string[] Locales { get; set; }
        [JsonProperty("max_download_speed_mbps")]
        public int Max_download_speed_mbps { get; set; }
    }
}
