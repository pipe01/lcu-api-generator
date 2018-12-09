using Newtonsoft.Json;

namespace LCU_API_Generator
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
