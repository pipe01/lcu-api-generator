using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LcdsPracticeGameSearchResult
    {
        [JsonProperty("allowSpectators")]
        public string AllowSpectators { get; set; }
        [JsonProperty("gameMap")]
        public LcdsGameMap GameMap { get; set; }
        [JsonProperty("gameMapId")]
        public int GameMapId { get; set; }
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("maxNumPlayers")]
        public int MaxNumPlayers { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("owner")]
        public LcdsPlayerParticipant Owner { get; set; }
        [JsonProperty("pickType")]
        public string PickType { get; set; }
        [JsonProperty("privateGame")]
        public bool PrivateGame { get; set; }
        [JsonProperty("spectatorCount")]
        public int SpectatorCount { get; set; }
        [JsonProperty("team1Count")]
        public int Team1Count { get; set; }
        [JsonProperty("team2Count")]
        public int Team2Count { get; set; }
    }
}
