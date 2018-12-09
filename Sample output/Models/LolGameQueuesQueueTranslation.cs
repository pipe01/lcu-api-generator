using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolGameQueuesQueueTranslation
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("detailedDescription")]
        public string DetailedDescription { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("shortName")]
        public string ShortName { get; set; }
    }
}
