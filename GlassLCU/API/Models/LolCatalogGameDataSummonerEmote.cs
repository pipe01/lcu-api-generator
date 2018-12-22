using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCatalogGameDataSummonerEmote
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("inventoryIcon")]
        public string InventoryIcon { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
