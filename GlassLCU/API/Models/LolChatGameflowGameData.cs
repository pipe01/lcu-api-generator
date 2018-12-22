using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChatGameflowGameData
    {
        [JsonProperty("gameId")]
        public long GameId { get; set; }
        [JsonProperty("playerChampionSelections")]
        public LolChatChampSelection[] PlayerChampionSelections { get; set; }
        [JsonProperty("queue")]
        public LolChatQueue Queue { get; set; }
        [JsonProperty("teamOne")]
        public LolChatTeamPlayerEntry[] TeamOne { get; set; }
        [JsonProperty("teamTwo")]
        public LolChatTeamPlayerEntry[] TeamTwo { get; set; }
    }
}
