using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LcdsFailedJoinPlayer
    {
        [JsonProperty("reasonFailed")]
        public string ReasonFailed { get; set; }
        [JsonProperty("summoner")]
        public LcdsSummoner Summoner { get; set; }
    }
}
