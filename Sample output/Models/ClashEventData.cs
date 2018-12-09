using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class ClashEventData
    {
        [JsonProperty("bracket")]
        public long Bracket { get; set; }
        [JsonProperty("earnedDate")]
        public string EarnedDate { get; set; }
        [JsonProperty("playerUUIDs")]
        public string[] PlayerUUIDs { get; set; }
        [JsonProperty("rewardSpec")]
        public ClashRewardSpec RewardSpec { get; set; }
        [JsonProperty("rewardType")]
        public string RewardType { get; set; }
        [JsonProperty("seasonId")]
        public int SeasonId { get; set; }
        [JsonProperty("teamLogoChromaId")]
        public string TeamLogoChromaId { get; set; }
        [JsonProperty("teamLogoName")]
        public string TeamLogoName { get; set; }
        [JsonProperty("teamName")]
        public string TeamName { get; set; }
        [JsonProperty("theme")]
        public string Theme { get; set; }
        [JsonProperty("tier")]
        public string Tier { get; set; }
        [JsonProperty("tournamentId")]
        public long TournamentId { get; set; }
        [JsonProperty("tournamentName")]
        public string TournamentName { get; set; }
    }
}
