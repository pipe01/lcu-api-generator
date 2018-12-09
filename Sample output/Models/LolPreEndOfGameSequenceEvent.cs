using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolPreEndOfGameSequenceEvent
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("priority")]
        public int Priority { get; set; }
    }
}
