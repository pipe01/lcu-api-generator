using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolSuggestedPlayersSuggestedPlayersKudoedPlayer
    {
        [JsonProperty("kudoedSummonerId")]
        public long KudoedSummonerId { get; set; }
        [JsonProperty("kudoedSummonerName")]
        public string KudoedSummonerName { get; set; }
    }
}
