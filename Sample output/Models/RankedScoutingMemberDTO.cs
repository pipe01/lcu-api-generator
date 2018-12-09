using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RankedScoutingMemberDTO
    {
        [JsonProperty("championScoutingData")]
        public RankedScoutingTopChampionDTO[] ChampionScoutingData { get; set; }
        [JsonProperty("playerId")]
        public long PlayerId { get; set; }
    }
}
