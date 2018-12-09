using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolBannersBannerFrame
    {
        [JsonProperty("level")]
        public long Level { get; set; }
    }
}
