using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolSummonerSummonerIcon
    {
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }
    }
}
