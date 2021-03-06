//Auto-generated by https://github.com/pipe01/lcu-api-generator
using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class PublicSummonerDTO
    {
        [JsonProperty("acctId")]
        public long AcctId { get; set; }
        [JsonProperty("internalName")]
        public string InternalName { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("previousSeasonHighestTier")]
        public string PreviousSeasonHighestTier { get; set; }
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }
        [JsonProperty("puuid")]
        public string Puuid { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
        [JsonProperty("summonerLevel")]
        public int SummonerLevel { get; set; }
    }
}
