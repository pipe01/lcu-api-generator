using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyCollectionsChampion
    {
        [JsonProperty("active")]
        public bool Active { get; set; }
        [JsonProperty("botEnabled")]
        public bool BotEnabled { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}