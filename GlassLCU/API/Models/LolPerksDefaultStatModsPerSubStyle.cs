using Newtonsoft.Json;

namespace GlassLCU.API.Models
{
    [JsonObject]
    public class LolPerksDefaultStatModsPerSubStyle
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("perks")]
        public int[] Perks { get; set; }
    }
}
