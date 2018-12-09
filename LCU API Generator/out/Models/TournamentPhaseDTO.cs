using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class TournamentPhaseDTO
    {
        [JsonProperty("cancelled")]
        public bool Cancelled { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("period")]
        public int Period { get; set; }
        [JsonProperty("registrationTime")]
        public long RegistrationTime { get; set; }
        [JsonProperty("startTime")]
        public long StartTime { get; set; }
        [JsonProperty("tournamentId")]
        public long TournamentId { get; set; }
    }
}
