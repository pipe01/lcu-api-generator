//Auto-generated by https://github.com/pipe01/lcu-api-generator
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
