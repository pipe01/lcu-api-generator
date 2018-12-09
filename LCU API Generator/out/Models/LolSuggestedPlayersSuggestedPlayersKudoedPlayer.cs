using Newtonsoft.Json;

namespace LCU_API_Generator
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
