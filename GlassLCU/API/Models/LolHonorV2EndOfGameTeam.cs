using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolHonorV2EndOfGameTeam
    {
        [JsonProperty("championBans")]
        public int[] ChampionBans { get; set; }
        [JsonProperty("fullId")]
        public string FullId { get; set; }
        [JsonProperty("isBottomTeam")]
        public bool IsBottomTeam { get; set; }
        [JsonProperty("isPlayerTeam")]
        public bool IsPlayerTeam { get; set; }
        [JsonProperty("isWinningTeam")]
        public bool IsWinningTeam { get; set; }
        [JsonProperty("memberStatusString")]
        public string MemberStatusString { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("players")]
        public LolHonorV2EndOfGamePlayer[] Players { get; set; }
        [JsonProperty("stats")]
        public object Stats { get; set; }
        [JsonProperty("tag")]
        public string Tag { get; set; }
        [JsonProperty("teamId")]
        public int TeamId { get; set; }
    }
}