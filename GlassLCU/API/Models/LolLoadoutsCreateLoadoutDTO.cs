using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLoadoutsCreateLoadoutDTO
    {
        [JsonProperty("itemId")]
        public int ItemId { get; set; }
        [JsonProperty("loadout")]
        public object Loadout { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("refreshTime")]
        public string RefreshTime { get; set; }
        [JsonProperty("scope")]
        public string Scope { get; set; }
    }
}