using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LcdsPlayerParticipant
    {
        [JsonProperty("botSkillLevel")]
        public int BotSkillLevel { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerInternalName")]
        public string SummonerInternalName { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
    }
}
