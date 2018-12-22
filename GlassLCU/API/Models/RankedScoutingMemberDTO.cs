using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
