using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolStoreGiftableResult
    {
        [JsonProperty("config")]
        public LolStoreGiftingConfig Config { get; set; }
        [JsonProperty("friends")]
        public LolStoreGiftingFriend[] Friends { get; set; }
    }
}
