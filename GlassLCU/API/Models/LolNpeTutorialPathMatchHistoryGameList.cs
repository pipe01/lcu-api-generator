using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolNpeTutorialPathMatchHistoryGameList
    {
        [JsonProperty("gameCount")]
        public long GameCount { get; set; }
        [JsonProperty("gameIndexBegin")]
        public long GameIndexBegin { get; set; }
        [JsonProperty("gameIndexEnd")]
        public long GameIndexEnd { get; set; }
        [JsonProperty("games")]
        public LolNpeTutorialPathMatchHistoryGame[] Games { get; set; }
    }
}
