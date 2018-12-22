using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LcdsGameMap
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("mapId")]
        public int MapId { get; set; }
        [JsonProperty("minCustomPlayers")]
        public int MinCustomPlayers { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("totalPlayers")]
        public int TotalPlayers { get; set; }
    }
}
