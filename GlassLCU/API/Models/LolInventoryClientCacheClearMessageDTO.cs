using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
