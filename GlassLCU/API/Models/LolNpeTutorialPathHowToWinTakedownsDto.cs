using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolNpeTutorialPathHowToWinTakedownsDto
    {
        [JsonProperty("assists")]
        public int Assists { get; set; }
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("kills")]
        public int Kills { get; set; }
        [JsonProperty("largestMulti")]
        public int LargestMulti { get; set; }
        [JsonProperty("largestSpree")]
        public int LargestSpree { get; set; }
        [JsonProperty("newRecord")]
        public bool NewRecord { get; set; }
        [JsonProperty("takedowns")]
        public int Takedowns { get; set; }
    }
}
