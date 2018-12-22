using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolHonorV2Ballot
    {
        [JsonProperty("eligiblePlayers")]
        public LolHonorV2EligiblePlayer[] EligiblePlayers { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
    }
}
