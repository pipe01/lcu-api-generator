using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolCollectionsSummonerData
    {
        [JsonProperty("spellBook")]
        public CollectionsLcdsSpellBookDTO SpellBook { get; set; }
    }
}
