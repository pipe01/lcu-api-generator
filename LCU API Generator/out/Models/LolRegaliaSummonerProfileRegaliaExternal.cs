using Newtonsoft.Json;

namespace LCU_API_Generator
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
