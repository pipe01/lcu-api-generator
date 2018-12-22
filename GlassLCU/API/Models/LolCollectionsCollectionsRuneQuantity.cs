using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCollectionsCollectionsRuneQuantity
    {
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        [JsonProperty("runeId")]
        public int RuneId { get; set; }
    }
}
