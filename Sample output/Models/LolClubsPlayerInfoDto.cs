using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClubsPlayerInfoDto
    {
        [JsonProperty("currentAccountId")]
        public long CurrentAccountId { get; set; }
        [JsonProperty("currentPlatformId")]
        public string CurrentPlatformId { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
