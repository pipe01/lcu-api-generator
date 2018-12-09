using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashPlaymodeRestrictedInfo
    {
        [JsonProperty("isRestricted")]
        public bool IsRestricted { get; set; }
        [JsonProperty("phaseId")]
        public long PhaseId { get; set; }
        [JsonProperty("presenceState")]
        public LolClashPresenceState PresenceState { get; set; }
        [JsonProperty("readyForVoice")]
        public bool ReadyForVoice { get; set; }
        [JsonProperty("rosterId")]
        public string RosterId { get; set; }
        [JsonProperty("tournamentId")]
        public long TournamentId { get; set; }
    }
}
