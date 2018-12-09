using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClubsClubName
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
