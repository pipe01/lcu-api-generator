//Auto-generated by https://github.com/pipe01/lcu-api-generator
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
