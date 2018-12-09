using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolSummonerRMSLevelProgression
    {
        [JsonProperty("finalLevelBoundary")]
        public long FinalLevelBoundary { get; set; }
        [JsonProperty("finalXp")]
        public long FinalXp { get; set; }
        [JsonProperty("initialLevelBoundary")]
        public long InitialLevelBoundary { get; set; }
        [JsonProperty("initialXp")]
        public long InitialXp { get; set; }
    }
}
