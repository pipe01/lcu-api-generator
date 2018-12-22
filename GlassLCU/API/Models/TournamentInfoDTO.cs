using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class TournamentInfoDTO
    {
        [JsonProperty("inviteePendingRosters")]
        public PendingRosterDTO[] InviteePendingRosters { get; set; }
        [JsonProperty("pendingRoster")]
        public PendingRosterDTO PendingRoster { get; set; }
        [JsonProperty("roster")]
        public RosterDTO Roster { get; set; }
        [JsonProperty("subRosters")]
        public RosterDTO[] SubRosters { get; set; }
        [JsonProperty("themeVp")]
        public int ThemeVp { get; set; }
        [JsonProperty("tournament")]
        public TournamentDTO Tournament { get; set; }
    }
}
