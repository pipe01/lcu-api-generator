//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLoadoutsSignGCORequestDTO
    {
        [JsonProperty("loadout")]
        public object Loadout { get; set; }
        [JsonProperty("serviceToJwtsMap")]
        public object ServiceToJwtsMap { get; set; }
    }
}
