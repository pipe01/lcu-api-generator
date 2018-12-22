using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolGameQueuesPlatformConfigEnabledMap
    {
        [JsonProperty("gameMapId")]
        public int GameMapId { get; set; }
        [JsonProperty("minPlayers")]
        public int MinPlayers { get; set; }
    }
}
