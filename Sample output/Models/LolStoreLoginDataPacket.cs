using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolStoreLoginDataPacket
    {
        [JsonProperty("allSummonerData")]
        public LolStoreAllSummonerData AllSummonerData { get; set; }
        [JsonProperty("simpleMessages")]
        public LolStoreSimpleDialogMessage[] SimpleMessages { get; set; }
    }
}
