using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolCollectionsSummonerData
    {
        [JsonProperty("spellBook")]
        public CollectionsLcdsSpellBookDTO SpellBook { get; set; }
    }
}
