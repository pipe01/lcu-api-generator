using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCollectionsCollectionsChampionMastery
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("championLevel")]
        public int ChampionLevel { get; set; }
        [JsonProperty("championPoints")]
        public int ChampionPoints { get; set; }
        [JsonProperty("championPointsSinceLastLevel")]
        public int ChampionPointsSinceLastLevel { get; set; }
        [JsonProperty("championPointsUntilNextLevel")]
        public int ChampionPointsUntilNextLevel { get; set; }
        [JsonProperty("chestGranted")]
        public bool ChestGranted { get; set; }
        [JsonProperty("highestGrade")]
        public string HighestGrade { get; set; }
        [JsonProperty("lastPlayTime")]
        public long LastPlayTime { get; set; }
        [JsonProperty("playerId")]
        public long PlayerId { get; set; }
    }
}
