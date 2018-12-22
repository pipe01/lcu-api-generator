using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolMatchHistoryMatchHistoryTeamBan
    {
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("pickTurn")]
        public int PickTurn { get; set; }
    }
}
