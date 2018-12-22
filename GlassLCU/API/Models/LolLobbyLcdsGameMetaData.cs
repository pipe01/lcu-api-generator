using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolLobbyLcdsGameMetaData
    {
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("mapId")]
        public int MapId { get; set; }
    }
}
