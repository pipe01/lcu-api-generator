using Newtonsoft.Json;

namespace LCU_API_Generator
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