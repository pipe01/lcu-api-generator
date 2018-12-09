using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLootPlayerLootDelta
    {
        [JsonProperty("deltaCount")]
        public int DeltaCount { get; set; }
        [JsonProperty("playerLoot")]
        public LolLootPlayerLoot PlayerLoot { get; set; }
    }
}
