using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolSuggestedPlayersSuggestedPlayersDynamicClientConfig
    {
        [JsonProperty("SuggestedPlayers")]
        public LolSuggestedPlayersSuggestedPlayersConfig SuggestedPlayers { get; set; }
    }
}
