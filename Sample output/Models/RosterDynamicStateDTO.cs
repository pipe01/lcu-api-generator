using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RosterDynamicStateDTO
    {
        [JsonProperty("members")]
        public PhaseInMember[] Members { get; set; }
        [JsonProperty("phaseCheckinStates")]
        public long[] PhaseCheckinStates { get; set; }
        [JsonProperty("phaseRosterSubs")]
        public PhaseRosterSubDTO[] PhaseRosterSubs { get; set; }
        [JsonProperty("rosterId")]
        public long RosterId { get; set; }
        [JsonProperty("subbedMemberIds")]
        public long[] SubbedMemberIds { get; set; }
        [JsonProperty("ticketOffers")]
        public TicketOfferDTO[] TicketOffers { get; set; }
        [JsonProperty("tournamentId")]
        public long TournamentId { get; set; }
        [JsonProperty("version")]
        public int Version { get; set; }
        [JsonProperty("withdraw")]
        public RosterWithdraw Withdraw { get; set; }
    }
}
