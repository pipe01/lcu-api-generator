using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class MatchmakingLcdsPlayerParticipant
    {
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
