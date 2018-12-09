using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LeaguesLcdsLeagueItemDTO
    {
        [JsonProperty("apexDaysUntilDecay")]
        public int ApexDaysUntilDecay { get; set; }
        [JsonProperty("demotionWarning")]
        public long DemotionWarning { get; set; }
        [JsonProperty("displayDecayWarning")]
        public bool DisplayDecayWarning { get; set; }
        [JsonProperty("inactivityStatus")]
        public string InactivityStatus { get; set; }
        [JsonProperty("isFreshBlood")]
        public bool IsFreshBlood { get; set; }
        [JsonProperty("isHotStreak")]
        public bool IsHotStreak { get; set; }
        [JsonProperty("isInactive")]
        public bool IsInactive { get; set; }
        [JsonProperty("isVeteran")]
        public bool IsVeteran { get; set; }
        [JsonProperty("lastPlayed")]
        public long LastPlayed { get; set; }
        [JsonProperty("leaguePoints")]
        public int LeaguePoints { get; set; }
        [JsonProperty("losses")]
        public long Losses { get; set; }
        [JsonProperty("miniSeries")]
        public LeaguesLcdsMiniSeriesDTO MiniSeries { get; set; }
        [JsonProperty("playerOrTeamId")]
        public string PlayerOrTeamId { get; set; }
        [JsonProperty("playerOrTeamName")]
        public string PlayerOrTeamName { get; set; }
        [JsonProperty("position")]
        public string Position { get; set; }
        [JsonProperty("previousDayLeaguePosition")]
        public long PreviousDayLeaguePosition { get; set; }
        [JsonProperty("provisionalGamesRemaining")]
        public int ProvisionalGamesRemaining { get; set; }
        [JsonProperty("queueType")]
        public string QueueType { get; set; }
        [JsonProperty("rank")]
        public string Rank { get; set; }
        [JsonProperty("tier")]
        public string Tier { get; set; }
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
