using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolRegaliaSummonerProfileRegaliaExternal
    {
        [JsonProperty("bannerType")]
        public int BannerType { get; set; }
        [JsonProperty("crestType")]
        public int CrestType { get; set; }
    }
}
