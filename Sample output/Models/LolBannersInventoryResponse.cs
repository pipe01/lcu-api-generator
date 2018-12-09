using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolBannersInventoryResponse
    {
        [JsonProperty("items")]
        public LolBannersInventoryItemsByType Items { get; set; }
    }
}
