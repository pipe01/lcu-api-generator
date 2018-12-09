using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class EndOfGameLcdsSpell
    {
        [JsonProperty("spellId")]
        public int SpellId { get; set; }
    }
}
