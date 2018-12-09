using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class GameflowLcdsGameDTO
    {
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("gameState")]
        public string GameState { get; set; }
        [JsonProperty("gameType")]
        public string GameType { get; set; }
        [JsonProperty("gameTypeConfigId")]
        public int GameTypeConfigId { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("mapId")]
        public int MapId { get; set; }
        [JsonProperty("maxNumPlayers")]
        public int MaxNumPlayers { get; set; }
        [JsonProperty("playerChampionSelections")]
        public object[] PlayerChampionSelections { get; set; }
        [JsonProperty("queueTypeName")]
        public string QueueTypeName { get; set; }
        [JsonProperty("spectatorDelay")]
        public int SpectatorDelay { get; set; }
        [JsonProperty("teamOne")]
        public object[] TeamOne { get; set; }
        [JsonProperty("teamTwo")]
        public object[] TeamTwo { get; set; }
    }
}
