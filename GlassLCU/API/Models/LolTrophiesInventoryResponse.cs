using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolTrophiesInventoryResponse
    {
        [JsonProperty("items")]
        public LolTrophiesInventoryItemsByType Items { get; set; }
    }
}
