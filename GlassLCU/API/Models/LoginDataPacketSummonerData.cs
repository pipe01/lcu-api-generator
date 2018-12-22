using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LoginDataPacketSummonerData
    {
        [JsonProperty("summoner")]
        public LoginDataPacketSummoner Summoner { get; set; }
    }
}
