using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClubsPublicClubsPublicData
    {
        [JsonProperty("availability")]
        public string Availability { get; set; }
        [JsonProperty("lastSeenOnlineTimestamp")]
        public string LastSeenOnlineTimestamp { get; set; }
        [JsonProperty("summonerIconId")]
        public int SummonerIconId { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
        [JsonProperty("tag")]
        public LolClubsPublicClubTag Tag { get; set; }
    }
}
