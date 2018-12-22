using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
