using Newtonsoft.Json;

namespace LCU_API_Generator
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
