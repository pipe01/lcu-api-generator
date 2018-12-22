using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class BasePublicSummonerDTO
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
        [JsonProperty("sumId")]
        public long SumId { get; set; }
    }
}
