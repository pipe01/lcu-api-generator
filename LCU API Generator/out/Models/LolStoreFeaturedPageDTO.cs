using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolStoreFeaturedPageDTO
    {
        [JsonProperty("Player")]
        public LolStorePlayer Player { get; set; }
    }
}
