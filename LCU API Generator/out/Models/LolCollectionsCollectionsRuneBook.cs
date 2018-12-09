using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCollectionsCollectionsRuneBook
    {
        [JsonProperty("pages")]
        public LolCollectionsCollectionsRunePage[] Pages { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
