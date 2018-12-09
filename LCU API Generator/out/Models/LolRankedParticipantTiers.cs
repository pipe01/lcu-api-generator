using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRankedParticipantTiers
    {
        [JsonProperty("achievedTiers")]
        public LolRankedAchievedTier[] AchievedTiers { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
