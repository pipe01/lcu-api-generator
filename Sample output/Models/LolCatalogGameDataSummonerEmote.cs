using Newtonsoft.Json;

namespace LCU_API_Generator
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
