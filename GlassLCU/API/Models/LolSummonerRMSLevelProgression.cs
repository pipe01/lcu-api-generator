using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
