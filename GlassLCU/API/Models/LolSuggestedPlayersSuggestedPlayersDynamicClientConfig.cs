using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolSuggestedPlayersSuggestedPlayersDynamicClientConfig
    {
        [JsonProperty("SuggestedPlayers")]
        public LolSuggestedPlayersSuggestedPlayersConfig SuggestedPlayers { get; set; }
    }
}
