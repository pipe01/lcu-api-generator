using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LootLcdsRecipeListClientDTO
    {
        [JsonProperty("lastUpdate")]
        public long LastUpdate { get; set; }
        [JsonProperty("recipes")]
        public LootLcdsRecipeClientDTO[] Recipes { get; set; }
    }
}
