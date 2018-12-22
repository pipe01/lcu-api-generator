using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRankedLeagueDivisionInfo
    {
        [JsonProperty("apexUnlockTimeMillis")]
        public long ApexUnlockTimeMillis { get; set; }
        [JsonProperty("leagueDivision")]
        public LolRankedLeagueDivision LeagueDivision { get; set; }
        [JsonProperty("leagueTier")]
        public LolRankedLeagueTier LeagueTier { get; set; }
        [JsonProperty("maxLeagueSize")]
        public long MaxLeagueSize { get; set; }
        [JsonProperty("standings")]
        public LolRankedLeagueStanding[] Standings { get; set; }
    }
}
