using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCollectionsCollectionsChestEligibility
    {
        [JsonProperty("earnableChests")]
        public int EarnableChests { get; set; }
        [JsonProperty("maximumChests")]
        public int MaximumChests { get; set; }
        [JsonProperty("nextChestRechargeTime")]
        public long NextChestRechargeTime { get; set; }
    }
}
