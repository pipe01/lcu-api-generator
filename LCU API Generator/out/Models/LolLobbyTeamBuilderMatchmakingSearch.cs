using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyTeamBuilderMatchmakingSearch
    {
        [JsonProperty("searchState")]
        public LolLobbyTeamBuilderMatchmakingSearchState SearchState { get; set; }
    }
}
