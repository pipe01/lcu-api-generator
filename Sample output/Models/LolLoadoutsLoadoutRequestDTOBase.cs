using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLoadoutsLoadoutRequestDTOBase
    {
        [JsonProperty("serviceToJwtsMap")]
        public object ServiceToJwtsMap { get; set; }
    }
}
