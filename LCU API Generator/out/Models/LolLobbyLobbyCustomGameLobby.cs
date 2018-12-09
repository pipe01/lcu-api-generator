using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyLobbyCustomGameLobby
    {
        [JsonProperty("configuration")]
        public LolLobbyLobbyCustomGameConfiguration Configuration { get; set; }
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("lobbyName")]
        public string LobbyName { get; set; }
        [JsonProperty("lobbyPassword")]
        public string LobbyPassword { get; set; }
        [JsonProperty("practiceGameRewardsDisabledReasons")]
        public string[] PracticeGameRewardsDisabledReasons { get; set; }
        [JsonProperty("spectators")]
        public LolLobbyLobbyMember[] Spectators { get; set; }
        [JsonProperty("teamOne")]
        public LolLobbyLobbyMember[] TeamOne { get; set; }
        [JsonProperty("teamTwo")]
        public LolLobbyLobbyMember[] TeamTwo { get; set; }
    }
}
