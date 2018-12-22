using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
