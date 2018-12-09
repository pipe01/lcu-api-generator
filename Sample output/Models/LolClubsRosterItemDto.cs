using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClubsRosterItemDto
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("clubRole")]
        public string ClubRole { get; set; }
        [JsonProperty("summonerIconId")]
        public int SummonerIconId { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }
    }
}