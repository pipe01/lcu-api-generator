using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LCDSChampionReward
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("skins")]
        public int[] Skins { get; set; }
    }
}
