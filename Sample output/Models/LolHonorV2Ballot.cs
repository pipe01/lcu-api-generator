using Newtonsoft.Json;

namespace LCU_API_Generator
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
