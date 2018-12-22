using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
