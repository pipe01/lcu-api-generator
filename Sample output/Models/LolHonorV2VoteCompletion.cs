using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolHonorV2VoteCompletion
    {
        [JsonProperty("fullTeamVote")]
        public bool FullTeamVote { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
    }
}
