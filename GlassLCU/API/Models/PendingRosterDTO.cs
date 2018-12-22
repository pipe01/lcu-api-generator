using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PendingRosterDTO
    {
        [JsonProperty("captainId")]
        public long CaptainId { get; set; }
        [JsonProperty("highTierVariance")]
        public bool HighTierVariance { get; set; }
        [JsonProperty("invitationId")]
        public string InvitationId { get; set; }
        [JsonProperty("inviteFaileds")]
        public FailedInvite[] InviteFaileds { get; set; }
        [JsonProperty("invitees")]
        public PendingRosterInviteeDTO[] Invitees { get; set; }
        [JsonProperty("logo")]
        public int Logo { get; set; }
        [JsonProperty("logoColor")]
        public int LogoColor { get; set; }
        [JsonProperty("members")]
        public PendingRosterMemberDTO[] Members { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("rewardLogos")]
        public RewardLogo[] RewardLogos { get; set; }
        [JsonProperty("shortName")]
        public string ShortName { get; set; }
        [JsonProperty("ticketOffers")]
        public TicketOfferDTO[] TicketOffers { get; set; }
        [JsonProperty("tier")]
        public int Tier { get; set; }
        [JsonProperty("tournamentId")]
        public long TournamentId { get; set; }
        [JsonProperty("version")]
        public int Version { get; set; }
    }
}
