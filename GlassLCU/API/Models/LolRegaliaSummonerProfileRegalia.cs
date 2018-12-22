using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRegaliaSummonerProfileRegalia
    {
        [JsonProperty("bannerType")]
        public LolRegaliaSummonerProfileRegaliaBannerType BannerType { get; set; }
        [JsonProperty("crestType")]
        public LolRegaliaSummonerProfileRegaliaCrestType CrestType { get; set; }
    }
}
