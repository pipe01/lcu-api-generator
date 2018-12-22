using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLoadoutsCreateLoadoutRequestDTO
    {
        [JsonProperty("loadout")]
        public LolLoadoutsCreateLoadoutDTO Loadout { get; set; }
        [JsonProperty("serviceToJwtsMap")]
        public object ServiceToJwtsMap { get; set; }
    }
}
