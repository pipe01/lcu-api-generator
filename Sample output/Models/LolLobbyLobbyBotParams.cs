using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyLobbyBotParams
    {
        [JsonProperty("botDifficulty")]
        public LolLobbyLobbyBotDifficulty BotDifficulty { get; set; }
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("teamId")]
        public string TeamId { get; set; }
    }
}
