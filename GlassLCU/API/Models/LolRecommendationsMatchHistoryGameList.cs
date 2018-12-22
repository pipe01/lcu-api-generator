using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRecommendationsMatchHistoryGameList
    {
        [JsonProperty("gameBeginDate")]
        public string GameBeginDate { get; set; }
        [JsonProperty("gameCount")]
        public long GameCount { get; set; }
        [JsonProperty("gameEndDate")]
        public string GameEndDate { get; set; }
        [JsonProperty("gameIndexBegin")]
        public long GameIndexBegin { get; set; }
        [JsonProperty("gameIndexEnd")]
        public long GameIndexEnd { get; set; }
        [JsonProperty("games")]
        public LolRecommendationsMatchHistoryGame[] Games { get; set; }
    }
}
