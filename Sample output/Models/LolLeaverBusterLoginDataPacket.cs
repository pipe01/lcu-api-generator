using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLeaverBusterLoginDataPacket
    {
        [JsonProperty("allSummonerData")]
        public LolLeaverBusterAllSummonerData AllSummonerData { get; set; }
        [JsonProperty("simpleMessages")]
        public LolLeaverBusterSimpleMessage[] SimpleMessages { get; set; }
    }
}
