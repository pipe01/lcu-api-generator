using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolTrophiesInventoryResponse
    {
        [JsonProperty("items")]
        public LolTrophiesInventoryItemsByType Items { get; set; }
    }
}
