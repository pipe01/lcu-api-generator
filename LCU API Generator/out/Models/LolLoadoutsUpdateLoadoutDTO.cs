using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLoadoutsUpdateLoadoutDTO
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("loadout")]
        public object Loadout { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
