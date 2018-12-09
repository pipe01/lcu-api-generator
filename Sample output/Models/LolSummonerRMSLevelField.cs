using Newtonsoft.Json;

namespace LCU_API_Generator
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
