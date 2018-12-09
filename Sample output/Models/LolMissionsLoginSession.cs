using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolMissionsLoginSession
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
