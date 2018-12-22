using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLootPlayerLootMap
    {
        [JsonProperty("playerLoot")]
        public object PlayerLoot { get; set; }
        [JsonProperty("version")]
        public long Version { get; set; }
    }
}
