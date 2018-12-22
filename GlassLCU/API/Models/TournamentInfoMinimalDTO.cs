using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
