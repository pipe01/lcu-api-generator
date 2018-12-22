using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
