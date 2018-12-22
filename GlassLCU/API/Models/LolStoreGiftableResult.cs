using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
