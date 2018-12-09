using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LcdsPracticeGameConfig
    {
        [JsonProperty("allowSpectators")]
        public string AllowSpectators { get; set; }
        [JsonProperty("gameMap")]
        public LcdsGameMap GameMap { get; set; }
        [JsonProperty("gameMode")]
        public string GameMode { get; set; }
        [JsonProperty("gameMutators")]
        public string[] GameMutators { get; set; }
        [JsonProperty("gameName")]
        public string GameName { get; set; }
        [JsonProperty("gamePassword")]
        public string GamePassword { get; set; }
        [JsonProperty("gameTypeConfig")]
        public int GameTypeConfig { get; set; }
        [JsonProperty("maxNumPlayers")]
        public int MaxNumPlayers { get; set; }
        [JsonProperty("passbackDataPacket")]
        public string PassbackDataPacket { get; set; }
        [JsonProperty("passbackUrl")]
        public string PassbackUrl { get; set; }
        [JsonProperty("region")]
        public string Region { get; set; }
    }
}
