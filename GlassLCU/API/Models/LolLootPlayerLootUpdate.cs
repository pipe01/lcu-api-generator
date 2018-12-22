using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLootPlayerLootUpdate
    {
        [JsonProperty("added")]
        public LolLootPlayerLootDelta[] Added { get; set; }
        [JsonProperty("redeemed")]
        public LolLootPlayerLootDelta[] Redeemed { get; set; }
        [JsonProperty("removed")]
        public LolLootPlayerLootDelta[] Removed { get; set; }
    }
}
