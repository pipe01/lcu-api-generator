using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolNpeTutorialPathSummonerIcon
    {
        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }
    }
}
