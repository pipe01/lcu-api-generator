using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolSummonerRMSLevelField
    {
        [JsonProperty("finalLevel")]
        public int FinalLevel { get; set; }
        [JsonProperty("initialLevel")]
        public int InitialLevel { get; set; }
        [JsonProperty("progress")]
        public LolSummonerRMSLevelProgression Progress { get; set; }
    }
}
