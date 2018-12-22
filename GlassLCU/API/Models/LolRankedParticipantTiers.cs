using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
