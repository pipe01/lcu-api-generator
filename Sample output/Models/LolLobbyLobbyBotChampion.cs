using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLobbyLobbyBotChampion
    {
        [JsonProperty("active")]
        public bool Active { get; set; }
        [JsonProperty("botDifficulties")]
        public LolLobbyLobbyBotDifficulty[] BotDifficulties { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
