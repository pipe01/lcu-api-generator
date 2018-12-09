using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolKrShutdownLawShutdownLawNotification
    {
        [JsonProperty("type")]
        public LolKrShutdownLawShutdownLawStatus Type { get; set; }
    }
}
