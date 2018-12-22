using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
