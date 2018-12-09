using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class TournamentInfoMinimalDTO
    {
        [JsonProperty("time")]
        public long Time { get; set; }
        [JsonProperty("tournamentInfo")]
        public TournamentInfoDTO[] TournamentInfo { get; set; }
    }
}
