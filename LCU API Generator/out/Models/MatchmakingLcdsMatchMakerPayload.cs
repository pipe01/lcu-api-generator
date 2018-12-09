using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class MatchmakingLcdsMatchMakerPayload
    {
        [JsonProperty("LEAVER_BUSTER_ACCESS_TOKEN")]
        public string LEAVER_BUSTER_ACCESS_TOKEN { get; set; }
    }
}
