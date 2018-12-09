using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRankedRankedApexQueueInfo
    {
        [JsonProperty("challengerNextPromotionUpdateInMs")]
        public long ChallengerNextPromotionUpdateInMs { get; set; }
        [JsonProperty("leagueTier")]
        public LolRankedLeagueTier LeagueTier { get; set; }
        [JsonProperty("leagues")]
        public LolRankedLeagueDivisionInfo[] Leagues { get; set; }
        [JsonProperty("maxLeagueSize")]
        public long MaxLeagueSize { get; set; }
        [JsonProperty("queueType")]
        public LolRankedLeagueQueueType QueueType { get; set; }
    }
}