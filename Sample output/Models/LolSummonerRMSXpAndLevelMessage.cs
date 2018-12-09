using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolSummonerRMSXpAndLevelMessage
    {
        [JsonProperty("level")]
        public LolSummonerRMSLevelField Level { get; set; }
        [JsonProperty("xp")]
        public object Xp { get; set; }
    }
}
