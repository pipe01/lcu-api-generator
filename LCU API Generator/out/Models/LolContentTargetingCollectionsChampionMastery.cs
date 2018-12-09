using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolContentTargetingCollectionsChampionMastery
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("championLevel")]
        public int ChampionLevel { get; set; }
        [JsonProperty("lastPlayTime")]
        public long LastPlayTime { get; set; }
        [JsonProperty("playerId")]
        public long PlayerId { get; set; }
    }
}
