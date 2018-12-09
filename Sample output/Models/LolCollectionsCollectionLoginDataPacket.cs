using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCollectionsCollectionLoginDataPacket
    {
        [JsonProperty("allSummonerData")]
        public LolCollectionsSummonerData AllSummonerData { get; set; }
    }
}
