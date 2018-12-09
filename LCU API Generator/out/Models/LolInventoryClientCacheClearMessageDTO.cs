using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolInventoryClientCacheClearMessageDTO
    {
        [JsonProperty("clearAll")]
        public bool ClearAll { get; set; }
        [JsonProperty("inventoryTypes")]
        public string[] InventoryTypes { get; set; }
        [JsonProperty("regions")]
        public string[] Regions { get; set; }
    }
}
