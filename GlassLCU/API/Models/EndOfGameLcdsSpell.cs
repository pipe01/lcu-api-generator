using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class EndOfGameLcdsSpell
    {
        [JsonProperty("spellId")]
        public int SpellId { get; set; }
    }
}
