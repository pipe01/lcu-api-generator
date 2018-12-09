using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPremadeVoiceSummoner
    {
        [JsonProperty("accountId")]
        public long AccountId { get; set; }
        [JsonProperty("puuid")]
        public string Puuid { get; set; }
    }
}
