using Newtonsoft.Json;

namespace LCU_API_Generator
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
