using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyGameModeDto
    {
        [JsonProperty("botDifficulty")]
        public string BotDifficulty { get; set; }
        [JsonProperty("gameCustomization")]
        public object GameCustomization { get; set; }
        [JsonProperty("gameType")]
        public string GameType { get; set; }
        [JsonProperty("maxPartySize")]
        public int MaxPartySize { get; set; }
        [JsonProperty("queueId")]
        public int QueueId { get; set; }
    }
}
