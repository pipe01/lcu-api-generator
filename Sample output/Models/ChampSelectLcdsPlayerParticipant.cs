using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class ChampSelectLcdsPlayerParticipant
    {
        [JsonProperty("pickMode")]
        public int PickMode { get; set; }
        [JsonProperty("pickTurn")]
        public int PickTurn { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerInternalName")]
        public string SummonerInternalName { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
    }
}
