using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRankedLeague
    {
        [JsonProperty("challengerNextPromotionUpdateInMs")]
        public long ChallengerNextPromotionUpdateInMs { get; set; }
        [JsonProperty("leagueName")]
        public string LeagueName { get; set; }
        [JsonProperty("leagueTier")]
        public LolRankedLeagueTier LeagueTier { get; set; }
        [JsonProperty("leagues")]
        public LolRankedLeagueDivisionInfo[] Leagues { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("queueType")]
        public LolRankedLeagueQueueType QueueType { get; set; }
        [JsonProperty("requesterLeagueDivision")]
        public LolRankedLeagueDivision RequesterLeagueDivision { get; set; }
    }
}
