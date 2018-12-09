using Newtonsoft.Json;

namespace LCU_API_Generator
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
