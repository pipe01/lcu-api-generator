using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPlayerMessagingAllSummonerData
    {
        [JsonProperty("summoner")]
        public LolPlayerMessagingSummoner Summoner { get; set; }
    }
}
