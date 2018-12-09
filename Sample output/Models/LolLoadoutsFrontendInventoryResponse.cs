using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLoadoutsFrontendInventoryResponse
    {
        [JsonProperty("entitlements")]
        public LolLoadoutsItemKey[] Entitlements { get; set; }
    }
}
