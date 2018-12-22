using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class TournamentHistoryAndWinnersDTO
    {
        [JsonProperty("tournamentHistory")]
        public TournamentDTO[] TournamentHistory { get; set; }
        [JsonProperty("tournamentWinnersCompressed")]
        public string TournamentWinnersCompressed { get; set; }
    }
}
