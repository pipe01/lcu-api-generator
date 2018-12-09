using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolChatGroupResource
    {
        [JsonProperty("collapsed")]
        public bool Collapsed { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("isMetaGroup")]
        public bool IsMetaGroup { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("priority")]
        public int Priority { get; set; }
    }
}
