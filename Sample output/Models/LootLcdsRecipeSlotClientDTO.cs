//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LootLcdsRecipeSlotClientDTO
    {
        [JsonProperty("quantityExpression")]
        public string QuantityExpression { get; set; }
        [JsonProperty("query")]
        public string Query { get; set; }
        [JsonProperty("slotNumber")]
        public int SlotNumber { get; set; }
    }
}
