using Newtonsoft.Json;

namespace LCU_API_Generator
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
