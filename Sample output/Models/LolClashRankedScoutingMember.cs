using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashRankedScoutingMember
    {
        [JsonProperty("championScoutingData")]
        public LolClashRankedScoutingTopChampion[] ChampionScoutingData { get; set; }
        [JsonProperty("playerId")]
        public long PlayerId { get; set; }
    }
}
