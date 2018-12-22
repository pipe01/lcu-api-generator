using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPlayerMessagingAllSummonerData
    {
        [JsonProperty("summoner")]
        public LolPlayerMessagingSummoner Summoner { get; set; }
    }
}
