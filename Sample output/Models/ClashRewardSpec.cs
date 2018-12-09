using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class ClashRewardSpec
    {
        [JsonProperty("bracket")]
        public string Bracket { get; set; }
        [JsonProperty("cup")]
        public string Cup { get; set; }
        [JsonProperty("gem")]
        public string Gem { get; set; }
        [JsonProperty("level")]
        public string Level { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("pedestal")]
        public string Pedestal { get; set; }
        [JsonProperty("quantity")]
        public string Quantity { get; set; }
        [JsonProperty("seasonId")]
        public string SeasonId { get; set; }
        [JsonProperty("theme")]
        public string Theme { get; set; }
        [JsonProperty("tier")]
        public string Tier { get; set; }
    }
}
