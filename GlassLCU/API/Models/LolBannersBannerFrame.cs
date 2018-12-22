using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolBannersBannerFrame
    {
        [JsonProperty("level")]
        public long Level { get; set; }
    }
}
