using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLoadoutsUpdateLoadoutRequestDTO
    {
        [JsonProperty("loadout")]
        public LolLoadoutsUpdateLoadoutDTO Loadout { get; set; }
        [JsonProperty("serviceToJwtsMap")]
        public object ServiceToJwtsMap { get; set; }
    }
}
