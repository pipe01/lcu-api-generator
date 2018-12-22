using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LcdsBotParticipant
    {
        [JsonProperty("botSkillLevel")]
        public int BotSkillLevel { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerInternalName")]
        public string SummonerInternalName { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
        [JsonProperty("teamId")]
        public string TeamId { get; set; }
    }
}
