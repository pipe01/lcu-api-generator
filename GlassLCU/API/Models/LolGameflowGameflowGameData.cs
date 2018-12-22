using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolGameflowGameflowGameData
    {
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("gameName")]
        public string GameName { get; set; }
        [JsonProperty("isCustomGame")]
        public bool IsCustomGame { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("playerChampionSelections")]
        public object[] PlayerChampionSelections { get; set; }
        [JsonProperty("queue")]
        public LolGameflowQueue Queue { get; set; }
        [JsonProperty("spectatorsAllowed")]
        public bool SpectatorsAllowed { get; set; }
        [JsonProperty("teamOne")]
        public object[] TeamOne { get; set; }
        [JsonProperty("teamTwo")]
        public object[] TeamTwo { get; set; }
    }
}
