using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolStorePageDTO
    {
        [JsonProperty("Player")]
        public LolStorePlayer Player { get; set; }
        [JsonProperty("catalog")]
        public LolStoreCatalogItem[] Catalog { get; set; }
        [JsonProperty("groupOrder")]
        public string[] GroupOrder { get; set; }
        [JsonProperty("itemGroups")]
        public object ItemGroups { get; set; }
    }
}
