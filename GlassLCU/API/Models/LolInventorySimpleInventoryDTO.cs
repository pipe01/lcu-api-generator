using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolInventorySimpleInventoryDTO
    {
        [JsonProperty("expires")]
        public string Expires { get; set; }
        [JsonProperty("items")]
        public object Items { get; set; }
        [JsonProperty("itemsJwt")]
        public string ItemsJwt { get; set; }
    }
}
