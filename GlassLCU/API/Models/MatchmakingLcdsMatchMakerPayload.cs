using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class MatchmakingLcdsMatchMakerPayload
    {
        [JsonProperty("LEAVER_BUSTER_ACCESS_TOKEN")]
        public string LEAVER_BUSTER_ACCESS_TOKEN { get; set; }
    }
}
