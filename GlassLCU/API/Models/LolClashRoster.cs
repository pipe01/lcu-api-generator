using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashRoster
    {
        [JsonProperty("availableLogos")]
        public RewardLogo[] AvailableLogos { get; set; }
        [JsonProperty("captainSummonerId")]
        public long CaptainSummonerId { get; set; }
        [JsonProperty("currentBracketWins")]
        public int CurrentBracketWins { get; set; }
        [JsonProperty("highTierVariance")]
        public bool HighTierVariance { get; set; }
        [JsonProperty("iconColorId")]
        public int IconColorId { get; set; }
        [JsonProperty("iconId")]
        public int IconId { get; set; }
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("invitationId")]
        public string InvitationId { get; set; }
        [JsonProperty("isActiveInCurrentPhase")]
        public bool IsActiveInCurrentPhase { get; set; }
        [JsonProperty("isClashBanned")]
        public bool IsClashBanned { get; set; }
        [JsonProperty("isCurrentBracketComplete")]
        public bool IsCurrentBracketComplete { get; set; }
        [JsonProperty("isEliminated")]
        public bool IsEliminated { get; set; }
        [JsonProperty("isRegistered")]
        public bool IsRegistered { get; set; }
        [JsonProperty("losses")]
        public int Losses { get; set; }
        [JsonProperty("members")]
        public LolClashRosterMember[] Members { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("numCompletedPeriods")]
        public int NumCompletedPeriods { get; set; }
        [JsonProperty("phaseInfos")]
        public LolClashRosterPhaseInfo[] PhaseInfos { get; set; }
        [JsonProperty("points")]
        public int Points { get; set; }
        [JsonProperty("shortName")]
        public string ShortName { get; set; }
        [JsonProperty("suggestedInvites")]
        public LolClashSuggestedInvite[] SuggestedInvites { get; set; }
        [JsonProperty("tier")]
        public int Tier { get; set; }
        [JsonProperty("tournamentId")]
        public long TournamentId { get; set; }
        [JsonProperty("wins")]
        public int Wins { get; set; }
        [JsonProperty("withdraw")]
        public RosterWithdraw Withdraw { get; set; }
    }
}
