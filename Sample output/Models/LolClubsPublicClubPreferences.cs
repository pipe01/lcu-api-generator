using Newtonsoft.Json;

namespace LCU_API_Generator
{
    [JsonObject]
    public class LolClubsPublicClubPreferences
    {
        [JsonProperty("shareClubAffiliation")]
        public bool ShareClubAffiliation { get; set; }
    }
}
