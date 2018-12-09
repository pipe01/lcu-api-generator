using Newtonsoft.Json;

namespace LCU_API_Generator
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
