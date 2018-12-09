using Newtonsoft.Json;

namespace LCU_API_Generator
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
