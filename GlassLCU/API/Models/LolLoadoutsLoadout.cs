using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLoadoutsLoadout
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("items")]
        public object Items { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}