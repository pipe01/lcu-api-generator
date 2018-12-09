using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolLootLoginDataPacket
    {
        [JsonProperty("allSummonerData")]
        public LolLootLoginAllSummonerData AllSummonerData { get; set; }
        [JsonProperty("simpleMessages")]
        public LolLootLoginSimpleMessage[] SimpleMessages { get; set; }
    }
}
