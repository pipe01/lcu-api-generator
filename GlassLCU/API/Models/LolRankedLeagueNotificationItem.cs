using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRankedLeagueNotificationItem
    {
        [JsonProperty("demotionWarning")]
        public long DemotionWarning { get; set; }
        [JsonProperty("displayDecayWarning")]
        public bool DisplayDecayWarning { get; set; }
        [JsonProperty("division")]
        public LolRankedLeagueDivision Division { get; set; }
        [JsonProperty("emblems")]
        public LolRankedLeagueEmblem[] Emblems { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("inactive")]
        public bool Inactive { get; set; }
        [JsonProperty("inactivityStatus")]
        public string InactivityStatus { get; set; }
        [JsonProperty("isPositionRanks")]
        public bool IsPositionRanks { get; set; }
        [JsonProperty("lastPlayed")]
        public long LastPlayed { get; set; }
        [JsonProperty("leaguePointsDelta")]
        public long LeaguePointsDelta { get; set; }
        [JsonProperty("losses")]
        public long Losses { get; set; }
        [JsonProperty("minGamesForSeeding")]
        public long MinGamesForSeeding { get; set; }
        [JsonProperty("miniseriesResults")]
        public LolRankedMiniseries[] MiniseriesResults { get; set; }
        [JsonProperty("miniseriesTimeLeftToPlayMillis")]
        public long MiniseriesTimeLeftToPlayMillis { get; set; }
        [JsonProperty("miniseriesWins")]
        public long MiniseriesWins { get; set; }
        [JsonProperty("notifyReason")]
        public string NotifyReason { get; set; }
        [JsonProperty("playerOrTeamId")]
        public string PlayerOrTeamId { get; set; }
        [JsonProperty("playerOrTeamName")]
        public string PlayerOrTeamName { get; set; }
        [JsonProperty("points")]
        public long Points { get; set; }
        [JsonProperty("position")]
        public LolRankedRankedPosition Position { get; set; }
        [JsonProperty("previousPosition")]
        public long PreviousPosition { get; set; }
        [JsonProperty("provisionalGameThreshold")]
        public long ProvisionalGameThreshold { get; set; }
        [JsonProperty("provisionalGamesRemaining")]
        public long ProvisionalGamesRemaining { get; set; }
        [JsonProperty("provisionalResults")]
        public int[] ProvisionalResults { get; set; }
        [JsonProperty("queueType")]
        public LolRankedLeagueQueueType QueueType { get; set; }
        [JsonProperty("rewardEarned")]
        public string RewardEarned { get; set; }
        [JsonProperty("seasonEndApexPosition")]
        public long SeasonEndApexPosition { get; set; }
        [JsonProperty("seasonEndDivision")]
        public LolRankedLeagueDivision SeasonEndDivision { get; set; }
        [JsonProperty("seasonEndTier")]
        public LolRankedLeagueTier SeasonEndTier { get; set; }
        [JsonProperty("tier")]
        public LolRankedLeagueTier Tier { get; set; }
        [JsonProperty("timeLastDecayMessageShown")]
        public long TimeLastDecayMessageShown { get; set; }
        [JsonProperty("timeUntilDecay")]
        public long TimeUntilDecay { get; set; }
        [JsonProperty("timeUntilInactivityStatusChanges")]
        public long TimeUntilInactivityStatusChanges { get; set; }
        [JsonProperty("totalPlayed")]
        public long TotalPlayed { get; set; }
        [JsonProperty("wins")]
        public long Wins { get; set; }
    }
}
