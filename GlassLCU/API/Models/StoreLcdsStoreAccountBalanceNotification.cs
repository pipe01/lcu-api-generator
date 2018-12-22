using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class StoreLcdsStoreAccountBalanceNotification
    {
        [JsonProperty("ip")]
        public long Ip { get; set; }
        [JsonProperty("rp")]
        public long Rp { get; set; }
    }
}
