using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RosterStatsDTO
    {
        [JsonProperty("rosterId")]
        public long RosterId { get; set; }
        [JsonProperty("rosterLogo")]
        public int RosterLogo { get; set; }
        [JsonProperty("rosterLogoColor")]
        public int RosterLogoColor { get; set; }
        [JsonProperty("rosterName")]
        public string RosterName { get; set; }
        [JsonProperty("rosterShortName")]
        public string RosterShortName { get; set; }
        [JsonProperty("scheduleEndTime")]
        public long ScheduleEndTime { get; set; }
        [JsonProperty("scheduleTime")]
        public long ScheduleTime { get; set; }
        [JsonProperty("stats")]
        public RosterAggregatedStatsDTO Stats { get; set; }
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
