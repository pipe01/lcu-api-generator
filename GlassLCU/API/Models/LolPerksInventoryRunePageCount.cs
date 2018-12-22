using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPerksInventoryRunePageCount
    {
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}
