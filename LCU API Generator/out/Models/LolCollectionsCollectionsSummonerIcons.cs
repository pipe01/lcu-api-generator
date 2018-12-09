using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCollectionsCollectionsSummonerIcons
    {
        [JsonProperty("icons")]
        public int[] Icons { get; set; }
        [JsonProperty("summonerIcons")]
        public LolCollectionsCollectionsSummonerIcon[] SummonerIcons { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
