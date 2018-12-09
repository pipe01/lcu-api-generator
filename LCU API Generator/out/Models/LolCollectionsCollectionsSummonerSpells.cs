using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCollectionsCollectionsSummonerSpells
    {
        [JsonProperty("spells")]
        public long[] Spells { get; set; }
        [JsonProperty("summonerId")]
        public long SummonerId { get; set; }
    }
}
