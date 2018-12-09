using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class FailedInvite
    {
        [JsonProperty("exception")]
        public ClientRequestError Exception { get; set; }
        [JsonProperty("playerId")]
        public long PlayerId { get; set; }
    }
}
