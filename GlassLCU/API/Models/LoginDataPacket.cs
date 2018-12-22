using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LoginDataPacket
    {
        [JsonProperty("allSummonerData")]
        public LoginDataPacketSummonerData AllSummonerData { get; set; }
        [JsonProperty("simpleMessages")]
        public LeaguesLcdsSimpleMessage[] SimpleMessages { get; set; }
    }
}
