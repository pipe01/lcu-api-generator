using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClashClientFailedInvite
    {
        [JsonProperty("exception")]
        public string Exception { get; set; }
        [JsonProperty("playerId")]
        public long PlayerId { get; set; }
    }
}
