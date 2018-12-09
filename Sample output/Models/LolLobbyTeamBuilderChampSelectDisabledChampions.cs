using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderChampSelectDisabledChampions
    {
        [JsonProperty("championIds")]
        public int[] ChampionIds { get; set; }
    }
}
