using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolRegaliaSummonerProfile
    {
        [JsonProperty("regalia")]
        public string Regalia { get; set; }
    }
}
