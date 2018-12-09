using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChampSelectLegacyGameflowSession
    {
        [JsonProperty("gameClient")]
        public LolChampSelectLegacyGameflowGameClient GameClient { get; set; }
        [JsonProperty("gameData")]
        public LolChampSelectLegacyGameflowGameData GameData { get; set; }
        [JsonProperty("phase")]
        public LolChampSelectLegacyGameflowPhase Phase { get; set; }
    }
}
