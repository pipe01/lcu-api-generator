using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPatchPublishedReleaseResponse
    {
        [JsonProperty("client_patch_url")]
        public string Client_patch_url { get; set; }
        [JsonProperty("enabled_client_installs_percent")]
        public float Enabled_client_installs_percent { get; set; }
        [JsonProperty("enabled_game_installs_percent")]
        public float Enabled_game_installs_percent { get; set; }
        [JsonProperty("game_patch_url")]
        public string Game_patch_url { get; set; }
        [JsonProperty("version")]
        public int Version { get; set; }
    }
}
