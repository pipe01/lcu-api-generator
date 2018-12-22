using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class RedeemLootTransactionDTO
    {
        [JsonProperty("lootName")]
        public string LootName { get; set; }
    }
}
