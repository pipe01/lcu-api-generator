//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
