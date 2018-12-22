using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyTeamBuilderMatchmakingSearch
    {
        [JsonProperty("searchState")]
        public LolLobbyTeamBuilderMatchmakingSearchState SearchState { get; set; }
    }
}
