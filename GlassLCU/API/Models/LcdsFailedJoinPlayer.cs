using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
