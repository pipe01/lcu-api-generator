using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolInventoryInventoryDTO
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("expires")]
        public string Expires { get; set; }
        [JsonProperty("items")]
        public object Items { get; set; }
        [JsonProperty("itemsJwt")]
        public string ItemsJwt { get; set; }
        [JsonProperty("puuid")]
        public string Puuid { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
