using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class RewardDetails
    {
        [JsonProperty("rosterId")]
        public long RosterId { get; set; }
        [JsonProperty("teamMemberIds")]
        public long[] TeamMemberIds { get; set; }
        [JsonProperty("tournamentId")]
        public long TournamentId { get; set; }
    }
}
