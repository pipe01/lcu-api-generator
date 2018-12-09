using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class BracketRoster
    {
        [JsonProperty("logo")]
        public int Logo { get; set; }
        [JsonProperty("logoColor")]
        public int LogoColor { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("rosterId")]
        public long RosterId { get; set; }
        [JsonProperty("shortName")]
        public string ShortName { get; set; }
    }
}
