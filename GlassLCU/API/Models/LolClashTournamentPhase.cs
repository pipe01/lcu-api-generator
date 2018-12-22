using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashTournamentPhase
    {
        [JsonProperty("cancelled")]
        public bool Cancelled { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("lockinStartTime")]
        public long LockinStartTime { get; set; }
        [JsonProperty("period")]
        public int Period { get; set; }
        [JsonProperty("scoutingStartTime")]
        public long ScoutingStartTime { get; set; }
        [JsonProperty("tournamentId")]
        public long TournamentId { get; set; }
    }
}
