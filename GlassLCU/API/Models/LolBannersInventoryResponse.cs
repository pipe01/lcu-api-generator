using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolBannersInventoryResponse
    {
        [JsonProperty("items")]
        public LolBannersInventoryItemsByType Items { get; set; }
    }
}
