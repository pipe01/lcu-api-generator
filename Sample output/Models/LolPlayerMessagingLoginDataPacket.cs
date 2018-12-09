using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPlayerMessagingLoginDataPacket
    {
        [JsonProperty("allSummonerData")]
        public LolPlayerMessagingAllSummonerData AllSummonerData { get; set; }
        [JsonProperty("simpleMessages")]
        public LolPlayerMessagingSimpleMessage[] SimpleMessages { get; set; }
    }
}
