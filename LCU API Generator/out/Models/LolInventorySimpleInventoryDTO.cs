using Newtonsoft.Json;

namespace LCU_API_Generator
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
