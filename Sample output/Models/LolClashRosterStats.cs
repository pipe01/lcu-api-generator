using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashRosterStats
    {
        [JsonProperty("endTimeMs")]
        public long EndTimeMs { get; set; }
        [JsonProperty("periodStats")]
        public LolClashRosterPeriodAggregatedStats[] PeriodStats { get; set; }
        [JsonProperty("playerStats")]
        public object PlayerStats { get; set; }
        [JsonProperty("rosterIconColorId")]
        public int RosterIconColorId { get; set; }
        [JsonProperty("rosterIconId")]
        public int RosterIconId { get; set; }
        [JsonProperty("rosterId")]
        public long RosterId { get; set; }
        [JsonProperty("rosterName")]
        public string RosterName { get; set; }
        [JsonProperty("rosterShortName")]
        public string RosterShortName { get; set; }
        [JsonProperty("startTimeMs")]
        public long StartTimeMs { get; set; }
        [JsonProperty("tier")]
        public int Tier { get; set; }
        [JsonProperty("tournamentNameLocKey")]
        public string TournamentNameLocKey { get; set; }
        [JsonProperty("tournamentNameLocKeySecondary")]
        public string TournamentNameLocKeySecondary { get; set; }
        [JsonProperty("tournamentPeriods")]
        public int TournamentPeriods { get; set; }
        [JsonProperty("tournamentThemeId")]
        public int TournamentThemeId { get; set; }
    }
}
