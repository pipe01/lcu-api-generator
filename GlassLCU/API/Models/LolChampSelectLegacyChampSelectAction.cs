using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolChampSelectLegacyChampSelectAction
    {
        [JsonProperty("actorCellId")]
        public long ActorCellId { get; set; }
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("completed")]
        public bool Completed { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("pickTurn")]
        public int PickTurn { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
