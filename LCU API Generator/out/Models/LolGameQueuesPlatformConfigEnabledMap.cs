using Newtonsoft.Json;

namespace LCU_API_Generator
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
