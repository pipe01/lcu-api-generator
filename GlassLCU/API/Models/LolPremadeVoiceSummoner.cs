using Newtonsoft.Json;

namespace GlassLCU.API.Models
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
