using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashEogPlayerUpdateDTO
    {
        [JsonProperty("bid")]
        public int Bid { get; set; }
        [JsonProperty("bracketSize")]
        public int BracketSize { get; set; }
        [JsonProperty("earnedRewards")]
        public ClashRewardDefinition[] EarnedRewards { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("lowestPosition")]
        public int LowestPosition { get; set; }
        [JsonProperty("rewardProgress")]
        public ClashRewardDefinition[] RewardProgress { get; set; }
        [JsonProperty("seasonVp")]
        public int SeasonVp { get; set; }
        [JsonProperty("themeVp")]
        public int ThemeVp { get; set; }
        [JsonProperty("tier")]
        public int Tier { get; set; }
        [JsonProperty("tournamentId")]
        public long TournamentId { get; set; }
        [JsonProperty("winner")]
        public bool Winner { get; set; }
    }
}
