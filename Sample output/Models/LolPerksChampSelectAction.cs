using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPerksChampSelectAction
    {
        [JsonProperty("actorCellId")]
        public long ActorCellId { get; set; }
        [JsonProperty("championId")]
        public int ChampionId { get; set; }
        [JsonProperty("completed")]
        public bool Completed { get; set; }
        [JsonProperty("id")]
        public long Id { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
