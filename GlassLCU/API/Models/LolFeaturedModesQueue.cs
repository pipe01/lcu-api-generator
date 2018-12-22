using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolFeaturedModesQueue
    {
        [JsonProperty("category")]
        public LolFeaturedModesQueueGameCategory Category { get; set; }
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("lastToggledOffTime")]
        public long LastToggledOffTime { get; set; }
        [JsonProperty("lastToggledOnTime")]
        public long LastToggledOnTime { get; set; }
        [JsonProperty("mapId")]
        public int MapId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("queueAvailability")]
        public LolFeaturedModesQueueAvailability QueueAvailability { get; set; }
    }
}
