using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolGameflowGameSessionGameInfo
    {
        [JsonProperty("bannedChampions")]
        public object[] BannedChampions { get; set; }
        [JsonProperty("gameId")]
        public int GameId { get; set; }
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("gameQueueConfigId")]
        public int GameQueueConfigId { get; set; }
        [JsonProperty("gameStartTime")]
        public long GameStartTime { get; set; }
        [JsonProperty("gameType")]
        public string GameType { get; set; }
        [JsonProperty("mapId")]
        public int MapId { get; set; }
        [JsonProperty("observers")]
        public object Observers { get; set; }
        [JsonProperty("participants")]
        public object[] Participants { get; set; }
    }
}
