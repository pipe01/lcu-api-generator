using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderChampionBenchStateV1
    {
        [JsonProperty("benchEnabled")]
        public bool BenchEnabled { get; set; }
        [JsonProperty("championIds")]
        public int[] ChampionIds { get; set; }
    }
}
