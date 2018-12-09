using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyLobbyCustomGameConfiguration
    {
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("gameServerRegion")]
        public string GameServerRegion { get; set; }
        [JsonProperty("gameTypeConfig")]
        public LolLobbyQueueGameTypeConfig GameTypeConfig { get; set; }
        [JsonProperty("mapId")]
        public int MapId { get; set; }
        [JsonProperty("maxPlayerCount")]
        public int MaxPlayerCount { get; set; }
        [JsonProperty("mutators")]
        public LolLobbyQueueGameTypeConfig Mutators { get; set; }
        [JsonProperty("spectatorPolicy")]
        public LolLobbyQueueCustomGameSpectatorPolicy SpectatorPolicy { get; set; }
        [JsonProperty("teamSize")]
        public int TeamSize { get; set; }
        [JsonProperty("tournamentGameMode")]
        public string TournamentGameMode { get; set; }
        [JsonProperty("tournamentPassbackDataPacket")]
        public string TournamentPassbackDataPacket { get; set; }
        [JsonProperty("tournamentPassbackUrl")]
        public string TournamentPassbackUrl { get; set; }
    }
}
