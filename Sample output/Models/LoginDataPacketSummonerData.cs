using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LoginDataPacketSummonerData
    {
        [JsonProperty("summoner")]
        public LoginDataPacketSummoner Summoner { get; set; }
    }
}
