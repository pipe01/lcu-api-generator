using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolClashPlayerTournamentData
    {
        [JsonProperty("bracketId")]
        public long BracketId { get; set; }
        [JsonProperty("isSub")]
        public bool IsSub { get; set; }
        [JsonProperty("rosterId")]
        public string RosterId { get; set; }
        [JsonProperty("state")]
        public LolClashPlayerState State { get; set; }
    }
}
