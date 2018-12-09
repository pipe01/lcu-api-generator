using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashTournamentUpdatedNotificationDTO
    {
        [JsonProperty("reason")]
        public LolClashTournamentNotifyReason Reason { get; set; }
        [JsonProperty("relevantPhaseId")]
        public long RelevantPhaseId { get; set; }
        [JsonProperty("tournament")]
        public TournamentDTO Tournament { get; set; }
        [JsonProperty("tournamentId")]
        public long TournamentId { get; set; }
    }
}
