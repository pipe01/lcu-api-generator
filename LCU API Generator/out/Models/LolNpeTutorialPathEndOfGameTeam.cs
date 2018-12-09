using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeTutorialPathEndOfGameTeam
    {
        [JsonProperty("isPlayerTeam")]
        public bool IsPlayerTeam { get; set; }
        [JsonProperty("players")]
        public LolNpeTutorialPathEndOfGamePlayer[] Players { get; set; }
        [JsonProperty("stats")]
        public object Stats { get; set; }
    }
}
