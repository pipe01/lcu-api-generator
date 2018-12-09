using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class RosterDTO
    {
        [JsonProperty("banned")]
        public bool Banned { get; set; }
        [JsonProperty("captainId")]
        public long CaptainId { get; set; }
        [JsonProperty("dynamicState")]
        public RosterDynamicStateDTO DynamicState { get; set; }
        [JsonProperty("eliminated")]
        public bool Eliminated { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("invitationId")]
        public string InvitationId { get; set; }
        [JsonProperty("logo")]
        public int Logo { get; set; }
        [JsonProperty("logoColor")]
        public int LogoColor { get; set; }
        [JsonProperty("losses")]
        public int Losses { get; set; }
        [JsonProperty("members")]
        public RosterMemberDTO[] Members { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("phases")]
        public PhaseRosterDTO[] Phases { get; set; }
        [JsonProperty("points")]
        public int Points { get; set; }
        [JsonProperty("shortName")]
        public string ShortName { get; set; }
        [JsonProperty("tier")]
        public int Tier { get; set; }
        [JsonProperty("tournamentId")]
        public long TournamentId { get; set; }
        [JsonProperty("version")]
        public int Version { get; set; }
        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}
