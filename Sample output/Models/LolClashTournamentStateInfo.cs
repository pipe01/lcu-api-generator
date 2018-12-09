using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashTournamentStateInfo
    {
        [JsonProperty("currentPhaseId")]
        public long CurrentPhaseId { get; set; }
        [JsonProperty("nextPhaseId")]
        public long NextPhaseId { get; set; }
        [JsonProperty("nextStateChangeTime")]
        public long NextStateChangeTime { get; set; }
        [JsonProperty("numRemainingPeriods")]
        public int NumRemainingPeriods { get; set; }
        [JsonProperty("state")]
        public LolClashTournamentState State { get; set; }
        [JsonProperty("tournamentId")]
        public long TournamentId { get; set; }
    }
}
