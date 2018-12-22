using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
