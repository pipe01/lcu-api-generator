using Newtonsoft.Json;

namespace LCU_API_Generator
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
