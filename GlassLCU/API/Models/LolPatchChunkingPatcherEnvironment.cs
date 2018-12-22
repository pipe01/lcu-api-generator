using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPatchChunkingPatcherEnvironment
    {
        [JsonProperty("client_patcher_available")]
        public bool Client_patcher_available { get; set; }
        [JsonProperty("client_patcher_enabled")]
        public bool Client_patcher_enabled { get; set; }
        [JsonProperty("components")]
        public string[] Components { get; set; }
        [JsonProperty("game_patcher_available")]
        public bool Game_patcher_available { get; set; }
        [JsonProperty("game_patcher_enabled")]
        public bool Game_patcher_enabled { get; set; }
    }
}
