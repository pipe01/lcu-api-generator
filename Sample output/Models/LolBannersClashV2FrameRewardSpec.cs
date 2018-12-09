using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolBannersClashV2FrameRewardSpec
    {
        [JsonProperty("level")]
        public string Level { get; set; }
        [JsonProperty("seasonId")]
        public string SeasonId { get; set; }
    }
}
