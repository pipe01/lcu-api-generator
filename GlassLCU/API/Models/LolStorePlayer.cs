using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolStorePlayer
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("ip")]
        public long Ip { get; set; }
        [JsonProperty("rp")]
        public long Rp { get; set; }
        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
    }
}