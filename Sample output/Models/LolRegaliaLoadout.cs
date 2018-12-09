using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRegaliaLoadout
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("loadout")]
        public LolRegaliaRegaliaLoadout Loadout { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("scope")]
        public string Scope { get; set; }
    }
}
