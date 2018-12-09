using Newtonsoft.Json;

namespace LCU_API_Generator
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
