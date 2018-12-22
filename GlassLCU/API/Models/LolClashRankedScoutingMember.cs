using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
