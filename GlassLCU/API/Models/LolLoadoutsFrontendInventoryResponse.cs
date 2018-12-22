using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLoadoutsFrontendInventoryResponse
    {
        [JsonProperty("entitlements")]
        public LolLoadoutsItemKey[] Entitlements { get; set; }
    }
}
