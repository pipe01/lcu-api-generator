using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolEndOfGameLoginDataPacket
    {
        [JsonProperty("allSummonerData")]
        public LolEndOfGameLoginSummonerData AllSummonerData { get; set; }
        [JsonProperty("platformId")]
        public string PlatformId { get; set; }
        [JsonProperty("simpleMessages")]
        public LolEndOfGameSimpleMessage[] SimpleMessages { get; set; }
    }
}
