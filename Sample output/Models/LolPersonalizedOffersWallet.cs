using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPersonalizedOffersWallet
    {
        [JsonProperty("rp")]
        public long Rp { get; set; }
    }
}
