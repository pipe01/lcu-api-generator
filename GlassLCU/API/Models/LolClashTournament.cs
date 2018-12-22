using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashTournament
    {
        [JsonProperty("allowRosterCreation")]
        public bool AllowRosterCreation { get; set; }
        [JsonProperty("bracketSize")]
        public string BracketSize { get; set; }
        [JsonProperty("buyInOptions")]
        public int[] BuyInOptions { get; set; }
        [JsonProperty("endTimeMs")]
        public long EndTimeMs { get; set; }
        [JsonProperty("entryFee")]
        public int EntryFee { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("isHonorRestrictionEnabled")]
        public bool IsHonorRestrictionEnabled { get; set; }
        [JsonProperty("isRankedRestrictionEnabled")]
        public bool IsRankedRestrictionEnabled { get; set; }
        [JsonProperty("isSmsRestrictionEnabled")]
        public bool IsSmsRestrictionEnabled { get; set; }
        [JsonProperty("lastThemeOfSeason")]
        public bool LastThemeOfSeason { get; set; }
        [JsonProperty("maxSubstitutes")]
        public int MaxSubstitutes { get; set; }
        [JsonProperty("nameLocKey")]
        public string NameLocKey { get; set; }
        [JsonProperty("nameLocKeySecondary")]
        public string NameLocKeySecondary { get; set; }
        [JsonProperty("phases")]
        public LolClashTournamentPhase[] Phases { get; set; }
        [JsonProperty("rewardConfig")]
        public ClashRewardConfigClient[] RewardConfig { get; set; }
        [JsonProperty("rosterCreateDeadline")]
        public long RosterCreateDeadline { get; set; }
        [JsonProperty("rosterSize")]
        public int RosterSize { get; set; }
        [JsonProperty("scoutingDurationMs")]
        public long ScoutingDurationMs { get; set; }
        [JsonProperty("startTimeMs")]
        public long StartTimeMs { get; set; }
        [JsonProperty("themeId")]
        public int ThemeId { get; set; }
    }
}
