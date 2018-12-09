using Newtonsoft.Json;

namespace LCU_API_Generator
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
