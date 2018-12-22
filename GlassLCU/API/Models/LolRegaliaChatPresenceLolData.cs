using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRegaliaChatPresenceLolData
    {
        [JsonProperty("level")]
        public int Level { get; set; }
        [JsonProperty("rankedLeagueDivision")]
        public LolRegaliaLeagueDivision RankedLeagueDivision { get; set; }
        [JsonProperty("rankedLeagueQueue")]
        public LolRegaliaLeagueQueueType RankedLeagueQueue { get; set; }
        [JsonProperty("rankedLeagueTier")]
        public LolRegaliaLeagueTier RankedLeagueTier { get; set; }
        [JsonProperty("regalia")]
        public LolRegaliaSummonerProfileRegalia Regalia { get; set; }
    }
}